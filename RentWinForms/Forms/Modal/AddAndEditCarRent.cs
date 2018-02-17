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
    public partial class AddAndEditCarRent : Form
    {
        public int CarRentID { get; set; }

        public AddAndEditCarRent()
        {
            InitializeComponent();
        }

        public AddAndEditCarRent(int carRentID)
        {
            InitializeComponent();

            CarRentID = carRentID;
        }
        
        private void AddAndEditCarRent_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'rentDataSet.tbl_CarriageType' table. You can move, or remove it, as needed.
            this.tbl_CarriageTypeTableAdapter.FillWithSort(this.rentDataSet.tbl_CarriageType);
            // TODO: This line of code loads data into the 'rentDataSet.tbl_Contragent' table. You can move, or remove it, as needed.
            this.LessorTableAdapter.FillWithSort(this.rentDataSet.tbl_Contragent);

            if (CarRentID == 0)
            {
                cboCarType.SelectedIndex = -1;
                cboLessor.SelectedIndex = -1;
                cboSeller.SelectedIndex = -1;
                cboCustomer.SelectedIndex = -1;
            }
            else
            {
                this.Text = "Редактирование записи";
                btnConfirm.Text = "Сохранить";

                tbl_CarRentTableAdapter.FillByCarRentID(this.rentDataSet.tbl_CarRent, CarRentID, Firm.FirmID);
                RentDataSet.tbl_CarRentRow tbl_CarRentRow = rentDataSet.tbl_CarRent.FindByCarRent_ID(CarRentID);
                this.txtCarNum.Text = tbl_CarRentRow.CarNum.ToString();
                cboCarType.SelectedValue = tbl_CarRentRow.CarType;
                cboLessor.SelectedValue = tbl_CarRentRow.Lessor;
                cboSeller.SelectedValue = tbl_CarRentRow.Seller;
                if (!tbl_CarRentRow.IsBeginDateNull())
                    dtpBeginDate.Value = tbl_CarRentRow.BeginDate;
                if (!tbl_CarRentRow.IsEndDateNull())
                    dtpEndDate.Value = tbl_CarRentRow.EndDate;
                else
                {
                    dtpEndDate.CustomFormat = " ";
                    dtpEndDate.Format = DateTimePickerFormat.Custom;
                }
                cboCustomer.SelectedValue = tbl_CarRentRow.Customer;
                ckResale.Checked = tbl_CarRentRow.Resale;
            }
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (CarRentID == 0)
            {
                RentDataSet.tbl_CarRentRow newtbl_CarRentRow = rentDataSet.tbl_CarRent.Newtbl_CarRentRow();

                newtbl_CarRentRow.CarNum = int.Parse(txtCarNum.Text);
                newtbl_CarRentRow.CarType = (int)cboCarType.SelectedValue;
                newtbl_CarRentRow.Lessor = (int)cboLessor.SelectedValue;
                newtbl_CarRentRow.Seller = (int)cboSeller.SelectedValue;
                newtbl_CarRentRow.BeginDate = dtpBeginDate.Value;
                newtbl_CarRentRow.EndDate = dtpEndDate.Value;
                newtbl_CarRentRow.Customer = (int)cboCustomer.SelectedValue;
                newtbl_CarRentRow.Resale = ckResale.Checked;
                newtbl_CarRentRow.Firm_ID = Firm.FirmID;

                rentDataSet.tbl_CarRent.Rows.Add(newtbl_CarRentRow);
                this.tbl_CarRentTableAdapter.Update(this.rentDataSet.tbl_CarRent);
            }
            else
            {
                tbl_CarRentTableAdapter.Fill(this.rentDataSet.tbl_CarRent, Firm.FirmID);
                RentDataSet.tbl_CarRentRow tbl_CarRentRow = rentDataSet.tbl_CarRent.FindByCarRent_ID(CarRentID);

                tbl_CarRentRow.CarNum = int.Parse(txtCarNum.Text);
                tbl_CarRentRow.CarType = (int)cboCarType.SelectedValue;
                tbl_CarRentRow.Lessor = (int)cboLessor.SelectedValue;
                tbl_CarRentRow.Seller = (int)cboSeller.SelectedValue;
                tbl_CarRentRow.BeginDate = dtpBeginDate.Value;
                if (dtpEndDate.Format != DateTimePickerFormat.Custom)
                    tbl_CarRentRow.EndDate = dtpEndDate.Value;
                else
                    tbl_CarRentRow.SetEndDateNull();
                tbl_CarRentRow.Customer = (int)cboCustomer.SelectedValue;
                tbl_CarRentRow.Resale = ckResale.Checked;
                tbl_CarRentRow.Firm_ID = Firm.FirmID;

                this.tbl_CarRentTableAdapter.Update(this.rentDataSet.tbl_CarRent);
            }
            this.Close();

            Rent.CarRentChanged = true;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dtpEndDate_ValueChanged(object sender, EventArgs e)
        {
            dtpEndDate.Format = DateTimePickerFormat.Long;
        }

        private void dtpEndDate_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Delete) || (e.KeyCode == Keys.Back))
            {
                dtpEndDate.CustomFormat = " ";
                dtpEndDate.Format = DateTimePickerFormat.Custom;
            }
        }
    }
}
