namespace c_practic.Controls
{
    partial class CalcSLAE_ByCholeskyMethodControl
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
            this.labelCountVariables = new System.Windows.Forms.Label();
            this.numCountVariables = new System.Windows.Forms.NumericUpDown();
            this.btnGenerateMatrixSLAE = new System.Windows.Forms.Button();
            this.panelMatrixSLAE = new System.Windows.Forms.Panel();
            this.cbHelpFillSymmetricMatrix = new System.Windows.Forms.CheckBox();
            this.cbCheckSymmetricallyPositiveDefiniteMatrix = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.numCountVariables)).BeginInit();
            this.SuspendLayout();
            // 
            // labelCountVariables
            // 
            this.labelCountVariables.AutoSize = true;
            this.labelCountVariables.Location = new System.Drawing.Point(3, 9);
            this.labelCountVariables.Name = "labelCountVariables";
            this.labelCountVariables.Size = new System.Drawing.Size(135, 13);
            this.labelCountVariables.TabIndex = 0;
            this.labelCountVariables.Text = "Количество переменных:";
            // 
            // numCountVariables
            // 
            this.numCountVariables.Location = new System.Drawing.Point(144, 7);
            this.numCountVariables.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numCountVariables.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numCountVariables.Name = "numCountVariables";
            this.numCountVariables.Size = new System.Drawing.Size(120, 20);
            this.numCountVariables.TabIndex = 1;
            this.numCountVariables.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // btnGenerateMatrixSLAE
            // 
            this.btnGenerateMatrixSLAE.Location = new System.Drawing.Point(285, 6);
            this.btnGenerateMatrixSLAE.Name = "btnGenerateMatrixSLAE";
            this.btnGenerateMatrixSLAE.Size = new System.Drawing.Size(178, 23);
            this.btnGenerateMatrixSLAE.TabIndex = 2;
            this.btnGenerateMatrixSLAE.Text = "Сформировать матрицу СЛАУ";
            this.btnGenerateMatrixSLAE.UseVisualStyleBackColor = true;
            this.btnGenerateMatrixSLAE.Click += new System.EventHandler(this.btnGenerateMatrixSLAE_Click);
            // 
            // panelMatrixSLAE
            // 
            this.panelMatrixSLAE.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelMatrixSLAE.Location = new System.Drawing.Point(3, 74);
            this.panelMatrixSLAE.Name = "panelMatrixSLAE";
            this.panelMatrixSLAE.Size = new System.Drawing.Size(634, 259);
            this.panelMatrixSLAE.TabIndex = 3;
            // 
            // cbHelpFillSymmetricMatrix
            // 
            this.cbHelpFillSymmetricMatrix.AutoSize = true;
            this.cbHelpFillSymmetricMatrix.Location = new System.Drawing.Point(6, 33);
            this.cbHelpFillSymmetricMatrix.Name = "cbHelpFillSymmetricMatrix";
            this.cbHelpFillSymmetricMatrix.Size = new System.Drawing.Size(262, 17);
            this.cbHelpFillSymmetricMatrix.TabIndex = 4;
            this.cbHelpFillSymmetricMatrix.Text = "Помочь с заполнение симметричной матрицы";
            this.cbHelpFillSymmetricMatrix.UseVisualStyleBackColor = true;
            // 
            // cbCheckSymmetricallyPositiveDefiniteMatrix
            // 
            this.cbCheckSymmetricallyPositiveDefiniteMatrix.AutoSize = true;
            this.cbCheckSymmetricallyPositiveDefiniteMatrix.Location = new System.Drawing.Point(6, 56);
            this.cbCheckSymmetricallyPositiveDefiniteMatrix.Name = "cbCheckSymmetricallyPositiveDefiniteMatrix";
            this.cbCheckSymmetricallyPositiveDefiniteMatrix.Size = new System.Drawing.Size(407, 17);
            this.cbCheckSymmetricallyPositiveDefiniteMatrix.TabIndex = 5;
            this.cbCheckSymmetricallyPositiveDefiniteMatrix.Text = "Порверять матрицу на симметричность и положительную-определённость\r\n";
            this.cbCheckSymmetricallyPositiveDefiniteMatrix.UseVisualStyleBackColor = true;
            // 
            // CalcSLAE_ByCholeskyMethodControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cbCheckSymmetricallyPositiveDefiniteMatrix);
            this.Controls.Add(this.cbHelpFillSymmetricMatrix);
            this.Controls.Add(this.panelMatrixSLAE);
            this.Controls.Add(this.btnGenerateMatrixSLAE);
            this.Controls.Add(this.numCountVariables);
            this.Controls.Add(this.labelCountVariables);
            this.Name = "CalcSLAE_ByCholeskyMethodControl";
            this.Size = new System.Drawing.Size(640, 336);
            ((System.ComponentModel.ISupportInitialize)(this.numCountVariables)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelCountVariables;
        private System.Windows.Forms.NumericUpDown numCountVariables;
        private System.Windows.Forms.Button btnGenerateMatrixSLAE;
        private System.Windows.Forms.Panel panelMatrixSLAE;
        private System.Windows.Forms.CheckBox cbHelpFillSymmetricMatrix;
        private System.Windows.Forms.CheckBox cbCheckSymmetricallyPositiveDefiniteMatrix;
    }
}
