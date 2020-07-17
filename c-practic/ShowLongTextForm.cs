using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace c_practic
{
    public partial class ShowLongTextForm : Form
    {
        public ShowLongTextForm()
        {
            InitializeComponent();
        }

        public ShowLongTextForm(string text, string header = null) : this()
        {
            SetText(text, header);
        }

        public void SetText(string text, string header = null)
        {
            Text = !string.IsNullOrEmpty(header) ? header : Text;
            rtbText.Text = text;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
