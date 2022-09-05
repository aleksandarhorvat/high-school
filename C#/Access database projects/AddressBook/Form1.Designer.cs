namespace AddressBook
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.Label surnamesLabel;
            System.Windows.Forms.Label namesLabel;
            System.Windows.Forms.Label addressesLabel;
            System.Windows.Forms.Label phone_numbersLabel;
            System.Windows.Forms.Label emailsLabel;
            System.Windows.Forms.Label dates_of_birthLabel;
            System.Windows.Forms.Label picturesLabel;
            this.btAddImage = new System.Windows.Forms.Button();
            this.btDeleteImage = new System.Windows.Forms.Button();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.btFind = new System.Windows.Forms.Button();
            this.dataDataGridView = new System.Windows.Forms.DataGridView();
            this.dataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.databaseDataSet = new AddressBook.DatabaseDataSet();
            this.dataTableAdapter = new AddressBook.DatabaseDataSetTableAdapters.DataTableAdapter();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.bindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
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
            this.saveToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.tableAdapterManager = new AddressBook.DatabaseDataSetTableAdapters.TableAdapterManager();
            this.surnamesTextBox = new System.Windows.Forms.TextBox();
            this.namesTextBox = new System.Windows.Forms.TextBox();
            this.addressesTextBox = new System.Windows.Forms.TextBox();
            this.phone_numbersTextBox = new System.Windows.Forms.TextBox();
            this.emailsTextBox = new System.Windows.Forms.TextBox();
            this.dates_of_birthDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.picturesPictureBox = new System.Windows.Forms.PictureBox();
            this.surnamesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneNumbersDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            surnamesLabel = new System.Windows.Forms.Label();
            namesLabel = new System.Windows.Forms.Label();
            addressesLabel = new System.Windows.Forms.Label();
            phone_numbersLabel = new System.Windows.Forms.Label();
            emailsLabel = new System.Windows.Forms.Label();
            dates_of_birthLabel = new System.Windows.Forms.Label();
            picturesLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator)).BeginInit();
            this.bindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picturesPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // btAddImage
            // 
            this.btAddImage.Location = new System.Drawing.Point(477, 304);
            this.btAddImage.Margin = new System.Windows.Forms.Padding(4);
            this.btAddImage.Name = "btAddImage";
            this.btAddImage.Size = new System.Drawing.Size(111, 28);
            this.btAddImage.TabIndex = 15;
            this.btAddImage.Text = "Add image";
            this.btAddImage.UseVisualStyleBackColor = true;
            this.btAddImage.Click += new System.EventHandler(this.btAddPicture_Click);
            // 
            // btDeleteImage
            // 
            this.btDeleteImage.Location = new System.Drawing.Point(639, 304);
            this.btDeleteImage.Margin = new System.Windows.Forms.Padding(4);
            this.btDeleteImage.Name = "btDeleteImage";
            this.btDeleteImage.Size = new System.Drawing.Size(111, 28);
            this.btDeleteImage.TabIndex = 16;
            this.btDeleteImage.Text = "Delete image";
            this.btDeleteImage.UseVisualStyleBackColor = true;
            this.btDeleteImage.Click += new System.EventHandler(this.btDeletePicture_Click);
            // 
            // tbSearch
            // 
            this.tbSearch.Location = new System.Drawing.Point(20, 369);
            this.tbSearch.Margin = new System.Windows.Forms.Padding(4);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(620, 22);
            this.tbSearch.TabIndex = 17;
            // 
            // btFind
            // 
            this.btFind.Location = new System.Drawing.Point(639, 366);
            this.btFind.Margin = new System.Windows.Forms.Padding(4);
            this.btFind.Name = "btFind";
            this.btFind.Size = new System.Drawing.Size(111, 28);
            this.btFind.TabIndex = 18;
            this.btFind.Text = "Find";
            this.btFind.UseVisualStyleBackColor = true;
            this.btFind.Click += new System.EventHandler(this.btSearch_Click);
            // 
            // dataDataGridView
            // 
            this.dataDataGridView.AutoGenerateColumns = false;
            this.dataDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.surnamesDataGridViewTextBoxColumn,
            this.namesDataGridViewTextBoxColumn,
            this.addressesDataGridViewTextBoxColumn,
            this.phoneNumbersDataGridViewTextBoxColumn,
            this.emailsDataGridViewTextBoxColumn});
            this.dataDataGridView.DataSource = this.dataBindingSource;
            this.dataDataGridView.Location = new System.Drawing.Point(13, 426);
            this.dataDataGridView.Margin = new System.Windows.Forms.Padding(4);
            this.dataDataGridView.Name = "dataDataGridView";
            this.dataDataGridView.RowHeadersWidth = 51;
            this.dataDataGridView.Size = new System.Drawing.Size(737, 271);
            this.dataDataGridView.TabIndex = 19;
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
            // dataTableAdapter
            // 
            this.dataTableAdapter.ClearBeforeFill = true;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // bindingNavigator
            // 
            this.bindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.bindingNavigator.BindingSource = this.dataBindingSource;
            this.bindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.bindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.bindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.bindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.saveToolStripButton});
            this.bindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.bindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigator.Name = "bindingNavigator";
            this.bindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigator.Size = new System.Drawing.Size(781, 27);
            this.bindingNavigator.TabIndex = 20;
            this.bindingNavigator.Text = "bindingNavigator1";
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
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
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
            // saveToolStripButton
            // 
            this.saveToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.saveToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("saveToolStripButton.Image")));
            this.saveToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveToolStripButton.Name = "saveToolStripButton";
            this.saveToolStripButton.Size = new System.Drawing.Size(29, 24);
            this.saveToolStripButton.Text = "&Save";
            this.saveToolStripButton.Click += new System.EventHandler(this.saveToolStripButton_Click);
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.DataTableAdapter = this.dataTableAdapter;
            this.tableAdapterManager.UpdateOrder = AddressBook.DatabaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // surnamesLabel
            // 
            surnamesLabel.AutoSize = true;
            surnamesLabel.Location = new System.Drawing.Point(22, 51);
            surnamesLabel.Name = "surnamesLabel";
            surnamesLabel.Size = new System.Drawing.Size(71, 16);
            surnamesLabel.TabIndex = 20;
            surnamesLabel.Text = "Surnames:";
            // 
            // surnamesTextBox
            // 
            this.surnamesTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dataBindingSource, "Surnames", true));
            this.surnamesTextBox.Location = new System.Drawing.Point(139, 48);
            this.surnamesTextBox.Name = "surnamesTextBox";
            this.surnamesTextBox.Size = new System.Drawing.Size(200, 22);
            this.surnamesTextBox.TabIndex = 21;
            // 
            // namesLabel
            // 
            namesLabel.AutoSize = true;
            namesLabel.Location = new System.Drawing.Point(22, 80);
            namesLabel.Name = "namesLabel";
            namesLabel.Size = new System.Drawing.Size(54, 16);
            namesLabel.TabIndex = 21;
            namesLabel.Text = "Names:";
            // 
            // namesTextBox
            // 
            this.namesTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dataBindingSource, "Names", true));
            this.namesTextBox.Location = new System.Drawing.Point(139, 77);
            this.namesTextBox.Name = "namesTextBox";
            this.namesTextBox.Size = new System.Drawing.Size(200, 22);
            this.namesTextBox.TabIndex = 22;
            // 
            // addressesLabel
            // 
            addressesLabel.AutoSize = true;
            addressesLabel.Location = new System.Drawing.Point(22, 108);
            addressesLabel.Name = "addressesLabel";
            addressesLabel.Size = new System.Drawing.Size(76, 16);
            addressesLabel.TabIndex = 22;
            addressesLabel.Text = "Addresses:";
            // 
            // addressesTextBox
            // 
            this.addressesTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dataBindingSource, "Addresses", true));
            this.addressesTextBox.Location = new System.Drawing.Point(139, 105);
            this.addressesTextBox.Name = "addressesTextBox";
            this.addressesTextBox.Size = new System.Drawing.Size(200, 22);
            this.addressesTextBox.TabIndex = 23;
            // 
            // phone_numbersLabel
            // 
            phone_numbersLabel.AutoSize = true;
            phone_numbersLabel.Location = new System.Drawing.Point(22, 136);
            phone_numbersLabel.Name = "phone_numbersLabel";
            phone_numbersLabel.Size = new System.Drawing.Size(104, 16);
            phone_numbersLabel.TabIndex = 23;
            phone_numbersLabel.Text = "Phone numbers:";
            // 
            // phone_numbersTextBox
            // 
            this.phone_numbersTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dataBindingSource, "Phone numbers", true));
            this.phone_numbersTextBox.Location = new System.Drawing.Point(139, 133);
            this.phone_numbersTextBox.Name = "phone_numbersTextBox";
            this.phone_numbersTextBox.Size = new System.Drawing.Size(200, 22);
            this.phone_numbersTextBox.TabIndex = 24;
            // 
            // emailsLabel
            // 
            emailsLabel.AutoSize = true;
            emailsLabel.Location = new System.Drawing.Point(22, 164);
            emailsLabel.Name = "emailsLabel";
            emailsLabel.Size = new System.Drawing.Size(51, 16);
            emailsLabel.TabIndex = 24;
            emailsLabel.Text = "Emails:";
            // 
            // emailsTextBox
            // 
            this.emailsTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dataBindingSource, "Emails", true));
            this.emailsTextBox.Location = new System.Drawing.Point(139, 161);
            this.emailsTextBox.Name = "emailsTextBox";
            this.emailsTextBox.Size = new System.Drawing.Size(200, 22);
            this.emailsTextBox.TabIndex = 25;
            // 
            // dates_of_birthLabel
            // 
            dates_of_birthLabel.AutoSize = true;
            dates_of_birthLabel.Location = new System.Drawing.Point(22, 207);
            dates_of_birthLabel.Name = "dates_of_birthLabel";
            dates_of_birthLabel.Size = new System.Drawing.Size(88, 16);
            dates_of_birthLabel.TabIndex = 25;
            dates_of_birthLabel.Text = "Dates of birth:";
            // 
            // dates_of_birthDateTimePicker
            // 
            this.dates_of_birthDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.dataBindingSource, "Dates of birth", true));
            this.dates_of_birthDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dates_of_birthDateTimePicker.Location = new System.Drawing.Point(139, 201);
            this.dates_of_birthDateTimePicker.Name = "dates_of_birthDateTimePicker";
            this.dates_of_birthDateTimePicker.Size = new System.Drawing.Size(200, 22);
            this.dates_of_birthDateTimePicker.TabIndex = 26;
            this.dates_of_birthDateTimePicker.Value = new System.DateTime(2022, 9, 3, 15, 29, 55, 0);
            // 
            // picturesLabel
            // 
            picturesLabel.AutoSize = true;
            picturesLabel.Location = new System.Drawing.Point(413, 51);
            picturesLabel.Name = "picturesLabel";
            picturesLabel.Size = new System.Drawing.Size(58, 16);
            picturesLabel.TabIndex = 26;
            picturesLabel.Text = "Pictures:";
            // 
            // picturesPictureBox
            // 
            this.picturesPictureBox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.dataBindingSource, "Pictures", true));
            this.picturesPictureBox.Location = new System.Drawing.Point(477, 51);
            this.picturesPictureBox.Name = "picturesPictureBox";
            this.picturesPictureBox.Size = new System.Drawing.Size(273, 246);
            this.picturesPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picturesPictureBox.TabIndex = 27;
            this.picturesPictureBox.TabStop = false;
            // 
            // surnamesDataGridViewTextBoxColumn
            // 
            this.surnamesDataGridViewTextBoxColumn.DataPropertyName = "Surnames";
            this.surnamesDataGridViewTextBoxColumn.HeaderText = "Surnames";
            this.surnamesDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.surnamesDataGridViewTextBoxColumn.Name = "surnamesDataGridViewTextBoxColumn";
            // 
            // namesDataGridViewTextBoxColumn
            // 
            this.namesDataGridViewTextBoxColumn.DataPropertyName = "Names";
            this.namesDataGridViewTextBoxColumn.HeaderText = "Names";
            this.namesDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.namesDataGridViewTextBoxColumn.Name = "namesDataGridViewTextBoxColumn";
            // 
            // addressesDataGridViewTextBoxColumn
            // 
            this.addressesDataGridViewTextBoxColumn.DataPropertyName = "Addresses";
            this.addressesDataGridViewTextBoxColumn.HeaderText = "Addresses";
            this.addressesDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.addressesDataGridViewTextBoxColumn.Name = "addressesDataGridViewTextBoxColumn";
            // 
            // phoneNumbersDataGridViewTextBoxColumn
            // 
            this.phoneNumbersDataGridViewTextBoxColumn.DataPropertyName = "Phone numbers";
            this.phoneNumbersDataGridViewTextBoxColumn.HeaderText = "Phone numbers";
            this.phoneNumbersDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.phoneNumbersDataGridViewTextBoxColumn.Name = "phoneNumbersDataGridViewTextBoxColumn";
            // 
            // emailsDataGridViewTextBoxColumn
            // 
            this.emailsDataGridViewTextBoxColumn.DataPropertyName = "Emails";
            this.emailsDataGridViewTextBoxColumn.HeaderText = "Emails";
            this.emailsDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.emailsDataGridViewTextBoxColumn.Name = "emailsDataGridViewTextBoxColumn";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(781, 717);
            this.Controls.Add(picturesLabel);
            this.Controls.Add(this.picturesPictureBox);
            this.Controls.Add(dates_of_birthLabel);
            this.Controls.Add(this.dates_of_birthDateTimePicker);
            this.Controls.Add(emailsLabel);
            this.Controls.Add(this.emailsTextBox);
            this.Controls.Add(phone_numbersLabel);
            this.Controls.Add(this.phone_numbersTextBox);
            this.Controls.Add(addressesLabel);
            this.Controls.Add(this.addressesTextBox);
            this.Controls.Add(namesLabel);
            this.Controls.Add(this.namesTextBox);
            this.Controls.Add(surnamesLabel);
            this.Controls.Add(this.surnamesTextBox);
            this.Controls.Add(this.bindingNavigator);
            this.Controls.Add(this.dataDataGridView);
            this.Controls.Add(this.btFind);
            this.Controls.Add(this.tbSearch);
            this.Controls.Add(this.btDeleteImage);
            this.Controls.Add(this.btAddImage);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator)).EndInit();
            this.bindingNavigator.ResumeLayout(false);
            this.bindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picturesPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btAddImage;
        private System.Windows.Forms.Button btDeleteImage;
        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.Button btFind;
        private System.Windows.Forms.DataGridView dataDataGridView;
        private DatabaseDataSet databaseDataSet;
        private System.Windows.Forms.BindingSource dataBindingSource;
        private DatabaseDataSetTableAdapters.DataTableAdapter dataTableAdapter;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.BindingNavigator bindingNavigator;
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
        private DatabaseDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ToolStripButton saveToolStripButton;
        private System.Windows.Forms.TextBox surnamesTextBox;
        private System.Windows.Forms.TextBox namesTextBox;
        private System.Windows.Forms.TextBox addressesTextBox;
        private System.Windows.Forms.TextBox phone_numbersTextBox;
        private System.Windows.Forms.TextBox emailsTextBox;
        private System.Windows.Forms.DateTimePicker dates_of_birthDateTimePicker;
        private System.Windows.Forms.PictureBox picturesPictureBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn surnamesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn namesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneNumbersDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailsDataGridViewTextBoxColumn;
    }
}

