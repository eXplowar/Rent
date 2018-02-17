namespace RentWinForms.Forms.Modal
{
    partial class EditCarRate
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
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpBeginDateCarRent = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.cboCustomer = new System.Windows.Forms.ComboBox();
            this.tblContragentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rentDataSet = new RentWinForms.RentDataSet();
            this.cboCarRent = new System.Windows.Forms.ComboBox();
            this.tblCarRentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.txtInRateSum = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtOutRateSum = new System.Windows.Forms.TextBox();
            this.tbl_ContragentTableAdapter = new RentWinForms.RentDataSetTableAdapters.tbl_ContragentTableAdapter();
            this.tbl_CarRentTableAdapter = new RentWinForms.RentDataSetTableAdapters.tbl_CarRentTableAdapter();
            this.dtBeginDateCarRateTableAdapter = new RentWinForms.RentDataSetTableAdapters.dtBeginDateCarRateTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.tblContragentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rentDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblCarRentBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(300, 143);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 21;
            this.btnCancel.Text = "Отмена";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(219, 143);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(75, 23);
            this.btnConfirm.TabIndex = 20;
            this.btnConfirm.Text = "Сохранить";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 13);
            this.label1.TabIndex = 23;
            this.label1.Text = "Дата начала действия ставики";
            // 
            // dtpBeginDateCarRent
            // 
            this.dtpBeginDateCarRent.Location = new System.Drawing.Point(175, 12);
            this.dtpBeginDateCarRent.Name = "dtpBeginDateCarRent";
            this.dtpBeginDateCarRent.Size = new System.Drawing.Size(200, 20);
            this.dtpBeginDateCarRent.TabIndex = 24;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 25;
            this.label2.Text = "Клиент";
            // 
            // cboCustomer
            // 
            this.cboCustomer.DataSource = this.tblContragentBindingSource;
            this.cboCustomer.DisplayMember = "FullName";
            this.cboCustomer.FormattingEnabled = true;
            this.cboCustomer.Location = new System.Drawing.Point(77, 38);
            this.cboCustomer.Name = "cboCustomer";
            this.cboCustomer.Size = new System.Drawing.Size(298, 21);
            this.cboCustomer.TabIndex = 26;
            this.cboCustomer.ValueMember = "Contragent_ID";
            // 
            // tblContragentBindingSource
            // 
            this.tblContragentBindingSource.DataMember = "tbl_Contragent";
            this.tblContragentBindingSource.DataSource = this.rentDataSet;
            // 
            // rentDataSet
            // 
            this.rentDataSet.DataSetName = "RentDataSet";
            this.rentDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cboCarRent
            // 
            this.cboCarRent.DataSource = this.tblCarRentBindingSource;
            this.cboCarRent.DisplayMember = "CarNum";
            this.cboCarRent.FormattingEnabled = true;
            this.cboCarRent.Location = new System.Drawing.Point(77, 65);
            this.cboCarRent.Name = "cboCarRent";
            this.cboCarRent.Size = new System.Drawing.Size(100, 21);
            this.cboCarRent.TabIndex = 28;
            this.cboCarRent.ValueMember = "CarRent_ID";
            // 
            // tblCarRentBindingSource
            // 
            this.tblCarRentBindingSource.DataMember = "tbl_CarRent";
            this.tblCarRentBindingSource.DataSource = this.rentDataSet;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 27;
            this.label3.Text = "№ вагона";
            // 
            // txtInRateSum
            // 
            this.txtInRateSum.Location = new System.Drawing.Point(77, 92);
            this.txtInRateSum.Name = "txtInRateSum";
            this.txtInRateSum.Size = new System.Drawing.Size(100, 20);
            this.txtInRateSum.TabIndex = 29;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 30;
            this.label4.Text = "Вх. ставка";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 121);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 13);
            this.label5.TabIndex = 32;
            this.label5.Text = "Исх. ставка";
            // 
            // txtOutRateSum
            // 
            this.txtOutRateSum.Location = new System.Drawing.Point(77, 118);
            this.txtOutRateSum.Name = "txtOutRateSum";
            this.txtOutRateSum.Size = new System.Drawing.Size(100, 20);
            this.txtOutRateSum.TabIndex = 31;
            // 
            // tbl_ContragentTableAdapter
            // 
            this.tbl_ContragentTableAdapter.ClearBeforeFill = true;
            // 
            // tbl_CarRentTableAdapter
            // 
            this.tbl_CarRentTableAdapter.ClearBeforeFill = true;
            // 
            // dtBeginDateCarRateTableAdapter
            // 
            this.dtBeginDateCarRateTableAdapter.ClearBeforeFill = true;
            // 
            // EditCarRate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(390, 182);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtOutRateSum);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtInRateSum);
            this.Controls.Add(this.cboCarRent);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cboCustomer);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtpBeginDateCarRent);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnConfirm);
            this.Name = "EditCarRate";
            this.Text = "Редактирование ставки";
            this.Load += new System.EventHandler(this.EditCarRate_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tblContragentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rentDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblCarRentBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpBeginDateCarRent;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboCustomer;
        private System.Windows.Forms.ComboBox cboCarRent;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtInRateSum;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtOutRateSum;
        private RentDataSet rentDataSet;
        private System.Windows.Forms.BindingSource tblContragentBindingSource;
        private RentDataSetTableAdapters.tbl_ContragentTableAdapter tbl_ContragentTableAdapter;
        private System.Windows.Forms.BindingSource tblCarRentBindingSource;
        private RentDataSetTableAdapters.tbl_CarRentTableAdapter tbl_CarRentTableAdapter;
        private RentDataSetTableAdapters.dtBeginDateCarRateTableAdapter dtBeginDateCarRateTableAdapter;
    }
}