namespace DBServer_Inventory_1._1
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            System.Windows.Forms.Label informsys_nameLabel;
            System.Windows.Forms.Label informsys_EnShortNameLabel;
            System.Windows.Forms.Label informsys_worktimeLabel;
            this.servers_listBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.servers_listBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.servers_listDataGridView = new System.Windows.Forms.DataGridView();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.informsys_nameTextBox = new System.Windows.Forms.TextBox();
            this.informsys_EnShortNameTextBox = new System.Windows.Forms.TextBox();
            this.informsys_worktimeTextBox = new System.Windows.Forms.TextBox();
            this.informsys_listBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dBA_DBServer_InventoryDataSet = new DBServer_Inventory_1._1.DBA_DBServer_InventoryDataSet();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.servers_listBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.servers_listTableAdapter = new DBServer_Inventory_1._1.DBA_DBServer_InventoryDataSetTableAdapters.servers_listTableAdapter();
            this.tableAdapterManager = new DBServer_Inventory_1._1.DBA_DBServer_InventoryDataSetTableAdapters.TableAdapterManager();
            this.informsys_listTableAdapter = new DBServer_Inventory_1._1.DBA_DBServer_InventoryDataSetTableAdapters.informsys_listTableAdapter();
            informsys_nameLabel = new System.Windows.Forms.Label();
            informsys_EnShortNameLabel = new System.Windows.Forms.Label();
            informsys_worktimeLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.servers_listBindingNavigator)).BeginInit();
            this.servers_listBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.servers_listDataGridView)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.informsys_listBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBA_DBServer_InventoryDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.servers_listBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // servers_listBindingNavigator
            // 
            this.servers_listBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.servers_listBindingNavigator.BindingSource = this.servers_listBindingSource;
            this.servers_listBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.servers_listBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.servers_listBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.bindingNavigatorDeleteItem,
            this.servers_listBindingNavigatorSaveItem});
            this.servers_listBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.servers_listBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.servers_listBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.servers_listBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.servers_listBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.servers_listBindingNavigator.Name = "servers_listBindingNavigator";
            this.servers_listBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.servers_listBindingNavigator.Size = new System.Drawing.Size(800, 25);
            this.servers_listBindingNavigator.TabIndex = 0;
            this.servers_listBindingNavigator.Text = "bindingNavigator1";
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
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
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
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
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
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // servers_listBindingNavigatorSaveItem
            // 
            this.servers_listBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.servers_listBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("servers_listBindingNavigatorSaveItem.Image")));
            this.servers_listBindingNavigatorSaveItem.Name = "servers_listBindingNavigatorSaveItem";
            this.servers_listBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.servers_listBindingNavigatorSaveItem.Text = "Save Data";
            this.servers_listBindingNavigatorSaveItem.Click += new System.EventHandler(this.servers_listBindingNavigatorSaveItem_Click);
            // 
            // servers_listDataGridView
            // 
            this.servers_listDataGridView.AutoGenerateColumns = false;
            this.servers_listDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.servers_listDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.servers_listDataGridView.DataSource = this.servers_listBindingSource;
            this.servers_listDataGridView.Location = new System.Drawing.Point(0, 28);
            this.servers_listDataGridView.Name = "servers_listDataGridView";
            this.servers_listDataGridView.Size = new System.Drawing.Size(343, 220);
            this.servers_listDataGridView.TabIndex = 1;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(359, 28);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(441, 220);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(informsys_nameLabel);
            this.tabPage1.Controls.Add(this.informsys_nameTextBox);
            this.tabPage1.Controls.Add(informsys_EnShortNameLabel);
            this.tabPage1.Controls.Add(this.informsys_EnShortNameTextBox);
            this.tabPage1.Controls.Add(informsys_worktimeLabel);
            this.tabPage1.Controls.Add(this.informsys_worktimeTextBox);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(433, 194);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(433, 194);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // informsys_nameLabel
            // 
            informsys_nameLabel.AutoSize = true;
            informsys_nameLabel.Location = new System.Drawing.Point(6, 11);
            informsys_nameLabel.Name = "informsys_nameLabel";
            informsys_nameLabel.Size = new System.Drawing.Size(82, 13);
            informsys_nameLabel.TabIndex = 0;
            informsys_nameLabel.Text = "informsys name:";
            // 
            // informsys_nameTextBox
            // 
            this.informsys_nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.informsys_listBindingSource, "informsys_name", true));
            this.informsys_nameTextBox.Location = new System.Drawing.Point(140, 8);
            this.informsys_nameTextBox.Name = "informsys_nameTextBox";
            this.informsys_nameTextBox.Size = new System.Drawing.Size(285, 20);
            this.informsys_nameTextBox.TabIndex = 1;
            // 
            // informsys_EnShortNameLabel
            // 
            informsys_EnShortNameLabel.AutoSize = true;
            informsys_EnShortNameLabel.Location = new System.Drawing.Point(6, 37);
            informsys_EnShortNameLabel.Name = "informsys_EnShortNameLabel";
            informsys_EnShortNameLabel.Size = new System.Drawing.Size(128, 13);
            informsys_EnShortNameLabel.TabIndex = 2;
            informsys_EnShortNameLabel.Text = "informsys En Short Name:";
            // 
            // informsys_EnShortNameTextBox
            // 
            this.informsys_EnShortNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.informsys_listBindingSource, "informsys_EnShortName", true));
            this.informsys_EnShortNameTextBox.Location = new System.Drawing.Point(140, 34);
            this.informsys_EnShortNameTextBox.Name = "informsys_EnShortNameTextBox";
            this.informsys_EnShortNameTextBox.Size = new System.Drawing.Size(285, 20);
            this.informsys_EnShortNameTextBox.TabIndex = 3;
            // 
            // informsys_worktimeLabel
            // 
            informsys_worktimeLabel.AutoSize = true;
            informsys_worktimeLabel.Location = new System.Drawing.Point(6, 63);
            informsys_worktimeLabel.Name = "informsys_worktimeLabel";
            informsys_worktimeLabel.Size = new System.Drawing.Size(98, 13);
            informsys_worktimeLabel.TabIndex = 4;
            informsys_worktimeLabel.Text = "informsys worktime:";
            // 
            // informsys_worktimeTextBox
            // 
            this.informsys_worktimeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.informsys_listBindingSource, "informsys_worktime", true));
            this.informsys_worktimeTextBox.Location = new System.Drawing.Point(140, 60);
            this.informsys_worktimeTextBox.Name = "informsys_worktimeTextBox";
            this.informsys_worktimeTextBox.Size = new System.Drawing.Size(285, 20);
            this.informsys_worktimeTextBox.TabIndex = 5;
            // 
            // informsys_listBindingSource
            // 
            this.informsys_listBindingSource.DataMember = "informsys_list";
            this.informsys_listBindingSource.DataSource = this.dBA_DBServer_InventoryDataSet;
            // 
            // dBA_DBServer_InventoryDataSet
            // 
            this.dBA_DBServer_InventoryDataSet.DataSetName = "DBA_DBServer_InventoryDataSet";
            this.dBA_DBServer_InventoryDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "server_dnsname";
            this.dataGridViewTextBoxColumn2.HeaderText = "server_dnsname";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "server_address";
            this.dataGridViewTextBoxColumn3.HeaderText = "server_address";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "server_description";
            this.dataGridViewTextBoxColumn4.HeaderText = "server_description";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // servers_listBindingSource
            // 
            this.servers_listBindingSource.DataMember = "servers_list";
            this.servers_listBindingSource.DataSource = this.dBA_DBServer_InventoryDataSet;
            // 
            // servers_listTableAdapter
            // 
            this.servers_listTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.informsys_listTableAdapter = this.informsys_listTableAdapter;
            this.tableAdapterManager.servers_listTableAdapter = this.servers_listTableAdapter;
            this.tableAdapterManager.UpdateOrder = DBServer_Inventory_1._1.DBA_DBServer_InventoryDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // informsys_listTableAdapter
            // 
            this.informsys_listTableAdapter.ClearBeforeFill = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.servers_listDataGridView);
            this.Controls.Add(this.servers_listBindingNavigator);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.servers_listBindingNavigator)).EndInit();
            this.servers_listBindingNavigator.ResumeLayout(false);
            this.servers_listBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.servers_listDataGridView)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.informsys_listBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBA_DBServer_InventoryDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.servers_listBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DBA_DBServer_InventoryDataSet dBA_DBServer_InventoryDataSet;
        private System.Windows.Forms.BindingSource servers_listBindingSource;
        private DBA_DBServer_InventoryDataSetTableAdapters.servers_listTableAdapter servers_listTableAdapter;
        private DBA_DBServer_InventoryDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator servers_listBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton servers_listBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView servers_listDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DBA_DBServer_InventoryDataSetTableAdapters.informsys_listTableAdapter informsys_listTableAdapter;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.BindingSource informsys_listBindingSource;
        private System.Windows.Forms.TextBox informsys_nameTextBox;
        private System.Windows.Forms.TextBox informsys_EnShortNameTextBox;
        private System.Windows.Forms.TextBox informsys_worktimeTextBox;
    }
}