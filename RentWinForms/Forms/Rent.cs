using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.Data.SqlClient;
using RentWinForms.Forms.Modal;

namespace RentWinForms {
    public partial class Rent : Form {
        public Rent() {
            InitializeComponent();
        }

        private void tbl_CarRentBindingNavigatorSaveItem_Click(object sender, EventArgs e) {
            this.Validate();
            this.tbl_CarRentBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.rentDataSet);
        }

        private void Rent_Load(object sender, EventArgs e) {
            //this.dateTimePickerFrom.Value = new DateTime(DateTime.Today.Year, DateTime.Today.Month, 1);
            this.dateTimePickerFrom.Value = Convert.ToDateTime("01.01.2011");

            //Заполнение cboCarNum
            this.dtCarNumTableAdapter.Fill(rentDataSet.dtCarNum, Firm.FirmID);
            //Заполнение cboCarType
            this.dtCarTypeTableAdapter.Fill(rentDataSet.dtCarType, Firm.FirmID);
            //Заполнение cboLessor
            this.dtLessorTableAdapter.Fill(rentDataSet.dtLessor, Firm.FirmID);
            //Заполнение cboCustomer
            this.dtCustomerTableAdapter.Fill(rentDataSet.dtCustomer, Firm.FirmID);

            // TODO: This line of code loads data into the 'rentDataSet.tbl_Contragent' table. You can move, or remove it, as needed.
            this.tbl_ContragentTableAdapter.Fill(this.rentDataSet.tbl_Contragent);

            // TODO: This line of code loads data into the 'rentDataSet.tbl_CarriageType' table. You can move, or remove it, as needed.
            this.tbl_CarriageTypeTableAdapter.Fill(this.rentDataSet.tbl_CarriageType);

            //this.tbl_CarRentBindingSource.Filter = System.Convert.ToString("Firm_ID = " + Firm.FirmID);

            //Заполнение tbl_CarRentDataGridView
            FillTblCarRentDataGridView();

            this.cboCarNum.SelectedValueChanged += new EventHandler(cboCarNum_SelectedValueChanged);
            this.cboCarType.SelectedValueChanged += new EventHandler(cboCarType_SelectedValueChanged);
            this.cboLessor.SelectedValueChanged += new EventHandler(cboLessor_SelectedValueChanged);
            this.cboCustomer.SelectedValueChanged += new EventHandler(cboCustomer_SelectedValueChanged);
            this.dtCarRentDataGridView.Paint += new PaintEventHandler(dtCarRentDataGridView_Paint);
        }

        private void btnCarRentRate_Click(object sender, EventArgs e) {
            CarRentRate carRentRate = new CarRentRate();
            carRentRate.Show();
        }

        private void btnReCalc_Click(object sender, EventArgs e) {
            this.btnReCalc.Enabled = false;
            new Thread(new ThreadStart(ReCalculateRent)).Start();
        }

