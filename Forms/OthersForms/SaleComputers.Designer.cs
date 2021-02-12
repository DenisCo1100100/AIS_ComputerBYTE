
namespace AIS_ComputerBYTE
{
    partial class SaleComputersForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SaleComputersForm));
            this.computersDataGridView = new System.Windows.Forms.DataGridView();
            this.кодDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.производительDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.материнскаяПлатаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.оЗУDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.пЗУDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.блокПитанияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.видеокартаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.процессорDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ценаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.гарантияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.computersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.computerByteDataBaseDataSet3 = new AIS_ComputerBYTE.ComputerByteDataBaseDataSet3();
            this.clientsDataGridView = new System.Windows.Forms.DataGridView();
            this.фамилияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.имяDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.отчествоDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.адресDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.паспортDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.мобильныйТелефонDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.предоставитьСкидкуDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.computerByteDataBaseDataSet4 = new AIS_ComputerBYTE.ComputerByteDataBaseDataSet4();
            this.clientsTableAdapter = new AIS_ComputerBYTE.ComputerByteDataBaseDataSet4TableAdapters.ClientsTableAdapter();
            this.selectCompLabel = new System.Windows.Forms.Label();
            this.selectClientLabel = new System.Windows.Forms.Label();
            this.checkoutButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.computersTableAdapter = new AIS_ComputerBYTE.ComputerByteDataBaseDataSet3TableAdapters.ComputersTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.computersDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.computersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.computerByteDataBaseDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.computerByteDataBaseDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // computersDataGridView
            // 
            this.computersDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.computersDataGridView.AutoGenerateColumns = false;
            this.computersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.computersDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.кодDataGridViewTextBoxColumn,
            this.производительDataGridViewTextBoxColumn,
            this.материнскаяПлатаDataGridViewTextBoxColumn,
            this.оЗУDataGridViewTextBoxColumn,
            this.пЗУDataGridViewTextBoxColumn,
            this.блокПитанияDataGridViewTextBoxColumn,
            this.видеокартаDataGridViewTextBoxColumn,
            this.процессорDataGridViewTextBoxColumn,
            this.ценаDataGridViewTextBoxColumn,
            this.гарантияDataGridViewTextBoxColumn});
            this.computersDataGridView.DataSource = this.computersBindingSource;
            this.computersDataGridView.Location = new System.Drawing.Point(313, 30);
            this.computersDataGridView.Name = "computersDataGridView";
            this.computersDataGridView.ReadOnly = true;
            this.computersDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.computersDataGridView.Size = new System.Drawing.Size(709, 300);
            this.computersDataGridView.TabIndex = 0;
            this.computersDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.computersDataGridView_CellClick);
            // 
            // кодDataGridViewTextBoxColumn
            // 
            this.кодDataGridViewTextBoxColumn.DataPropertyName = "Код";
            this.кодDataGridViewTextBoxColumn.HeaderText = "Код";
            this.кодDataGridViewTextBoxColumn.Name = "кодDataGridViewTextBoxColumn";
            this.кодDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // производительDataGridViewTextBoxColumn
            // 
            this.производительDataGridViewTextBoxColumn.DataPropertyName = "Производитель";
            this.производительDataGridViewTextBoxColumn.HeaderText = "Производитель";
            this.производительDataGridViewTextBoxColumn.Name = "производительDataGridViewTextBoxColumn";
            this.производительDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // материнскаяПлатаDataGridViewTextBoxColumn
            // 
            this.материнскаяПлатаDataGridViewTextBoxColumn.DataPropertyName = "Материнская плата";
            this.материнскаяПлатаDataGridViewTextBoxColumn.HeaderText = "Материнская плата";
            this.материнскаяПлатаDataGridViewTextBoxColumn.Name = "материнскаяПлатаDataGridViewTextBoxColumn";
            this.материнскаяПлатаDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // оЗУDataGridViewTextBoxColumn
            // 
            this.оЗУDataGridViewTextBoxColumn.DataPropertyName = "ОЗУ";
            this.оЗУDataGridViewTextBoxColumn.HeaderText = "ОЗУ";
            this.оЗУDataGridViewTextBoxColumn.Name = "оЗУDataGridViewTextBoxColumn";
            this.оЗУDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // пЗУDataGridViewTextBoxColumn
            // 
            this.пЗУDataGridViewTextBoxColumn.DataPropertyName = "ПЗУ";
            this.пЗУDataGridViewTextBoxColumn.HeaderText = "ПЗУ";
            this.пЗУDataGridViewTextBoxColumn.Name = "пЗУDataGridViewTextBoxColumn";
            this.пЗУDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // блокПитанияDataGridViewTextBoxColumn
            // 
            this.блокПитанияDataGridViewTextBoxColumn.DataPropertyName = "Блок питания";
            this.блокПитанияDataGridViewTextBoxColumn.HeaderText = "Блок питания";
            this.блокПитанияDataGridViewTextBoxColumn.Name = "блокПитанияDataGridViewTextBoxColumn";
            this.блокПитанияDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // видеокартаDataGridViewTextBoxColumn
            // 
            this.видеокартаDataGridViewTextBoxColumn.DataPropertyName = "Видеокарта";
            this.видеокартаDataGridViewTextBoxColumn.HeaderText = "Видеокарта";
            this.видеокартаDataGridViewTextBoxColumn.Name = "видеокартаDataGridViewTextBoxColumn";
            this.видеокартаDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // процессорDataGridViewTextBoxColumn
            // 
            this.процессорDataGridViewTextBoxColumn.DataPropertyName = "Процессор";
            this.процессорDataGridViewTextBoxColumn.HeaderText = "Процессор";
            this.процессорDataGridViewTextBoxColumn.Name = "процессорDataGridViewTextBoxColumn";
            this.процессорDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ценаDataGridViewTextBoxColumn
            // 
            this.ценаDataGridViewTextBoxColumn.DataPropertyName = "Цена";
            this.ценаDataGridViewTextBoxColumn.HeaderText = "Цена";
            this.ценаDataGridViewTextBoxColumn.Name = "ценаDataGridViewTextBoxColumn";
            this.ценаDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // гарантияDataGridViewTextBoxColumn
            // 
            this.гарантияDataGridViewTextBoxColumn.DataPropertyName = "Гарантия";
            this.гарантияDataGridViewTextBoxColumn.HeaderText = "Гарантия";
            this.гарантияDataGridViewTextBoxColumn.Name = "гарантияDataGridViewTextBoxColumn";
            this.гарантияDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // computersBindingSource
            // 
            this.computersBindingSource.DataMember = "Computers";
            this.computersBindingSource.DataSource = this.computerByteDataBaseDataSet3;
            // 
            // computerByteDataBaseDataSet3
            // 
            this.computerByteDataBaseDataSet3.DataSetName = "ComputerByteDataBaseDataSet3";
            this.computerByteDataBaseDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // clientsDataGridView
            // 
            this.clientsDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.clientsDataGridView.AutoGenerateColumns = false;
            this.clientsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.clientsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.фамилияDataGridViewTextBoxColumn,
            this.имяDataGridViewTextBoxColumn,
            this.отчествоDataGridViewTextBoxColumn,
            this.адресDataGridViewTextBoxColumn,
            this.паспортDataGridViewTextBoxColumn,
            this.мобильныйТелефонDataGridViewTextBoxColumn,
            this.предоставитьСкидкуDataGridViewTextBoxColumn});
            this.clientsDataGridView.DataSource = this.clientsBindingSource;
            this.clientsDataGridView.Location = new System.Drawing.Point(12, 360);
            this.clientsDataGridView.Name = "clientsDataGridView";
            this.clientsDataGridView.ReadOnly = true;
            this.clientsDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.clientsDataGridView.Size = new System.Drawing.Size(1010, 244);
            this.clientsDataGridView.TabIndex = 1;
            this.clientsDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.clientsDataGridView_CellClick);
            // 
            // фамилияDataGridViewTextBoxColumn
            // 
            this.фамилияDataGridViewTextBoxColumn.DataPropertyName = "Фамилия";
            this.фамилияDataGridViewTextBoxColumn.HeaderText = "Фамилия";
            this.фамилияDataGridViewTextBoxColumn.Name = "фамилияDataGridViewTextBoxColumn";
            this.фамилияDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // имяDataGridViewTextBoxColumn
            // 
            this.имяDataGridViewTextBoxColumn.DataPropertyName = "Имя";
            this.имяDataGridViewTextBoxColumn.HeaderText = "Имя";
            this.имяDataGridViewTextBoxColumn.Name = "имяDataGridViewTextBoxColumn";
            this.имяDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // отчествоDataGridViewTextBoxColumn
            // 
            this.отчествоDataGridViewTextBoxColumn.DataPropertyName = "Отчество";
            this.отчествоDataGridViewTextBoxColumn.HeaderText = "Отчество";
            this.отчествоDataGridViewTextBoxColumn.Name = "отчествоDataGridViewTextBoxColumn";
            this.отчествоDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // адресDataGridViewTextBoxColumn
            // 
            this.адресDataGridViewTextBoxColumn.DataPropertyName = "Адрес";
            this.адресDataGridViewTextBoxColumn.HeaderText = "Адрес";
            this.адресDataGridViewTextBoxColumn.Name = "адресDataGridViewTextBoxColumn";
            this.адресDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // паспортDataGridViewTextBoxColumn
            // 
            this.паспортDataGridViewTextBoxColumn.DataPropertyName = "Паспорт";
            this.паспортDataGridViewTextBoxColumn.HeaderText = "Паспорт";
            this.паспортDataGridViewTextBoxColumn.Name = "паспортDataGridViewTextBoxColumn";
            this.паспортDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // мобильныйТелефонDataGridViewTextBoxColumn
            // 
            this.мобильныйТелефонDataGridViewTextBoxColumn.DataPropertyName = "Мобильный телефон";
            this.мобильныйТелефонDataGridViewTextBoxColumn.HeaderText = "Мобильный телефон";
            this.мобильныйТелефонDataGridViewTextBoxColumn.Name = "мобильныйТелефонDataGridViewTextBoxColumn";
            this.мобильныйТелефонDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // предоставитьСкидкуDataGridViewTextBoxColumn
            // 
            this.предоставитьСкидкуDataGridViewTextBoxColumn.DataPropertyName = "Предоставить скидку";
            this.предоставитьСкидкуDataGridViewTextBoxColumn.HeaderText = "Предоставить скидку";
            this.предоставитьСкидкуDataGridViewTextBoxColumn.Name = "предоставитьСкидкуDataGridViewTextBoxColumn";
            this.предоставитьСкидкуDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // clientsBindingSource
            // 
            this.clientsBindingSource.DataMember = "Clients";
            this.clientsBindingSource.DataSource = this.computerByteDataBaseDataSet4;
            // 
            // computerByteDataBaseDataSet4
            // 
            this.computerByteDataBaseDataSet4.DataSetName = "ComputerByteDataBaseDataSet4";
            this.computerByteDataBaseDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // clientsTableAdapter
            // 
            this.clientsTableAdapter.ClearBeforeFill = true;
            // 
            // selectCompLabel
            // 
            this.selectCompLabel.AutoSize = true;
            this.selectCompLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.selectCompLabel.ForeColor = System.Drawing.Color.White;
            this.selectCompLabel.Location = new System.Drawing.Point(16, 4);
            this.selectCompLabel.Name = "selectCompLabel";
            this.selectCompLabel.Size = new System.Drawing.Size(306, 24);
            this.selectCompLabel.TabIndex = 2;
            this.selectCompLabel.Text = "Выбор компьютера: Не выбрано!";
            // 
            // selectClientLabel
            // 
            this.selectClientLabel.AutoSize = true;
            this.selectClientLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.selectClientLabel.ForeColor = System.Drawing.Color.White;
            this.selectClientLabel.Location = new System.Drawing.Point(16, 334);
            this.selectClientLabel.Name = "selectClientLabel";
            this.selectClientLabel.Size = new System.Drawing.Size(267, 24);
            this.selectClientLabel.TabIndex = 3;
            this.selectClientLabel.Text = "Выбор клиента: Не выбрано!";
            // 
            // checkoutButton
            // 
            this.checkoutButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.checkoutButton.BackColor = System.Drawing.Color.Transparent;
            this.checkoutButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.checkoutButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.checkoutButton.FlatAppearance.BorderSize = 4;
            this.checkoutButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.checkoutButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkoutButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkoutButton.ForeColor = System.Drawing.Color.White;
            this.checkoutButton.Location = new System.Drawing.Point(394, 613);
            this.checkoutButton.Name = "checkoutButton";
            this.checkoutButton.Size = new System.Drawing.Size(226, 49);
            this.checkoutButton.TabIndex = 11;
            this.checkoutButton.Text = "Оформить чек";
            this.checkoutButton.UseVisualStyleBackColor = false;
            this.checkoutButton.Click += new System.EventHandler(this.checkoutButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.LightGray;
            this.pictureBox1.Location = new System.Drawing.Point(20, 32);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(286, 298);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // computersTableAdapter
            // 
            this.computersTableAdapter.ClearBeforeFill = true;
            // 
            // SaleComputersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.ClientSize = new System.Drawing.Size(1034, 671);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.checkoutButton);
            this.Controls.Add(this.selectClientLabel);
            this.Controls.Add(this.selectCompLabel);
            this.Controls.Add(this.clientsDataGridView);
            this.Controls.Add(this.computersDataGridView);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SaleComputersForm";
            this.Text = "Продажи";
            this.Load += new System.EventHandler(this.SaleComputers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.computersDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.computersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.computerByteDataBaseDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.computerByteDataBaseDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView computersDataGridView;
        private System.Windows.Forms.DataGridView clientsDataGridView;
        private ComputerByteDataBaseDataSet4 computerByteDataBaseDataSet4;
        private System.Windows.Forms.BindingSource clientsBindingSource;
        private ComputerByteDataBaseDataSet4TableAdapters.ClientsTableAdapter clientsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn фамилияDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn имяDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn отчествоDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn адресDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn паспортDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn мобильныйТелефонDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn предоставитьСкидкуDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label selectCompLabel;
        private System.Windows.Forms.Label selectClientLabel;
        private System.Windows.Forms.Button checkoutButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private ComputerByteDataBaseDataSet3 computerByteDataBaseDataSet3;
        private System.Windows.Forms.BindingSource computersBindingSource;
        private ComputerByteDataBaseDataSet3TableAdapters.ComputersTableAdapter computersTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn производительDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn материнскаяПлатаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn оЗУDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn пЗУDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn блокПитанияDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn видеокартаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn процессорDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ценаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn гарантияDataGridViewTextBoxColumn;
    }
}