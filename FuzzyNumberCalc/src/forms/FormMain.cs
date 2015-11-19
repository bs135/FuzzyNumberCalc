using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FuzzyNumberCalc.Utils;
using System.Windows.Forms.DataVisualization.Charting;

namespace FuzzyNumberCalc
{
    public partial class FormMain : Form
    {
        decimal smooth = 0;

        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            chartFuzzy.Series.Clear();
            chartFuzzy.Titles.Add("Fuzzy number chart");

            chartFuzzy.ChartAreas[0].AxisX.MajorGrid.Enabled = true;
            chartFuzzy.ChartAreas[0].AxisX.MajorGrid.LineColor = Color.LightGray;
            chartFuzzy.ChartAreas[0].AxisX.MinorGrid.Enabled = true;
            chartFuzzy.ChartAreas[0].AxisX.MinorGrid.LineColor = Color.WhiteSmoke;
            chartFuzzy.ChartAreas[0].AxisX.MinorGrid.LineDashStyle = ChartDashStyle.Dot;
            chartFuzzy.ChartAreas[0].AxisX.Title = "R";
            chartFuzzy.ChartAreas[0].AxisX.Interval = 1;
            chartFuzzy.ChartAreas[0].AxisX.ArrowStyle = AxisArrowStyle.Lines;

            chartFuzzy.ChartAreas[0].AxisY.MajorGrid.Enabled = true;
            chartFuzzy.ChartAreas[0].AxisY.MajorGrid.LineColor = Color.LightGray;
            chartFuzzy.ChartAreas[0].AxisY.MinorGrid.Enabled = true;
            chartFuzzy.ChartAreas[0].AxisY.MinorGrid.LineColor = Color.WhiteSmoke;
            chartFuzzy.ChartAreas[0].AxisY.Title = "P";
            chartFuzzy.ChartAreas[0].AxisY.Interval = 0.5;
            chartFuzzy.ChartAreas[0].AxisY.ArrowStyle = AxisArrowStyle.Lines;

        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            chartFuzzy.Series.Clear();

            FuzzyNumberTrapezoid fnumA = new FuzzyNumberTrapezoid();
            FuzzyNumberTrapezoid fnumB = new FuzzyNumberTrapezoid();

            if (validateAndGetInput(out fnumA, out fnumB))
            {
                drawChartTrapezoidFuzzyNumber(ref chartFuzzy, "A", fnumA, Color.Green);
                drawChartTrapezoidFuzzyNumber(ref chartFuzzy, "B", fnumB, Color.Blue);

                //// test
                //Series testSeriesA = chartFuzzy.Series.Add("TestA");
                //Series testSeriesB = chartFuzzy.Series.Add("TestB");
                //testSeriesA.ChartType = SeriesChartType.Point;
                //testSeriesA.BorderWidth = 2;
                //testSeriesA.Color = Color.Green;
                //testSeriesA.IsVisibleInLegend = false;
                //testSeriesB.ChartType = SeriesChartType.Point;
                //testSeriesB.BorderWidth = 2;
                //testSeriesB.Color = Color.Blue;
                //testSeriesB.IsVisibleInLegend = false;
                //decimal x = 0;
                //for (int i = 0; i < 50; i++)
                //{
                //    x = ((decimal)i) / 10m;
                //    testSeriesA.Points.AddXY(x, fnumA.Probability(x));
                //    testSeriesB.Points.AddXY(x, fnumB.Probability(x));
                //}

                Series testSeriesA = chartFuzzy.Series.Add("A_byPoint");
                Series testSeriesB = chartFuzzy.Series.Add("B_byPoint");
                testSeriesA.ChartType = SeriesChartType.Point;
                testSeriesA.BorderWidth = 2;
                testSeriesA.Color = Color.Green;
                testSeriesA.IsVisibleInLegend = false;
                testSeriesB.ChartType = SeriesChartType.Point;
                testSeriesB.BorderWidth = 2;
                testSeriesB.Color = Color.Blue;
                testSeriesB.IsVisibleInLegend = false;
                decimal y = 0;
                Interval acut;
                while (y <= 1)
                {
                    acut = fnumA.AlphaCut(y);
                    testSeriesA.Points.AddXY(acut.LowerBound, y);
                    testSeriesA.Points.AddXY(acut.UpperBound, y);
                    acut = fnumB.AlphaCut(y);
                    testSeriesB.Points.AddXY(acut.LowerBound, y);
                    testSeriesB.Points.AddXY(acut.UpperBound, y);

                    y = y + smooth;
                }

                if (chkOperationAdd.Checked) drawChartResult(ref chartFuzzy, fnumA, fnumB, Operation.Add, Color.Magenta);
                if (chkOperationSub.Checked) drawChartResult(ref chartFuzzy, fnumA, fnumB, Operation.Sub, Color.Brown);
                if (chkOperationMul.Checked) drawChartResult(ref chartFuzzy, fnumA, fnumB, Operation.Mul, Color.Purple);
                if (chkOperationDiv.Checked) drawChartResult(ref chartFuzzy, fnumA, fnumB, Operation.Div, Color.Red);

            }
        }

        private void drawChartTrapezoidFuzzyNumber(ref Chart chart, string name, FuzzyNumberTrapezoid fnum, Color color)
        {
            Series series = chart.Series.Add(name);
            series.ChartType = SeriesChartType.Line;
            series.BorderWidth = 2;
            series.Color = color;

            series.Points.AddXY(fnum.BottomLeft, 0);
            series.Points.AddXY(fnum.TopLeft, 1);
            series.Points.AddXY(fnum.TopRight, 1);
            series.Points.AddXY(fnum.BottomRight, 0);
        }

