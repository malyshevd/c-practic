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
        private DrawComplexRootsForm drawComplexRootsForm;
        public MainForm()
        {
            InitializeComponent();
            InitControls();
        }

        private void InitControls()
        {
            drawComplexRootsForm = new DrawComplexRootsForm();
            calcComplexNthRootsControl.СalculationСompleted += CalcComplexNthRootsControl_СalculationСompleted;
        }

        private void CalcComplexNthRootsControl_СalculationСompleted(object sender, string answer)
        {
            CalcComplexNthRootsControl control = sender as CalcComplexNthRootsControl;
            var confirmResult = MessageBox.Show("Показать график", "Подтверждение", MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                drawComplexRootsForm.SetParameters(control.LastCalcRoots, control.Decimals, title: $"График для корня {control.NtxRootValue}-ст. компл. числа: {control.CurentComplexStr}");
                drawComplexRootsForm.ShowDialog();
            }
        }
    }
}
