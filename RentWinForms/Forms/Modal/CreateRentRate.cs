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
using System.Collections;
using System.Data.Common;

namespace RentWinForms.Forms.Modal
{
    public partial class CreateRentRate : Form
    {
        public CreateRentRate()
        {
            InitializeComponent();
        }

        bool isLoaded = false;

        private void CreateRentRate_Load(object sender, EventArgs e)
        {

            cboCarType.DataSource = null;
            cboLessor.DataSource = null;
            lbxCustomer.DataSource = null;

            FillCarType();
            FillLessor();
            FillCusomer();

            cboCarType.DataSource = rentDataSet.tbl_CarriageType;
            cboCarType.DisplayMember = "CarriageType";
            cboCarType.ValueMember = "CarriageType_ID";
            cboCarType.SelectedIndex = -1;

            cboLessor.DataSource = rentDataSet.tbl_Contragent;
            cboLessor.DisplayMember = "FullName";
            cboLessor.ValueMember = "Contragent_ID";
            cboLessor.SelectedIndex = -1;

            lbxCustomer.DataSource = rentDataSet1.tbl_Contragent;
            lbxCustomer.DisplayMember = "FullName";
            lbxCustomer.ValueMember = "Contragent_ID";
            lbxCustomer.SelectedIndex = -1;

            RegisterEvent();

            isLoaded = true;
        }

        private void RegisterEvent()
        {
            this.cboCarType.SelectedValueChanged += new EventHandler(cboCarType_SelectedIndexChanged);
            this.cboLessor.SelectedValueChanged += new EventHandler(cboLessor_SelectedIndexChanged);
            this.lbxCustomer.SelectedValueChanged += new EventHandler(lbxCustomer_SelectedIndexChanged);
            this.cboCarType.TextChanged += new EventHandler(cboCarType_TextChanged);
            this.cboLessor.TextChanged += new EventHandler(cboLessor_TextChanged);
        }

        private void UnRegisterEvent()
        {
            this.cboCarType.SelectedIndexChanged -= new EventHandler(cboCarType_SelectedIndexChanged);
            this.cboLessor.SelectedIndexChanged -= new EventHandler(cboLessor_SelectedIndexChanged);
            this.lbxCustomer.SelectedIndexChanged -= new EventHandler(lbxCustomer_SelectedIndexChanged);
        }

        private void FillCarType()
        {
            // TODO: This line of code loads data into the 'rentDataSet.tbl_CarriageType' table. You can move, or remove it, as needed.
            this.tbl_CarriageTypeTableAdapter.FillJoinCarRent(this.rentDataSet.tbl_CarriageType, Firm.FirmID, (int?)cboLessor.SelectedValue, (int?)lbxCustomer.SelectedValue);
        }

        private void FillLessor()
        {
            // TODO: This line of code loads data into the 'rentDataSet.tbl_Contragent' table. You can move, or remove it, as needed.
            this.tbl_ContragentTableAdapter.FillByLessorJoinCarRent(this.rentDataSet.tbl_Contragent, Firm.FirmID, (int?)cboCarType.SelectedValue, (int?)lbxCustomer.SelectedValue);
        }

        private void FillCusomer()
        {
            // TODO: This line of code loads data into the 'rentDataSet1.tbl_Contragent' table. You can move, or remove it, as needed.
            this.tbl_ContragentTableAdapter.FillByCustomerJoinCarRent(this.rentDataSet1.tbl_Contragent, Firm.FirmID, (int?)cboCarType.SelectedValue, (int?)cboLessor.SelectedValue);
        }

        private void FilterLessorAndCustomer()
        {
            //if (isLoaded)
            //{
            int selectedLessor = 0;
            isLoaded = false;
            //Если SelectedIndex == -1, присвоить его переменной selectedLessor, иначе присвоить переменной selectedLessor значение SelectedValue
            selectedLessor = (cboLessor.SelectedIndex == -1) ? cboLessor.SelectedIndex : (int)cboLessor.SelectedValue;

            FillLessor();

            if (selectedLessor == -1) //Если в переменной хранится Индекс -1
                cboLessor.SelectedIndex = selectedLessor;
            else //Если в переменной хранится не значение -1 (не индекс)
                cboLessor.SelectedValue = selectedLessor;

            FillCusomer();
            lbxCustomer.SelectedIndex = -1;
            isLoaded = true;
            //}
            //else
            //    cboCarType.SelectedIndex = -1;
        }

