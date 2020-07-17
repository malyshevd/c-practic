namespace c_practic
{
    partial class MainForm
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
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tbComplexRoots = new System.Windows.Forms.TabPage();
            this.tbCholesky = new System.Windows.Forms.TabPage();
            this.calcComplexNthRootsControl = new c_practic.Controls.CalcComplexNthRootsControl();
            this.calcSLAE_ByCholeskyMethodControl1 = new c_practic.Controls.CalcSLAE_ByCholeskyMethodControl();
            this.tabControl.SuspendLayout();
            this.tbComplexRoots.SuspendLayout();
            this.tbCholesky.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tbComplexRoots);
            this.tabControl.Controls.Add(this.tbCholesky);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(731, 413);
            this.tabControl.TabIndex = 2;
            // 
            // tbComplexRoots
            // 
            this.tbComplexRoots.Controls.Add(this.calcComplexNthRootsControl);
            this.tbComplexRoots.Location = new System.Drawing.Point(4, 22);
            this.tbComplexRoots.Name = "tbComplexRoots";
            this.tbComplexRoots.Padding = new System.Windows.Forms.Padding(3);
            this.tbComplexRoots.Size = new System.Drawing.Size(723, 387);
            this.tbComplexRoots.TabIndex = 0;
            this.tbComplexRoots.Text = "Корень n-ой степени комплексного числа";
            this.tbComplexRoots.UseVisualStyleBackColor = true;
            // 
            // tbCholesky
            // 
            this.tbCholesky.Controls.Add(this.calcSLAE_ByCholeskyMethodControl1);
            this.tbCholesky.Location = new System.Drawing.Point(4, 22);
            this.tbCholesky.Name = "tbCholesky";
            this.tbCholesky.Padding = new System.Windows.Forms.Padding(3);
            this.tbCholesky.Size = new System.Drawing.Size(723, 387);
            this.tbCholesky.TabIndex = 1;
            this.tbCholesky.Text = "Решение СЛАУ методом Холецкого";
            this.tbCholesky.UseVisualStyleBackColor = true;
            // 
            // calcComplexNthRootsControl
            // 
            this.calcComplexNthRootsControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.calcComplexNthRootsControl.Location = new System.Drawing.Point(6, 6);
            this.calcComplexNthRootsControl.Name = "calcComplexNthRootsControl";
            this.calcComplexNthRootsControl.Size = new System.Drawing.Size(711, 373);
            this.calcComplexNthRootsControl.TabIndex = 0;
            // 
            // calcSLAE_ByCholeskyMethodControl1
            // 
            this.calcSLAE_ByCholeskyMethodControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.calcSLAE_ByCholeskyMethodControl1.Location = new System.Drawing.Point(6, 6);
            this.calcSLAE_ByCholeskyMethodControl1.Name = "calcSLAE_ByCholeskyMethodControl1";
            this.calcSLAE_ByCholeskyMethodControl1.Size = new System.Drawing.Size(709, 373);
            this.calcSLAE_ByCholeskyMethodControl1.TabIndex = 1;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(731, 413);
            this.Controls.Add(this.tabControl);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.tabControl.ResumeLayout(false);
            this.tbComplexRoots.ResumeLayout(false);
            this.tbCholesky.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Controls.CalcComplexNthRootsControl calcComplexNthRootsControl;
        private Controls.CalcSLAE_ByCholeskyMethodControl calcSLAE_ByCholeskyMethodControl1;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tbComplexRoots;
        private System.Windows.Forms.TabPage tbCholesky;
    }
}

