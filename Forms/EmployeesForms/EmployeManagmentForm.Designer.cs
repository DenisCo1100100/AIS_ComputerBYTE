
namespace AIS_ComputerBYTE
{
    partial class EmployeManagmentForm
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
            this.employeesDataGridView = new System.Windows.Forms.DataGridView();
            this.должностьDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.полноеИмяDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.номерПаспортаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.возрастDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.адресDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.уровеньДоступаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.полученнаяприбыльDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.заработнаяплатаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.стажDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.образованиеDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.уровеньдоверияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.computerByteDataBaseDataSet1 = new AIS_ComputerBYTE.ComputerByteDataBaseDataSet1();
            this.employeesTableAdapter = new AIS_ComputerBYTE.ComputerByteDataBaseDataSet1TableAdapters.EmployeesTableAdapter();
            this.assortmentButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.employeesDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.computerByteDataBaseDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // employeesDataGridView
            // 
            this.employeesDataGridView.AutoGenerateColumns = false;
            this.employeesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.employeesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.должностьDataGridViewTextBoxColumn,
            this.полноеИмяDataGridViewTextBoxColumn,
            this.номерПаспортаDataGridViewTextBoxColumn,
            this.возрастDataGridViewTextBoxColumn,
            this.адресDataGridViewTextBoxColumn,
            this.уровеньДоступаDataGridViewTextBoxColumn,
            this.полученнаяприбыльDataGridViewTextBoxColumn,
            this.заработнаяплатаDataGridViewTextBoxColumn,
            this.стажDataGridViewTextBoxColumn,
            this.образованиеDataGridViewTextBoxColumn,
            this.уровеньдоверияDataGridViewTextBoxColumn});
            this.employeesDataGridView.DataSource = this.employeesBindingSource;
            this.employeesDataGridView.Location = new System.Drawing.Point(12, 12);
            this.employeesDataGridView.Name = "employeesDataGridView";
            this.employeesDataGridView.Size = new System.Drawing.Size(913, 319);
            this.employeesDataGridView.TabIndex = 0;
            // 
            // должностьDataGridViewTextBoxColumn
            // 
            this.должностьDataGridViewTextBoxColumn.DataPropertyName = "Должность";
            this.должностьDataGridViewTextBoxColumn.HeaderText = "Должность";
            this.должностьDataGridViewTextBoxColumn.Name = "должностьDataGridViewTextBoxColumn";
            // 
            // полноеИмяDataGridViewTextBoxColumn
            // 
            this.полноеИмяDataGridViewTextBoxColumn.DataPropertyName = "Полное имя";
            this.полноеИмяDataGridViewTextBoxColumn.HeaderText = "Полное имя";
            this.полноеИмяDataGridViewTextBoxColumn.Name = "полноеИмяDataGridViewTextBoxColumn";
            // 
            // номерПаспортаDataGridViewTextBoxColumn
            // 
            this.номерПаспортаDataGridViewTextBoxColumn.DataPropertyName = "Номер паспорта";
            this.номерПаспортаDataGridViewTextBoxColumn.HeaderText = "Номер паспорта";
            this.номерПаспортаDataGridViewTextBoxColumn.Name = "номерПаспортаDataGridViewTextBoxColumn";
            // 
            // возрастDataGridViewTextBoxColumn
            // 
            this.возрастDataGridViewTextBoxColumn.DataPropertyName = "Возраст";
            this.возрастDataGridViewTextBoxColumn.HeaderText = "Возраст";
            this.возрастDataGridViewTextBoxColumn.Name = "возрастDataGridViewTextBoxColumn";
            // 
            // адресDataGridViewTextBoxColumn
            // 
            this.адресDataGridViewTextBoxColumn.DataPropertyName = "Адрес";
            this.адресDataGridViewTextBoxColumn.HeaderText = "Адрес";
            this.адресDataGridViewTextBoxColumn.Name = "адресDataGridViewTextBoxColumn";
            // 
            // уровеньДоступаDataGridViewTextBoxColumn
            // 
            this.уровеньДоступаDataGridViewTextBoxColumn.DataPropertyName = "Уровень доступа";
            this.уровеньДоступаDataGridViewTextBoxColumn.HeaderText = "Уровень доступа";
            this.уровеньДоступаDataGridViewTextBoxColumn.Name = "уровеньДоступаDataGridViewTextBoxColumn";
            // 
            // полученнаяприбыльDataGridViewTextBoxColumn
            // 
            this.полученнаяприбыльDataGridViewTextBoxColumn.DataPropertyName = "Полученная_прибыль";
            this.полученнаяприбыльDataGridViewTextBoxColumn.HeaderText = "Полученная_прибыль";
            this.полученнаяприбыльDataGridViewTextBoxColumn.Name = "полученнаяприбыльDataGridViewTextBoxColumn";
            // 
            // заработнаяплатаDataGridViewTextBoxColumn
            // 
            this.заработнаяплатаDataGridViewTextBoxColumn.DataPropertyName = "Заработная_плата";
            this.заработнаяплатаDataGridViewTextBoxColumn.HeaderText = "Заработная_плата";
            this.заработнаяплатаDataGridViewTextBoxColumn.Name = "заработнаяплатаDataGridViewTextBoxColumn";
            // 
            // стажDataGridViewTextBoxColumn
            // 
            this.стажDataGridViewTextBoxColumn.DataPropertyName = "Стаж";
            this.стажDataGridViewTextBoxColumn.HeaderText = "Стаж";
            this.стажDataGridViewTextBoxColumn.Name = "стажDataGridViewTextBoxColumn";
            // 
            // образованиеDataGridViewTextBoxColumn
            // 
            this.образованиеDataGridViewTextBoxColumn.DataPropertyName = "Образование";
            this.образованиеDataGridViewTextBoxColumn.HeaderText = "Образование";
            this.образованиеDataGridViewTextBoxColumn.Name = "образованиеDataGridViewTextBoxColumn";
            // 
            // уровеньдоверияDataGridViewTextBoxColumn
            // 
            this.уровеньдоверияDataGridViewTextBoxColumn.DataPropertyName = "Уровень_доверия";
            this.уровеньдоверияDataGridViewTextBoxColumn.HeaderText = "Уровень_доверия";
            this.уровеньдоверияDataGridViewTextBoxColumn.Name = "уровеньдоверияDataGridViewTextBoxColumn";
            // 
            // employeesBindingSource
            // 
            this.employeesBindingSource.DataMember = "Employees";
            this.employeesBindingSource.DataSource = this.computerByteDataBaseDataSet1;
            // 
            // computerByteDataBaseDataSet1
            // 
            this.computerByteDataBaseDataSet1.DataSetName = "ComputerByteDataBaseDataSet1";
            this.computerByteDataBaseDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // employeesTableAdapter
            // 
            this.employeesTableAdapter.ClearBeforeFill = true;
            // 
            // assortmentButton
            // 
            this.assortmentButton.BackColor = System.Drawing.Color.Transparent;
            this.assortmentButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.assortmentButton.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.assortmentButton.FlatAppearance.BorderSize = 3;
            this.assortmentButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.assortmentButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.assortmentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.assortmentButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.assortmentButton.Location = new System.Drawing.Point(12, 337);
            this.assortmentButton.Name = "assortmentButton";
            this.assortmentButton.Size = new System.Drawing.Size(261, 75);
            this.assortmentButton.TabIndex = 10;
            this.assortmentButton.Text = "Зарегистрировать";
            this.assortmentButton.UseVisualStyleBackColor = false;
            this.assortmentButton.Click += new System.EventHandler(this.assortmentButton_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.button1.FlatAppearance.BorderSize = 3;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Location = new System.Drawing.Point(590, 337);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(154, 75);
            this.button1.TabIndex = 11;
            this.button1.Text = "Удалить";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.button2.FlatAppearance.BorderSize = 3;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button2.Location = new System.Drawing.Point(776, 337);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(149, 75);
            this.button2.TabIndex = 12;
            this.button2.Text = "Назад";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Transparent;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button3.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.button3.FlatAppearance.BorderSize = 3;
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button3.Location = new System.Drawing.Point(301, 337);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(263, 75);
            this.button3.TabIndex = 13;
            this.button3.Text = "Изменить информацию";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // EmployeManagmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.ClientSize = new System.Drawing.Size(937, 424);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.assortmentButton);
            this.Controls.Add(this.employeesDataGridView);
            this.Name = "EmployeManagmentForm";
            this.Text = "Управление сотрудниками";
            this.Load += new System.EventHandler(this.EmployeManagmentForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.employeesDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.computerByteDataBaseDataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView employeesDataGridView;
        private ComputerByteDataBaseDataSet1 computerByteDataBaseDataSet1;
        private System.Windows.Forms.BindingSource employeesBindingSource;
        private ComputerByteDataBaseDataSet1TableAdapters.EmployeesTableAdapter employeesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn должностьDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn полноеИмяDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn номерПаспортаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn возрастDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn адресDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn уровеньДоступаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn полученнаяприбыльDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn заработнаяплатаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn стажDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn образованиеDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn уровеньдоверияDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button assortmentButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}