        private void FilterCarTypeAndCustomer()
        {
            //if (isLoaded)
            //{
            int selectedCarType = 0;
            isLoaded = false;
            //Если SelectedIndex == -1, присвоить его переменной selectedLessor, иначе присвоить переменной selectedLessor значение SelectedValue
            selectedCarType = (cboCarType.SelectedIndex == -1) ? cboCarType.SelectedIndex : (int)cboCarType.SelectedValue;

            FillCarType();

            if (selectedCarType == -1) //Если в переменной хранится Индекс -1
                cboCarType.SelectedIndex = selectedCarType;
            else //Если в переменной хранится не значение -1 (не индекс)
                cboCarType.SelectedValue = selectedCarType;

            FillCusomer();
            lbxCustomer.SelectedIndex = -1;
            isLoaded = true;
            //}
            //else
            //    cboLessor.SelectedIndex = -1;
        }

        private void cboCarType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (isLoaded)
                FilterLessorAndCustomer();
        }

        private void cboLessor_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (isLoaded)
                FilterCarTypeAndCustomer();
        }

        private void lbxCustomer_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Фильтровать lbxCarNum
            FillCarNum();
        }

        private void FillCarNum()
        {
            string GetCustomers = null;
            if ((lbxCustomer.SelectedItems.Count == 0) || (cboCarType.SelectedValue == null) || (cboLessor.SelectedValue == null))
                return;
            else
                foreach (var item in lbxCustomer.SelectedItems)
                {
                    if (string.IsNullOrEmpty(GetCustomers))
                        GetCustomers = ((DataRowView)lbxCustomer.SelectedItem).Row.ItemArray[0].ToString();
                    else
                        GetCustomers = GetCustomers + " Or (tbl_CarRent.Customer)=" + ((DataRowView)item).Row.ItemArray[0].ToString();
                }

            string query = string.Format("SELECT CarRent_ID, CarNum FROM tbl_CarRent WHERE (tbl_CarRent.CarType={0}) And (tbl_CarRent.Lessor={1}) And (tbl_CarRent.CarNum Like '%{2}%') AND (tbl_CarRent.Customer={3}) And (tbl_CarRent.Firm_ID={4})", cboCarType.SelectedValue, cboLessor.SelectedValue, txtSearchCarNum.Text, GetCustomers, Firm.FirmID);
            SqlDataAdapter carNumDataAdapter = new SqlDataAdapter(query, new SqlConnection(Properties.Settings.Default.RentConnectionString));
            rentDataSet.tbl_CarRent.Clear();
            carNumDataAdapter.Fill(rentDataSet.tbl_CarRent);

            lbxCarRent.DataSource = rentDataSet.tbl_CarRent;
            lbxCarRent.DisplayMember = "CarNum";
            lbxCarRent.ValueMember = "CarRent_ID";
            lbxCarRent.SelectedIndex = -1;
        }

        private void cboCarType_TextChanged(object sender, EventArgs e)
        {
            //Событие используется в случае если был очищено значение в соответствующем ComboBox для того чтобы перезаполнить остальные фильтры
            if (isLoaded)
                if (((ComboBox)sender).SelectedIndex == -1)
                    FilterLessorAndCustomer();
        }

        private void cboLessor_TextChanged(object sender, EventArgs e)
        {
            //Событие используется в случае если был очищено значение в соответствующем ComboBox для того чтобы перезаполнить остальные фильтры
            if (isLoaded)
                if (((ComboBox)sender).SelectedIndex == -1)
                    FilterCarTypeAndCustomer();
        }

        private void txtSearchCarNum_TextChanged(object sender, EventArgs e)
        {
            // Фильтровать lbxCarNum
            FillCarNum();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if ((this.cboCarType.SelectedValue == null) || (this.cboLessor.SelectedValue == null))
            {
                MessageBox.Show("Не выбран тип вагона или арендодатель!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }

            string query = string.Format(@"SELECT   tbl_CarTypeRentRate.CarTypeRentRate_ID, 
                                                    tbl_CarTypeRentRate.CarType, 
                                                    tbl_CarTypeLessorRentRate.CarTypeLessorRentRate_ID, 
                                                    tbl_CarTypeLessorRentRate.Lessor, 
                                                    tbl_BeginDateCarRate.BeginDateCarRent_ID, 
                                                    tbl_BeginDateCarRate.BeginDateCarRent, 
                                                    tbl_BeginDateCarRate.InRateSum, 
                                                    tbl_BeginDateCarRate.OutRateSum, 
                                                    tbl_BeginDateCarRate.CarRent_ID
                                            FROM tbl_CarTypeRentRate LEFT OUTER JOIN
                                                    tbl_CarTypeLessorRentRate LEFT OUTER JOIN
                                                        tbl_BeginDateCarRate ON tbl_CarTypeLessorRentRate.CarTypeLessorRentRate_ID = tbl_BeginDateCarRate.CarTypeLessorRentRate_ID ON 
                                                            tbl_CarTypeRentRate.CarTypeRentRate_ID = tbl_CarTypeLessorRentRate.CarTypeRentRate_ID
                                            WHERE (tbl_BeginDateCarRate.Firm_ID = {0})", Firm.FirmID);
            SqlConnection cn = new SqlConnection(Properties.Settings.Default.RentConnectionString);
            cn.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cn;
            string checkRate = null; //В строке перечислены вагоны для которых уже существует создаваемая ставка. Используется для формирования окна сообщения об ошибке
            string carRentID = null; //Список вагонов для которых необходимо создать ставку. Используется в SQL запросе на вставку

            //Перебрать все выбранные элементы
            foreach (DataRowView objDataRowView in this.lbxCarRent.SelectedItems)
            {
                //Проверить существует ли ставка для текущего в цикле вагона (objDataRowView[0].ToString())
                cmd.CommandText = string.Format("SELECT Rent.dbo.fn_CheckRate({0}, {1}, '{2}', {3}, {4}, {5}, {6})", this.cboCarType.SelectedValue, this.cboLessor.SelectedValue, this.dtpBeginDateCarRent.Value.ToShortDateString(), this.txtInRateSum.Text.Replace(",", "."), this.txtOutRateSum.Text.Replace(",", "."), objDataRowView[0].ToString(), Firm.FirmID); //objDataRowView[0].ToString() - вытаскивается CarRent_ID
                int result = (int)cmd.ExecuteScalar();
                if (result != 0) //Если у этого вагона (objDataRowView[0].ToString()) уже есть эта ставка
                {
                    if (string.IsNullOrEmpty(checkRate)) //Формирование списка вагона для сообщения пользователю о том, что были найдены ставки - далее приостановить создание ставок
                        checkRate = "Эта ставка уже существует у следующих вагонов: " + objDataRowView[1].ToString();
                    else
                        checkRate += ", " + objDataRowView[1].ToString();
                }
                else if (result == 0) //Если для этого вагона нету ставки
                {
                    if (string.IsNullOrEmpty(carRentID)) //Формирование списка вагонов (CarRent_ID) для использования его в запросе на вставку в таблицу tbl_BeginDateCarRate ставок
                        carRentID = objDataRowView[0].ToString();
                    else
                        carRentID += " Or (tbl_CarRent.CarRent_ID)=" + objDataRowView[0].ToString();
                }
            }

            if (string.IsNullOrEmpty(checkRate) && !string.IsNullOrEmpty(carRentID)) //Если, после того как пробежались по всем элементам списка lbxCarRent, в переменной checkRate не хронятся вагоны у которых уже есть ставка, а также в переменую carRentID были добавлены вагоны (CarRent_ID)
            {
                //Использовать сформировавшийся carRentID в запросе на вставку ставок в таблицу tbl_BeginDateCarRate...
                //Но перед тем как вставлять сами ставки, необходимо убедиться создан ли [Тип вагона] + [Арендодатель]
                cmd.CommandText = string.Format("SELECT Rent.dbo.fn_CheckRate({0}, {1}, {2}, {3}, {4}, {5}, {6})", this.cboCarType.SelectedValue, this.cboLessor.SelectedValue, "null", "null", "null", "null", Firm.FirmID);
                if ((int)cmd.ExecuteScalar() != 0) //Если директория [Тип вагона - Арендодатель] уже существует
                {
                    //Вытаскиваем CarTypeLessorRentRate_ID
                    cmd.CommandText = string.Format("SELECT Rent.dbo.fn_GetCarTypeLessorRentRateID({0}, {1})", this.cboCarType.SelectedValue, this.cboLessor.SelectedValue);
                    int FK = (int)cmd.ExecuteScalar();

                    //Вставка в tbl_BeginDateCarRate
                    cmd.CommandText = string.Format("INSERT INTO dbo.tbl_BeginDateCarRate ( CarTypeLessorRentRate_ID, BeginDateCarRent, InRateSum, OutRateSum, CarRent_ID, Creator, Editor, Firm_ID ) " +
                                                    "SELECT {0} AS CarTypeLessorRentRate_ID, '{1}' AS BeginDateCarRent, {2} AS InRateSum, {3} AS OutRateSum, tbl_CarRent.CarRent_ID AS CarRent_ID, {4} AS Creator, {5} AS Editor, {6} AS Firm_ID " +
                                                    "FROM tbl_CarRent " +
                                                    "WHERE (((tbl_CarRent.CarRent_ID)={7}));", FK, this.dtpBeginDateCarRent.Value.Date, this.txtInRateSum.Text, this.txtOutRateSum.Text, "null", "null", Firm.FirmID, carRentID);
                    if ((int)cmd.ExecuteNonQuery() != 0) //Если вставка успешно выполнена
                        MessageBox.Show("Ставка успешно создана для выбранных вагонов", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        MessageBox.Show("Ошибка во время создания ставки!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                    cn.Close();
                    return;
                }
                else //Если директория [Тип вагона - Арендодатель] нет
                {
                    //Проверить существует ли тип вагона
                    cmd.CommandText = string.Format("SELECT Rent.dbo.fn_CheckRate({0}, {1}, {2}, {3}, {4}, {5}, {6})", this.cboCarType.SelectedValue, "null", "null", "null", "null", "null", Firm.FirmID);
                    if ((int)cmd.ExecuteScalar() != 0) //Если тип вагона существует
                    {
                        //Вытаскиваем CarTypeRentRate_ID
                        cmd.CommandText = string.Format("SELECT Rent.dbo.fn_GetCarTypeRentRateID({0})", this.cboCarType.SelectedValue);
                        int FK = (int)cmd.ExecuteScalar();

                        //Вставка в tbl_CarTypeLessorRentRate
                            cmd.CommandText = string.Format("INSERT INTO dbo.tbl_CarTypeLessorRentRate ( CarTypeRentRate_ID, Lessor ) " +
                                                            "SELECT {0} AS CarTypeRentRate_ID, {1} AS Lessor;", FK, this.cboLessor.SelectedValue);

                        if ((int)cmd.ExecuteNonQuery() != 0) //Если вставка арендодателя успешно выполнена
                        {
                            //Вытаскиваем tbl_CarTypeLessorRentRate_ID только что добавленной записи
                            cmd.CommandText = "SELECT IDENT_CURRENT('Rent.dbo.tbl_CarTypeLessorRentRate')";//string.Format("SELECT @@IDENTITY AS LastId FROM Rent.dbo.tbl_CarTypeLessorRentRate;");
                            int LastCarTypeLessorRentRateID = int.Parse(cmd.ExecuteScalar().ToString());

                            //Вставка в tbl_BeginDateCarRate
                            cmd.CommandText = string.Format("INSERT INTO dbo.tbl_BeginDateCarRate ( CarTypeLessorRentRate_ID, BeginDateCarRent, InRateSum, OutRateSum, CarRent_ID, Creator, Editor, Firm_ID ) " +
                                                    "SELECT {0} AS CarTypeLessorRentRate_ID, '{1}' AS BeginDateCarRent, {2} AS InRateSum, {3} AS OutRateSum, tbl_CarRent.CarRent_ID AS CarRent_ID, {4} AS Creator, {5} AS Editor, {6} AS Firm_ID " +
                                                    "FROM tbl_CarRent " +
                                                    "WHERE (((tbl_CarRent.CarRent_ID)={7}));", LastCarTypeLessorRentRateID, this.dtpBeginDateCarRent.Value.Date, this.txtInRateSum.Text, this.txtOutRateSum.Text, "null", "null", Firm.FirmID, carRentID);
                            if ((int)cmd.ExecuteNonQuery() != 0) //Если вставка успешно выполнена
                                MessageBox.Show("Ставка успешно создана для выбранных вагонов", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            else
                                MessageBox.Show("Ошибка во время создания ставки!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            this.Close();
                            cn.Close();
                            return;
                        }
                    }
                    else //Если типа вагона не существует, создать его и тд...
                    {
                        //Вставка в tbl_CarTypeRentRate
                        cmd.CommandText = string.Format("INSERT INTO dbo.tbl_CarTypeRentRate ( CarType ) SELECT {0} AS CarType;", this.cboCarType.SelectedValue);

                        if ((int)cmd.ExecuteNonQuery() != 0) //Если вставка успешно выполнена
                        {
                            //Вытаскиваем CarTypeRentRate_ID только что добавленной записи
                            cmd.CommandText = "SELECT IDENT_CURRENT('Rent.dbo.tbl_CarTypeRentRate')";//"SELECT SCOPE_IDENTITY() AS LastId FROM Rent.dbo.tbl_CarTypeRentRate;";
                            int LastCarTypeRentRateID = int.Parse(cmd.ExecuteScalar().ToString());

                            //Вставка в tbl_CarTypeLessorRentRate
                            cmd.CommandText = string.Format("INSERT INTO dbo.tbl_CarTypeLessorRentRate ( CarTypeRentRate_ID, Lessor ) " +
                                                            "SELECT {0} AS CarTypeRentRate_ID, {1} AS Lessor;", LastCarTypeRentRateID, this.cboLessor.SelectedValue);

                            if ((int)cmd.ExecuteNonQuery() != 0) //Если вставка арендодателя успешно выполнена
                            {
                                //Вытаскиваем tbl_CarTypeLessorRentRate_ID только что добавленной записи
                                cmd.CommandText = "SELECT IDENT_CURRENT('Rent.dbo.tbl_CarTypeLessorRentRate')";//string.Format("SELECT @@IDENTITY AS LastId FROM Rent.dbo.tbl_CarTypeLessorRentRate;");
                                int LastCarTypeLessorRentRateID = int.Parse(cmd.ExecuteScalar().ToString());

                                //Вставка в tbl_BeginDateCarRate
                                cmd.CommandText = string.Format("INSERT INTO dbo.tbl_BeginDateCarRate ( CarTypeLessorRentRate_ID, BeginDateCarRent, InRateSum, OutRateSum, CarRent_ID, Creator, Editor, Firm_ID ) " +
                                                    "SELECT {0} AS CarTypeLessorRentRate_ID, '{1}' AS BeginDateCarRent, {2} AS InRateSum, {3} AS OutRateSum, tbl_CarRent.CarRent_ID AS CarRent_ID, {4} AS Creator, {5} AS Editor, {6} AS Firm_ID " +
                                                    "FROM tbl_CarRent " +
                                                    "WHERE (((tbl_CarRent.CarRent_ID)={7}));", LastCarTypeLessorRentRateID, this.dtpBeginDateCarRent.Value.Date, this.txtInRateSum.Text, this.txtOutRateSum.Text, "null", "null", Firm.FirmID, carRentID);
                                if ((int)cmd.ExecuteNonQuery() != 0) //Если вставка успешно выполнена
                                    MessageBox.Show("Ставка успешно создана для выбранных вагонов", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                else
                                    MessageBox.Show("Ошибка во время создания ставки!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                this.Close();
                                cn.Close();
                                return;
                            }
                        }
                    }
                }
                //
                MessageBox.Show(checkRate + "\nСтавка успешно создана!");
            }
            else
                MessageBox.Show(checkRate);

            cn.Close();
        }
    }
}