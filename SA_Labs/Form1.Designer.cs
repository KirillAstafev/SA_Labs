namespace SA_Labs
{
    partial class MainForm
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.vertexComboBox = new System.Windows.Forms.ComboBox();
            this.matrixLabel = new System.Windows.Forms.Label();
            this.matrixDataGrid = new System.Windows.Forms.DataGridView();
            this.vertexCountLabel = new System.Windows.Forms.Label();
            this.matrixCalcButton = new System.Windows.Forms.Button();
            this.setCalcButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.resultMatrixDataGrid = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.resultSetDataGrid = new System.Windows.Forms.DataGridView();
            this.graphCheckBox = new System.Windows.Forms.CheckBox();
            this.edgeComboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.matrixDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.resultMatrixDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.resultSetDataGrid)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.edgeComboBox);
            this.tabPage1.Controls.Add(this.graphCheckBox);
            this.tabPage1.Controls.Add(this.resultSetDataGrid);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.resultMatrixDataGrid);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.setCalcButton);
            this.tabPage1.Controls.Add(this.matrixCalcButton);
            this.tabPage1.Controls.Add(this.vertexCountLabel);
            this.tabPage1.Controls.Add(this.matrixDataGrid);
            this.tabPage1.Controls.Add(this.matrixLabel);
            this.tabPage1.Controls.Add(this.vertexComboBox);
            this.tabPage1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(941, 563);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "ЛР 1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // vertexComboBox
            // 
            this.vertexComboBox.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.vertexComboBox.FormattingEnabled = true;
            this.vertexComboBox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.vertexComboBox.Location = new System.Drawing.Point(6, 25);
            this.vertexComboBox.Name = "vertexComboBox";
            this.vertexComboBox.Size = new System.Drawing.Size(156, 23);
            this.vertexComboBox.TabIndex = 1;
            this.vertexComboBox.SelectedIndexChanged += new System.EventHandler(this.comboBox_SelectedIndexChanged);
            // 
            // matrixLabel
            // 
            this.matrixLabel.AutoSize = true;
            this.matrixLabel.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.matrixLabel.Location = new System.Drawing.Point(6, 76);
            this.matrixLabel.Name = "matrixLabel";
            this.matrixLabel.Size = new System.Drawing.Size(208, 21);
            this.matrixLabel.TabIndex = 3;
            this.matrixLabel.Text = "Матрица инцидентности";
            // 
            // matrixDataGrid
            // 
            this.matrixDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.matrixDataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.matrixDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.matrixDataGrid.Location = new System.Drawing.Point(6, 100);
            this.matrixDataGrid.Name = "matrixDataGrid";
            this.matrixDataGrid.Size = new System.Drawing.Size(517, 351);
            this.matrixDataGrid.TabIndex = 0;
            // 
            // vertexCountLabel
            // 
            this.vertexCountLabel.AutoSize = true;
            this.vertexCountLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.vertexCountLabel.Location = new System.Drawing.Point(6, 3);
            this.vertexCountLabel.Name = "vertexCountLabel";
            this.vertexCountLabel.Size = new System.Drawing.Size(145, 19);
            this.vertexCountLabel.TabIndex = 2;
            this.vertexCountLabel.Text = "Количество вершин";
            // 
            // matrixCalcButton
            // 
            this.matrixCalcButton.AutoSize = true;
            this.matrixCalcButton.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.matrixCalcButton.Location = new System.Drawing.Point(6, 457);
            this.matrixCalcButton.Name = "matrixCalcButton";
            this.matrixCalcButton.Size = new System.Drawing.Size(244, 31);
            this.matrixCalcButton.TabIndex = 4;
            this.matrixCalcButton.Text = "Найти матрицу смежности";
            this.matrixCalcButton.UseVisualStyleBackColor = true;
            this.matrixCalcButton.Click += new System.EventHandler(this.matrixCalcButton_Click);
            // 
            // setCalcButton
            // 
            this.setCalcButton.AutoSize = true;
            this.setCalcButton.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.setCalcButton.Location = new System.Drawing.Point(6, 494);
            this.setCalcButton.Name = "setCalcButton";
            this.setCalcButton.Size = new System.Drawing.Size(391, 31);
            this.setCalcButton.TabIndex = 5;
            this.setCalcButton.Text = "Сгенерировать множество левых инциденций";
            this.setCalcButton.UseVisualStyleBackColor = true;
            this.setCalcButton.Click += new System.EventHandler(this.setCalcButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(525, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 19);
            this.label1.TabIndex = 6;
            this.label1.Text = "Матрица смежности";
            // 
            // resultMatrixDataGrid
            // 
            this.resultMatrixDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.resultMatrixDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.resultMatrixDataGrid.Location = new System.Drawing.Point(529, 29);
            this.resultMatrixDataGrid.Name = "resultMatrixDataGrid";
            this.resultMatrixDataGrid.Size = new System.Drawing.Size(406, 250);
            this.resultMatrixDataGrid.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(525, 282);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(224, 19);
            this.label2.TabIndex = 8;
            this.label2.Text = "Множество левых инциденций";
            // 
            // resultSetDataGrid
            // 
            this.resultSetDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.resultSetDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.resultSetDataGrid.Location = new System.Drawing.Point(529, 304);
            this.resultSetDataGrid.Name = "resultSetDataGrid";
            this.resultSetDataGrid.Size = new System.Drawing.Size(406, 250);
            this.resultSetDataGrid.TabIndex = 9;
            // 
            // graphCheckBox
            // 
            this.graphCheckBox.AutoSize = true;
            this.graphCheckBox.Location = new System.Drawing.Point(7, 532);
            this.graphCheckBox.Name = "graphCheckBox";
            this.graphCheckBox.Size = new System.Drawing.Size(192, 23);
            this.graphCheckBox.TabIndex = 10;
            this.graphCheckBox.Text = "Ориентированный граф";
            this.graphCheckBox.UseVisualStyleBackColor = true;
            // 
            // edgeComboBox
            // 
            this.edgeComboBox.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.edgeComboBox.FormattingEnabled = true;
            this.edgeComboBox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30"});
            this.edgeComboBox.Location = new System.Drawing.Point(169, 25);
            this.edgeComboBox.Name = "edgeComboBox";
            this.edgeComboBox.Size = new System.Drawing.Size(164, 23);
            this.edgeComboBox.TabIndex = 11;
            this.edgeComboBox.SelectedIndexChanged += new System.EventHandler(this.comboBox_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(165, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 19);
            this.label3.TabIndex = 12;
            this.label3.Text = "Количество дуг";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(949, 589);
            this.tabControl1.TabIndex = 4;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(966, 613);
            this.Controls.Add(this.tabControl1);
            this.Name = "MainForm";
            this.Text = "Системный анализ";
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.matrixDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.resultMatrixDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.resultSetDataGrid)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox edgeComboBox;
        private System.Windows.Forms.CheckBox graphCheckBox;
        private System.Windows.Forms.DataGridView resultSetDataGrid;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView resultMatrixDataGrid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button setCalcButton;
        private System.Windows.Forms.Button matrixCalcButton;
        private System.Windows.Forms.Label vertexCountLabel;
        private System.Windows.Forms.DataGridView matrixDataGrid;
        private System.Windows.Forms.Label matrixLabel;
        private System.Windows.Forms.ComboBox vertexComboBox;
        private System.Windows.Forms.TabControl tabControl1;
    }
}

