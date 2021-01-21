
namespace AIS_ComputerBYTE
{
    partial class AssortmentForm
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
            this.button3 = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.addingCoputerButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.assortmentTable = new System.Windows.Forms.DataGridView();
            this.computerByteDataBaseDataSet = new AIS_ComputerBYTE.ComputerByteDataBaseDataSet();
            this.computersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.computersTableAdapter = new AIS_ComputerBYTE.ComputerByteDataBaseDataSetTableAdapters.ComputersTableAdapter();
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.assortmentTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.computerByteDataBaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.computersBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button3
            // 
            this.button3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button3.Location = new System.Drawing.Point(12, 344);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(240, 29);
            this.button3.TabIndex = 10;
            this.button3.Text = "Удалить";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // exit
            // 
            this.exit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.exit.Location = new System.Drawing.Point(12, 379);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(240, 29);
            this.exit.TabIndex = 9;
            this.exit.Text = "Назад";
            this.exit.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button2.Location = new System.Drawing.Point(12, 309);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(240, 29);
            this.button2.TabIndex = 8;
            this.button2.Text = "Обновить";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // addingCoputerButton
            // 
            this.addingCoputerButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.addingCoputerButton.Location = new System.Drawing.Point(12, 274);
            this.addingCoputerButton.Name = "addingCoputerButton";
            this.addingCoputerButton.Size = new System.Drawing.Size(240, 29);
            this.addingCoputerButton.TabIndex = 7;
            this.addingCoputerButton.Text = "Добавить компьютер";
            this.addingCoputerButton.UseVisualStyleBackColor = true;
            this.addingCoputerButton.Click += new System.EventHandler(this.addingCoputerButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(240, 256);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // assortmentTable
            // 
            this.assortmentTable.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.assortmentTable.AutoGenerateColumns = false;
            this.assortmentTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.assortmentTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
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
            this.assortmentTable.DataSource = this.computersBindingSource;
            this.assortmentTable.Location = new System.Drawing.Point(267, 12);
            this.assortmentTable.Name = "assortmentTable";
            this.assortmentTable.Size = new System.Drawing.Size(802, 396);
            this.assortmentTable.TabIndex = 11;
            this.assortmentTable.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.AssortmentTable_CellClick);
            // 
            // computerByteDataBaseDataSet
            // 
            this.computerByteDataBaseDataSet.DataSetName = "ComputerByteDataBaseDataSet";
            this.computerByteDataBaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // computersBindingSource
            // 
            this.computersBindingSource.DataMember = "Computers";
            this.computersBindingSource.DataSource = this.computerByteDataBaseDataSet;
            // 
            // computersTableAdapter
            // 
            this.computersTableAdapter.ClearBeforeFill = true;
            // 
            // кодDataGridViewTextBoxColumn
            // 
            this.кодDataGridViewTextBoxColumn.DataPropertyName = "Код";
            this.кодDataGridViewTextBoxColumn.HeaderText = "Код";
            this.кодDataGridViewTextBoxColumn.Name = "кодDataGridViewTextBoxColumn";
            // 
            // производительDataGridViewTextBoxColumn
            // 
            this.производительDataGridViewTextBoxColumn.DataPropertyName = "Производитель";
            this.производительDataGridViewTextBoxColumn.HeaderText = "Производитель";
            this.производительDataGridViewTextBoxColumn.Name = "производительDataGridViewTextBoxColumn";
            // 
            // материнскаяПлатаDataGridViewTextBoxColumn
            // 
            this.материнскаяПлатаDataGridViewTextBoxColumn.DataPropertyName = "Материнская плата";
            this.материнскаяПлатаDataGridViewTextBoxColumn.HeaderText = "Материнская плата";
            this.материнскаяПлатаDataGridViewTextBoxColumn.Name = "материнскаяПлатаDataGridViewTextBoxColumn";
            // 
            // оЗУDataGridViewTextBoxColumn
            // 
            this.оЗУDataGridViewTextBoxColumn.DataPropertyName = "ОЗУ";
            this.оЗУDataGridViewTextBoxColumn.HeaderText = "ОЗУ";
            this.оЗУDataGridViewTextBoxColumn.Name = "оЗУDataGridViewTextBoxColumn";
            // 
            // пЗУDataGridViewTextBoxColumn
            // 
            this.пЗУDataGridViewTextBoxColumn.DataPropertyName = "ПЗУ";
            this.пЗУDataGridViewTextBoxColumn.HeaderText = "ПЗУ";
            this.пЗУDataGridViewTextBoxColumn.Name = "пЗУDataGridViewTextBoxColumn";
            // 
            // блокПитанияDataGridViewTextBoxColumn
            // 
            this.блокПитанияDataGridViewTextBoxColumn.DataPropertyName = "Блок питания";
            this.блокПитанияDataGridViewTextBoxColumn.HeaderText = "Блок питания";
            this.блокПитанияDataGridViewTextBoxColumn.Name = "блокПитанияDataGridViewTextBoxColumn";
            // 
            // видеокартаDataGridViewTextBoxColumn
            // 
            this.видеокартаDataGridViewTextBoxColumn.DataPropertyName = "Видеокарта";
            this.видеокартаDataGridViewTextBoxColumn.HeaderText = "Видеокарта";
            this.видеокартаDataGridViewTextBoxColumn.Name = "видеокартаDataGridViewTextBoxColumn";
            // 
            // процессорDataGridViewTextBoxColumn
            // 
            this.процессорDataGridViewTextBoxColumn.DataPropertyName = "Процессор";
            this.процессорDataGridViewTextBoxColumn.HeaderText = "Процессор";
            this.процессорDataGridViewTextBoxColumn.Name = "процессорDataGridViewTextBoxColumn";
            // 
            // ценаDataGridViewTextBoxColumn
            // 
            this.ценаDataGridViewTextBoxColumn.DataPropertyName = "Цена";
            this.ценаDataGridViewTextBoxColumn.HeaderText = "Цена";
            this.ценаDataGridViewTextBoxColumn.Name = "ценаDataGridViewTextBoxColumn";
            // 
            // гарантияDataGridViewTextBoxColumn
            // 
            this.гарантияDataGridViewTextBoxColumn.DataPropertyName = "Гарантия";
            this.гарантияDataGridViewTextBoxColumn.HeaderText = "Гарантия";
            this.гарантияDataGridViewTextBoxColumn.Name = "гарантияDataGridViewTextBoxColumn";
            // 
            // AssortmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1081, 420);
            this.Controls.Add(this.assortmentTable);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.addingCoputerButton);
            this.Controls.Add(this.pictureBox1);
            this.Name = "AssortmentForm";
            this.Text = "Ассортимент";
            this.Load += new System.EventHandler(this.AssortmentForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.assortmentTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.computerByteDataBaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.computersBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button addingCoputerButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView assortmentTable;
        private ComputerByteDataBaseDataSet computerByteDataBaseDataSet;
        private System.Windows.Forms.BindingSource computersBindingSource;
        private ComputerByteDataBaseDataSetTableAdapters.ComputersTableAdapter computersTableAdapter;
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