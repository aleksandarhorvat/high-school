namespace MojAdresar
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
            System.Windows.Forms.Label prezimeLabel;
            System.Windows.Forms.Label imeLabel;
            System.Windows.Forms.Label adresaLabel;
            System.Windows.Forms.Label telefonLabel;
            System.Windows.Forms.Label emailLabel;
            System.Windows.Forms.Label rodjenjeLabel;
            System.Windows.Forms.Label slikaLabel;
            this.adresarBazaDataSet = new MojAdresar.AdresarBazaDataSet();
            this.podaciBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.podaciTableAdapter = new MojAdresar.AdresarBazaDataSetTableAdapters.PodaciTableAdapter();
            this.tableAdapterManager = new MojAdresar.AdresarBazaDataSetTableAdapters.TableAdapterManager();
            this.podaciBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.podaciBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.prezimeTextBox = new System.Windows.Forms.TextBox();
            this.imeTextBox = new System.Windows.Forms.TextBox();
            this.adresaTextBox = new System.Windows.Forms.TextBox();
            this.telefonTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.rodjenjeDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.slikaPictureBox = new System.Windows.Forms.PictureBox();
            this.btDodajSliku = new System.Windows.Forms.Button();
            this.btObrisiSliku = new System.Windows.Forms.Button();
            this.tbPretraga = new System.Windows.Forms.TextBox();
            this.btPronadji = new System.Windows.Forms.Button();
            this.podaciDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            prezimeLabel = new System.Windows.Forms.Label();
            imeLabel = new System.Windows.Forms.Label();
            adresaLabel = new System.Windows.Forms.Label();
            telefonLabel = new System.Windows.Forms.Label();
            emailLabel = new System.Windows.Forms.Label();
            rodjenjeLabel = new System.Windows.Forms.Label();
            slikaLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.adresarBazaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.podaciBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.podaciBindingNavigator)).BeginInit();
            this.podaciBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.slikaPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.podaciDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // adresarBazaDataSet
            // 
            this.adresarBazaDataSet.DataSetName = "AdresarBazaDataSet";
            this.adresarBazaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // podaciBindingSource
            // 
            this.podaciBindingSource.DataMember = "Podaci";
            this.podaciBindingSource.DataSource = this.adresarBazaDataSet;
            // 
            // podaciTableAdapter
            // 
            this.podaciTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.PodaciTableAdapter = this.podaciTableAdapter;
            this.tableAdapterManager.UpdateOrder = MojAdresar.AdresarBazaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // podaciBindingNavigator
            // 
            this.podaciBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.podaciBindingNavigator.BindingSource = this.podaciBindingSource;
            this.podaciBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.podaciBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.podaciBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.podaciBindingNavigatorSaveItem});
            this.podaciBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.podaciBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.podaciBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.podaciBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.podaciBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.podaciBindingNavigator.Name = "podaciBindingNavigator";
            this.podaciBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.podaciBindingNavigator.Size = new System.Drawing.Size(572, 25);
            this.podaciBindingNavigator.TabIndex = 0;
            this.podaciBindingNavigator.Text = "bindingNavigator1";
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
            // podaciBindingNavigatorSaveItem
            // 
            this.podaciBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.podaciBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("podaciBindingNavigatorSaveItem.Image")));
            this.podaciBindingNavigatorSaveItem.Name = "podaciBindingNavigatorSaveItem";
            this.podaciBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.podaciBindingNavigatorSaveItem.Text = "Save Data";
            this.podaciBindingNavigatorSaveItem.Click += new System.EventHandler(this.podaciBindingNavigatorSaveItem_Click);
            // 
            // prezimeLabel
            // 
            prezimeLabel.AutoSize = true;
            prezimeLabel.Location = new System.Drawing.Point(29, 66);
            prezimeLabel.Name = "prezimeLabel";
            prezimeLabel.Size = new System.Drawing.Size(47, 13);
            prezimeLabel.TabIndex = 1;
            prezimeLabel.Text = "Prezime:";
            // 
            // prezimeTextBox
            // 
            this.prezimeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.podaciBindingSource, "Prezime", true));
            this.prezimeTextBox.Location = new System.Drawing.Point(87, 63);
            this.prezimeTextBox.Name = "prezimeTextBox";
            this.prezimeTextBox.Size = new System.Drawing.Size(200, 20);
            this.prezimeTextBox.TabIndex = 2;
            // 
            // imeLabel
            // 
            imeLabel.AutoSize = true;
            imeLabel.Location = new System.Drawing.Point(29, 92);
            imeLabel.Name = "imeLabel";
            imeLabel.Size = new System.Drawing.Size(27, 13);
            imeLabel.TabIndex = 3;
            imeLabel.Text = "Ime:";
            // 
            // imeTextBox
            // 
            this.imeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.podaciBindingSource, "Ime", true));
            this.imeTextBox.Location = new System.Drawing.Point(87, 89);
            this.imeTextBox.Name = "imeTextBox";
            this.imeTextBox.Size = new System.Drawing.Size(200, 20);
            this.imeTextBox.TabIndex = 4;
            // 
            // adresaLabel
            // 
            adresaLabel.AutoSize = true;
            adresaLabel.Location = new System.Drawing.Point(29, 118);
            adresaLabel.Name = "adresaLabel";
            adresaLabel.Size = new System.Drawing.Size(43, 13);
            adresaLabel.TabIndex = 5;
            adresaLabel.Text = "Adresa:";
            // 
            // adresaTextBox
            // 
            this.adresaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.podaciBindingSource, "Adresa", true));
            this.adresaTextBox.Location = new System.Drawing.Point(87, 115);
            this.adresaTextBox.Name = "adresaTextBox";
            this.adresaTextBox.Size = new System.Drawing.Size(200, 20);
            this.adresaTextBox.TabIndex = 6;
            // 
            // telefonLabel
            // 
            telefonLabel.AutoSize = true;
            telefonLabel.Location = new System.Drawing.Point(29, 144);
            telefonLabel.Name = "telefonLabel";
            telefonLabel.Size = new System.Drawing.Size(46, 13);
            telefonLabel.TabIndex = 7;
            telefonLabel.Text = "Telefon:";
            // 
            // telefonTextBox
            // 
            this.telefonTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.podaciBindingSource, "Telefon", true));
            this.telefonTextBox.Location = new System.Drawing.Point(87, 141);
            this.telefonTextBox.Name = "telefonTextBox";
            this.telefonTextBox.Size = new System.Drawing.Size(200, 20);
            this.telefonTextBox.TabIndex = 8;
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Location = new System.Drawing.Point(29, 170);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(35, 13);
            emailLabel.TabIndex = 9;
            emailLabel.Text = "Email:";
            // 
            // emailTextBox
            // 
            this.emailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.podaciBindingSource, "Email", true));
            this.emailTextBox.Location = new System.Drawing.Point(87, 167);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(200, 20);
            this.emailTextBox.TabIndex = 10;
            // 
            // rodjenjeLabel
            // 
            rodjenjeLabel.AutoSize = true;
            rodjenjeLabel.Location = new System.Drawing.Point(29, 197);
            rodjenjeLabel.Name = "rodjenjeLabel";
            rodjenjeLabel.Size = new System.Drawing.Size(52, 13);
            rodjenjeLabel.TabIndex = 11;
            rodjenjeLabel.Text = "Rodjenje:";
            // 
            // rodjenjeDateTimePicker
            // 
            this.rodjenjeDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.podaciBindingSource, "Rodjenje", true));
            this.rodjenjeDateTimePicker.Location = new System.Drawing.Point(87, 193);
            this.rodjenjeDateTimePicker.Name = "rodjenjeDateTimePicker";
            this.rodjenjeDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.rodjenjeDateTimePicker.TabIndex = 12;
            // 
            // slikaLabel
            // 
            slikaLabel.AutoSize = true;
            slikaLabel.Location = new System.Drawing.Point(316, 49);
            slikaLabel.Name = "slikaLabel";
            slikaLabel.Size = new System.Drawing.Size(33, 13);
            slikaLabel.TabIndex = 13;
            slikaLabel.Text = "Slika:";
            // 
            // slikaPictureBox
            // 
            this.slikaPictureBox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.podaciBindingSource, "Slika", true));
            this.slikaPictureBox.Location = new System.Drawing.Point(355, 49);
            this.slikaPictureBox.Name = "slikaPictureBox";
            this.slikaPictureBox.Size = new System.Drawing.Size(199, 182);
            this.slikaPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.slikaPictureBox.TabIndex = 14;
            this.slikaPictureBox.TabStop = false;
            // 
            // btDodajSliku
            // 
            this.btDodajSliku.Location = new System.Drawing.Point(358, 247);
            this.btDodajSliku.Name = "btDodajSliku";
            this.btDodajSliku.Size = new System.Drawing.Size(75, 23);
            this.btDodajSliku.TabIndex = 15;
            this.btDodajSliku.Text = "Dodaj sliku";
            this.btDodajSliku.UseVisualStyleBackColor = true;
            this.btDodajSliku.Click += new System.EventHandler(this.btDodajSliku_Click);
            // 
            // btObrisiSliku
            // 
            this.btObrisiSliku.Location = new System.Drawing.Point(479, 247);
            this.btObrisiSliku.Name = "btObrisiSliku";
            this.btObrisiSliku.Size = new System.Drawing.Size(75, 23);
            this.btObrisiSliku.TabIndex = 16;
            this.btObrisiSliku.Text = "Obrisi sliku";
            this.btObrisiSliku.UseVisualStyleBackColor = true;
            this.btObrisiSliku.Click += new System.EventHandler(this.btObrisiSliku_Click);
            // 
            // tbPretraga
            // 
            this.tbPretraga.Location = new System.Drawing.Point(15, 300);
            this.tbPretraga.Name = "tbPretraga";
            this.tbPretraga.Size = new System.Drawing.Size(458, 20);
            this.tbPretraga.TabIndex = 17;
            // 
            // btPronadji
            // 
            this.btPronadji.Location = new System.Drawing.Point(479, 297);
            this.btPronadji.Name = "btPronadji";
            this.btPronadji.Size = new System.Drawing.Size(75, 23);
            this.btPronadji.TabIndex = 18;
            this.btPronadji.Text = "Pronadji";
            this.btPronadji.UseVisualStyleBackColor = true;
            this.btPronadji.Click += new System.EventHandler(this.btPronadji_Click);
            // 
            // podaciDataGridView
            // 
            this.podaciDataGridView.AutoGenerateColumns = false;
            this.podaciDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.podaciDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.podaciDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.podaciDataGridView.DataSource = this.podaciBindingSource;
            this.podaciDataGridView.Location = new System.Drawing.Point(15, 345);
            this.podaciDataGridView.Name = "podaciDataGridView";
            this.podaciDataGridView.Size = new System.Drawing.Size(539, 220);
            this.podaciDataGridView.TabIndex = 19;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Prezime";
            this.dataGridViewTextBoxColumn1.HeaderText = "Prezime";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Ime";
            this.dataGridViewTextBoxColumn2.HeaderText = "Ime";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Adresa";
            this.dataGridViewTextBoxColumn3.HeaderText = "Adresa";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Telefon";
            this.dataGridViewTextBoxColumn4.HeaderText = "Telefon";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(572, 577);
            this.Controls.Add(this.podaciDataGridView);
            this.Controls.Add(this.btPronadji);
            this.Controls.Add(this.tbPretraga);
            this.Controls.Add(this.btObrisiSliku);
            this.Controls.Add(this.btDodajSliku);
            this.Controls.Add(slikaLabel);
            this.Controls.Add(this.slikaPictureBox);
            this.Controls.Add(prezimeLabel);
            this.Controls.Add(this.prezimeTextBox);
            this.Controls.Add(imeLabel);
            this.Controls.Add(this.imeTextBox);
            this.Controls.Add(adresaLabel);
            this.Controls.Add(this.adresaTextBox);
            this.Controls.Add(telefonLabel);
            this.Controls.Add(this.telefonTextBox);
            this.Controls.Add(emailLabel);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(rodjenjeLabel);
            this.Controls.Add(this.rodjenjeDateTimePicker);
            this.Controls.Add(this.podaciBindingNavigator);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.adresarBazaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.podaciBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.podaciBindingNavigator)).EndInit();
            this.podaciBindingNavigator.ResumeLayout(false);
            this.podaciBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.slikaPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.podaciDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AdresarBazaDataSet adresarBazaDataSet;
        private System.Windows.Forms.BindingSource podaciBindingSource;
        private AdresarBazaDataSetTableAdapters.PodaciTableAdapter podaciTableAdapter;
        private AdresarBazaDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator podaciBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton podaciBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox prezimeTextBox;
        private System.Windows.Forms.TextBox imeTextBox;
        private System.Windows.Forms.TextBox adresaTextBox;
        private System.Windows.Forms.TextBox telefonTextBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.DateTimePicker rodjenjeDateTimePicker;
        private System.Windows.Forms.PictureBox slikaPictureBox;
        private System.Windows.Forms.Button btDodajSliku;
        private System.Windows.Forms.Button btObrisiSliku;
        private System.Windows.Forms.TextBox tbPretraga;
        private System.Windows.Forms.Button btPronadji;
        private System.Windows.Forms.DataGridView podaciDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

