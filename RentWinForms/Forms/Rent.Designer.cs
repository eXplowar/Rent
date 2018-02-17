//using System;
//using System.Windows.Forms;
namespace RentWinForms
{
    partial class Rent
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
                this.tbl_CarRentDataGridView.DataSource = null; // Очищаю источник данных таблицы перед закрытием или высвобождения неуправляемых ресурсов
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Rent));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tbl_CarRentBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.tbl_CarRentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rentDataSet = new RentWinForms.RentDataSet();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.toolStripEditBtn = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.tbl_CarRentBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.tbl_CarRentDataGridView = new System.Windows.Forms.DataGridView();
            this.carRentIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.carNumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.carTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.tblCarriageTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lessorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.tblContragentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sellerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.beginDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.resaleDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.editDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firmIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabCtrlTabs = new System.Windows.Forms.TabControl();
            this.tabPgRent = new System.Windows.Forms.TabPage();
            this.tabPgRentDay = new System.Windows.Forms.TabPage();
            this.dgvCarRateCalc = new System.Windows.Forms.DataGridView();
            this.dtCarRateCalcBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabPgTotal = new System.Windows.Forms.TabPage();
            this.pbWait = new System.Windows.Forms.PictureBox();
            this.dtCarRentDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn17 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtCarRentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dateTimePickerFrom = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerTo = new System.Windows.Forms.DateTimePicker();
            this.lblFrom = new System.Windows.Forms.Label();
            this.lblTo = new System.Windows.Forms.Label();
            this.chkBoxBeginYear = new System.Windows.Forms.CheckBox();
            this.btnCarRentRate = new System.Windows.Forms.Button();
            this.toolTipBtnCarRentRate = new System.Windows.Forms.ToolTip(this.components);
            this.btnReCalc = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.tbl_CarRentTableAdapter = new RentWinForms.RentDataSetTableAdapters.tbl_CarRentTableAdapter();
            this.tableAdapterManager = new RentWinForms.RentDataSetTableAdapters.TableAdapterManager();
            this.tbl_CarriageTypeTableAdapter = new RentWinForms.RentDataSetTableAdapters.tbl_CarriageTypeTableAdapter();
            this.tbl_ContragentTableAdapter = new RentWinForms.RentDataSetTableAdapters.tbl_ContragentTableAdapter();
            this.dtCarRentTableAdapter = new RentWinForms.RentDataSetTableAdapters.dtCarRentTableAdapter();
            this.cboCarNum = new System.Windows.Forms.ComboBox();
            this.dtCarNumBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cboCarType = new System.Windows.Forms.ComboBox();
            this.dtCarTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cboLessor = new System.Windows.Forms.ComboBox();
            this.dtLessorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cboCustomer = new System.Windows.Forms.ComboBox();
            this.dtCustomerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lblCarNum = new System.Windows.Forms.Label();
            this.lblCarType = new System.Windows.Forms.Label();
            this.lblLessor = new System.Windows.Forms.Label();
            this.lblCustomer = new System.Windows.Forms.Label();
            this.dtCarNumTableAdapter = new RentWinForms.RentDataSetTableAdapters.dtCarNumTableAdapter();
            this.dtCarTypeTableAdapter = new RentWinForms.RentDataSetTableAdapters.dtCarTypeTableAdapter();
            this.dtCustomerTableAdapter = new RentWinForms.RentDataSetTableAdapters.dtCustomerTableAdapter();
            this.dtLessorTableAdapter = new RentWinForms.RentDataSetTableAdapters.dtLessorTableAdapter();
            this.dtCarRateCalcTableAdapter = new RentWinForms.RentDataSetTableAdapters.dtCarRateCalcTableAdapter();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BeginDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EndDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InRateSum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OutRateSum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CalcDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CarRent_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.carRentIDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.carNumDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.calcDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inRateSumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.outRateSumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.carTypeDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lessorDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.beginDateDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endDateDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_CarRentBindingNavigator)).BeginInit();
            this.tbl_CarRentBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_CarRentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rentDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_CarRentDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblCarriageTypeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblContragentBindingSource)).BeginInit();
            this.tabCtrlTabs.SuspendLayout();
            this.tabPgRent.SuspendLayout();
            this.tabPgRentDay.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCarRateCalc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtCarRateCalcBindingSource)).BeginInit();
            this.tabPgTotal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbWait)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtCarRentDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtCarRentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtCarNumBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtCarTypeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtLessorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtCustomerBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tbl_CarRentBindingNavigator
            // 
            this.tbl_CarRentBindingNavigator.AddNewItem = null;
            this.tbl_CarRentBindingNavigator.AutoSize = false;
            this.tbl_CarRentBindingNavigator.BindingSource = this.tbl_CarRentBindingSource;
            this.tbl_CarRentBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.tbl_CarRentBindingNavigator.DeleteItem = null;
            this.tbl_CarRentBindingNavigator.Dock = System.Windows.Forms.DockStyle.None;
            this.tbl_CarRentBindingNavigator.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.tbl_CarRentBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.toolStripEditBtn,
            this.bindingNavigatorDeleteItem,
            this.tbl_CarRentBindingNavigatorSaveItem});
            this.tbl_CarRentBindingNavigator.Location = new System.Drawing.Point(3, 408);
            this.tbl_CarRentBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.tbl_CarRentBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.tbl_CarRentBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.tbl_CarRentBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.tbl_CarRentBindingNavigator.Name = "tbl_CarRentBindingNavigator";
            this.tbl_CarRentBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.tbl_CarRentBindingNavigator.Size = new System.Drawing.Size(1253, 25);
            this.tbl_CarRentBindingNavigator.TabIndex = 0;
            this.tbl_CarRentBindingNavigator.Text = "bindingNavigator1";
            // 
            // tbl_CarRentBindingSource
            // 
            this.tbl_CarRentBindingSource.DataMember = "tbl_CarRent";
            this.tbl_CarRentBindingSource.DataSource = this.rentDataSet;
            // 
            // rentDataSet
            // 
            this.rentDataSet.DataSetName = "RentDataSet";
            this.rentDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(43, 22);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            this.bindingNavigatorAddNewItem.Click += new System.EventHandler(this.bindingNavigatorAddNewItem_Click);
            // 
            // toolStripEditBtn
            // 
            this.toolStripEditBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripEditBtn.Image = global::RentWinForms.Properties.Resources._1328517209_edit_16x16;
            this.toolStripEditBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripEditBtn.Name = "toolStripEditBtn";
            this.toolStripEditBtn.Size = new System.Drawing.Size(23, 22);
            this.toolStripEditBtn.Text = "toolStripEditBtn";
            this.toolStripEditBtn.Click += new System.EventHandler(this.toolStripEditBtn_Click);
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            this.bindingNavigatorDeleteItem.Click += new System.EventHandler(this.bindingNavigatorDeleteItem_Click);
            // 
            // tbl_CarRentBindingNavigatorSaveItem
            // 
            this.tbl_CarRentBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbl_CarRentBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("tbl_CarRentBindingNavigatorSaveItem.Image")));
            this.tbl_CarRentBindingNavigatorSaveItem.Name = "tbl_CarRentBindingNavigatorSaveItem";
            this.tbl_CarRentBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.tbl_CarRentBindingNavigatorSaveItem.Text = "Save Data";
            this.tbl_CarRentBindingNavigatorSaveItem.Click += new System.EventHandler(this.tbl_CarRentBindingNavigatorSaveItem_Click);
            // 
            // tbl_CarRentDataGridView
            // 
            this.tbl_CarRentDataGridView.AllowUserToAddRows = false;
            this.tbl_CarRentDataGridView.AllowUserToDeleteRows = false;
            this.tbl_CarRentDataGridView.AutoGenerateColumns = false;
            this.tbl_CarRentDataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.tbl_CarRentDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tbl_CarRentDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.carRentIDDataGridViewTextBoxColumn,
            this.carNumDataGridViewTextBoxColumn,
            this.carTypeDataGridViewTextBoxColumn,
            this.lessorDataGridViewTextBoxColumn,
            this.sellerDataGridViewTextBoxColumn,
            this.beginDateDataGridViewTextBoxColumn,
            this.endDateDataGridViewTextBoxColumn,
            this.customerDataGridViewTextBoxColumn,
            this.resaleDataGridViewCheckBoxColumn,
            this.editDateDataGridViewTextBoxColumn,
            this.firmIDDataGridViewTextBoxColumn});
            this.tbl_CarRentDataGridView.DataSource = this.tbl_CarRentBindingSource;
            this.tbl_CarRentDataGridView.Location = new System.Drawing.Point(3, 3);
            this.tbl_CarRentDataGridView.Name = "tbl_CarRentDataGridView";
            this.tbl_CarRentDataGridView.ReadOnly = true;
            this.tbl_CarRentDataGridView.RowHeadersWidth = 24;
            this.tbl_CarRentDataGridView.RowTemplate.Height = 20;
            this.tbl_CarRentDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tbl_CarRentDataGridView.Size = new System.Drawing.Size(1200, 402);
            this.tbl_CarRentDataGridView.TabIndex = 1;
            this.tbl_CarRentDataGridView.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.tbl_CarRentDataGridView_CellEndEdit);
            this.tbl_CarRentDataGridView.RowValidating += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.tbl_CarRentDataGridView_RowValidating);
            this.tbl_CarRentDataGridView.DoubleClick += new System.EventHandler(this.tbl_CarRentDataGridView_DoubleClick);
            // 
            // carRentIDDataGridViewTextBoxColumn
            // 
            this.carRentIDDataGridViewTextBoxColumn.DataPropertyName = "CarRent_ID";
            this.carRentIDDataGridViewTextBoxColumn.HeaderText = "CarRent_ID";
            this.carRentIDDataGridViewTextBoxColumn.Name = "carRentIDDataGridViewTextBoxColumn";
            this.carRentIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.carRentIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // carNumDataGridViewTextBoxColumn
            // 
            this.carNumDataGridViewTextBoxColumn.DataPropertyName = "CarNum";
            this.carNumDataGridViewTextBoxColumn.HeaderText = "№ вагона";
            this.carNumDataGridViewTextBoxColumn.Name = "carNumDataGridViewTextBoxColumn";
            this.carNumDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // carTypeDataGridViewTextBoxColumn
            // 
            this.carTypeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.carTypeDataGridViewTextBoxColumn.DataPropertyName = "CarType";
            this.carTypeDataGridViewTextBoxColumn.DataSource = this.tblCarriageTypeBindingSource;
            this.carTypeDataGridViewTextBoxColumn.DisplayMember = "CarriageType";
            this.carTypeDataGridViewTextBoxColumn.DisplayStyleForCurrentCellOnly = true;
            this.carTypeDataGridViewTextBoxColumn.HeaderText = "Тип вагона";
            this.carTypeDataGridViewTextBoxColumn.Name = "carTypeDataGridViewTextBoxColumn";
            this.carTypeDataGridViewTextBoxColumn.ReadOnly = true;
            this.carTypeDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.carTypeDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.carTypeDataGridViewTextBoxColumn.ValueMember = "CarriageType_ID";
            this.carTypeDataGridViewTextBoxColumn.Width = 82;
            // 
            // tblCarriageTypeBindingSource
            // 
            this.tblCarriageTypeBindingSource.DataMember = "tbl_CarriageType";
            this.tblCarriageTypeBindingSource.DataSource = this.rentDataSet;
            // 
            // lessorDataGridViewTextBoxColumn
            // 
            this.lessorDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.lessorDataGridViewTextBoxColumn.DataPropertyName = "Lessor";
            this.lessorDataGridViewTextBoxColumn.DataSource = this.tblContragentBindingSource;
            this.lessorDataGridViewTextBoxColumn.DisplayMember = "FullName";
            this.lessorDataGridViewTextBoxColumn.DisplayStyleForCurrentCellOnly = true;
            this.lessorDataGridViewTextBoxColumn.HeaderText = "Арендодатель";
            this.lessorDataGridViewTextBoxColumn.Name = "lessorDataGridViewTextBoxColumn";
            this.lessorDataGridViewTextBoxColumn.ReadOnly = true;
            this.lessorDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.lessorDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.lessorDataGridViewTextBoxColumn.ValueMember = "Contragent_ID";
            this.lessorDataGridViewTextBoxColumn.Width = 104;
            // 
            // tblContragentBindingSource
            // 
            this.tblContragentBindingSource.DataMember = "tbl_Contragent";
            this.tblContragentBindingSource.DataSource = this.rentDataSet;
            // 
            // sellerDataGridViewTextBoxColumn
            // 
            this.sellerDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.sellerDataGridViewTextBoxColumn.DataPropertyName = "Seller";
            this.sellerDataGridViewTextBoxColumn.DataSource = this.tblContragentBindingSource;
            this.sellerDataGridViewTextBoxColumn.DisplayMember = "FullName";
            this.sellerDataGridViewTextBoxColumn.DisplayStyleForCurrentCellOnly = true;
            this.sellerDataGridViewTextBoxColumn.HeaderText = "Продавец";
            this.sellerDataGridViewTextBoxColumn.Name = "sellerDataGridViewTextBoxColumn";
            this.sellerDataGridViewTextBoxColumn.ReadOnly = true;
            this.sellerDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.sellerDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.sellerDataGridViewTextBoxColumn.ValueMember = "Contragent_ID";
            this.sellerDataGridViewTextBoxColumn.Width = 82;
            // 
            // beginDateDataGridViewTextBoxColumn
            // 
            this.beginDateDataGridViewTextBoxColumn.DataPropertyName = "BeginDate";
            this.beginDateDataGridViewTextBoxColumn.HeaderText = "Начало аренды";
            this.beginDateDataGridViewTextBoxColumn.Name = "beginDateDataGridViewTextBoxColumn";
            this.beginDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // endDateDataGridViewTextBoxColumn
            // 
            this.endDateDataGridViewTextBoxColumn.DataPropertyName = "EndDate";
            this.endDateDataGridViewTextBoxColumn.HeaderText = "Конец аренды";
            this.endDateDataGridViewTextBoxColumn.Name = "endDateDataGridViewTextBoxColumn";
            this.endDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // customerDataGridViewTextBoxColumn
            // 
            this.customerDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.customerDataGridViewTextBoxColumn.DataPropertyName = "Customer";
            this.customerDataGridViewTextBoxColumn.DataSource = this.tblContragentBindingSource;
            this.customerDataGridViewTextBoxColumn.DisplayMember = "FullName";
            this.customerDataGridViewTextBoxColumn.DisplayStyleForCurrentCellOnly = true;
            this.customerDataGridViewTextBoxColumn.HeaderText = "Клиент";
            this.customerDataGridViewTextBoxColumn.Name = "customerDataGridViewTextBoxColumn";
            this.customerDataGridViewTextBoxColumn.ReadOnly = true;
            this.customerDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.customerDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.customerDataGridViewTextBoxColumn.ValueMember = "Contragent_ID";
            this.customerDataGridViewTextBoxColumn.Width = 68;
            // 
            // resaleDataGridViewCheckBoxColumn
            // 
            this.resaleDataGridViewCheckBoxColumn.DataPropertyName = "Resale";
            this.resaleDataGridViewCheckBoxColumn.HeaderText = "Перепродажа";
            this.resaleDataGridViewCheckBoxColumn.Name = "resaleDataGridViewCheckBoxColumn";
            this.resaleDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // editDateDataGridViewTextBoxColumn
            // 
            this.editDateDataGridViewTextBoxColumn.DataPropertyName = "EditDate";
            this.editDateDataGridViewTextBoxColumn.HeaderText = "EditDate";
            this.editDateDataGridViewTextBoxColumn.Name = "editDateDataGridViewTextBoxColumn";
            this.editDateDataGridViewTextBoxColumn.ReadOnly = true;
            this.editDateDataGridViewTextBoxColumn.Visible = false;
            // 
            // firmIDDataGridViewTextBoxColumn
            // 
            this.firmIDDataGridViewTextBoxColumn.DataPropertyName = "Firm_ID";
            this.firmIDDataGridViewTextBoxColumn.HeaderText = "Firm_ID";
            this.firmIDDataGridViewTextBoxColumn.Name = "firmIDDataGridViewTextBoxColumn";
            this.firmIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.firmIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // tabCtrlTabs
            // 
            this.tabCtrlTabs.Controls.Add(this.tabPgRent);
            this.tabCtrlTabs.Controls.Add(this.tabPgRentDay);
            this.tabCtrlTabs.Controls.Add(this.tabPgTotal);
            this.tabCtrlTabs.Location = new System.Drawing.Point(0, 123);
            this.tabCtrlTabs.Name = "tabCtrlTabs";
            this.tabCtrlTabs.SelectedIndex = 0;
            this.tabCtrlTabs.Size = new System.Drawing.Size(1214, 462);
            this.tabCtrlTabs.TabIndex = 2;
            this.tabCtrlTabs.SelectedIndexChanged += new System.EventHandler(this.tabCtrlTabs_SelectedIndexChanged);
            // 
            // tabPgRent
            // 
            this.tabPgRent.Controls.Add(this.tbl_CarRentDataGridView);
            this.tabPgRent.Controls.Add(this.tbl_CarRentBindingNavigator);
            this.tabPgRent.Location = new System.Drawing.Point(4, 22);
            this.tabPgRent.Name = "tabPgRent";
            this.tabPgRent.Padding = new System.Windows.Forms.Padding(3);
            this.tabPgRent.Size = new System.Drawing.Size(1206, 436);
            this.tabPgRent.TabIndex = 0;
            this.tabPgRent.Text = "Арендованные вагоны";
            this.tabPgRent.UseVisualStyleBackColor = true;
            // 
            // tabPgRentDay
            // 
            this.tabPgRentDay.Controls.Add(this.dgvCarRateCalc);
            this.tabPgRentDay.Location = new System.Drawing.Point(4, 22);
            this.tabPgRentDay.Name = "tabPgRentDay";
            this.tabPgRentDay.Padding = new System.Windows.Forms.Padding(3);
            this.tabPgRentDay.Size = new System.Drawing.Size(1206, 436);
            this.tabPgRentDay.TabIndex = 1;
            this.tabPgRentDay.Text = "Аренда за каждый день";
            this.tabPgRentDay.UseVisualStyleBackColor = true;
            // 
            // dgvCarRateCalc
            // 
            this.dgvCarRateCalc.AllowUserToAddRows = false;
            this.dgvCarRateCalc.AllowUserToDeleteRows = false;
            this.dgvCarRateCalc.AutoGenerateColumns = false;
            this.dgvCarRateCalc.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvCarRateCalc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCarRateCalc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.carRentIDDataGridViewTextBoxColumn1,
            this.carNumDataGridViewTextBoxColumn1,
            this.calcDateDataGridViewTextBoxColumn,
            this.inRateSumDataGridViewTextBoxColumn,
            this.outRateSumDataGridViewTextBoxColumn,
            this.carTypeDataGridViewTextBoxColumn1,
            this.lessorDataGridViewTextBoxColumn1,
            this.beginDateDataGridViewTextBoxColumn1,
            this.endDateDataGridViewTextBoxColumn1,
            this.customerDataGridViewTextBoxColumn1});
            this.dgvCarRateCalc.DataSource = this.dtCarRateCalcBindingSource;
            this.dgvCarRateCalc.Location = new System.Drawing.Point(3, 3);
            this.dgvCarRateCalc.Name = "dgvCarRateCalc";
            this.dgvCarRateCalc.ReadOnly = true;
            this.dgvCarRateCalc.RowHeadersWidth = 24;
            this.dgvCarRateCalc.Size = new System.Drawing.Size(1200, 402);
            this.dgvCarRateCalc.TabIndex = 0;
            // 
            // dtCarRateCalcBindingSource
            // 
            this.dtCarRateCalcBindingSource.DataMember = "dtCarRateCalc";
            this.dtCarRateCalcBindingSource.DataSource = this.rentDataSet;
            // 
            // tabPgTotal
            // 
            this.tabPgTotal.Controls.Add(this.pbWait);
            this.tabPgTotal.Controls.Add(this.dtCarRentDataGridView);
            this.tabPgTotal.Location = new System.Drawing.Point(4, 22);
            this.tabPgTotal.Name = "tabPgTotal";
            this.tabPgTotal.Size = new System.Drawing.Size(1206, 436);
            this.tabPgTotal.TabIndex = 2;
            this.tabPgTotal.Text = "Итоговые данные";
            this.tabPgTotal.UseVisualStyleBackColor = true;
            // 
            // pbWait
            // 
            this.pbWait.Image = global::RentWinForms.Properties.Resources.wait32;
            this.pbWait.Location = new System.Drawing.Point(587, 190);
            this.pbWait.Name = "pbWait";
            this.pbWait.Size = new System.Drawing.Size(32, 32);
            this.pbWait.TabIndex = 2;
            this.pbWait.TabStop = false;
            this.pbWait.Visible = false;
            // 
            // dtCarRentDataGridView
            // 
            this.dtCarRentDataGridView.AllowUserToAddRows = false;
            this.dtCarRentDataGridView.AllowUserToDeleteRows = false;
            this.dtCarRentDataGridView.AutoGenerateColumns = false;
            this.dtCarRentDataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dtCarRentDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtCarRentDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn14,
            this.dataGridViewTextBoxColumn15,
            this.dataGridViewTextBoxColumn16,
            this.dataGridViewTextBoxColumn17});
            this.dtCarRentDataGridView.DataSource = this.dtCarRentBindingSource;
            this.dtCarRentDataGridView.Location = new System.Drawing.Point(3, 3);
            this.dtCarRentDataGridView.Name = "dtCarRentDataGridView";
            this.dtCarRentDataGridView.RowHeadersWidth = 24;
            this.dtCarRentDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtCarRentDataGridView.Size = new System.Drawing.Size(1200, 430);
            this.dtCarRentDataGridView.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "CarRent_ID";
            this.dataGridViewTextBoxColumn1.HeaderText = "CarRent_ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "CarNum";
            this.dataGridViewTextBoxColumn2.HeaderText = "№ вагона";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 81;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dataGridViewTextBoxColumn3.DataPropertyName = "CarType";
            this.dataGridViewTextBoxColumn3.HeaderText = "Тип вагона";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 89;
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dataGridViewTextBoxColumn14.DataPropertyName = "Customer";
            this.dataGridViewTextBoxColumn14.HeaderText = "Клиент";
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            this.dataGridViewTextBoxColumn14.Width = 68;
            // 
            // dataGridViewTextBoxColumn15
            // 
            this.dataGridViewTextBoxColumn15.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dataGridViewTextBoxColumn15.DataPropertyName = "SumInRateSum";
            dataGridViewCellStyle3.Format = "N2";
            dataGridViewCellStyle3.NullValue = null;
            this.dataGridViewTextBoxColumn15.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewTextBoxColumn15.HeaderText = "Вх. ставка";
            this.dataGridViewTextBoxColumn15.Name = "dataGridViewTextBoxColumn15";
            this.dataGridViewTextBoxColumn15.ReadOnly = true;
            this.dataGridViewTextBoxColumn15.Width = 85;
            // 
            // dataGridViewTextBoxColumn16
            // 
            this.dataGridViewTextBoxColumn16.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dataGridViewTextBoxColumn16.DataPropertyName = "SumOutRateSum";
            dataGridViewCellStyle4.Format = "N2";
            dataGridViewCellStyle4.NullValue = null;
            this.dataGridViewTextBoxColumn16.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewTextBoxColumn16.HeaderText = "Исх. ставка";
            this.dataGridViewTextBoxColumn16.Name = "dataGridViewTextBoxColumn16";
            this.dataGridViewTextBoxColumn16.ReadOnly = true;
            this.dataGridViewTextBoxColumn16.Width = 92;
            // 
            // dataGridViewTextBoxColumn17
            // 
            this.dataGridViewTextBoxColumn17.DataPropertyName = "CountCarRentID";
            this.dataGridViewTextBoxColumn17.HeaderText = "Дней";
            this.dataGridViewTextBoxColumn17.Name = "dataGridViewTextBoxColumn17";
            this.dataGridViewTextBoxColumn17.ReadOnly = true;
            // 
            // dtCarRentBindingSource
            // 
            this.dtCarRentBindingSource.DataMember = "dtCarRent";
            this.dtCarRentBindingSource.DataSource = this.rentDataSet;
            // 
            // dateTimePickerFrom
            // 
            this.dateTimePickerFrom.Location = new System.Drawing.Point(88, 12);
            this.dateTimePickerFrom.Name = "dateTimePickerFrom";
            this.dateTimePickerFrom.Size = new System.Drawing.Size(140, 20);
            this.dateTimePickerFrom.TabIndex = 3;
            this.dateTimePickerFrom.Value = new System.DateTime(2011, 1, 1, 0, 0, 0, 0);
            // 
            // dateTimePickerTo
            // 
            this.dateTimePickerTo.Location = new System.Drawing.Point(88, 38);
            this.dateTimePickerTo.Name = "dateTimePickerTo";
            this.dateTimePickerTo.Size = new System.Drawing.Size(140, 20);
            this.dateTimePickerTo.TabIndex = 4;
            // 
            // lblFrom
            // 
            this.lblFrom.AutoSize = true;
            this.lblFrom.Location = new System.Drawing.Point(14, 12);
            this.lblFrom.Name = "lblFrom";
            this.lblFrom.Size = new System.Drawing.Size(68, 13);
            this.lblFrom.TabIndex = 5;
            this.lblFrom.Text = "За период с";
            // 
            // lblTo
            // 
            this.lblTo.AutoSize = true;
            this.lblTo.Location = new System.Drawing.Point(61, 38);
            this.lblTo.Name = "lblTo";
            this.lblTo.Size = new System.Drawing.Size(21, 13);
            this.lblTo.TabIndex = 6;
            this.lblTo.Text = "По";
            // 
            // chkBoxBeginYear
            // 
            this.chkBoxBeginYear.AutoSize = true;
            this.chkBoxBeginYear.Location = new System.Drawing.Point(88, 64);
            this.chkBoxBeginYear.Name = "chkBoxBeginYear";
            this.chkBoxBeginYear.Size = new System.Drawing.Size(97, 17);
            this.chkBoxBeginYear.TabIndex = 7;
            this.chkBoxBeginYear.Text = "С начала года";
            this.chkBoxBeginYear.UseVisualStyleBackColor = true;
            // 
            // btnCarRentRate
            // 
            this.btnCarRentRate.AutoSize = true;
            this.btnCarRentRate.BackColor = System.Drawing.SystemColors.Control;
            this.btnCarRentRate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCarRentRate.Image = global::RentWinForms.Properties.Resources.money_calculator;
            this.btnCarRentRate.Location = new System.Drawing.Point(626, 9);
            this.btnCarRentRate.Name = "btnCarRentRate";
            this.btnCarRentRate.Size = new System.Drawing.Size(38, 38);
            this.btnCarRentRate.TabIndex = 8;
            this.toolTipBtnCarRentRate.SetToolTip(this.btnCarRentRate, "Арендные ставки");
            this.btnCarRentRate.UseVisualStyleBackColor = false;
            this.btnCarRentRate.Click += new System.EventHandler(this.btnCarRentRate_Click);
            // 
            // btnReCalc
            // 
            this.btnReCalc.AutoSize = true;
            this.btnReCalc.Image = global::RentWinForms.Properties.Resources.gtk_refresh;
            this.btnReCalc.Location = new System.Drawing.Point(582, 9);
            this.btnReCalc.Name = "btnReCalc";
            this.btnReCalc.Size = new System.Drawing.Size(38, 38);
            this.btnReCalc.TabIndex = 9;
            this.btnReCalc.UseVisualStyleBackColor = true;
            this.btnReCalc.Click += new System.EventHandler(this.btnReCalc_Click);
            // 
            // button1
            // 
            this.button1.Enabled = false;
            this.button1.Location = new System.Drawing.Point(1132, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tbl_CarRentTableAdapter
            // 
            this.tbl_CarRentTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.dtBeginDateCarRateTableAdapter = null;
            this.tableAdapterManager.tbl_allTableAdapter = null;
            this.tableAdapterManager.tbl_BeginDateCarRateTableAdapter = null;
            this.tableAdapterManager.tbl_CarRateCalcTableAdapter = null;
            this.tableAdapterManager.tbl_CarRentTableAdapter = this.tbl_CarRentTableAdapter;
            this.tableAdapterManager.tbl_CarriageTypeTableAdapter = null;
            this.tableAdapterManager.tbl_CarTypeLessorRentRateTableAdapter = null;
            this.tableAdapterManager.tbl_CarTypeRentRateTableAdapter = null;
            this.tableAdapterManager.tbl_ContragentTableAdapter = null;
            this.tableAdapterManager.tbl_FirmTableAdapter = null;
            this.tableAdapterManager.tbl_TestCalcTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = RentWinForms.RentDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // tbl_CarriageTypeTableAdapter
            // 
            this.tbl_CarriageTypeTableAdapter.ClearBeforeFill = true;
            // 
            // tbl_ContragentTableAdapter
            // 
            this.tbl_ContragentTableAdapter.ClearBeforeFill = true;
            // 
            // dtCarRentTableAdapter
            // 
            this.dtCarRentTableAdapter.ClearBeforeFill = true;
            // 
            // cboCarNum
            // 
            this.cboCarNum.DataSource = this.dtCarNumBindingSource;
            this.cboCarNum.DisplayMember = "CarNum";
            this.cboCarNum.FormattingEnabled = true;
            this.cboCarNum.Location = new System.Drawing.Point(319, 9);
            this.cboCarNum.Name = "cboCarNum";
            this.cboCarNum.Size = new System.Drawing.Size(257, 21);
            this.cboCarNum.TabIndex = 11;
            this.cboCarNum.ValueMember = "CarNum";
            // 
            // dtCarNumBindingSource
            // 
            this.dtCarNumBindingSource.DataMember = "dtCarNum";
            this.dtCarNumBindingSource.DataSource = this.rentDataSet;
            // 
            // cboCarType
            // 
            this.cboCarType.DataSource = this.dtCarTypeBindingSource;
            this.cboCarType.DisplayMember = "CarriageType";
            this.cboCarType.FormattingEnabled = true;
            this.cboCarType.Location = new System.Drawing.Point(319, 36);
            this.cboCarType.Name = "cboCarType";
            this.cboCarType.Size = new System.Drawing.Size(257, 21);
            this.cboCarType.TabIndex = 12;
            this.cboCarType.ValueMember = "CarriageType_ID";
            // 
            // dtCarTypeBindingSource
            // 
            this.dtCarTypeBindingSource.DataMember = "dtCarType";
            this.dtCarTypeBindingSource.DataSource = this.rentDataSet;
            // 
            // cboLessor
            // 
            this.cboLessor.DataSource = this.dtLessorBindingSource;
            this.cboLessor.DisplayMember = "FullName";
            this.cboLessor.FormattingEnabled = true;
            this.cboLessor.Location = new System.Drawing.Point(319, 63);
            this.cboLessor.Name = "cboLessor";
            this.cboLessor.Size = new System.Drawing.Size(257, 21);
            this.cboLessor.TabIndex = 13;
            this.cboLessor.ValueMember = "Contragent_ID";
            // 
            // dtLessorBindingSource
            // 
            this.dtLessorBindingSource.DataMember = "dtLessor";
            this.dtLessorBindingSource.DataSource = this.rentDataSet;
            // 
            // cboCustomer
            // 
            this.cboCustomer.DataSource = this.dtCustomerBindingSource;
            this.cboCustomer.DisplayMember = "FullName";
            this.cboCustomer.FormattingEnabled = true;
            this.cboCustomer.Location = new System.Drawing.Point(319, 90);
            this.cboCustomer.Name = "cboCustomer";
            this.cboCustomer.Size = new System.Drawing.Size(257, 21);
            this.cboCustomer.TabIndex = 14;
            this.cboCustomer.ValueMember = "Contragent_ID";
            // 
            // dtCustomerBindingSource
            // 
            this.dtCustomerBindingSource.DataMember = "dtCustomer";
            this.dtCustomerBindingSource.DataSource = this.rentDataSet;
            // 
            // lblCarNum
            // 
            this.lblCarNum.AutoSize = true;
            this.lblCarNum.Location = new System.Drawing.Point(234, 12);
            this.lblCarNum.Name = "lblCarNum";
            this.lblCarNum.Size = new System.Drawing.Size(56, 13);
            this.lblCarNum.TabIndex = 15;
            this.lblCarNum.Text = "№ вагона";
            // 
            // lblCarType
            // 
            this.lblCarType.AutoSize = true;
            this.lblCarType.Location = new System.Drawing.Point(234, 39);
            this.lblCarType.Name = "lblCarType";
            this.lblCarType.Size = new System.Drawing.Size(64, 13);
            this.lblCarType.TabIndex = 16;
            this.lblCarType.Text = "Тип вагона";
            // 
            // lblLessor
            // 
            this.lblLessor.AutoSize = true;
            this.lblLessor.Location = new System.Drawing.Point(234, 66);
            this.lblLessor.Name = "lblLessor";
            this.lblLessor.Size = new System.Drawing.Size(79, 13);
            this.lblLessor.TabIndex = 17;
            this.lblLessor.Text = "Арендодатель";
            // 
            // lblCustomer
            // 
            this.lblCustomer.AutoSize = true;
            this.lblCustomer.Location = new System.Drawing.Point(234, 93);
            this.lblCustomer.Name = "lblCustomer";
            this.lblCustomer.Size = new System.Drawing.Size(43, 13);
            this.lblCustomer.TabIndex = 18;
            this.lblCustomer.Text = "Клиент";
            // 
            // dtCarNumTableAdapter
            // 
            this.dtCarNumTableAdapter.ClearBeforeFill = true;
            // 
            // dtCarTypeTableAdapter
            // 
            this.dtCarTypeTableAdapter.ClearBeforeFill = true;
            // 
            // dtCustomerTableAdapter
            // 
            this.dtCustomerTableAdapter.ClearBeforeFill = true;
            // 
            // dtLessorTableAdapter
            // 
            this.dtLessorTableAdapter.ClearBeforeFill = true;
            // 
            // dtCarRateCalcTableAdapter
            // 
            this.dtCarRateCalcTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "CarRent_ID";
            this.dataGridViewTextBoxColumn4.HeaderText = "CarRent_ID";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "CarNum";
            this.dataGridViewTextBoxColumn5.HeaderText = "CarNum";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // BeginDate
            // 
            this.BeginDate.DataPropertyName = "BeginDate";
            this.BeginDate.HeaderText = "Начало аренды";
            this.BeginDate.Name = "BeginDate";
            // 
            // EndDate
            // 
            this.EndDate.DataPropertyName = "EndDate";
            this.EndDate.HeaderText = "Конец аренды";
            this.EndDate.Name = "EndDate";
            // 
            // InRateSum
            // 
            this.InRateSum.DataPropertyName = "InRateSum";
            this.InRateSum.HeaderText = "Вх. ставка";
            this.InRateSum.Name = "InRateSum";
            // 
            // OutRateSum
            // 
            this.OutRateSum.DataPropertyName = "OutRateSum";
            this.OutRateSum.HeaderText = "Исх. ставка";
            this.OutRateSum.Name = "OutRateSum";
            // 
            // CalcDate
            // 
            this.CalcDate.DataPropertyName = "CalcDate";
            this.CalcDate.HeaderText = "Дата";
            this.CalcDate.Name = "CalcDate";
            // 
            // CarRent_ID
            // 
            this.CarRent_ID.DataPropertyName = "CarRent_ID";
            this.CarRent_ID.HeaderText = "CarRent_ID";
            this.CarRent_ID.Name = "CarRent_ID";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "CarRent_ID";
            this.dataGridViewTextBoxColumn6.HeaderText = "CarRent_ID";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Visible = false;
            // 
            // carRentIDDataGridViewTextBoxColumn1
            // 
            this.carRentIDDataGridViewTextBoxColumn1.DataPropertyName = "CarRent_ID";
            this.carRentIDDataGridViewTextBoxColumn1.HeaderText = "CarRent_ID";
            this.carRentIDDataGridViewTextBoxColumn1.Name = "carRentIDDataGridViewTextBoxColumn1";
            this.carRentIDDataGridViewTextBoxColumn1.ReadOnly = true;
            this.carRentIDDataGridViewTextBoxColumn1.Visible = false;
            // 
            // carNumDataGridViewTextBoxColumn1
            // 
            this.carNumDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.carNumDataGridViewTextBoxColumn1.DataPropertyName = "CarNum";
            this.carNumDataGridViewTextBoxColumn1.HeaderText = "№ вагона";
            this.carNumDataGridViewTextBoxColumn1.Name = "carNumDataGridViewTextBoxColumn1";
            this.carNumDataGridViewTextBoxColumn1.ReadOnly = true;
            this.carNumDataGridViewTextBoxColumn1.Width = 81;
            // 
            // calcDateDataGridViewTextBoxColumn
            // 
            this.calcDateDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.calcDateDataGridViewTextBoxColumn.DataPropertyName = "CalcDate";
            this.calcDateDataGridViewTextBoxColumn.HeaderText = "Дата";
            this.calcDateDataGridViewTextBoxColumn.Name = "calcDateDataGridViewTextBoxColumn";
            this.calcDateDataGridViewTextBoxColumn.ReadOnly = true;
            this.calcDateDataGridViewTextBoxColumn.Width = 58;
            // 
            // inRateSumDataGridViewTextBoxColumn
            // 
            this.inRateSumDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.inRateSumDataGridViewTextBoxColumn.DataPropertyName = "InRateSum";
            dataGridViewCellStyle1.Format = "N2";
            dataGridViewCellStyle1.NullValue = null;
            this.inRateSumDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle1;
            this.inRateSumDataGridViewTextBoxColumn.HeaderText = "Вх. ставка";
            this.inRateSumDataGridViewTextBoxColumn.MinimumWidth = 85;
            this.inRateSumDataGridViewTextBoxColumn.Name = "inRateSumDataGridViewTextBoxColumn";
            this.inRateSumDataGridViewTextBoxColumn.ReadOnly = true;
            this.inRateSumDataGridViewTextBoxColumn.Width = 85;
            // 
            // outRateSumDataGridViewTextBoxColumn
            // 
            this.outRateSumDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.outRateSumDataGridViewTextBoxColumn.DataPropertyName = "OutRateSum";
            dataGridViewCellStyle2.Format = "N2";
            dataGridViewCellStyle2.NullValue = null;
            this.outRateSumDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.outRateSumDataGridViewTextBoxColumn.HeaderText = "Исх. ставка";
            this.outRateSumDataGridViewTextBoxColumn.MinimumWidth = 92;
            this.outRateSumDataGridViewTextBoxColumn.Name = "outRateSumDataGridViewTextBoxColumn";
            this.outRateSumDataGridViewTextBoxColumn.ReadOnly = true;
            this.outRateSumDataGridViewTextBoxColumn.Width = 92;
            // 
            // carTypeDataGridViewTextBoxColumn1
            // 
            this.carTypeDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.carTypeDataGridViewTextBoxColumn1.DataPropertyName = "CarType";
            this.carTypeDataGridViewTextBoxColumn1.HeaderText = "Тип вагона";
            this.carTypeDataGridViewTextBoxColumn1.MinimumWidth = 120;
            this.carTypeDataGridViewTextBoxColumn1.Name = "carTypeDataGridViewTextBoxColumn1";
            this.carTypeDataGridViewTextBoxColumn1.ReadOnly = true;
            this.carTypeDataGridViewTextBoxColumn1.Width = 120;
            // 
            // lessorDataGridViewTextBoxColumn1
            // 
            this.lessorDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.lessorDataGridViewTextBoxColumn1.DataPropertyName = "Lessor";
            this.lessorDataGridViewTextBoxColumn1.HeaderText = "Арендодатель";
            this.lessorDataGridViewTextBoxColumn1.Name = "lessorDataGridViewTextBoxColumn1";
            this.lessorDataGridViewTextBoxColumn1.ReadOnly = true;
            this.lessorDataGridViewTextBoxColumn1.Width = 104;
            // 
            // beginDateDataGridViewTextBoxColumn1
            // 
            this.beginDateDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.beginDateDataGridViewTextBoxColumn1.DataPropertyName = "BeginDate";
            this.beginDateDataGridViewTextBoxColumn1.HeaderText = "Начало аренды";
            this.beginDateDataGridViewTextBoxColumn1.Name = "beginDateDataGridViewTextBoxColumn1";
            this.beginDateDataGridViewTextBoxColumn1.ReadOnly = true;
            this.beginDateDataGridViewTextBoxColumn1.Width = 101;
            // 
            // endDateDataGridViewTextBoxColumn1
            // 
            this.endDateDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.endDateDataGridViewTextBoxColumn1.DataPropertyName = "EndDate";
            this.endDateDataGridViewTextBoxColumn1.HeaderText = "Конец аренды";
            this.endDateDataGridViewTextBoxColumn1.Name = "endDateDataGridViewTextBoxColumn1";
            this.endDateDataGridViewTextBoxColumn1.ReadOnly = true;
            this.endDateDataGridViewTextBoxColumn1.Width = 96;
            // 
            // customerDataGridViewTextBoxColumn1
            // 
            this.customerDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.customerDataGridViewTextBoxColumn1.DataPropertyName = "Customer";
            this.customerDataGridViewTextBoxColumn1.HeaderText = "Клиент";
            this.customerDataGridViewTextBoxColumn1.Name = "customerDataGridViewTextBoxColumn1";
            this.customerDataGridViewTextBoxColumn1.ReadOnly = true;
            this.customerDataGridViewTextBoxColumn1.Width = 68;
            // 
            // Rent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1214, 585);
            this.Controls.Add(this.lblCustomer);
            this.Controls.Add(this.lblLessor);
            this.Controls.Add(this.lblCarType);
            this.Controls.Add(this.lblCarNum);
            this.Controls.Add(this.cboCustomer);
            this.Controls.Add(this.cboLessor);
            this.Controls.Add(this.cboCarType);
            this.Controls.Add(this.cboCarNum);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnReCalc);
            this.Controls.Add(this.btnCarRentRate);
            this.Controls.Add(this.chkBoxBeginYear);
            this.Controls.Add(this.lblTo);
            this.Controls.Add(this.lblFrom);
            this.Controls.Add(this.dateTimePickerTo);
            this.Controls.Add(this.dateTimePickerFrom);
            this.Controls.Add(this.tabCtrlTabs);
            this.Name = "Rent";
            this.Text = "Rent";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Rent_FormClosed);
            this.Load += new System.EventHandler(this.Rent_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tbl_CarRentBindingNavigator)).EndInit();
            this.tbl_CarRentBindingNavigator.ResumeLayout(false);
            this.tbl_CarRentBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_CarRentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rentDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_CarRentDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblCarriageTypeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblContragentBindingSource)).EndInit();
            this.tabCtrlTabs.ResumeLayout(false);
            this.tabPgRent.ResumeLayout(false);
            this.tabPgRentDay.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCarRateCalc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtCarRateCalcBindingSource)).EndInit();
            this.tabPgTotal.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbWait)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtCarRentDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtCarRentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtCarNumBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtCarTypeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtLessorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtCustomerBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        
        private RentDataSet rentDataSet;
        private System.Windows.Forms.BindingSource tbl_CarRentBindingSource;
        private RentDataSetTableAdapters.tbl_CarRentTableAdapter tbl_CarRentTableAdapter;
        private RentDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator tbl_CarRentBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton tbl_CarRentBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView tbl_CarRentDataGridView;
        private System.Windows.Forms.BindingSource tblCarriageTypeBindingSource;
        private RentDataSetTableAdapters.tbl_CarriageTypeTableAdapter tbl_CarriageTypeTableAdapter;
        private System.Windows.Forms.BindingSource tblContragentBindingSource;
        private RentDataSetTableAdapters.tbl_ContragentTableAdapter tbl_ContragentTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn carRentIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn carNumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn carTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn lessorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn sellerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn beginDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn endDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn customerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn resaleDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn editDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firmIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.TabControl tabCtrlTabs;
        private System.Windows.Forms.TabPage tabPgRent;
        private System.Windows.Forms.TabPage tabPgRentDay;
        private System.Windows.Forms.TabPage tabPgTotal;
        private System.Windows.Forms.DateTimePicker dateTimePickerFrom;
        private System.Windows.Forms.DateTimePicker dateTimePickerTo;
        private System.Windows.Forms.Label lblFrom;
        private System.Windows.Forms.Label lblTo;
        private System.Windows.Forms.CheckBox chkBoxBeginYear;
        private System.Windows.Forms.Button btnCarRentRate;
        private System.Windows.Forms.ToolTip toolTipBtnCarRentRate;
        private System.Windows.Forms.Button btnReCalc;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource dtCarRentBindingSource;
        private System.Windows.Forms.DataGridView dtCarRentDataGridView;
        private RentDataSetTableAdapters.dtCarRentTableAdapter dtCarRentTableAdapter;
        private System.Windows.Forms.ComboBox cboCarNum;
        private System.Windows.Forms.ComboBox cboCarType;
        private System.Windows.Forms.ComboBox cboLessor;
        private System.Windows.Forms.ComboBox cboCustomer;
        private System.Windows.Forms.Label lblCarNum;
        private System.Windows.Forms.Label lblCarType;
        private System.Windows.Forms.Label lblLessor;
        private System.Windows.Forms.Label lblCustomer;
        private System.Windows.Forms.BindingSource dtCarNumBindingSource;
        private System.Windows.Forms.BindingSource dtCarTypeBindingSource;
        private System.Windows.Forms.BindingSource dtCustomerBindingSource;
        private RentDataSetTableAdapters.dtCarNumTableAdapter dtCarNumTableAdapter;
        private RentDataSetTableAdapters.dtCarTypeTableAdapter dtCarTypeTableAdapter;
        private RentDataSetTableAdapters.dtCustomerTableAdapter dtCustomerTableAdapter;
        private System.Windows.Forms.BindingSource dtLessorBindingSource;
        private RentDataSetTableAdapters.dtLessorTableAdapter dtLessorTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn16;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn17;
        private System.Windows.Forms.PictureBox pbWait;
        private System.Windows.Forms.DataGridView dgvCarRateCalc;
        private System.Windows.Forms.BindingSource dtCarRateCalcBindingSource;
        private RentDataSetTableAdapters.dtCarRateCalcTableAdapter dtCarRateCalcTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn BeginDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn EndDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn InRateSum;
        private System.Windows.Forms.DataGridViewTextBoxColumn OutRateSum;
        private System.Windows.Forms.DataGridViewTextBoxColumn CalcDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn CarRent_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.ToolStripButton toolStripEditBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn carRentIDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn carNumDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn calcDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn inRateSumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn outRateSumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn carTypeDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn lessorDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn beginDateDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn endDateDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerDataGridViewTextBoxColumn1;
    }
}