using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using c_practic.Extensions;
using System.Text.RegularExpressions;

namespace c_practic.Controls
{
    public partial class CalcSLAE_ByCholeskyMethodControl : UserControl
    {
        private int CntVariables => (int)numCountVariables.Value;
        private NumericUpDown[,] MatrixA;
        private NumericUpDown[] ResultB;
        private const string matrixItemName = "matrixItem[{0},{1}]";
        private const string matrixItemNameRowNumberKey = "rowNumber";
        private const string matrixItemNameColumnNumberKey = "columnNumber";
        private string matrixItemNameRegexPattern => $@"matrixItem\[(?<{matrixItemNameRowNumberKey}>\d+),(?<{matrixItemNameColumnNumberKey}>\d+)\]";
        public CalcSLAE_ByCholeskyMethodControl()
        {
            InitializeComponent();
        }

        private double[,] GetValueMatrixA()
        {
            double[,] val = new double[MatrixA?.GetLength(0) ?? 0, MatrixA?.GetLength(1) ?? 0];
            for (int r = 0; r < val?.GetLength(0); r++)
            {
                for (int c = 0; c < val?.GetLength(1); c++)
                {
                    val[r, c] = (double)MatrixA[r, c].Value;
                }
            }

            return val;
        }

        private double[] GetValueResultB()
        {
            return ResultB.Select(r => (double)r.Value).ToArray();
        }

        private void btnGenerateMatrixSLAE_Click(object sender, EventArgs e)
        {
            //генерируем матрицу СЛАУ
            MatrixA = new NumericUpDown[CntVariables, CntVariables];
            ResultB = new NumericUpDown[CntVariables];
            //создаем контрол табличного размещения
            //ширина и высота равны ширине и высоте основной панели
            TableLayoutPanel tableLayoutPanel = new TableLayoutPanel()
            {
                Width = panelMatrixSLAE.Width,
                Height = panelMatrixSLAE.Height,
                Anchor = AnchorStyles.Left | AnchorStyles.Top | AnchorStyles.Right | AnchorStyles.Bottom,
                AutoScroll = true,
                CellBorderStyle = TableLayoutPanelCellBorderStyle.Inset
            };

            //Стили колонок и строк
            TableLayoutColumnStyleCollection csc = tableLayoutPanel.ColumnStyles;
            TableLayoutRowStyleCollection rsc = tableLayoutPanel.RowStyles;

            tableLayoutPanel.ColumnCount = CntVariables + 1;//кол-во колонок = размер матрицы + столбец для результатов
            tableLayoutPanel.RowCount = CntVariables + 2;//кол-во строк = размер матрицы + строка для заголовка + строка для кнопки расчета

            //создаем и вставляем заголовок для матрицы
            Label labelMatrixA = new Label()
            {
                Text = "Матрица А",
                AutoSize = true,
                Dock = DockStyle.Fill,
                TextAlign = ContentAlignment.TopCenter
            };
            tableLayoutPanel.Controls.Add(labelMatrixA, 0, 0);
            tableLayoutPanel.SetColumnSpan(labelMatrixA, CntVariables);
            //для заголовка стили размеров автоматические
            csc.Add(new ColumnStyle(SizeType.Percent, 100f / (CntVariables + 1)));
            rsc.Add(new ColumnStyle(SizeType.AutoSize));

            int tabIndex = 0;//проставляем TabIndex

            //создаем контролы для матрицы СЛАУ
            for (int r = 0; r < CntVariables; r++)
            {
                csc.Add(new ColumnStyle(SizeType.Percent, 100f / (CntVariables + 1)));
                for (int c = 0; c < CntVariables; c++)
                {
                    MatrixA[r, c] = CreateNumericUpDown(tabIndex++);
                    MatrixA[r, c].Name = string.Format(matrixItemName, r, c);
                    if (r != c) // Для быстрого заполнения симметричной матрицы добавляем событие отзеркаливания значения при его изменении
                    {
                        MatrixA[r, c].ValueChanged += NumericValueChanged_HelpFillSymmetricMatrix;
                    }
                    tableLayoutPanel.Controls.Add(MatrixA[r, c], c, r + 1);
                }
                tabIndex++;
            }

            //создаем и втсавляем заголовок для результатов
            Label labelResultB = new Label()
            {
                Text = "Результат B",
                AutoSize = true,
                Dock = DockStyle.Fill,
                TextAlign = ContentAlignment.TopCenter
            };
            tableLayoutPanel.Controls.Add(labelResultB, CntVariables, 0);
            //добавляем контролы результатов
            tabIndex = -1;
            for (int i = 0; i < CntVariables; i++)
            {
                ResultB[i] = CreateNumericUpDown(tabIndex += CntVariables + 1, Color.LightBlue);
                rsc.Add(new ColumnStyle(SizeType.Percent, 100f / (CntVariables + 1)));
                tableLayoutPanel.Controls.Add(ResultB[i], CntVariables, i + 1);
            }
            //создаем кнопку для расчета СЛАУ и вставляем в контрол табличного размещения
            Button btnCalc = new Button()
            {
                Text = "Решить",
                Anchor = AnchorStyles.None,
                Dock = DockStyle.Fill,
                AutoSize = true
            };
            btnCalc.Click += BtnCalc_Click;
            tableLayoutPanel.Controls.Add(btnCalc, 0, tableLayoutPanel.RowCount - 1);
            tableLayoutPanel.SetColumnSpan(btnCalc, tableLayoutPanel.ColumnCount);


            panelMatrixSLAE.Controls.Clear(); //очищаем панель
            panelMatrixSLAE.Controls.Add(tableLayoutPanel); // вставляем матрицу СЛАУ

            MatrixA[0, 0].Focus();//делаем активным первый элемент в матрице
        }