        private void ReCalculateRent() {
            SqlConnection sqlCn = null;

            try {
                sqlCn = new SqlConnection();
                sqlCn.ConnectionString = Properties.Settings.Default.RentConnectionString;
                sqlCn.Open();
                SqlCommand sqlCount = new SqlCommand("Select Count(*) From tbl_CarRateCalc", sqlCn);

                int BeforeCount = (int)sqlCount.ExecuteScalar();
                DateTime Start = DateTime.Now;

                int RetVal;

                using (SqlCommand cmd = new SqlCommand("pr_ReCalculateRent", sqlCn)) {
                    cmd.CommandTimeout = 120; //ожидание конца выполнения хранимой процедуры не больше 2х минут
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@RetVal", SqlDbType.Int).Direction = ParameterDirection.ReturnValue;
                    cmd.ExecuteNonQuery();
                    RetVal = (int)cmd.Parameters["@RetVal"].Value;
                }

                if ((RetVal != 0) & (RetVal != 1)) {
                    MessageBox.Show("В данный момент уже выполняется пересчет ставок.", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Thread.Sleep(10000);
                } else {
                    DateTime End = DateTime.Now;
                    TimeSpan TimeDiff = End - Start;
                    int AfterCount = (int)sqlCount.ExecuteScalar();

                    if ((this.CurrentTabPage == this.tabPgTotal.Name.ToString()) & (!dtCarRentWait)) {
                        FilldtCarRentDataGridView();
                    }

                    MessageBox.Show(string.Format("Аренда полностью пересчитана. Количество записей в таблице tbl_CarRateCalc до пересчета: {0}, после пересчета: {1}. \n\nВремя выполнения хранимой процедуры {2}", BeforeCount, AfterCount, TimeDiff), "Результат пересчёта аренды", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            } catch (Exception e) {
                MessageBox.Show(string.Format("Ошибка в методе ReCalculateRent(): {0}", e.Message), "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } finally {
                sqlCn.Close();
                this.BeginInvoke((MethodInvoker)delegate () {
                    this.btnReCalc.Enabled = true;
                });
            }
        }

        public void FillTblCarRentDataGridView() {
            // TODO: This line of code loads data into the 'rentDataSet.tbl_CarRent' table. You can move, or remove it, as needed.
            this.tbl_CarRentTableAdapter.FillBy(this.rentDataSet.tbl_CarRent, Firm.FirmID, CarNum, CarType, Lessor, Customer);
        }

        private void FilldgvCarRateCalc() {
            // TODO: This line of code loads data into the 'rentDataSet.dtCarRateCalc' table. You can move, or remove it, as needed.
            this.dtCarRateCalcTableAdapter.Fill(this.rentDataSet.dtCarRateCalc, Firm.FirmID, this.dateTimePickerFrom.Value.ToShortDateString(), this.dateTimePickerTo.Value.ToShortDateString(), CarNum, CarType, Lessor, Customer);
        }

        private void dtCarRentShowWait(bool showWait) {
            dtCarRentWait = showWait;
            this.BeginInvoke((MethodInvoker)delegate () {
                this.pbWait.Visible = showWait;
                this.dtCarRentDataGridView.Enabled = !showWait;
                this.dtCarRentDataGridView.DataSource = (showWait) ? null : this.dtCarRentBindingSource;
            });
        }

        private void FilldtCarRentDataGridView() {
            dtCarRentShowWait(true);

            try {
                // TODO: This line of code loads data into the 'rentDataSet.dtCarRent' table. You can move, or remove it, as needed.
                this.dtCarRentTableAdapter.Fill(this.rentDataSet.dtCarRent, Firm.FirmID, this.dateTimePickerFrom.Value.ToShortDateString(), this.dateTimePickerTo.Value.ToShortDateString(), Customer, CarNum, CarType);
            } catch (Exception e) {
                MessageBox.Show(string.Format("Ошибка в методе FilldtCarRentDataGridView: {0}", e.Message), "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            dtCarRentShowWait(false);

            #region Тестовая фильтрация через dtCarRentView
            /*string filter = "";

            if ((this.cboCarNum.SelectedValue != null) && (this.cboCarNum.SelectedValue.ToString() != Convert.ToString(@"</>")))
            {
                if (filter == "")
                    filter = string.Format("CarNum={0}", this.cboCarNum.SelectedValue);
                else
                    filter = string.Format(" AND CarNum={0}", this.cboCarNum.SelectedValue);
            }
            if ((this.cboCarType.SelectedValue.ToString() != "0") && (this.cboCarType.SelectedValue.ToString() != Convert.ToString(@"</>")))
            {
                if (filter == "")
                    filter = string.Format("CarType={0}", this.cboCarType.SelectedValue);
                else
                    filter += string.Format(" AND CarType={0}", this.cboCarType.SelectedValue);
            }
            if ((this.cboCustomer.SelectedValue.ToString() != "0") && (this.cboCustomer.SelectedValue.ToString() != Convert.ToString(@"</>")))
            {
                if (filter == "")
                    filter = string.Format("Customer={0}", this.cboCustomer.SelectedValue);
                else
                    filter += string.Format(" AND Customer={0}", this.cboCustomer.SelectedValue);
            }

            this.dtCarRentTableAdapter.FillBy(this.rentDataSet.dtCarRent, Firm.FirmID);

            DataView dtCarRentView = new DataView(rentDataSet.dtCarRent);
            dtCarRentView.RowFilter = filter;
            dtCarRentBindingSource.DataSource = dtCarRentView;
            dtCarRentDataGridView.DataSource = dtCarRentBindingSource;*/
            #endregion
        }

        private void button1_Click(object sender, EventArgs e) {
            SqlConnection sqlCn = new SqlConnection();
            sqlCn.ConnectionString = Properties.Settings.Default.RentConnectionString;
            sqlCn.Open();
            SqlDataReader reader;
            //DataTable dataTable = new DataTable();

            using (SqlCommand cmd = new SqlCommand("pr_CarRent", sqlCn)) {
                cmd.CommandTimeout = 120;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@FirmID", Firm.FirmID));
                reader = cmd.ExecuteReader();
                rentDataSet.dtCarRentTest.Load(reader);
                reader.Close();
                this.dtCarRentDataGridView.Refresh();
            }
        }

        private void ReFill(object sender) {
            if (((ComboBox)sender).Text != "") {
                if (this.tabCtrlTabs.SelectedTab == this.tabPgRent)
                    FillTblCarRentDataGridView();
                else if (this.tabCtrlTabs.SelectedTab == this.tabPgRentDay)
                    FilldgvCarRateCalc();
                else if (this.tabCtrlTabs.SelectedTab == this.tabPgTotal)
                    FilldtCarRentDataGridView();
            }
        }

        #region События на фильтры

        private void cboCarNum_SelectedValueChanged(object sender, EventArgs e) {
            //if (loaded)
            this.ReFill(sender);
        }

        private void cboCarType_SelectedValueChanged(object sender, EventArgs e) {
            //if (loaded)
            this.ReFill(sender);
        }

        private void cboLessor_SelectedValueChanged(object sender, EventArgs e) {
            //if (loaded)
            this.ReFill(sender);
        }

        private void cboCustomer_SelectedValueChanged(object sender, EventArgs e) {
            //if (loaded)
            this.ReFill(sender);
        }

        #endregion

        #region Поля и свойства
        int carNum = 0;
        int carType = 0;
        int lessor = 0;
        int customer = 0;
        string currentTabPage = null;
        bool dtCarRentWait = false;

        public int CarNum {
            get {
                object cboCarNumSelectedValue = null;
                if (cboCarNum.InvokeRequired)
                    this.cboCarNum.Invoke(new MethodInvoker(delegate { cboCarNumSelectedValue = this.cboCarNum.SelectedValue; }));
                else
                    cboCarNumSelectedValue = this.cboCarNum.SelectedValue;

                if ((cboCarNumSelectedValue != null) && (cboCarNumSelectedValue.ToString() != Convert.ToString(@"</>")))
                    carNum = Convert.ToInt32(cboCarNumSelectedValue);
                else
                    carNum = 0;
                return carNum;
            }
        }

        public int CarType {
            get {
                object cboCarTypeSelectedValue = null;
                if (cboCustomer.InvokeRequired)
                    this.cboCustomer.Invoke(new MethodInvoker(delegate { cboCarTypeSelectedValue = this.cboCarType.SelectedValue; }));
                else
                    cboCarTypeSelectedValue = this.cboCarType.SelectedValue;

                if ((cboCarTypeSelectedValue != null) && (cboCarTypeSelectedValue is int)) {
                    carType = Convert.ToInt32(cboCarTypeSelectedValue);
                }
                //
                //if ((this.cboCarType.SelectedValue != null) && (this.cboCarType.SelectedValue is int))
                //{
                //    carType = (int)this.cboCarType.SelectedValue;
                //}
                return carType;
            }
        }

        public int Lessor {
            get {
                object cboLessorSelectedValue = null;
                if (cboCustomer.InvokeRequired)
                    this.cboCustomer.Invoke(new MethodInvoker(delegate { cboLessorSelectedValue = this.cboLessor.SelectedValue; }));
                else
                    cboLessorSelectedValue = this.cboLessor.SelectedValue;

                if ((cboLessorSelectedValue != null) && (cboLessorSelectedValue is int)) {
                    lessor = Convert.ToInt32(cboLessorSelectedValue);
                }
                //
                //if ((this.cboLessor.SelectedValue != null) && (this.cboLessor.SelectedValue is int))
                //{
                //    lessor = (int)this.cboLessor.SelectedValue;
                //}
                return lessor;
            }
        }

        public int Customer {
            get {
                object cboCustomerSelectedValue = null;
                if (cboCustomer.InvokeRequired)
                    this.cboCustomer.Invoke(new MethodInvoker(delegate { cboCustomerSelectedValue = this.cboCustomer.SelectedValue; }));
                else
                    cboCustomerSelectedValue = this.cboCustomer.SelectedValue;

                if ((cboCustomerSelectedValue != null) && (cboCustomerSelectedValue is int)) {
                    customer = Convert.ToInt32(cboCustomerSelectedValue);
                }
                //
                //if ((this.cboCustomer.SelectedValue != null) && (this.cboCustomer.SelectedValue is int))
                //{
                //    customer = (int)this.cboCustomer.SelectedValue;
                //}
                return customer;
            }
        }

        public string CurrentTabPage {
            get {
                if (tabCtrlTabs.InvokeRequired)
                    this.tabCtrlTabs.Invoke(new MethodInvoker(delegate { currentTabPage = this.tabCtrlTabs.SelectedTab.Name.ToString(); }));
                else
                    currentTabPage = this.tabCtrlTabs.SelectedTab.Name.ToString();
                return currentTabPage;
            }
        }

        public static bool CarRentChanged { get; set; }
        #endregion

        private void tabCtrlTabs_SelectedIndexChanged(object sender, EventArgs e) {
            if (this.tabCtrlTabs.SelectedTab == this.tabPgRent)
                this.cboLessor.Enabled = true;
            else if (this.tabCtrlTabs.SelectedTab == this.tabPgRentDay) {
                this.cboLessor.Enabled = true;
                FilldgvCarRateCalc();
            } else if (this.tabCtrlTabs.SelectedTab == this.tabPgTotal) {
                this.cboLessor.Enabled = false;
                //new Thread(new ThreadStart(FilldtCarRentDataGridView)).Start();
                Thread th = new Thread(FilldtCarRentDataGridView);
                th.IsBackground = true;
                if (th.ThreadState == ThreadState.Running) {
                    dtCarRentDataGridView.Refresh();
                } else {
                    if (!dtCarRentWait) {
                        th.Start();
                    }
                }

                /*// "запомнить" основной поток 
                AsyncOperation ao = AsyncOperationManager.CreateOperation(null);
                // выполняется в рабочем/отдельном потоке 
                new MethodInvoker(delegate()
                {
                    // передать в основной поток 
                    ao.Post(delegate(object obj)
                    {
                        FilldtCarRentDataGridView(); // по идее должно быть не сдесь, а двумя строчками выше. А вот что встраивать в основной поток нужно - хз, но точно не метод FilldtCarRentDataGridView()
                    }, null);
                }).BeginInvoke(null, null);*/
            }
        }

        private void dtCarRentDataGridView_Paint(object sender, PaintEventArgs e) {
            //bool lblWaitVisible = true;
            /*Label lblWait = new Label();
            lblWait.AutoSize = true;
            lblWait.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            lblWait.Location = new System.Drawing.Point(550, 186);
            lblWait.Name = "lblWait";
            lblWait.Size = new System.Drawing.Size(100, 20);
            lblWait.TabIndex = 2;
            lblWait.Text = "Ожидайте...";
            lblWait.Visible = false;
            this.dtCarRentDataGridView.Controls.Add(lblWait);*/
            //
            Color color = Color.Transparent;
            if (dtCarRentWait) {
                color = Color.FromArgb(90, Color.White);
            } else {
                color = Color.Transparent;
            }
            SolidBrush br = new SolidBrush(color);
            e.Graphics.FillRectangle(br, e.ClipRectangle);
        }

        private void Rent_FormClosed(object sender, FormClosedEventArgs e) {
            Program.main.Visible = true;
        }

        private void tbl_CarRentDataGridView_CellEndEdit(object sender, DataGridViewCellEventArgs e) {
            /*if (this.rentDataSet.tbl_CarRent.Rows[e.RowIndex].RowState == DataRowState.Modified)
            {
                tbl_CarRentTableAdapter.Update(this.rentDataSet.tbl_CarRent);
            }*/
        }

        private void tbl_CarRentDataGridView_RowValidating(object sender, DataGridViewCellCancelEventArgs e) {
            // Проверка является ли текущая строка новой и пустой
            if (!tbl_CarRentDataGridView.CurrentRow.IsNewRow) {
                // Проверка были ли какие либо изменения над строкой
                if (this.tbl_CarRentDataGridView.IsCurrentRowDirty) {
                    // Проверка пустое ли поле CarRent_ID
                    if (!string.IsNullOrEmpty(this.tbl_CarRentDataGridView.CurrentRow.Cells["carNumDataGridViewTextBoxColumn"].Value.ToString())) {
                        // Завершить редактирование текущей строки
                        ((DataRowView)this.tbl_CarRentDataGridView.CurrentRow.DataBoundItem).EndEdit();
                        // Обновление DataTable (dtBeginDateCarRate)
                        this.tbl_CarRentTableAdapter.Update(this.rentDataSet.tbl_CarRent);
                    } else {
                        MessageBox.Show("Не заполнено поле № вагона!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        e.Cancel = true;
                    }
                }
            }
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e) {
            if (MessageBox.Show("Удалить запись?", "Внимание!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes) {
                this.tbl_CarRentBindingSource.RemoveCurrent();
                this.tbl_CarRentTableAdapter.Update(this.rentDataSet.tbl_CarRent);
            }
        }

        private void EditCurrentRecord() {
            int CurrentPosition = tbl_CarRentBindingSource.CurrencyManager.Position;
            AddAndEditCarRent addAndEditCarRent = new AddAndEditCarRent((int)tbl_CarRentDataGridView.CurrentRow.Cells["carRentIDDataGridViewTextBoxColumn"].Value);
            addAndEditCarRent.ShowDialog();
            if (CarRentChanged) {
                FillTblCarRentDataGridView();
                tbl_CarRentBindingSource.CurrencyManager.Position = CurrentPosition;
            }
            CarRentChanged = false;
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e) {
            AddAndEditCarRent addAndEditCarRent = new AddAndEditCarRent();
            addAndEditCarRent.ShowDialog();
            if (CarRentChanged) {
                FillTblCarRentDataGridView();
            }
            CarRentChanged = false;
        }

        private void toolStripEditBtn_Click(object sender, EventArgs e) {
            EditCurrentRecord();
        }

        private void tbl_CarRentDataGridView_DoubleClick(object sender, EventArgs e) {
            EditCurrentRecord();
        }
    }
}