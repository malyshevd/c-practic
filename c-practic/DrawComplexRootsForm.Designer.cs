namespace c_practic
{
    partial class DrawComplexRootsForm
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
            this.panelSettings = new System.Windows.Forms.Panel();
            this.btnScaleRise = new System.Windows.Forms.Button();
            this.btnScaleDdecrease = new System.Windows.Forms.Button();
            this.labelScale = new System.Windows.Forms.Label();
            this.cbShowGrid = new System.Windows.Forms.CheckBox();
            this.panelSettings.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelSettings
            // 
            this.panelSettings.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panelSettings.Controls.Add(this.cbShowGrid);
            this.panelSettings.Controls.Add(this.labelScale);
            this.panelSettings.Controls.Add(this.btnScaleDdecrease);
            this.panelSettings.Controls.Add(this.btnScaleRise);
            this.panelSettings.Location = new System.Drawing.Point(596, 1);
            this.panelSettings.Name = "panelSettings";
            this.panelSettings.Size = new System.Drawing.Size(202, 62);
            this.panelSettings.TabIndex = 0;
            // 
            // btnScaleRise
            // 
            this.btnScaleRise.Location = new System.Drawing.Point(74, 3);
            this.btnScaleRise.Name = "btnScaleRise";
            this.btnScaleRise.Size = new System.Drawing.Size(55, 23);
            this.btnScaleRise.TabIndex = 0;
            this.btnScaleRise.Text = "+";
            this.btnScaleRise.UseVisualStyleBackColor = true;
            this.btnScaleRise.Click += new System.EventHandler(this.btnScaleRise_Click);
            // 
            // btnScaleDdecrease
            // 
            this.btnScaleDdecrease.Location = new System.Drawing.Point(135, 3);
            this.btnScaleDdecrease.Name = "btnScaleDdecrease";
            this.btnScaleDdecrease.Size = new System.Drawing.Size(55, 23);
            this.btnScaleDdecrease.TabIndex = 1;
            this.btnScaleDdecrease.Text = "-";
            this.btnScaleDdecrease.UseVisualStyleBackColor = true;
            this.btnScaleDdecrease.Click += new System.EventHandler(this.btnScaleDdecrease_Click);
            // 
            // labelScale
            // 
            this.labelScale.AutoSize = true;
            this.labelScale.Location = new System.Drawing.Point(15, 8);
            this.labelScale.Name = "labelScale";
            this.labelScale.Size = new System.Drawing.Size(53, 13);
            this.labelScale.TabIndex = 2;
            this.labelScale.Text = "Масштаб";
            // 
            // cbShowGrid
            // 
            this.cbShowGrid.AutoSize = true;
            this.cbShowGrid.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cbShowGrid.Location = new System.Drawing.Point(14, 32);
            this.cbShowGrid.Name = "cbShowGrid";
            this.cbShowGrid.Size = new System.Drawing.Size(106, 17);
            this.cbShowGrid.TabIndex = 3;
            this.cbShowGrid.Text = "Показать сетку";
            this.cbShowGrid.UseVisualStyleBackColor = true;
            this.cbShowGrid.CheckedChanged += new System.EventHandler(this.cbShowGrid_CheckedChanged);
            // 
            // DrawComplexRootsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelSettings);
            this.Name = "DrawComplexRootsForm";
            this.Text = "DrawCoplexRoots";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.DrawPolygonForm_Paint);
            this.panelSettings.ResumeLayout(false);
            this.panelSettings.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelSettings;
        private System.Windows.Forms.Button btnScaleDdecrease;
        private System.Windows.Forms.Button btnScaleRise;
        private System.Windows.Forms.CheckBox cbShowGrid;
        private System.Windows.Forms.Label labelScale;
    }
}