        private void NumericValueChanged_HelpFillSymmetricMatrix(object sender, EventArgs e)
        {
            if (cbHelpFillSymmetricMatrix.Checked)
            {
                NumericUpDown curNum = sender as NumericUpDown;
                Regex reg = new Regex(matrixItemNameRegexPattern);
                Match match = reg.Match(curNum?.Name);
                if (match.Success)
                {
                    if (int.TryParse(match.Groups[matrixItemNameRowNumberKey]?.Value, out int row)
                        && int.TryParse(match.Groups[matrixItemNameColumnNumberKey]?.Value, out int column)
                        && curNum.Value != MatrixA[column, row].Value)
                    {
                        MatrixA[column, row].Value = curNum.Value;
                    }
                }
            }
        }

        private NumericUpDown CreateNumericUpDown(int tabIndex, Color? backColor = null)
        {
            NumericUpDown numeric = new NumericUpDown()
            {
                Minimum = -999,
                Maximum = 999,
                DecimalPlaces = 2,
                Value = 0,
                Anchor = AnchorStyles.None,
                TabIndex = tabIndex,
                BackColor = backColor ?? Color.White
            };
            //Выделяем значение в контроле при получение фокуса при табуляции
            numeric.Enter += (s, e) =>
            {
                NumericUpDown nud = s as NumericUpDown;
                nud.Select(0, nud.Text.Length);
            };
            numeric.MouseClick += (s, e) =>
            {
                NumericUpDown nud = s as NumericUpDown;
                nud.Select(0, nud.Text.Length);
            };

            return numeric;
        }
        private void BtnCalc_Click(object sender, EventArgs e)
        {
            double[,] valueMatrixA = GetValueMatrixA();
            if(cbCheckSymmetricallyPositiveDefiniteMatrix.Checked && valueMatrixA?.IsSymmetricallyPositiveDefiniteMatrix() != true)
            {
                MessageBox.Show("Матрица А НЕ является симметричной положительно-определённой матрице", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string solution = string.Empty;
            double[] x = valueMatrixA?.CalcSLAE_ByCholesky(GetValueResultB(), out solution, 3);
            string answer = $"Ответ: {string.Join(", ", x.Select((val, i) => $"x{i + 1} = {val}").ToArray())}" +
                Environment.NewLine +
                $"Показать подробности решения?";
            if(MessageBox.Show(answer,"Ответ",MessageBoxButtons.YesNo,MessageBoxIcon.Information) == DialogResult.Yes)
            {
                new ShowLongTextForm(solution, "Подробности решения").ShowDialog();
            }
        }
    }
}
