
namespace AIS_ComputerBYTE
{
    partial class ClientsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClientsForm));
            this.deleteButton = new System.Windows.Forms.Button();
            this.registrationButton = new System.Windows.Forms.Button();
            this.clientsGridView = new System.Windows.Forms.DataGridView();
            this.кодDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.фамилияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.имяDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.отчествоDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.адресDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.паспортDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.датаРегистрацииDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.мобильныйТелефонDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.предоставитьСкидкуDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.предпологаемыйМесяцDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.средняяЗарплатаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.computerByteDataBaseDataSet2 = new AIS_ComputerBYTE.ComputerByteDataBaseDataSet2();
            this.backButton = new System.Windows.Forms.Button();
            this.clientsTableAdapter = new AIS_ComputerBYTE.ComputerByteDataBaseDataSet2TableAdapters.ClientsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.clientsGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.computerByteDataBaseDataSet2)).BeginInit();
            this.SuspendLayout();
            // 
            // deleteButton
            // 
            this.deleteButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.deleteButton.BackColor = System.Drawing.Color.Transparent;
            this.deleteButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.deleteButton.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.deleteButton.FlatAppearance.BorderSize = 3;
            this.deleteButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.deleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.deleteButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.deleteButton.Location = new System.Drawing.Point(353, 391);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(272, 75);
            this.deleteButton.TabIndex = 13;
            this.deleteButton.Text = "Удалить";
            this.deleteButton.UseVisualStyleBackColor = false;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // registrationButton
            // 
            this.registrationButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.registrationButton.BackColor = System.Drawing.Color.Transparent;
            this.registrationButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.registrationButton.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.registrationButton.FlatAppearance.BorderSize = 3;
            this.registrationButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.registrationButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.registrationButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.registrationButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.registrationButton.Location = new System.Drawing.Point(12, 391);
            this.registrationButton.Name = "registrationButton";
            this.registrationButton.Size = new System.Drawing.Size(261, 75);
            this.registrationButton.TabIndex = 12;
            this.registrationButton.Text = "Зарегистрировать";
            this.registrationButton.UseVisualStyleBackColor = false;
            this.registrationButton.Click += new System.EventHandler(this.registrationButton_Click);
            // 
            // clientsGridView
            // 
            this.clientsGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.clientsGridView.AutoGenerateColumns = false;
            this.clientsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.clientsGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.кодDataGridViewTextBoxColumn,
            this.фамилияDataGridViewTextBoxColumn,
            this.имяDataGridViewTextBoxColumn,
            this.отчествоDataGridViewTextBoxColumn,
            this.адресDataGridViewTextBoxColumn,
            this.паспортDataGridViewTextBoxColumn,
            this.датаРегистрацииDataGridViewTextBoxColumn,
            this.мобильныйТелефонDataGridViewTextBoxColumn,
            this.предоставитьСкидкуDataGridViewTextBoxColumn,
            this.предпологаемыйМесяцDataGridViewTextBoxColumn,
            this.средняяЗарплатаDataGridViewTextBoxColumn});
            this.clientsGridView.DataSource = this.clientsBindingSource;
            this.clientsGridView.Location = new System.Drawing.Point(12, 12);
            this.clientsGridView.Name = "clientsGridView";
            this.clientsGridView.Size = new System.Drawing.Size(911, 363);
            this.clientsGridView.TabIndex = 14;
            this.clientsGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.clientsGridView_CellClick);
            // 
            // кодDataGridViewTextBoxColumn
            // 
            this.кодDataGridViewTextBoxColumn.DataPropertyName = "Код";
            this.кодDataGridViewTextBoxColumn.HeaderText = "Код";
            this.кодDataGridViewTextBoxColumn.Name = "кодDataGridViewTextBoxColumn";
            // 
            // фамилияDataGridViewTextBoxColumn
            // 
            this.фамилияDataGridViewTextBoxColumn.DataPropertyName = "Фамилия";
            this.фамилияDataGridViewTextBoxColumn.HeaderText = "Фамилия";
            this.фамилияDataGridViewTextBoxColumn.Name = "фамилияDataGridViewTextBoxColumn";
            // 
            // имяDataGridViewTextBoxColumn
            // 
            this.имяDataGridViewTextBoxColumn.DataPropertyName = "Имя";
            this.имяDataGridViewTextBoxColumn.HeaderText = "Имя";
            this.имяDataGridViewTextBoxColumn.Name = "имяDataGridViewTextBoxColumn";
            // 
            // отчествоDataGridViewTextBoxColumn
            // 
            this.отчествоDataGridViewTextBoxColumn.DataPropertyName = "Отчество";
            this.отчествоDataGridViewTextBoxColumn.HeaderText = "Отчество";
            this.отчествоDataGridViewTextBoxColumn.Name = "отчествоDataGridViewTextBoxColumn";
            // 
            // адресDataGridViewTextBoxColumn
            // 
            this.адресDataGridViewTextBoxColumn.DataPropertyName = "Адрес";
            this.адресDataGridViewTextBoxColumn.HeaderText = "Адрес";
            this.адресDataGridViewTextBoxColumn.Name = "адресDataGridViewTextBoxColumn";
            // 
            // паспортDataGridViewTextBoxColumn
            // 
            this.паспортDataGridViewTextBoxColumn.DataPropertyName = "Паспорт";
            this.паспортDataGridViewTextBoxColumn.HeaderText = "Паспорт";
            this.паспортDataGridViewTextBoxColumn.Name = "паспортDataGridViewTextBoxColumn";
            // 
            // датаРегистрацииDataGridViewTextBoxColumn
            // 
            this.датаРегистрацииDataGridViewTextBoxColumn.DataPropertyName = "Дата регистрации";
            this.датаРегистрацииDataGridViewTextBoxColumn.HeaderText = "Дата регистрации";
            this.датаРегистрацииDataGridViewTextBoxColumn.Name = "датаРегистрацииDataGridViewTextBoxColumn";
            // 
            // мобильныйТелефонDataGridViewTextBoxColumn
            // 
            this.мобильныйТелефонDataGridViewTextBoxColumn.DataPropertyName = "Мобильный телефон";
            this.мобильныйТелефонDataGridViewTextBoxColumn.HeaderText = "Мобильный телефон";
            this.мобильныйТелефонDataGridViewTextBoxColumn.Name = "мобильныйТелефонDataGridViewTextBoxColumn";
            // 
            // предоставитьСкидкуDataGridViewTextBoxColumn
            // 
            this.предоставитьСкидкуDataGridViewTextBoxColumn.DataPropertyName = "Предоставить скидку";
            this.предоставитьСкидкуDataGridViewTextBoxColumn.HeaderText = "Предоставить скидку";
            this.предоставитьСкидкуDataGridViewTextBoxColumn.Name = "предоставитьСкидкуDataGridViewTextBoxColumn";
            // 
            // предпологаемыйМесяцDataGridViewTextBoxColumn
            // 
            this.предпологаемыйМесяцDataGridViewTextBoxColumn.DataPropertyName = "Предпологаемый месяц";
            this.предпологаемыйМесяцDataGridViewTextBoxColumn.HeaderText = "Предпологаемый месяц";
            this.предпологаемыйМесяцDataGridViewTextBoxColumn.Name = "предпологаемыйМесяцDataGridViewTextBoxColumn";
            // 
            // средняяЗарплатаDataGridViewTextBoxColumn
            // 
            this.средняяЗарплатаDataGridViewTextBoxColumn.DataPropertyName = "Средняя зарплата";
            this.средняяЗарплатаDataGridViewTextBoxColumn.HeaderText = "Средняя зарплата";
            this.средняяЗарплатаDataGridViewTextBoxColumn.Name = "средняяЗарплатаDataGridViewTextBoxColumn";
            // 
            // clientsBindingSource
            // 
            this.clientsBindingSource.DataMember = "Clients";
            this.clientsBindingSource.DataSource = this.computerByteDataBaseDataSet2;
            // 
            // computerByteDataBaseDataSet2
            // 
            this.computerByteDataBaseDataSet2.DataSetName = "ComputerByteDataBaseDataSet2";
            this.computerByteDataBaseDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // backButton
            // 
            this.backButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.backButton.BackColor = System.Drawing.Color.Transparent;
            this.backButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.backButton.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.backButton.FlatAppearance.BorderSize = 3;
            this.backButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.backButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.backButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.backButton.Location = new System.Drawing.Point(709, 391);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(214, 75);
            this.backButton.TabIndex = 15;
            this.backButton.Text = "Назад";
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // clientsTableAdapter
            // 
            this.clientsTableAdapter.ClearBeforeFill = true;
            // 
            // ClientsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.ClientSize = new System.Drawing.Size(935, 478);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.clientsGridView);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.registrationButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ClientsForm";
            this.Text = "Клиенты";
            this.Load += new System.EventHandler(this.ClientsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.clientsGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.computerByteDataBaseDataSet2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button registrationButton;
        private System.Windows.Forms.DataGridView clientsGridView;
        private System.Windows.Forms.Button backButton;
        private ComputerByteDataBaseDataSet2 computerByteDataBaseDataSet2;
        private System.Windows.Forms.BindingSource clientsBindingSource;
        private ComputerByteDataBaseDataSet2TableAdapters.ClientsTableAdapter clientsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn фамилияDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn имяDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn отчествоDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn адресDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn паспортDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn датаРегистрацииDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn мобильныйТелефонDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn предоставитьСкидкуDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn предпологаемыйМесяцDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn средняяЗарплатаDataGridViewTextBoxColumn;
    }
}