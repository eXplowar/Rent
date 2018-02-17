using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace RentWinForms.Forms.Modal
{
    public partial class EditCarRate : Form
    {
        public int BeginDateCarRentID { get; set; }

        public EditCarRate()
        {
            InitializeComponent();
        }

        public EditCarRate(int beginDateCarRentID)
        {
            InitializeComponent();

            BeginDateCarRentID = beginDateCarRentID;
        }

        private void EditCarRate_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'rentDataSet.tbl_Contragent' table. You can move, or remove it, as needed.
            this.tbl_ContragentTableAdapter.Fill(this.rentDataSet.tbl_Contragent);
            // TODO: This line of code loads data into the 'rentDataSet.tbl_CarRent' table. You can move, or remove it, as needed.
            this.tbl_CarRentTableAdapter.Fill(this.rentDataSet.tbl_CarRent, Firm.FirmID);

            dtBeginDateCarRateTableAdapter.FillByBeginDateCarRentID(this.rentDataSet.dtBeginDateCarRate, BeginDateCarRentID, Firm.FirmID);
            RentDataSet.dtBeginDateCarRateRow dtBeginDateCarRateRow = rentDataSet.dtBeginDateCarRate.FindByBeginDateCarRent_ID(BeginDateCarRentID);

            this.dtpBeginDateCarRent.Value = dtBeginDateCarRateRow.BeginDateCarRent;
            this.cboCustomer.SelectedValue = dtBeginDateCarRateRow.Customer;
            this.cboCarRent.SelectedValue = dtBeginDateCarRateRow.CarRent_ID;
            this.txtInRateSum.Text = dtBeginDateCarRateRow.InRateSum.ToString();
            this.txtOutRateSum.Text = dtBeginDateCarRateRow.OutRateSum.ToString();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            dtBeginDateCarRateTableAdapter.FillBy(this.rentDataSet.dtBeginDateCarRate, Firm.FirmID);
            RentDataSet.dtBeginDateCarRateRow dtBeginDateCarRateRow = rentDataSet.dtBeginDateCarRate.FindByBeginDateCarRent_ID(BeginDateCarRentID);

            dtBeginDateCarRateRow.BeginDateCarRent = this.dtpBeginDateCarRent.Value.Date;
            dtBeginDateCarRateRow.CarRent_ID = (int)cboCarRent.SelectedValue;
            dtBeginDateCarRateRow.InRateSum = double.Parse(txtInRateSum.Text.Replace(".", ","));
            dtBeginDateCarRateRow.OutRateSum = double.Parse(txtOutRateSum.Text.Replace(".", ","));
            dtBeginDateCarRateRow.Firm_ID = Firm.FirmID;

            this.dtBeginDateCarRateTableAdapter.Update(this.rentDataSet.dtBeginDateCarRate);

            this.Close();

            CarRentRate.BeginDateCarRateChanged = true;
        }
    }
}