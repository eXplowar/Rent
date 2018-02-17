namespace RentWinForms.Forms.Modal
{
    partial class AddAndEditCarRent
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
            this.txtCarNum = new System.Windows.Forms.TextBox();
            this.lblCarNum = new System.Windows.Forms.Label();
            this.lblCarType = new System.Windows.Forms.Label();
            this.lblLessor = new System.Windows.Forms.Label();
            this.lblSeller = new System.Windows.Forms.Label();
            this.dtpBeginDate = new System.Windows.Forms.DateTimePicker();
            this.lblDateBegin = new System.Windows.Forms.Label();
            this.lblEndDate = new System.Windows.Forms.Label();
            this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
            this.cboCustomer = new System.Windows.Forms.ComboBox();
            this.CustomerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rentDataSet = new RentWinForms.RentDataSet();
            this.tblContragentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lblCustomer = new System.Windows.Forms.Label();
            this.ckResale = new System.Windows.Forms.CheckBox();
            this.cboLessor = new System.Windows.Forms.ComboBox();
            this.cboSeller = new System.Windows.Forms.ComboBox();
            this.SellerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.LessorTableAdapter = new RentWinForms.RentDataSetTableAdapters.tbl_ContragentTableAdapter();
            this.cboCarType = new System.Windows.Forms.ComboBox();
            this.tblCarriageTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnConfirm = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.tbl_CarRentTableAdapter = new RentWinForms.RentDataSetTableAdapters.tbl_CarRentTableAdapter();
            this.tbl_CarriageTypeTableAdapter = new RentWinForms.RentDataSetTableAdapters.tbl_CarriageTypeTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.CustomerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rentDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblContragentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SellerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblCarriageTypeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // txtCarNum
            // 
            this.txtCarNum.Location = new System.Drawing.Point(99, 12);
            this.txtCarNum.Name = "txtCarNum";
            this.txtCarNum.Size = new System.Drawing.Size(100, 20);
            this.txtCarNum.TabIndex = 0;
            // 
            // lblCarNum
            // 
            this.lblCarNum.AutoSize = true;
            this.lblCarNum.Location = new System.Drawing.Point(36, 15);
            this.lblCarNum.Name = "lblCarNum";
            this.lblCarNum.Size = new System.Drawing.Size(57, 13);
            this.lblCarNum.TabIndex = 1;
            this.lblCarNum.Text = "№ Вагона";
            // 
            // lblCarType
            // 
            this.lblCarType.AutoSize = true;
            this.lblCarType.Location = new System.Drawing.Point(29, 41);
            this.lblCarType.Name = "lblCarType";
            this.lblCarType.Size = new System.Drawing.Size(64, 13);
            this.lblCarType.TabIndex = 3;
            this.lblCarType.Text = "Тип вагона";
            // 
            // lblLessor
            // 
            this.lblLessor.AutoSize = true;
            this.lblLessor.Location = new System.Drawing.Point(14, 67);
            this.lblLessor.Name = "lblLessor";
            this.lblLessor.Size = new System.Drawing.Size(79, 13);
            this.lblLessor.TabIndex = 5;
            this.lblLessor.Text = "Арендодатель";
            // 
            // lblSeller
            // 
            this.lblSeller.AutoSize = true;
            this.lblSeller.Location = new System.Drawing.Point(36, 93);
            this.lblSeller.Name = "lblSeller";
            this.lblSeller.Size = new System.Drawing.Size(57, 13);
            this.lblSeller.TabIndex = 7;
            this.lblSeller.Text = "Продавец";
            // 
            // dtpBeginDate
            // 
            this.dtpBeginDate.Location = new System.Drawing.Point(99, 117);
            this.dtpBeginDate.Name = "dtpBeginDate";
            this.dtpBeginDate.Size = new System.Drawing.Size(200, 20);
            this.dtpBeginDate.TabIndex = 8;
            // 
            // lblDateBegin
            // 
            this.lblDateBegin.AutoSize = true;
            this.lblDateBegin.Location = new System.Drawing.Point(8, 123);
            this.lblDateBegin.Name = "lblDateBegin";
            this.lblDateBegin.Size = new System.Drawing.Size(85, 13);
            this.lblDateBegin.TabIndex = 9;
            this.lblDateBegin.Text = "Начало аренды";
            // 
            // lblEndDate
            // 
            this.lblEndDate.AutoSize = true;
            this.lblEndDate.Location = new System.Drawing.Point(14, 149);
            this.lblEndDate.Name = "lblEndDate";
            this.lblEndDate.Size = new System.Drawing.Size(79, 13);
            this.lblEndDate.TabIndex = 11;
            this.lblEndDate.Text = "Конец аренды";
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.Location = new System.Drawing.Point(99, 143);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Size = new System.Drawing.Size(200, 20);
            this.dtpEndDate.TabIndex = 10;
            this.dtpEndDate.ValueChanged += new System.EventHandler(this.dtpEndDate_ValueChanged);
            this.dtpEndDate.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dtpEndDate_KeyDown);
            // 
            // cboCustomer
            // 
            this.cboCustomer.DataSource = this.CustomerBindingSource;
            this.cboCustomer.DisplayMember = "FullName";
            this.cboCustomer.FormattingEnabled = true;
            this.cboCustomer.Location = new System.Drawing.Point(99, 169);
            this.cboCustomer.Name = "cboCustomer";
            this.cboCustomer.Size = new System.Drawing.Size(199, 21);
            this.cboCustomer.TabIndex = 12;
            this.cboCustomer.ValueMember = "Contragent_ID";
            // 
            // CustomerBindingSource
            // 
            this.CustomerBindingSource.DataMember = "tbl_Contragent";
            this.CustomerBindingSource.DataSource = this.rentDataSet;
            // 
            // rentDataSet
            // 
            this.rentDataSet.DataSetName = "RentDataSet";
            this.rentDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblContragentBindingSource
            // 
            this.tblContragentBindingSource.DataMember = "tbl_Contragent";
            this.tblContragentBindingSource.DataSource = this.rentDataSet;
            // 
            // lblCustomer
            // 
            this.lblCustomer.AutoSize = true;
            this.lblCustomer.Location = new System.Drawing.Point(50, 172);
            this.lblCustomer.Name = "lblCustomer";
            this.lblCustomer.Size = new System.Drawing.Size(43, 13);
            this.lblCustomer.TabIndex = 13;
            this.lblCustomer.Text = "Клиент";
            // 
            // ckResale
            // 
            this.ckResale.AutoSize = true;
            this.ckResale.Location = new System.Drawing.Point(99, 196);
            this.ckResale.Name = "ckResale";
            this.ckResale.Size = new System.Drawing.Size(96, 17);
            this.ckResale.TabIndex = 14;
            this.ckResale.Text = "Перепродажа";
            this.ckResale.UseVisualStyleBackColor = true;
            // 
            // cboLessor
            // 
            this.cboLessor.DataSource = this.tblContragentBindingSource;
            this.cboLessor.DisplayMember = "FullName";
            this.cboLessor.FormattingEnabled = true;
            this.cboLessor.Location = new System.Drawing.Point(99, 64);
            this.cboLessor.Name = "cboLessor";
            this.cboLessor.Size = new System.Drawing.Size(199, 21);
            this.cboLessor.TabIndex = 15;
            this.cboLessor.ValueMember = "Contragent_ID";
            // 
            // cboSeller
            // 
            this.cboSeller.DataSource = this.SellerBindingSource;
            this.cboSeller.DisplayMember = "FullName";
            this.cboSeller.FormattingEnabled = true;
            this.cboSeller.Location = new System.Drawing.Point(99, 90);
            this.cboSeller.Name = "cboSeller";
            this.cboSeller.Size = new System.Drawing.Size(199, 21);
            this.cboSeller.TabIndex = 16;
            this.cboSeller.ValueMember = "Contragent_ID";
            // 
            // SellerBindingSource
            // 
            this.SellerBindingSource.DataMember = "tbl_Contragent";
            this.SellerBindingSource.DataSource = this.rentDataSet;
            // 
            // LessorTableAdapter
            // 
            this.LessorTableAdapter.ClearBeforeFill = true;
            // 
            // cboCarType
            // 
            this.cboCarType.DataSource = this.tblCarriageTypeBindingSource;
            this.cboCarType.DisplayMember = "CarriageType";
            this.cboCarType.FormattingEnabled = true;
            this.cboCarType.Location = new System.Drawing.Point(100, 39);
            this.cboCarType.Name = "cboCarType";
            this.cboCarType.Size = new System.Drawing.Size(199, 21);
            this.cboCarType.TabIndex = 17;
            this.cboCarType.ValueMember = "CarriageType_ID";
            // 
            // tblCarriageTypeBindingSource
            // 
            this.tblCarriageTypeBindingSource.DataMember = "tbl_CarriageType";
            this.tblCarriageTypeBindingSource.DataSource = this.rentDataSet;
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(198, 220);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(75, 23);
            this.btnConfirm.TabIndex = 18;
            this.btnConfirm.Text = "Создать";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(279, 220);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 19;
            this.btnCancel.Text = "Отмена";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // tbl_CarRentTableAdapter
            // 
            this.tbl_CarRentTableAdapter.ClearBeforeFill = true;
            // 
            // tbl_CarriageTypeTableAdapter
            // 
            this.tbl_CarriageTypeTableAdapter.ClearBeforeFill = true;
            // 
            // AddAndEditCarRent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(372, 261);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.cboCarType);
            this.Controls.Add(this.cboSeller);
            this.Controls.Add(this.cboLessor);
            this.Controls.Add(this.ckResale);
            this.Controls.Add(this.lblCustomer);
            this.Controls.Add(this.cboCustomer);
            this.Controls.Add(this.lblEndDate);
            this.Controls.Add(this.dtpEndDate);
            this.Controls.Add(this.lblDateBegin);
            this.Controls.Add(this.dtpBeginDate);
            this.Controls.Add(this.lblSeller);
            this.Controls.Add(this.lblLessor);
            this.Controls.Add(this.lblCarType);
            this.Controls.Add(this.lblCarNum);
            this.Controls.Add(this.txtCarNum);
            this.Name = "AddAndEditCarRent";
            this.Text = "Создание записи";
            this.Load += new System.EventHandler(this.AddAndEditCarRent_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CustomerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rentDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblContragentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SellerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblCarriageTypeBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCarNum;
        private System.Windows.Forms.Label lblCarNum;
        private System.Windows.Forms.Label lblCarType;
        private System.Windows.Forms.Label lblLessor;
        private System.Windows.Forms.Label lblSeller;
        private System.Windows.Forms.DateTimePicker dtpBeginDate;
        private System.Windows.Forms.Label lblDateBegin;
        private System.Windows.Forms.Label lblEndDate;
        private System.Windows.Forms.DateTimePicker dtpEndDate;
        private System.Windows.Forms.ComboBox cboCustomer;
        private System.Windows.Forms.Label lblCustomer;
        private System.Windows.Forms.CheckBox ckResale;
        private System.Windows.Forms.ComboBox cboLessor;
        private System.Windows.Forms.ComboBox cboSeller;
        private RentDataSet rentDataSet;
        private System.Windows.Forms.BindingSource tblContragentBindingSource;
        private RentDataSetTableAdapters.tbl_ContragentTableAdapter LessorTableAdapter;
        private System.Windows.Forms.ComboBox cboCarType;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Button btnCancel;
        private RentDataSetTableAdapters.tbl_CarRentTableAdapter tbl_CarRentTableAdapter;
        private System.Windows.Forms.BindingSource tblCarriageTypeBindingSource;
        private RentDataSetTableAdapters.tbl_CarriageTypeTableAdapter tbl_CarriageTypeTableAdapter;
        private System.Windows.Forms.BindingSource SellerBindingSource;
        private System.Windows.Forms.BindingSource CustomerBindingSource;
    }
}