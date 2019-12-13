using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RandomGenerator
{
    public partial class MainForm : Form
    {
        private readonly Random random = new Random((int)DateTime.Now.Ticks);

        private const string HangeulDecimalDigit = "영일이삼사오육칠팔구";
        private readonly string[] HangeulPrimaryNumericUnit = { "천", "백", "십", "" };
        private readonly string[] HangeulSecondaryNumericUnit =
        {
            "", "만", "억", "조",
            "경", "해", "자", "양",
            "구", "간", "정", "재",
            "극", "항하사", "아승기", "나유타",
            "불가사의", "무량대수", "대수", "업"
        };

        public MainForm()
        {
            InitializeComponent();

            // TEST OUTPUT
            /*
            System.Diagnostics.Debug.WriteLine(DecimalToHangeul(1));
            System.Diagnostics.Debug.WriteLine(DecimalToHangeul(1234));
            System.Diagnostics.Debug.WriteLine(DecimalToHangeul(12345));
            System.Diagnostics.Debug.WriteLine(DecimalToHangeul(12345678));
            System.Diagnostics.Debug.WriteLine(DecimalToHangeul(123456789));
            */

            upperBoundUpDown.Maximum = decimal.MaxValue;
            lowerBoundUpDown.Maximum = decimal.MaxValue - 1;
        }

        private void BoundUpDown_ValueChanged(object sender, EventArgs e)
        {
            if (sender.Equals(upperBoundUpDown))
            {
                if (upperBoundUpDown.Value <= lowerBoundUpDown.Value)
                {
                    lowerBoundUpDown.Value = upperBoundUpDown.Value - 1;
                }
            }
            else
            {
                if (upperBoundUpDown.Value <= lowerBoundUpDown.Value)
                {
                    upperBoundUpDown.Value = lowerBoundUpDown.Value + 1;
                }
            }
        }

        private void UnitUpDown_ValueChanged(object sender, EventArgs e)
        {
            if (unitUpDown.Value == 0)
            {
                curUnitLabel.Text = "(일)";
            }
            else
            {
                string str = DecimalToHangeul((decimal)Math.Pow(10, (double)unitUpDown.Value));
                curUnitLabel.Text = $"({str.Substring(1, str.Length - 1)})";
            }
        }

        private void CopyButton_Click(object sender, EventArgs e)
        {
            StringBuilder builder = new StringBuilder();
            foreach (var item in resultList.Items)
            {
                builder.AppendLine(item.ToString());
            }
            Clipboard.SetText(builder.ToString());
        }

        private void GenButton_Click(object sender, EventArgs e)
        {
            Task.Run(() =>
            {
                int count = (int)countUpDown.Value;

                decimal unitCutter = (decimal)Math.Pow(10, (int)unitUpDown.Value);
                decimal upper = decimal.Truncate(upperBoundUpDown.Value / unitCutter);
                decimal lower = decimal.Truncate(lowerBoundUpDown.Value / unitCutter);
                decimal range = upper - lower + 1;

                count = (int)Math.Min(range, count);

                progressBar.Invoke((Action<int>)SetProgressBarMaxValue, count);
                progressBar.Invoke((Action<int>)SetProgressBarValue, 0);
                Invoke((Action<bool>)SetProgressBarVisible, true);
                resultList.Invoke((Action)resultList.Items.Clear);

                List<decimal> list = new List<decimal>();

                for (int i = 1; i <= count; i++)
                {
                    decimal value = (decimal)random.NextDouble() * range + lower;
                    value = decimal.Truncate(value) * unitCutter;

                    if (list.Contains(value))
                    {
                        i--;
                        continue;
                    }
                    list.Add(value);

                    resultList.Invoke((Action<object>)AppendItem, DecimalToHangeul(value));
                    progressBar.Invoke((Action<int>)SetProgressBarValue, i);
                }

                list.Sort(decimal.Compare);
                resultList.Invoke((Action)resultList.Items.Clear);
                foreach (var val in list)
                {
                    resultList.Invoke((Action<object>)AppendItem, DecimalToHangeul(val));
                }

                Invoke((Action<bool>)SetProgressBarVisible, false);
            });
        }

        private string DecimalToHangeul(decimal value)
        {
            if (value == 0)
            {
                return "영";
            }

            char[] valueString = value.ToString().ToCharArray();
            int primaryUnitIndex = 3 - (valueString.Length - 1) % 4;
            int secondaryUnitIndex = (valueString.Length - 1) / 4;

            StringBuilder builder = new StringBuilder();
            bool appendSecondaryUnit = false;
            foreach (var digit in valueString)
            {
                if (digit != '0')
                {
                    builder.Append($"{HangeulDecimalDigit[digit - '0']}{HangeulPrimaryNumericUnit[primaryUnitIndex]}");
                    appendSecondaryUnit = true;
                }

                primaryUnitIndex = (primaryUnitIndex + 1) % 4;
                if (primaryUnitIndex == 0)
                {
                    if (appendSecondaryUnit)
                    {
                        builder.Append(HangeulSecondaryNumericUnit[secondaryUnitIndex--]).Append(' ');
                        appendSecondaryUnit = false;
                    }
                }
            }

            return builder.ToString().Trim();
        }

        private void resultList_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control)
            {
                switch (e.KeyCode)
                {
                    case Keys.C:
                        if (resultList.SelectedIndex != -1)
                        {
                            Clipboard.SetText(resultList.SelectedItem.ToString());
                        }
                        break;

                    default:
                        break;
                }
            }
        }

        private void SetProgressBarVisible(bool visible)
        {
            progressBar.Visible = visible;
        }

        private void SetProgressBarMaxValue(int maxValue)
        {
            progressBar.Maximum = maxValue;
        }

        private void SetProgressBarValue(int value)
        {
            progressBar.Value = value;
        }

        private void AppendItem(object item)
        {
            resultList.Items.Add(item);
        }
    }
}
