namespace RentWinForms
{
    partial class CarRentRate
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
                this.tbl_BeginDateCarRateDataGridView.DataSource = null; // Очищаю источник данных таблицы перед закрытием или высвобождения неуправляемых ресурсов
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CarRentRate));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.cboCarType = new System.Windows.Forms.ComboBox();
            this.dtCarTypeRentRateBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rentDataSet = new RentWinForms.RentDataSet();
            this.lblCarType = new System.Windows.Forms.Label();
            this.lblLessor = new System.Windows.Forms.Label();
            this.cboLessor = new System.Windows.Forms.ComboBox();
            this.dtCarTypeLessorRentRateBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableAdapterManager = new RentWinForms.RentDataSetTableAdapters.TableAdapterManager();
            this.dtBeginDateCarRateTableAdapter = new RentWinForms.RentDataSetTableAdapters.dtBeginDateCarRateTableAdapter();
            this.tbl_CarRentTableAdapter = new RentWinForms.RentDataSetTableAdapters.tbl_CarRentTableAdapter();
            this.tbl_CarriageTypeTableAdapter = new RentWinForms.RentDataSetTableAdapters.tbl_CarriageTypeTableAdapter();
            this.tbl_ContragentTableAdapter = new RentWinForms.RentDataSetTableAdapters.tbl_ContragentTableAdapter();
            this.dtBeginDateCarRateBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.dtBeginDateCarRateBindingSource = new System.Windows.Forms.BindingSource(this.components);
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
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.dtBeginDateCarRateBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.tbl_BeginDateCarRateDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Customer = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.tblContragentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.CarRent_ID = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.tblCarRentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblCarriageTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dtCarTypeRentRateTableAdapter = new RentWinForms.RentDataSetTableAdapters.dtCarTypeRentRateTableAdapter();
            this.dtCarTypeLessorRentRateTableAdapter = new RentWinForms.RentDataSetTableAdapters.dtCarTypeLessorRentRateTableAdapter();
            this.btnCreateRate = new System.Windows.Forms.Button();
            this.toolStripEditBtn = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.dtCarTypeRentRateBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rentDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtCarTypeLessorRentRateBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtBeginDateCarRateBindingNavigator)).BeginInit();
            this.dtBeginDateCarRateBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtBeginDateCarRateBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_BeginDateCarRateDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblContragentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblCarRentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblCarriageTypeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // cboCarType
            // 
            this.cboCarType.DataSource = this.dtCarTypeRentRateBindingSource;
            this.cboCarType.DisplayMember = "CarriageType";
            this.cboCarType.FormattingEnabled = true;
            this.cboCarType.Location = new System.Drawing.Point(95, 7);
            this.cboCarType.Name = "cboCarType";
            this.cboCarType.Size = new System.Drawing.Size(182, 21);
            this.cboCarType.TabIndex = 0;
            this.cboCarType.ValueMember = "CarTypeRentRate_ID";
            // 
            // dtCarTypeRentRateBindingSource
            // 
            this.dtCarTypeRentRateBindingSource.DataMember = "dtCarTypeRentRate";
            this.dtCarTypeRentRateBindingSource.DataSource = this.rentDataSet;
            // 
            // rentDataSet
            // 
            this.rentDataSet.DataSetName = "RentDataSet";
            this.rentDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lblCarType
            // 
            this.lblCarType.AutoSize = true;
            this.lblCarType.Location = new System.Drawing.Point(25, 10);
            this.lblCarType.Name = "lblCarType";
            this.lblCarType.Size = new System.Drawing.Size(64, 13);
            this.lblCarType.TabIndex = 1;
            this.lblCarType.Text = "Тип вагона";
            // 
            // lblLessor
            // 
            this.lblLessor.AutoSize = true;
            this.lblLessor.Location = new System.Drawing.Point(10, 33);
            this.lblLessor.Name = "lblLessor";
            this.lblLessor.Size = new System.Drawing.Size(79, 13);
            this.lblLessor.TabIndex = 2;
            this.lblLessor.Text = "Арендодатель";
            // 
            // cboLessor
            // 
            this.cboLessor.DataSource = this.dtCarTypeLessorRentRateBindingSource;
            this.cboLessor.DisplayMember = "FullName";
            this.cboLessor.FormattingEnabled = true;
            this.cboLessor.Location = new System.Drawing.Point(95, 30);
            this.cboLessor.Name = "cboLessor";
            this.cboLessor.Size = new System.Drawing.Size(182, 21);
            this.cboLessor.TabIndex = 3;
            this.cboLessor.ValueMember = "CarTypeLessorRentRate_ID";
            this.cboLessor.SelectedValueChanged += new System.EventHandler(this.cboLessor_SelectedValueChanged);
            this.cboLessor.Enter += new System.EventHandler(this.cboLessor_Enter);
            // 
            // dtCarTypeLessorRentRateBindingSource
            // 
            this.dtCarTypeLessorRentRateBindingSource.DataMember = "dtCarTypeLessorRentRate";
            this.dtCarTypeLessorRentRateBindingSource.DataSource = this.rentDataSet;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.dtBeginDateCarRateTableAdapter = this.dtBeginDateCarRateTableAdapter;
            this.tableAdapterManager.tbl_allTableAdapter = null;
            this.tableAdapterManager.tbl_BeginDateCarRateTableAdapter = null;
            this.tableAdapterManager.tbl_CarRateCalcTableAdapter = null;
            this.tableAdapterManager.tbl_CarRentTableAdapter = null;
            this.tableAdapterManager.tbl_CarriageTypeTableAdapter = null;
            this.tableAdapterManager.tbl_CarTypeLessorRentRateTableAdapter = null;
            this.tableAdapterManager.tbl_CarTypeRentRateTableAdapter = null;
            this.tableAdapterManager.tbl_ContragentTableAdapter = null;
            this.tableAdapterManager.tbl_FirmTableAdapter = null;
            this.tableAdapterManager.tbl_TestCalcTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = RentWinForms.RentDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // dtBeginDateCarRateTableAdapter
            // 
            this.dtBeginDateCarRateTableAdapter.ClearBeforeFill = true;
            // 
            // tbl_CarRentTableAdapter
            // 
            this.tbl_CarRentTableAdapter.ClearBeforeFill = true;
            // 
            // tbl_CarriageTypeTableAdapter
            // 
            this.tbl_CarriageTypeTableAdapter.ClearBeforeFill = true;
            // 
            // tbl_ContragentTableAdapter
            // 
            this.tbl_ContragentTableAdapter.ClearBeforeFill = true;
            // 
            // dtBeginDateCarRateBindingNavigator
            // 
            this.dtBeginDateCarRateBindingNavigator.AddNewItem = null;
            this.dtBeginDateCarRateBindingNavigator.BindingSource = this.dtBeginDateCarRateBindingSource;
            this.dtBeginDateCarRateBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.dtBeginDateCarRateBindingNavigator.DeleteItem = null;
            this.dtBeginDateCarRateBindingNavigator.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dtBeginDateCarRateBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.dtBeginDateCarRateBindingNavigatorSaveItem});
            this.dtBeginDateCarRateBindingNavigator.Location = new System.Drawing.Point(0, 548);
            this.dtBeginDateCarRateBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.dtBeginDateCarRateBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.dtBeginDateCarRateBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.dtBeginDateCarRateBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.dtBeginDateCarRateBindingNavigator.Name = "dtBeginDateCarRateBindingNavigator";
            this.dtBeginDateCarRateBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.dtBeginDateCarRateBindingNavigator.Size = new System.Drawing.Size(705, 25);
            this.dtBeginDateCarRateBindingNavigator.TabIndex = 4;
            this.dtBeginDateCarRateBindingNavigator.Text = "bindingNavigator1";
            // 
            // dtBeginDateCarRateBindingSource
            // 
            this.dtBeginDateCarRateBindingSource.DataMember = "dtBeginDateCarRate";
            this.dtBeginDateCarRateBindingSource.DataSource = this.rentDataSet;
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
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
            // dtBeginDateCarRateBindingNavigatorSaveItem
            // 
            this.dtBeginDateCarRateBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.dtBeginDateCarRateBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("dtBeginDateCarRateBindingNavigatorSaveItem.Image")));
            this.dtBeginDateCarRateBindingNavigatorSaveItem.Name = "dtBeginDateCarRateBindingNavigatorSaveItem";
            this.dtBeginDateCarRateBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.dtBeginDateCarRateBindingNavigatorSaveItem.Text = "Save Data";
            this.dtBeginDateCarRateBindingNavigatorSaveItem.Click += new System.EventHandler(this.dtBeginDateCarRateBindingNavigatorSaveItem_Click);
            // 
            // tbl_BeginDateCarRateDataGridView
            // 
            this.tbl_BeginDateCarRateDataGridView.AllowUserToAddRows = false;
            this.tbl_BeginDateCarRateDataGridView.AllowUserToDeleteRows = false;
            this.tbl_BeginDateCarRateDataGridView.AutoGenerateColumns = false;
            this.tbl_BeginDateCarRateDataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.tbl_BeginDateCarRateDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tbl_BeginDateCarRateDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.Customer,
            this.CarRent_ID,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11});
            this.tbl_BeginDateCarRateDataGridView.DataSource = this.dtBeginDateCarRateBindingSource;
            this.tbl_BeginDateCarRateDataGridView.Location = new System.Drawing.Point(0, 57);
            this.tbl_BeginDateCarRateDataGridView.Name = "tbl_BeginDateCarRateDataGridView";
            this.tbl_BeginDateCarRateDataGridView.ReadOnly = true;
            this.tbl_BeginDateCarRateDataGridView.RowHeadersWidth = 24;
            this.tbl_BeginDateCarRateDataGridView.RowTemplate.Height = 20;
            this.tbl_BeginDateCarRateDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tbl_BeginDateCarRateDataGridView.Size = new System.Drawing.Size(705, 488);
            this.tbl_BeginDateCarRateDataGridView.TabIndex = 5;
            this.tbl_BeginDateCarRateDataGridView.DefaultValuesNeeded += new System.Windows.Forms.DataGridViewRowEventHandler(this.tbl_BeginDateCarRateDataGridView_DefaultValuesNeeded);
            this.tbl_BeginDateCarRateDataGridView.RowValidating += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.tbl_BeginDateCarRateDataGridView_RowValidating);
            this.tbl_BeginDateCarRateDataGridView.DoubleClick += new System.EventHandler(this.tbl_BeginDateCarRateDataGridView_DoubleClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "BeginDateCarRent_ID";
            this.dataGridViewTextBoxColumn1.HeaderText = "BeginDateCarRent_ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "CarTypeLessorRentRate_ID";
            this.dataGridViewTextBoxColumn2.HeaderText = "CarTypeLessorRentRate_ID";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Visible = false;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dataGridViewTextBoxColumn3.DataPropertyName = "BeginDateCarRent";
            dataGridViewCellStyle1.Format = "d";
            dataGridViewCellStyle1.NullValue = null;
            this.dataGridViewTextBoxColumn3.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewTextBoxColumn3.HeaderText = "Дата начала аренды";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // Customer
            // 
            this.Customer.DataPropertyName = "Customer";
            this.Customer.DataSource = this.tblContragentBindingSource;
            this.Customer.DisplayMember = "FullName";
            this.Customer.DisplayStyleForCurrentCellOnly = true;
            this.Customer.HeaderText = "Клиент";
            this.Customer.Name = "Customer";
            this.Customer.ReadOnly = true;
            this.Customer.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Customer.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Customer.ValueMember = "Contragent_ID";
            this.Customer.Width = 250;
            // 
            // tblContragentBindingSource
            // 
            this.tblContragentBindingSource.DataMember = "tbl_Contragent";
            this.tblContragentBindingSource.DataSource = this.rentDataSet;
            // 
            // CarRent_ID
            // 
            this.CarRent_ID.DataPropertyName = "CarRent_ID";
            this.CarRent_ID.DataSource = this.tblCarRentBindingSource;
            this.CarRent_ID.DisplayMember = "CarNum";
            this.CarRent_ID.DisplayStyleForCurrentCellOnly = true;
            this.CarRent_ID.HeaderText = "№ вагона";
            this.CarRent_ID.Name = "CarRent_ID";
            this.CarRent_ID.ReadOnly = true;
            this.CarRent_ID.ValueMember = "CarRent_ID";
            // 
            // tblCarRentBindingSource
            // 
            this.tblCarRentBindingSource.DataMember = "tbl_CarRent";
            this.tblCarRentBindingSource.DataSource = this.rentDataSet;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dataGridViewTextBoxColumn4.DataPropertyName = "InRateSum";
            this.dataGridViewTextBoxColumn4.HeaderText = "Вх. ставка";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 85;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 85;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dataGridViewTextBoxColumn5.DataPropertyName = "OutRateSum";
            this.dataGridViewTextBoxColumn5.HeaderText = "Исх. ставка";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 95;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 95;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "CreateDate";
            this.dataGridViewTextBoxColumn7.HeaderText = "CreateDate";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.Visible = false;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Creator";
            this.dataGridViewTextBoxColumn8.HeaderText = "Creator";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            this.dataGridViewTextBoxColumn8.Visible = false;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "EditDate";
            this.dataGridViewTextBoxColumn9.HeaderText = "EditDate";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            this.dataGridViewTextBoxColumn9.Visible = false;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "Editor";
            this.dataGridViewTextBoxColumn10.HeaderText = "Editor";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            this.dataGridViewTextBoxColumn10.Visible = false;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "Firm_ID";
            this.dataGridViewTextBoxColumn11.HeaderText = "Firm_ID";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.ReadOnly = true;
            this.dataGridViewTextBoxColumn11.Visible = false;
            // 
            // tblCarriageTypeBindingSource
            // 
            this.tblCarriageTypeBindingSource.DataMember = "tbl_CarriageType";
            this.tblCarriageTypeBindingSource.DataSource = this.rentDataSet;
            // 
            // dtCarTypeRentRateTableAdapter
            // 
            this.dtCarTypeRentRateTableAdapter.ClearBeforeFill = true;
            // 
            // dtCarTypeLessorRentRateTableAdapter
            // 
            this.dtCarTypeLessorRentRateTableAdapter.ClearBeforeFill = true;
            // 
            // btnCreateRate
            // 
            this.btnCreateRate.Image = global::RentWinForms.Properties.Resources.symbol_add;
            this.btnCreateRate.Location = new System.Drawing.Point(283, 7);
            this.btnCreateRate.Name = "btnCreateRate";
            this.btnCreateRate.Size = new System.Drawing.Size(40, 40);
            this.btnCreateRate.TabIndex = 6;
            this.btnCreateRate.UseVisualStyleBackColor = true;
            this.btnCreateRate.Click += new System.EventHandler(this.btnCreateRate_Click);
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
            // CarRentRate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(705, 573);
            this.Controls.Add(this.btnCreateRate);
            this.Controls.Add(this.tbl_BeginDateCarRateDataGridView);
            this.Controls.Add(this.dtBeginDateCarRateBindingNavigator);
            this.Controls.Add(this.cboLessor);
            this.Controls.Add(this.lblLessor);
            this.Controls.Add(this.lblCarType);
            this.Controls.Add(this.cboCarType);
            this.Name = "CarRentRate";
            this.Text = "Арендные ставки";
            this.Load += new System.EventHandler(this.CarRentRate_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtCarTypeRentRateBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rentDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtCarTypeLessorRentRateBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtBeginDateCarRateBindingNavigator)).EndInit();
            this.dtBeginDateCarRateBindingNavigator.ResumeLayout(false);
            this.dtBeginDateCarRateBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtBeginDateCarRateBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_BeginDateCarRateDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblContragentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblCarRentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblCarriageTypeBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboCarType;
        private System.Windows.Forms.Label lblCarType;
        private System.Windows.Forms.Label lblLessor;
        private System.Windows.Forms.ComboBox cboLessor;
        private RentDataSet rentDataSet;
        private RentDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator dtBeginDateCarRateBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton dtBeginDateCarRateBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView tbl_BeginDateCarRateDataGridView;
        private System.Windows.Forms.BindingSource dtBeginDateCarRateBindingSource;
        private RentDataSetTableAdapters.dtBeginDateCarRateTableAdapter dtBeginDateCarRateTableAdapter;
        private System.Windows.Forms.BindingSource tblCarRentBindingSource;
        private RentDataSetTableAdapters.tbl_CarRentTableAdapter tbl_CarRentTableAdapter;
        private System.Windows.Forms.BindingSource tblContragentBindingSource;
        private RentDataSetTableAdapters.tbl_ContragentTableAdapter tbl_ContragentTableAdapter;
        private System.Windows.Forms.BindingSource tblCarriageTypeBindingSource;
        private RentDataSetTableAdapters.tbl_CarriageTypeTableAdapter tbl_CarriageTypeTableAdapter;
        private System.Windows.Forms.BindingSource dtCarTypeRentRateBindingSource;
        private RentDataSetTableAdapters.dtCarTypeRentRateTableAdapter dtCarTypeRentRateTableAdapter;
        private System.Windows.Forms.BindingSource dtCarTypeLessorRentRateBindingSource;
        private RentDataSetTableAdapters.dtCarTypeLessorRentRateTableAdapter dtCarTypeLessorRentRateTableAdapter;
        private System.Windows.Forms.Button btnCreateRate;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewComboBoxColumn Customer;
        private System.Windows.Forms.DataGridViewComboBoxColumn CarRent_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.ToolStripButton toolStripEditBtn;
    }
}