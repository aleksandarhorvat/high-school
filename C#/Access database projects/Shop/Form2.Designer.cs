
namespace Shop
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
            System.Windows.Forms.Label iDLabel;
            System.Windows.Forms.Label namesLabel;
            System.Windows.Forms.Label pricesLabel;
            System.Windows.Forms.Label quantitiesLabel;
            System.Windows.Forms.Label picturesLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.btReturn = new System.Windows.Forms.Button();
            this.dataBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.dataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.databaseDataSet = new Shop.DatabaseDataSet();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tabelaBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.tabelaDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Names = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prices = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantities = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btAdd = new System.Windows.Forms.Button();
            this.btDelete = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.dataTableAdapter = new Shop.DatabaseDataSetTableAdapters.DataTableAdapter();
            this.dataAdapterManager = new Shop.DatabaseDataSetTableAdapters.TableAdapterManager();
            this.iDTextBox = new System.Windows.Forms.TextBox();
            this.namesTextBox = new System.Windows.Forms.TextBox();
            this.pricesTextBox = new System.Windows.Forms.TextBox();
            this.quantitiesTextBox = new System.Windows.Forms.TextBox();
            this.picturesPictureBox = new System.Windows.Forms.PictureBox();
            iDLabel = new System.Windows.Forms.Label();
            namesLabel = new System.Windows.Forms.Label();
            pricesLabel = new System.Windows.Forms.Label();
            quantitiesLabel = new System.Windows.Forms.Label();
            picturesLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataBindingNavigator)).BeginInit();
            this.dataBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabelaDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturesPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // iDLabel
            // 
            iDLabel.AutoSize = true;
            iDLabel.Location = new System.Drawing.Point(8, 49);
            iDLabel.Name = "iDLabel";
            iDLabel.Size = new System.Drawing.Size(23, 16);
            iDLabel.TabIndex = 14;
            iDLabel.Text = "ID:";
            // 
            // namesLabel
            // 
            namesLabel.AutoSize = true;
            namesLabel.Location = new System.Drawing.Point(8, 77);
            namesLabel.Name = "namesLabel";
            namesLabel.Size = new System.Drawing.Size(54, 16);
            namesLabel.TabIndex = 16;
            namesLabel.Text = "Names:";
            // 
            // pricesLabel
            // 
            pricesLabel.AutoSize = true;
            pricesLabel.Location = new System.Drawing.Point(8, 105);
            pricesLabel.Name = "pricesLabel";
            pricesLabel.Size = new System.Drawing.Size(48, 16);
            pricesLabel.TabIndex = 18;
            pricesLabel.Text = "Prices:";
            // 
            // quantitiesLabel
            // 
            quantitiesLabel.AutoSize = true;
            quantitiesLabel.Location = new System.Drawing.Point(8, 133);
            quantitiesLabel.Name = "quantitiesLabel";
            quantitiesLabel.Size = new System.Drawing.Size(69, 16);
            quantitiesLabel.TabIndex = 20;
            quantitiesLabel.Text = "Quantities:";
            // 
            // picturesLabel
            // 
            picturesLabel.AutoSize = true;
            picturesLabel.Location = new System.Drawing.Point(336, 43);
            picturesLabel.Name = "picturesLabel";
            picturesLabel.Size = new System.Drawing.Size(58, 16);
            picturesLabel.TabIndex = 21;
            picturesLabel.Text = "Pictures:";
            // 
            // btReturn
            // 
            this.btReturn.Location = new System.Drawing.Point(11, 274);
            this.btReturn.Margin = new System.Windows.Forms.Padding(4);
            this.btReturn.Name = "btReturn";
            this.btReturn.Size = new System.Drawing.Size(139, 28);
            this.btReturn.TabIndex = 0;
            this.btReturn.Text = "Return to main menu";
            this.btReturn.UseVisualStyleBackColor = true;
            this.btReturn.Click += new System.EventHandler(this.btReturn_Click);
            // 
            // dataBindingNavigator
            // 
            this.dataBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.dataBindingNavigator.BindingSource = this.dataBindingSource;
            this.dataBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.dataBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.dataBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.dataBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.tabelaBindingNavigatorSaveItem});
            this.dataBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.dataBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.dataBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.dataBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.dataBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.dataBindingNavigator.Name = "dataBindingNavigator";
            this.dataBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.dataBindingNavigator.Size = new System.Drawing.Size(695, 27);
            this.dataBindingNavigator.TabIndex = 1;
            this.dataBindingNavigator.Text = "bindingNavigator";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // dataBindingSource
            // 
            this.dataBindingSource.DataMember = "Data";
            this.dataBindingSource.DataSource = this.databaseDataSet;
            // 
            // databaseDataSet
            // 
            this.databaseDataSet.DataSetName = "DatabaseDataSet";
            this.databaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(45, 24);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            this.bindingNavigatorDeleteItem.Click += new System.EventHandler(this.bindingNavigatorDeleteItem_Click);
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(65, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // tabelaBindingNavigatorSaveItem
            // 
            this.tabelaBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tabelaBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("tabelaBindingNavigatorSaveItem.Image")));
            this.tabelaBindingNavigatorSaveItem.Name = "tabelaBindingNavigatorSaveItem";
            this.tabelaBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 24);
            this.tabelaBindingNavigatorSaveItem.Text = "Save Data";
            this.tabelaBindingNavigatorSaveItem.Click += new System.EventHandler(this.tabelaBindingNavigatorSaveItem_Click);
            // 
            // tabelaDataGridView
            // 
            this.tabelaDataGridView.AutoGenerateColumns = false;
            this.tabelaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tabelaDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.Names,
            this.Prices,
            this.Quantities});
            this.tabelaDataGridView.DataSource = this.dataBindingSource;
            this.tabelaDataGridView.Location = new System.Drawing.Point(13, 330);
            this.tabelaDataGridView.Margin = new System.Windows.Forms.Padding(4);
            this.tabelaDataGridView.Name = "tabelaDataGridView";
            this.tabelaDataGridView.RowHeadersWidth = 51;
            this.tabelaDataGridView.Size = new System.Drawing.Size(662, 271);
            this.tabelaDataGridView.TabIndex = 12;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // Names
            // 
            this.Names.DataPropertyName = "Names";
            this.Names.HeaderText = "Names";
            this.Names.MinimumWidth = 6;
            this.Names.Name = "Names";
            this.Names.Width = 155;
            // 
            // Prices
            // 
            this.Prices.DataPropertyName = "Prices";
            this.Prices.HeaderText = "Prices";
            this.Prices.MinimumWidth = 6;
            this.Prices.Name = "Prices";
            this.Prices.Width = 155;
            // 
            // Quantities
            // 
            this.Quantities.DataPropertyName = "Quantities";
            this.Quantities.HeaderText = "Quantities";
            this.Quantities.MinimumWidth = 6;
            this.Quantities.Name = "Quantities";
            this.Quantities.Width = 155;
            // 
            // btAdd
            // 
            this.btAdd.Location = new System.Drawing.Point(400, 274);
            this.btAdd.Margin = new System.Windows.Forms.Padding(4);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(100, 28);
            this.btAdd.TabIndex = 13;
            this.btAdd.Text = "Add picture";
            this.btAdd.UseVisualStyleBackColor = true;
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // btDelete
            // 
            this.btDelete.Location = new System.Drawing.Point(575, 274);
            this.btDelete.Margin = new System.Windows.Forms.Padding(4);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(100, 28);
            this.btDelete.TabIndex = 14;
            this.btDelete.Text = "Delete picture";
            this.btDelete.UseVisualStyleBackColor = true;
            this.btDelete.Click += new System.EventHandler(this.btDelete_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            // 
            // dataTableAdapter
            // 
            this.dataTableAdapter.ClearBeforeFill = true;
            // 
            // dataAdapterManager
            // 
            this.dataAdapterManager.BackupDataSetBeforeUpdate = false;
            this.dataAdapterManager.DataTableAdapter = this.dataTableAdapter;
            this.dataAdapterManager.UpdateOrder = Shop.DatabaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // iDTextBox
            // 
            this.iDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dataBindingSource, "ID", true));
            this.iDTextBox.Location = new System.Drawing.Point(83, 46);
            this.iDTextBox.Name = "iDTextBox";
            this.iDTextBox.Size = new System.Drawing.Size(193, 22);
            this.iDTextBox.TabIndex = 15;
            // 
            // namesTextBox
            // 
            this.namesTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dataBindingSource, "Names", true));
            this.namesTextBox.Location = new System.Drawing.Point(83, 74);
            this.namesTextBox.Name = "namesTextBox";
            this.namesTextBox.Size = new System.Drawing.Size(193, 22);
            this.namesTextBox.TabIndex = 17;
            // 
            // pricesTextBox
            // 
            this.pricesTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dataBindingSource, "Prices", true));
            this.pricesTextBox.Location = new System.Drawing.Point(83, 102);
            this.pricesTextBox.Name = "pricesTextBox";
            this.pricesTextBox.Size = new System.Drawing.Size(193, 22);
            this.pricesTextBox.TabIndex = 19;
            // 
            // quantitiesTextBox
            // 
            this.quantitiesTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dataBindingSource, "Quantities", true));
            this.quantitiesTextBox.Location = new System.Drawing.Point(83, 130);
            this.quantitiesTextBox.Name = "quantitiesTextBox";
            this.quantitiesTextBox.Size = new System.Drawing.Size(193, 22);
            this.quantitiesTextBox.TabIndex = 21;
            // 
            // picturesPictureBox
            // 
            this.picturesPictureBox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.dataBindingSource, "Pictures", true));
            this.picturesPictureBox.Location = new System.Drawing.Point(400, 30);
            this.picturesPictureBox.Name = "picturesPictureBox";
            this.picturesPictureBox.Size = new System.Drawing.Size(275, 237);
            this.picturesPictureBox.TabIndex = 22;
            this.picturesPictureBox.TabStop = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(695, 621);
            this.Controls.Add(picturesLabel);
            this.Controls.Add(this.picturesPictureBox);
            this.Controls.Add(iDLabel);
            this.Controls.Add(this.iDTextBox);
            this.Controls.Add(namesLabel);
            this.Controls.Add(this.namesTextBox);
            this.Controls.Add(pricesLabel);
            this.Controls.Add(this.pricesTextBox);
            this.Controls.Add(quantitiesLabel);
            this.Controls.Add(this.quantitiesTextBox);
            this.Controls.Add(this.btDelete);
            this.Controls.Add(this.btAdd);
            this.Controls.Add(this.tabelaDataGridView);
            this.Controls.Add(this.dataBindingNavigator);
            this.Controls.Add(this.btReturn);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataBindingNavigator)).EndInit();
            this.dataBindingNavigator.ResumeLayout(false);
            this.dataBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabelaDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturesPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btReturn;
        private System.Windows.Forms.BindingNavigator dataBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton tabelaBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView tabelaDataGridView;
        private System.Windows.Forms.Button btAdd;
        private System.Windows.Forms.Button btDelete;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private DatabaseDataSet databaseDataSet;
        private System.Windows.Forms.BindingSource dataBindingSource;
        private DatabaseDataSetTableAdapters.DataTableAdapter dataTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Names;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prices;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantities;
        private DatabaseDataSetTableAdapters.TableAdapterManager dataAdapterManager;
        private System.Windows.Forms.TextBox iDTextBox;
        private System.Windows.Forms.TextBox namesTextBox;
        private System.Windows.Forms.TextBox pricesTextBox;
        private System.Windows.Forms.TextBox quantitiesTextBox;
        private System.Windows.Forms.PictureBox picturesPictureBox;
    }
}