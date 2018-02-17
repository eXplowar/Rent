namespace RentWinForms.Forms.Modal
{
    partial class CreateRentRate
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.cboCarType = new System.Windows.Forms.ComboBox();
            this.tblCarriageTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rentDataSet = new RentWinForms.RentDataSet();
            this.lblCarType = new System.Windows.Forms.Label();
            this.lblLessor = new System.Windows.Forms.Label();
            this.cboLessor = new System.Windows.Forms.ComboBox();
            this.tblLessorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lbxCustomer = new System.Windows.Forms.ListBox();
            this.tblCustomerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rentDataSet1 = new RentWinForms.RentDataSet();
            this.lbxCarRent = new System.Windows.Forms.ListBox();
            this.txtSearchCarNum = new System.Windows.Forms.TextBox();
            this.txtInRateSum = new System.Windows.Forms.TextBox();
            this.txtOutRateSum = new System.Windows.Forms.TextBox();
            this.lblBeginDateCarRent = new System.Windows.Forms.Label();
            this.lblInRateSum = new System.Windows.Forms.Label();
            this.lbl = new System.Windows.Forms.Label();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.tbl_CarriageTypeTableAdapter = new RentWinForms.RentDataSetTableAdapters.tbl_CarriageTypeTableAdapter();
            this.tbl_ContragentTableAdapter = new RentWinForms.RentDataSetTableAdapters.tbl_ContragentTableAdapter();
            this.dtpBeginDateCarRent = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.tblCarriageTypeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rentDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblLessorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblCustomerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rentDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // cboCarType
            // 
            this.cboCarType.DataSource = this.tblCarriageTypeBindingSource;
            this.cboCarType.DisplayMember = "CarriageType";
            this.cboCarType.FormattingEnabled = true;
            this.cboCarType.Location = new System.Drawing.Point(97, 6);
            this.cboCarType.Name = "cboCarType";
            this.cboCarType.Size = new System.Drawing.Size(241, 21);
            this.cboCarType.TabIndex = 0;
            this.cboCarType.ValueMember = "CarriageType_ID";
            // 
            // tblCarriageTypeBindingSource
            // 
            this.tblCarriageTypeBindingSource.DataMember = "tbl_CarriageType";
            this.tblCarriageTypeBindingSource.DataSource = this.rentDataSet;
            // 
            // rentDataSet
            // 
            this.rentDataSet.DataSetName = "RentDataSet";
            this.rentDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lblCarType
            // 
            this.lblCarType.AutoSize = true;
            this.lblCarType.Location = new System.Drawing.Point(12, 9);
            this.lblCarType.Name = "lblCarType";
            this.lblCarType.Size = new System.Drawing.Size(64, 13);
            this.lblCarType.TabIndex = 1;
            this.lblCarType.Text = "Тип вагона";
            // 
            // lblLessor
            // 
            this.lblLessor.AutoSize = true;
            this.lblLessor.Location = new System.Drawing.Point(12, 36);
            this.lblLessor.Name = "lblLessor";
            this.lblLessor.Size = new System.Drawing.Size(79, 13);
            this.lblLessor.TabIndex = 3;
            this.lblLessor.Text = "Арендодатель";
            // 
            // cboLessor
            // 
            this.cboLessor.DataSource = this.tblLessorBindingSource;
            this.cboLessor.DisplayMember = "FullName";
            this.cboLessor.FormattingEnabled = true;
            this.cboLessor.Location = new System.Drawing.Point(97, 33);
            this.cboLessor.Name = "cboLessor";
            this.cboLessor.Size = new System.Drawing.Size(241, 21);
            this.cboLessor.TabIndex = 2;
            this.cboLessor.ValueMember = "Contragent_ID";
            // 
            // tblLessorBindingSource
            // 
            this.tblLessorBindingSource.DataMember = "tbl_Contragent";
            this.tblLessorBindingSource.DataSource = this.rentDataSet;
            // 
            // lbxCustomer
            // 
            this.lbxCustomer.DataSource = this.tblCustomerBindingSource;
            this.lbxCustomer.DisplayMember = "FullName";
            this.lbxCustomer.FormattingEnabled = true;
            this.lbxCustomer.Location = new System.Drawing.Point(15, 60);
            this.lbxCustomer.Name = "lbxCustomer";
            this.lbxCustomer.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lbxCustomer.Size = new System.Drawing.Size(215, 199);
            this.lbxCustomer.Sorted = true;
            this.lbxCustomer.TabIndex = 4;
            this.lbxCustomer.ValueMember = "Contragent_ID";
            // 
            // tblCustomerBindingSource
            // 
            this.tblCustomerBindingSource.DataMember = "tbl_Contragent";
            this.tblCustomerBindingSource.DataSource = this.rentDataSet1;
            // 
            // rentDataSet1
            // 
            this.rentDataSet1.DataSetName = "RentDataSet";
            this.rentDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lbxCarRent
            // 
            this.lbxCarRent.FormattingEnabled = true;
            this.lbxCarRent.Location = new System.Drawing.Point(236, 86);
            this.lbxCarRent.Name = "lbxCarRent";
            this.lbxCarRent.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lbxCarRent.Size = new System.Drawing.Size(102, 173);
            this.lbxCarRent.TabIndex = 5;
            // 
            // txtSearchCarNum
            // 
            this.txtSearchCarNum.Location = new System.Drawing.Point(236, 60);
            this.txtSearchCarNum.Name = "txtSearchCarNum";
            this.txtSearchCarNum.Size = new System.Drawing.Size(102, 20);
            this.txtSearchCarNum.TabIndex = 6;
            this.txtSearchCarNum.TextChanged += new System.EventHandler(this.txtSearchCarNum_TextChanged);
            // 
            // txtInRateSum
            // 
            this.txtInRateSum.Location = new System.Drawing.Point(130, 291);
            this.txtInRateSum.Name = "txtInRateSum";
            this.txtInRateSum.Size = new System.Drawing.Size(100, 20);
            this.txtInRateSum.TabIndex = 8;
            this.txtInRateSum.Text = "0.0000";
            // 
            // txtOutRateSum
            // 
            this.txtOutRateSum.Location = new System.Drawing.Point(130, 317);
            this.txtOutRateSum.Name = "txtOutRateSum";
            this.txtOutRateSum.Size = new System.Drawing.Size(100, 20);
            this.txtOutRateSum.TabIndex = 9;
            this.txtOutRateSum.Text = "0.0000";
            // 
            // lblBeginDateCarRent
            // 
            this.lblBeginDateCarRent.AutoSize = true;
            this.lblBeginDateCarRent.Location = new System.Drawing.Point(12, 268);
            this.lblBeginDateCarRent.Name = "lblBeginDateCarRent";
            this.lblBeginDateCarRent.Size = new System.Drawing.Size(112, 13);
            this.lblBeginDateCarRent.TabIndex = 10;
            this.lblBeginDateCarRent.Text = "Дата начала аренды";
            // 
            // lblInRateSum
            // 
            this.lblInRateSum.AutoSize = true;
            this.lblInRateSum.Location = new System.Drawing.Point(12, 294);
            this.lblInRateSum.Name = "lblInRateSum";
            this.lblInRateSum.Size = new System.Drawing.Size(60, 13);
            this.lblInRateSum.TabIndex = 11;
            this.lblInRateSum.Text = "Вх. ставка";
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Location = new System.Drawing.Point(12, 320);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(67, 13);
            this.lbl.TabIndex = 12;
            this.lbl.Text = "Исх. ставка";
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(263, 314);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(75, 23);
            this.btnConfirm.TabIndex = 13;
            this.btnConfirm.Text = "Создать";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // tbl_CarriageTypeTableAdapter
            // 
            this.tbl_CarriageTypeTableAdapter.ClearBeforeFill = true;
            // 
            // tbl_ContragentTableAdapter
            // 
            this.tbl_ContragentTableAdapter.ClearBeforeFill = true;
            // 
            // dtpBeginDateCarRent
            // 
            this.dtpBeginDateCarRent.Location = new System.Drawing.Point(131, 265);
            this.dtpBeginDateCarRent.Name = "dtpBeginDateCarRent";
            this.dtpBeginDateCarRent.Size = new System.Drawing.Size(200, 20);
            this.dtpBeginDateCarRent.TabIndex = 14;
            // 
            // CreateRentRate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(351, 348);
            this.Controls.Add(this.dtpBeginDateCarRent);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.lbl);
            this.Controls.Add(this.lblInRateSum);
            this.Controls.Add(this.lblBeginDateCarRent);
            this.Controls.Add(this.txtOutRateSum);
            this.Controls.Add(this.txtInRateSum);
            this.Controls.Add(this.txtSearchCarNum);
            this.Controls.Add(this.lbxCarRent);
            this.Controls.Add(this.lbxCustomer);
            this.Controls.Add(this.lblLessor);
            this.Controls.Add(this.cboLessor);
            this.Controls.Add(this.lblCarType);
            this.Controls.Add(this.cboCarType);
            this.Name = "CreateRentRate";
            this.Text = "CreateRentRate";
            this.Load += new System.EventHandler(this.CreateRentRate_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tblCarriageTypeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rentDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblLessorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblCustomerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rentDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboCarType;
        private System.Windows.Forms.Label lblCarType;
        private System.Windows.Forms.Label lblLessor;
        private System.Windows.Forms.ComboBox cboLessor;
        private System.Windows.Forms.ListBox lbxCustomer;
        private System.Windows.Forms.ListBox lbxCarRent;
        private System.Windows.Forms.TextBox txtSearchCarNum;
        private System.Windows.Forms.TextBox txtInRateSum;
        private System.Windows.Forms.TextBox txtOutRateSum;
        private System.Windows.Forms.Label lblBeginDateCarRent;
        private System.Windows.Forms.Label lblInRateSum;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.Button btnConfirm;
        private RentDataSet rentDataSet;
        private System.Windows.Forms.BindingSource tblCarriageTypeBindingSource;
        private RentDataSetTableAdapters.tbl_CarriageTypeTableAdapter tbl_CarriageTypeTableAdapter;
        private System.Windows.Forms.BindingSource tblLessorBindingSource;
        private RentDataSetTableAdapters.tbl_ContragentTableAdapter tbl_ContragentTableAdapter;
        private System.Windows.Forms.BindingSource tblCustomerBindingSource;
        private System.Windows.Forms.DateTimePicker dtpBeginDateCarRent;
        private RentDataSet rentDataSet1;
    }
}