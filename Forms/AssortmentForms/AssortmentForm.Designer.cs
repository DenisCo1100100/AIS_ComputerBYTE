
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AssortmentForm));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.assortmentTable = new System.Windows.Forms.DataGridView();
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
            this.computerByteDataBaseDataSet = new AIS_ComputerBYTE.ComputerByteDataBaseDataSet();
            this.computersTableAdapter = new AIS_ComputerBYTE.ComputerByteDataBaseDataSetTableAdapters.ComputersTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.assortmentTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.computersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.computerByteDataBaseDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(379, 361);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // assortmentTable
            // 
            this.assortmentTable.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.assortmentTable.AutoGenerateColumns = false;
            this.assortmentTable.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.assortmentTable.BorderStyle = System.Windows.Forms.BorderStyle.None;
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
            this.assortmentTable.GridColor = System.Drawing.Color.LightGray;
            this.assortmentTable.Location = new System.Drawing.Point(408, 12);
            this.assortmentTable.Name = "assortmentTable";
            this.assortmentTable.ReadOnly = true;
            this.assortmentTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.assortmentTable.Size = new System.Drawing.Size(647, 361);
            this.assortmentTable.TabIndex = 11;
            this.assortmentTable.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.AssortmentTable_CellClick);
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
            this.computersBindingSource.DataSource = this.computerByteDataBaseDataSet;
            // 
            // computerByteDataBaseDataSet
            // 
            this.computerByteDataBaseDataSet.DataSetName = "ComputerByteDataBaseDataSet";
            this.computerByteDataBaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // computersTableAdapter
            // 
            this.computersTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.BorderSize = 4;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(12, 390);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(224, 78);
            this.button1.TabIndex = 12;
            this.button1.Text = "Добавить компьютер";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.addingCoputerButton_Click);
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button2.FlatAppearance.BorderSize = 4;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(282, 390);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(224, 78);
            this.button2.TabIndex = 13;
            this.button2.Text = "Обновить";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.update_Click);
            // 
            // button3
            // 
            this.button3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button3.BackColor = System.Drawing.Color.Transparent;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button3.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button3.FlatAppearance.BorderSize = 4;
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(557, 390);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(224, 78);
            this.button3.TabIndex = 14;
            this.button3.Text = "Удалить";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.delete_Click);
            // 
            // button4
            // 
            this.button4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button4.BackColor = System.Drawing.Color.Transparent;
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button4.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button4.FlatAppearance.BorderSize = 4;
            this.button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(831, 390);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(224, 78);
            this.button4.TabIndex = 15;
            this.button4.Text = "Назад";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.exit_Click);
            // 
            // AssortmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1067, 476);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.assortmentTable);
            this.Controls.Add(this.pictureBox1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AssortmentForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ассортимент";
            this.Load += new System.EventHandler(this.AssortmentForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.assortmentTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.computersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.computerByteDataBaseDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}