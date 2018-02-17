using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.Common;

namespace RentWinForms
{
    public partial class CarRentRate : Form
    {
        public CarRentRate()
        {
            InitializeComponent();
        }

        private void dtBeginDateCarRateBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.dtBeginDateCarRateBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.rentDataSet);
            //dtBeginDateCarRateTableAdapter.Update(this.rentDataSet.dtBeginDateCarRate);

        }

        private void CarRentRate_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'rentDataSet.dtCarTypeRentRate' table. You can move, or remove it, as needed.
            this.dtCarTypeRentRateTableAdapter.Fill(this.rentDataSet.dtCarTypeRentRate);

            FillCarTypeLessorRentRate();

            // TODO: This line of code loads data into the 'rentDataSet.tbl_CarriageType' table. You can move, or remove it, as needed.
            this.tbl_CarriageTypeTableAdapter.Fill(this.rentDataSet.tbl_CarriageType);
            // TODO: This line of code loads data into the 'rentDataSet.tbl_Contragent' table. You can move, or remove it, as needed.
            this.tbl_ContragentTableAdapter.Fill(this.rentDataSet.tbl_Contragent);
            // TODO: This line of code loads data into the 'rentDataSet.tbl_CarRent' table. You can move, or remove it, as needed.
            this.tbl_CarRentTableAdapter.Fill(this.rentDataSet.tbl_CarRent, Firm.FirmID);

            FillBeginDateCarRateDataGridView();
        }

        private void cboLessor_Enter(object sender, EventArgs e)
        {
            FillCarTypeLessorRentRate();
        }

        private void cboLessor_SelectedValueChanged(object sender, EventArgs e)
        {
            FillBeginDateCarRateDataGridView();
        }

        private void FillCarTypeLessorRentRate()
        {
            if (this.cboCarType.SelectedValue is int)
            {
                // TODO: This line of code loads data into the 'rentDataSet.dtCarTypeLessorRentRate' table. You can move, or remove it, as needed.
                this.dtCarTypeLessorRentRateTableAdapter.Fill(this.rentDataSet.dtCarTypeLessorRentRate, (int)this.cboCarType.SelectedValue);
            }
        }

        private void FillBeginDateCarRateDataGridView()
        {
            if (this.cboLessor.SelectedValue is int)
            {
                // TODO: This line of code loads data into the 'rentDataSet.dtBeginDateCarRate' table. You can move, or remove it, as needed.
                this.dtBeginDateCarRateTableAdapter.Fill(this.rentDataSet.dtBeginDateCarRate, (int)this.cboLessor.SelectedValue, Firm.FirmID);
            }
        }

        private void tbl_BeginDateCarRateDataGridView_DefaultValuesNeeded(object sender, DataGridViewRowEventArgs e)
        {
            e.Row.Cells["dataGridViewTextBoxColumn2"].Value = this.cboLessor.SelectedValue;// Столбец CarTypeLessorRentRate_ID
            e.Row.Cells["dataGridViewTextBoxColumn11"].Value = Firm.FirmID;// Столбец Firm_ID
            e.Row.Cells["dataGridViewTextBoxColumn4"].Value = 0;// Столбец InRateSum
            e.Row.Cells["dataGridViewTextBoxColumn5"].Value = 0;// Столбец OutRateSum
        }

        bool NowValidating = false; //Используется в обработчике событий tbl_BeginDateCarRateDataGridView_RowValidating

        private void tbl_BeginDateCarRateDataGridView_RowValidating(object sender, DataGridViewCellCancelEventArgs e)
        {
            //Переменная NowValidating указывает выполняется ли уже обработчик события tbl_BeginDateCarRateDataGridView_RowValidating. Этот маркер обеспечивает уверенность в том что метод this.dtBeginDateCarRateTableAdapter.Update(this.rentDataSet.dtBeginDateCarRate) не запустится повторно в случае если осуществяется вставка новой строки
            if (!NowValidating)
            {
                NowValidating = true;
                // Проверка является ли текущая строка строкой для новых записей
                if (!tbl_BeginDateCarRateDataGridView.CurrentRow.IsNewRow)
                {
                    // Проверка были ли какие либо изменения над строкой
                    if (this.tbl_BeginDateCarRateDataGridView.IsCurrentRowDirty)
                    {
                        // Проверка пустое ли поле CarRent_ID
                        if (!string.IsNullOrEmpty(this.tbl_BeginDateCarRateDataGridView.CurrentRow.Cells[tbl_BeginDateCarRateDataGridView.Columns["CarRent_ID"].Index].Value.ToString()))
                        {
                            // Завершить редактирование текущей строки (в случае если это новая строка то до вызова метода EndEdit() состояние строки .Row.RowState = Detached, после .Row.RowState = Added; а в случае изменения Unchange изменяется на Modefied)
                            ((DataRowView)this.tbl_BeginDateCarRateDataGridView.CurrentRow.DataBoundItem).EndEdit();
                            // Обновление DataTable (dtBeginDateCarRate)
                            //MessageBox.Show("Был выполнен метод dtBeginDateCarRateTableAdapter.Update(), его результат: " + this.dtBeginDateCarRateTableAdapter.Update(this.rentDataSet.dtBeginDateCarRate).ToString());
                            this.dtBeginDateCarRateTableAdapter.Update(this.rentDataSet.dtBeginDateCarRate);
                        }
                        else
                        {
                            MessageBox.Show("Не заполнено поле № вагона!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            e.Cancel = true;
                        }
                    }
                }
                NowValidating = false;
            }
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы действительно хотите удалить ставку?", "Внимание!", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                this.dtBeginDateCarRateBindingSource.RemoveCurrent();
                this.dtBeginDateCarRateTableAdapter.Update(this.rentDataSet.dtBeginDateCarRate);
            }
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            Forms.Modal.EditCarRate addCarRate = new Forms.Modal.EditCarRate();
            addCarRate.ShowDialog();
        }

        private void btnCreateRate_Click(object sender, EventArgs e)
        {
            Forms.Modal.CreateRentRate createRentRate = new Forms.Modal.CreateRentRate();
            createRentRate.ShowDialog();
        }

        public static bool BeginDateCarRateChanged { get; set; }

        private void EditCurrentRecord()
        {
            int CurrentPosition = dtBeginDateCarRateBindingSource.CurrencyManager.Position;
            Forms.Modal.EditCarRate editCarRate = new Forms.Modal.EditCarRate((int)tbl_BeginDateCarRateDataGridView.CurrentRow.Cells["dataGridViewTextBoxColumn1"].Value); //BeginDateCarRent_ID
            editCarRate.ShowDialog();
            if (BeginDateCarRateChanged)
            {
                FillBeginDateCarRateDataGridView();
                dtBeginDateCarRateBindingSource.CurrencyManager.Position = CurrentPosition;
            }
            BeginDateCarRateChanged = false;
        }

        private void tbl_BeginDateCarRateDataGridView_DoubleClick(object sender, EventArgs e)
        {
            EditCurrentRecord();
        }

        private void toolStripEditBtn_Click(object sender, EventArgs e)
        {
            EditCurrentRecord();
        }
    }
}