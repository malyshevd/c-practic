namespace c_practic.Controls
{
    partial class CalcComplexNthRootsControl
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelHeader = new System.Windows.Forms.Label();
            this.labelReal = new System.Windows.Forms.Label();
            this.labelImaginary = new System.Windows.Forms.Label();
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.labelDecimals = new System.Windows.Forms.Label();
            this.numImaginary = new System.Windows.Forms.NumericUpDown();
            this.labelNthRoot = new System.Windows.Forms.Label();
            this.numReal = new System.Windows.Forms.NumericUpDown();
            this.numNtxRoot = new System.Windows.Forms.NumericUpDown();
            this.numDecimals = new System.Windows.Forms.NumericUpDown();
            this.btnCalc = new System.Windows.Forms.Button();
            this.rtbResult = new System.Windows.Forms.RichTextBox();
            this.tableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numImaginary)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numReal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numNtxRoot)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDecimals)).BeginInit();
            this.SuspendLayout();
            // 
            // labelHeader
            // 
            this.labelHeader.AutoSize = true;
            this.labelHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelHeader.Location = new System.Drawing.Point(17, 9);
            this.labelHeader.Name = "labelHeader";
            this.labelHeader.Size = new System.Drawing.Size(438, 16);
            this.labelHeader.TabIndex = 0;
            this.labelHeader.Text = "Вычисление корней n-ой степени из комплексного числа ";
            // 
            // labelReal
            // 
            this.labelReal.AutoSize = true;
            this.labelReal.Location = new System.Drawing.Point(3, 0);
            this.labelReal.Name = "labelReal";
            this.labelReal.Size = new System.Drawing.Size(155, 13);
            this.labelReal.TabIndex = 1;
            this.labelReal.Text = "Действительная часть числа";
            // 
            // labelImaginary
            // 
            this.labelImaginary.AutoSize = true;
            this.labelImaginary.Location = new System.Drawing.Point(3, 24);
            this.labelImaginary.Name = "labelImaginary";
            this.labelImaginary.Size = new System.Drawing.Size(111, 13);
            this.labelImaginary.TabIndex = 2;
            this.labelImaginary.Text = "Мнимая часть числа";
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tableLayoutPanel.ColumnCount = 2;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 58.25826F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 41.74174F));
            this.tableLayoutPanel.Controls.Add(this.labelDecimals, 0, 3);
            this.tableLayoutPanel.Controls.Add(this.numImaginary, 1, 1);
            this.tableLayoutPanel.Controls.Add(this.labelReal, 0, 0);
            this.tableLayoutPanel.Controls.Add(this.labelImaginary, 0, 1);
            this.tableLayoutPanel.Controls.Add(this.labelNthRoot, 0, 2);
            this.tableLayoutPanel.Controls.Add(this.numReal, 1, 0);
            this.tableLayoutPanel.Controls.Add(this.numNtxRoot, 1, 2);
            this.tableLayoutPanel.Controls.Add(this.numDecimals, 1, 3);
            this.tableLayoutPanel.Location = new System.Drawing.Point(18, 29);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 4;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 47.45763F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 52.54237F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.tableLayoutPanel.Size = new System.Drawing.Size(333, 107);
            this.tableLayoutPanel.TabIndex = 3;
            // 
            // labelDecimals
            // 
            this.labelDecimals.AutoSize = true;
            this.labelDecimals.Location = new System.Drawing.Point(3, 77);
            this.labelDecimals.Name = "labelDecimals";
            this.labelDecimals.Size = new System.Drawing.Size(169, 26);
            this.labelDecimals.TabIndex = 7;
            this.labelDecimals.Text = "Кол-во знаков после запятой в результате вычислений";
            // 
            // numImaginary
            // 
            this.numImaginary.DecimalPlaces = 2;
            this.numImaginary.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numImaginary.Location = new System.Drawing.Point(197, 27);
            this.numImaginary.Name = "numImaginary";
            this.numImaginary.Size = new System.Drawing.Size(120, 20);
            this.numImaginary.TabIndex = 5;
            // 
            // labelNthRoot
            // 
            this.labelNthRoot.AutoSize = true;
            this.labelNthRoot.Location = new System.Drawing.Point(3, 50);
            this.labelNthRoot.Name = "labelNthRoot";
            this.labelNthRoot.Size = new System.Drawing.Size(82, 13);
            this.labelNthRoot.TabIndex = 3;
            this.labelNthRoot.Text = "Степень корня";
            // 
            // numReal
            // 
            this.numReal.DecimalPlaces = 2;
            this.numReal.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numReal.Location = new System.Drawing.Point(197, 3);
            this.numReal.Name = "numReal";
            this.numReal.Size = new System.Drawing.Size(120, 20);
            this.numReal.TabIndex = 4;
            // 
            // numNtxRoot
            // 
            this.numNtxRoot.Location = new System.Drawing.Point(197, 53);
            this.numNtxRoot.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numNtxRoot.Name = "numNtxRoot";
            this.numNtxRoot.Size = new System.Drawing.Size(120, 20);
            this.numNtxRoot.TabIndex = 6;
            this.numNtxRoot.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // numDecimals
            // 
            this.numDecimals.Location = new System.Drawing.Point(197, 80);
            this.numDecimals.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numDecimals.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numDecimals.Name = "numDecimals";
            this.numDecimals.Size = new System.Drawing.Size(120, 20);
            this.numDecimals.TabIndex = 8;
            this.numDecimals.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            // 
            // btnCalc
            // 
            this.btnCalc.Location = new System.Drawing.Point(357, 28);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(96, 108);
            this.btnCalc.TabIndex = 4;
            this.btnCalc.Text = "Вычислить";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // rtbResult
            // 
            this.rtbResult.Location = new System.Drawing.Point(18, 142);
            this.rtbResult.Name = "rtbResult";
            this.rtbResult.ReadOnly = true;
            this.rtbResult.Size = new System.Drawing.Size(435, 130);
            this.rtbResult.TabIndex = 5;
            this.rtbResult.Text = "";
            // 
            // CalcComplexNthRootsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.rtbResult);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.tableLayoutPanel);
            this.Controls.Add(this.labelHeader);
            this.Name = "CalcComplexNthRootsControl";
            this.Size = new System.Drawing.Size(466, 295);
            this.tableLayoutPanel.ResumeLayout(false);
            this.tableLayoutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numImaginary)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numReal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numNtxRoot)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDecimals)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelHeader;
        private System.Windows.Forms.Label labelReal;
        private System.Windows.Forms.Label labelImaginary;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private System.Windows.Forms.NumericUpDown numImaginary;
        private System.Windows.Forms.Label labelNthRoot;
        private System.Windows.Forms.NumericUpDown numReal;
        private System.Windows.Forms.NumericUpDown numNtxRoot;
        private System.Windows.Forms.Label labelDecimals;
        private System.Windows.Forms.NumericUpDown numDecimals;
        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.RichTextBox rtbResult;
    }
}
