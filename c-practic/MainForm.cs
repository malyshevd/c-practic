using c_practic.Controls;
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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            InitControls();
        }

        private void InitControls()
        {
            calcComplexNthRootsControl.СalculationСompleted += CalcComplexNthRootsControl_СalculationСompleted;
        }

        private void CalcComplexNthRootsControl_СalculationСompleted(object sender, string answer)
        {
            CalcComplexNthRootsControl control = sender as CalcComplexNthRootsControl;
            var confirmResult = MessageBox.Show("Показать график", "Подтверждение", MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                new DrawComplexRootsForm(control.LastCalcRoots, 100, $"График для корня {control.NtxRootValue}-ст. компл. числа: {control.CurentComplexStr}").ShowDialog();
            }
        }

        private void btnShowGraph_Click(object sender, EventArgs e)
        {
            new DrawComplexRootsForm(calcComplexNthRootsControl.LastCalcRoots, 100, "Test").ShowDialog();
        }
    }
}
