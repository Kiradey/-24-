namespace задание_24_бл_схемы
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Generate = new System.Windows.Forms.Button();
            this.LastDiap = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.FirstDiap = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ColumnCounts = new System.Windows.Forms.TextBox();
            this.RowCounts = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.FindSPoint = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Controls.Add(this.Generate);
            this.groupBox1.Controls.Add(this.LastDiap);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.FirstDiap);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.ColumnCounts);
            this.groupBox1.Controls.Add(this.RowCounts);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 17);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(397, 362);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Генерируем массив";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.ColumnHeadersVisible = false;
            this.dataGridView1.Location = new System.Drawing.Point(48, 168);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(300, 188);
            this.dataGridView1.TabIndex = 6;
            // 
            // Generate
            // 
            this.Generate.Location = new System.Drawing.Point(141, 123);
            this.Generate.Name = "Generate";
            this.Generate.Size = new System.Drawing.Size(127, 29);
            this.Generate.TabIndex = 1;
            this.Generate.Text = "Сгенерировать";
            this.Generate.UseVisualStyleBackColor = true;
            this.Generate.Click += new System.EventHandler(this.Generate_Click);
            // 
            // LastDiap
            // 
            this.LastDiap.Location = new System.Drawing.Point(255, 77);
            this.LastDiap.Name = "LastDiap";
            this.LastDiap.Size = new System.Drawing.Size(53, 27);
            this.LastDiap.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(223, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "до";
            // 
            // FirstDiap
            // 
            this.FirstDiap.Location = new System.Drawing.Point(165, 77);
            this.FirstDiap.Name = "FirstDiap";
            this.FirstDiap.Size = new System.Drawing.Size(52, 27);
            this.FirstDiap.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(135, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "от";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Диапазон чисел:";
            // 
            // ColumnCounts
            // 
            this.ColumnCounts.Location = new System.Drawing.Point(341, 35);
            this.ColumnCounts.Name = "ColumnCounts";
            this.ColumnCounts.Size = new System.Drawing.Size(50, 27);
            this.ColumnCounts.TabIndex = 2;
            // 
            // RowCounts
            // 
            this.RowCounts.Location = new System.Drawing.Point(274, 35);
            this.RowCounts.Name = "RowCounts";
            this.RowCounts.Size = new System.Drawing.Size(52, 27);
            this.RowCounts.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(262, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Количество строк и столбцав соотв.:";
            // 
            // FindSPoint
            // 
            this.FindSPoint.Location = new System.Drawing.Point(416, 155);
            this.FindSPoint.Name = "FindSPoint";
            this.FindSPoint.Size = new System.Drawing.Size(114, 29);
            this.FindSPoint.TabIndex = 8;
            this.FindSPoint.Text = "Определить";
            this.FindSPoint.UseVisualStyleBackColor = true;
            this.FindSPoint.Click += new System.EventHandler(this.FindSPoint_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView2.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.ColumnHeadersVisible = false;
            this.dataGridView2.Location = new System.Drawing.Point(536, 85);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersVisible = false;
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 29;
            this.dataGridView2.Size = new System.Drawing.Size(300, 188);
            this.dataGridView2.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(856, 385);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.FindSPoint);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Программа определяет седловые точки в массиве";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox1;
        private Label label1;
        private DataGridView dataGridView1;
        private Button Generate;
        private TextBox LastDiap;
        private Label label4;
        private TextBox FirstDiap;
        private Label label3;
        private Label label2;
        private TextBox ColumnCounts;
        private TextBox RowCounts;
        private Button FindSPoint;
        private DataGridView dataGridView2;
    }
}