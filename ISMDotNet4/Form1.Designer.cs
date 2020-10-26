namespace ISMDotNet4
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
            this.buttonGenerate = new System.Windows.Forms.Button();
            this.dataGridArray = new System.Windows.Forms.DataGridView();
            this.labelColvo = new System.Windows.Forms.Label();
            this.textBoxCount = new System.Windows.Forms.TextBox();
            this.dataGridSorted = new System.Windows.Forms.DataGridView();
            this.labelSorted = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridDeleteNegative = new System.Windows.Forms.DataGridView();
            this.labelSumNegative = new System.Windows.Forms.Label();
            this.labelMax = new System.Windows.Forms.Label();
            this.labelMaxByModule = new System.Windows.Forms.Label();
            this.labelSumPositiveIndexes = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridArray)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridSorted)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridDeleteNegative)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonGenerate
            // 
            this.buttonGenerate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGenerate.Location = new System.Drawing.Point(458, 36);
            this.buttonGenerate.Name = "buttonGenerate";
            this.buttonGenerate.Size = new System.Drawing.Size(241, 38);
            this.buttonGenerate.TabIndex = 0;
            this.buttonGenerate.Text = "Создать массив";
            this.buttonGenerate.UseVisualStyleBackColor = true;
            this.buttonGenerate.Click += new System.EventHandler(this.buttonGenerate_Click);
            // 
            // dataGridArray
            // 
            this.dataGridArray.AllowUserToAddRows = false;
            this.dataGridArray.AllowUserToDeleteRows = false;
            this.dataGridArray.AllowUserToResizeRows = false;
            this.dataGridArray.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridArray.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridArray.Location = new System.Drawing.Point(12, 91);
            this.dataGridArray.Name = "dataGridArray";
            this.dataGridArray.RowHeadersWidth = 62;
            this.dataGridArray.RowTemplate.Height = 28;
            this.dataGridArray.Size = new System.Drawing.Size(804, 101);
            this.dataGridArray.TabIndex = 1;
            // 
            // labelColvo
            // 
            this.labelColvo.AutoSize = true;
            this.labelColvo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelColvo.Location = new System.Drawing.Point(161, 45);
            this.labelColvo.Name = "labelColvo";
            this.labelColvo.Size = new System.Drawing.Size(163, 22);
            this.labelColvo.TabIndex = 2;
            this.labelColvo.Text = "К-во элементов:";
            // 
            // textBoxCount
            // 
            this.textBoxCount.Location = new System.Drawing.Point(342, 41);
            this.textBoxCount.Name = "textBoxCount";
            this.textBoxCount.Size = new System.Drawing.Size(100, 26);
            this.textBoxCount.TabIndex = 3;
            this.textBoxCount.Text = "10";
            // 
            // dataGridSorted
            // 
            this.dataGridSorted.AllowUserToAddRows = false;
            this.dataGridSorted.AllowUserToDeleteRows = false;
            this.dataGridSorted.AllowUserToResizeRows = false;
            this.dataGridSorted.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridSorted.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridSorted.Location = new System.Drawing.Point(12, 385);
            this.dataGridSorted.Name = "dataGridSorted";
            this.dataGridSorted.RowHeadersWidth = 62;
            this.dataGridSorted.RowTemplate.Height = 28;
            this.dataGridSorted.Size = new System.Drawing.Size(804, 101);
            this.dataGridSorted.TabIndex = 4;
            // 
            // labelSorted
            // 
            this.labelSorted.AutoSize = true;
            this.labelSorted.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSorted.Location = new System.Drawing.Point(12, 360);
            this.labelSorted.Name = "labelSorted";
            this.labelSorted.Size = new System.Drawing.Size(463, 22);
            this.labelSorted.TabIndex = 5;
            this.labelSorted.Text = "Сортированый массив от большего к меньшему:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 492);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(503, 22);
            this.label1.TabIndex = 7;
            this.label1.Text = "Массив с удаленными отрицательными элементами:";
            // 
            // dataGridDeleteNegative
            // 
            this.dataGridDeleteNegative.AllowUserToAddRows = false;
            this.dataGridDeleteNegative.AllowUserToDeleteRows = false;
            this.dataGridDeleteNegative.AllowUserToResizeRows = false;
            this.dataGridDeleteNegative.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridDeleteNegative.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridDeleteNegative.Location = new System.Drawing.Point(12, 517);
            this.dataGridDeleteNegative.Name = "dataGridDeleteNegative";
            this.dataGridDeleteNegative.RowHeadersWidth = 62;
            this.dataGridDeleteNegative.RowTemplate.Height = 28;
            this.dataGridDeleteNegative.Size = new System.Drawing.Size(804, 101);
            this.dataGridDeleteNegative.TabIndex = 6;
            // 
            // labelSumNegative
            // 
            this.labelSumNegative.AutoSize = true;
            this.labelSumNegative.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSumNegative.Location = new System.Drawing.Point(12, 195);
            this.labelSumNegative.Name = "labelSumNegative";
            this.labelSumNegative.Size = new System.Drawing.Size(344, 22);
            this.labelSumNegative.TabIndex = 8;
            this.labelSumNegative.Text = "Сумма негативных элементов: NAN";
            // 
            // labelMax
            // 
            this.labelMax.AutoSize = true;
            this.labelMax.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMax.Location = new System.Drawing.Point(12, 236);
            this.labelMax.Name = "labelMax";
            this.labelMax.Size = new System.Drawing.Size(535, 22);
            this.labelMax.TabIndex = 9;
            this.labelMax.Text = "Максимальный элемент массива: NAN, его индекс: NAN";
            // 
            // labelMaxByModule
            // 
            this.labelMaxByModule.AutoSize = true;
            this.labelMaxByModule.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMaxByModule.Location = new System.Drawing.Point(12, 274);
            this.labelMaxByModule.Name = "labelMaxByModule";
            this.labelMaxByModule.Size = new System.Drawing.Size(641, 22);
            this.labelMaxByModule.TabIndex = 10;
            this.labelMaxByModule.Text = "Максимальный элемент массива по модулю: NAN, его индекс: NAN";
            // 
            // labelSumPositiveIndexes
            // 
            this.labelSumPositiveIndexes.AutoSize = true;
            this.labelSumPositiveIndexes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSumPositiveIndexes.Location = new System.Drawing.Point(12, 308);
            this.labelSumPositiveIndexes.Name = "labelSumPositiveIndexes";
            this.labelSumPositiveIndexes.Size = new System.Drawing.Size(771, 22);
            this.labelSumPositiveIndexes.TabIndex = 11;
            this.labelSumPositiveIndexes.Text = "Сумма индексов положительных элементов: NAN, количестов целых чисел: NAN";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(828, 630);
            this.Controls.Add(this.labelSumPositiveIndexes);
            this.Controls.Add(this.labelMaxByModule);
            this.Controls.Add(this.labelMax);
            this.Controls.Add(this.labelSumNegative);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridDeleteNegative);
            this.Controls.Add(this.labelSorted);
            this.Controls.Add(this.dataGridSorted);
            this.Controls.Add(this.textBoxCount);
            this.Controls.Add(this.labelColvo);
            this.Controls.Add(this.dataGridArray);
            this.Controls.Add(this.buttonGenerate);
            this.MinimumSize = new System.Drawing.Size(850, 686);
            this.Name = "Form1";
            this.Text = "ISMDotNet4 by Yehor Ovseukov";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridArray)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridSorted)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridDeleteNegative)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonGenerate;
        private System.Windows.Forms.DataGridView dataGridArray;
        private System.Windows.Forms.Label labelColvo;
        private System.Windows.Forms.TextBox textBoxCount;
        private System.Windows.Forms.DataGridView dataGridSorted;
        private System.Windows.Forms.Label labelSorted;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridDeleteNegative;
        private System.Windows.Forms.Label labelSumNegative;
        private System.Windows.Forms.Label labelMax;
        private System.Windows.Forms.Label labelMaxByModule;
        private System.Windows.Forms.Label labelSumPositiveIndexes;
    }
}