        private void drawChartResult(ref Chart chart, FuzzyNumberTrapezoid fnumA, FuzzyNumberTrapezoid fnumB, Operation operation, Color color)
        {
            Series series = chart.Series.Add(operation.ToString());
            series.ChartType = SeriesChartType.Line;
            series.BorderWidth = 2;
            series.Color = color;

            Series seriesPoint = chart.Series.Add(operation.ToString() + "_point");
            seriesPoint.ChartType = SeriesChartType.Point;
            seriesPoint.BorderWidth = 2;
            seriesPoint.Color = color;
            seriesPoint.IsVisibleInLegend = false;

            decimal y = 0;
            Interval acut, a, b;
            List<CPoint> resultPointList = new List<CPoint>();
            while (y <= 1)
            {
                a = fnumA.AlphaCut(y);
                b = fnumB.AlphaCut(y);
                acut = ArithmeticInterval.Calculate(operation, a, b);

                resultPointList.Add(new CPoint(acut.LowerBound, y));
                resultPointList.Add(new CPoint(acut.UpperBound, y));
                y += smooth;
            }

            foreach (CPoint p in resultPointList.OrderBy(i => i.x))
            {
                series.Points.AddXY(p.x, p.y);
                seriesPoint.Points.AddXY(p.x, p.y);
            }
        }

        private bool validateAndGetInput(out FuzzyNumberTrapezoid fnumA, out FuzzyNumberTrapezoid fnumB)
        {
            bool result = true;
            fnumA = new FuzzyNumberTrapezoid();
            fnumB = new FuzzyNumberTrapezoid();
            decimal val = 0;

            epInValid.Clear();


            // number A
            if (!MathsEvaluator.TryParse(txtABotLeft.Text, out val))
            {
                epInValid.SetError(txtABotLeft, "Invalid input");
                result = false;
            }
            else
            {
                fnumA.BottomLeft = val;
            }


            if (!MathsEvaluator.TryParse(txtABotRight.Text, out val))
            {
                epInValid.SetError(txtABotRight, "Invalid input");
                result = false;
            }
            else
            {
                fnumA.BottomRight = val;
            }


            if (!MathsEvaluator.TryParse(txtATopLeft.Text, out val))
            {
                epInValid.SetError(txtATopLeft, "Invalid input");
                result = false;
            }
            else
            {
                fnumA.TopLeft = val;
            }


            if (!MathsEvaluator.TryParse(txtATopRight.Text, out val))
            {
                epInValid.SetError(txtATopRight, "Invalid input");
                result = false;
            }
            else
            {
                fnumA.TopRight = val;
            }


            // number B

            if (!MathsEvaluator.TryParse(txtBBotLeft.Text, out val))
            {
                epInValid.SetError(txtBBotLeft, "Invalid input");
                result = false;
            }
            else
            {
                fnumB.BottomLeft = val;
            }


            if (!MathsEvaluator.TryParse(txtBBotRight.Text, out val))
            {
                epInValid.SetError(txtBBotRight, "Invalid input");
                result = false;
            }
            else
            {
                fnumB.BottomRight = val;
            }


            if (!MathsEvaluator.TryParse(txtBTopLeft.Text, out val))
            {
                epInValid.SetError(txtBTopLeft, "Invalid input");
                result = false;
            }
            else
            {
                fnumB.TopLeft = val;
            }


            if (!MathsEvaluator.TryParse(txtBTopRight.Text, out val))
            {
                epInValid.SetError(txtBTopRight, "Invalid input");
                result = false;
            }
            else
            {
                fnumB.TopRight = val;
            }

            // options
            if (!MathsEvaluator.TryParse(txtSmooth.Text, out val))
            {
                epInValid.SetError(txtSmooth, "Invalid input");
                result = false;
            }
            else
            {
                if (val <= 0 || val > 1)
                {
                    epInValid.SetError(txtSmooth, "Smooth is a number in (0,1]");
                    result = false;
                }
                else
                {
                    smooth = val;
                }
            }

            // Trapezoid Fuzzy Number validation
            if (result)
            {
                if (!fnumA.IsValid())
                {
                    //epInValid.SetError(lblInvalidNumA, "Invalid input");
                    MessageBox.Show("The input A is not a Trapezoid Fuzzy Number.", "Invalid input");
                    result = false;
                }
                else if (!fnumB.IsValid())
                {
                    //epInValid.SetError(lblInvalidNumB, "Invalid input");
                    MessageBox.Show("The input B is not a Trapezoid Fuzzy Number.", "Invalid input");
                    result = false;
                }
            }

            // re-format input
            if (result)
            {
                txtABotLeft.Text = fnumA.BottomLeft.ToString();
                txtABotRight.Text = fnumA.BottomRight.ToString();
                txtATopLeft.Text = fnumA.TopLeft.ToString();
                txtATopRight.Text = fnumA.TopRight.ToString();

                txtBBotLeft.Text = fnumB.BottomLeft.ToString();
                txtBBotRight.Text = fnumB.BottomRight.ToString();
                txtBTopLeft.Text = fnumB.TopLeft.ToString();
                txtBTopRight.Text = fnumB.TopRight.ToString();

                txtSmooth.Text = smooth.ToString();
            }


            return result;
        }

    }
}
