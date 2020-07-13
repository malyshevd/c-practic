using c_practic.Extensions;
using System;
using System.Data;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Windows.Forms;

namespace c_practic.Controls
{
    public partial class CalcComplexNthRootsControl : UserControl
    {
        public Complex CurentComplex => new Complex((double)numReal.Value, (double)numImaginary.Value);
        public int Decimals => (int)numDecimals.Value;
        public string CurentComplexStr => CurentComplex.ToString(Decimals);
        public int NtxRootValue => (int)numNtxRoot.Value;
        public Complex[] LastCalcRoots { get; private set; }
        public event Action<object, string> СalculationСompleted;

        public CalcComplexNthRootsControl()
        {
            InitializeComponent();
            InitControls();
        }

        private void InitControls()
        {
            numReal.Minimum = numImaginary.Minimum = decimal.MinValue;
            numReal.Maximum = numImaginary.Maximum = decimal.MaxValue;
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            LastCalcRoots = CurentComplex.CalcNthRoots(NtxRootValue)
                .Select(c => new Complex(Math.Round(c.Real, Decimals), Math.Round(c.Imaginary, Decimals))).ToArray();
            StringBuilder sbResult = new StringBuilder();
            sbResult.AppendLine($"Комплексное число: {CurentComplexStr}");
            sbResult.AppendLine($"Степень вычисляемого корня: {(int)numNtxRoot.Value}");
            sbResult.AppendLine();
            for (int i = 0; i < LastCalcRoots.Length; i++)
            {
                sbResult.AppendLine($"Корень №{i + 1}: {LastCalcRoots[i].ToString(Decimals)}");
            }
            rtbResult.Text = sbResult.ToString();

            СalculationСompleted?.Invoke(this, rtbResult.Text);
        }
    }
}
