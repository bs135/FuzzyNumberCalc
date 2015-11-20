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
            chartFuzzy.ChartAreas[0].AxisX.Minimum = 0;

            chartFuzzy.ChartAreas[0].AxisY.MajorGrid.Enabled = true;
            chartFuzzy.ChartAreas[0].AxisY.MajorGrid.LineColor = Color.LightGray;
            chartFuzzy.ChartAreas[0].AxisY.MinorGrid.Enabled = true;
            chartFuzzy.ChartAreas[0].AxisY.MinorGrid.LineColor = Color.WhiteSmoke;
            chartFuzzy.ChartAreas[0].AxisY.Title = "P";
            chartFuzzy.ChartAreas[0].AxisY.Interval = 0.5;
            chartFuzzy.ChartAreas[0].AxisY.ArrowStyle = AxisArrowStyle.Lines;
            chartFuzzy.ChartAreas[0].AxisY.Minimum = 0;

        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            chartFuzzy.Series.Clear();
            TrapezoidFuzzyNumber fnumA = new TrapezoidFuzzyNumber();
            TrapezoidFuzzyNumber fnumB = new TrapezoidFuzzyNumber();

            if (!validateAndGetInput(out fnumA, out fnumB))
            {
                MessageBox.Show("Your input is not valid. Please check again.", "Inalid input!");
                return;
            }

            if (chkOperationDiv.Checked && fnumB.IsZero())
            {
                MessageBox.Show("Cannot divide by zero.", "Error!");
                return;
            }

            drawTrapezoidFuzzyNumberGraph(ref chartFuzzy, "A", fnumA, Color.Green);
            drawTrapezoidFuzzyNumberGraph(ref chartFuzzy, "B", fnumB, Color.Blue);

            if (radIntervalBased.Checked)
            {
                if (chkOperationAdd.Checked) drawResultIntervalBasedGraph(ref chartFuzzy, fnumA, fnumB, Operation.Add, Color.Magenta);
                if (chkOperationSub.Checked) drawResultIntervalBasedGraph(ref chartFuzzy, fnumA, fnumB, Operation.Sub, Color.Chocolate);
                if (chkOperationMul.Checked) drawResultIntervalBasedGraph(ref chartFuzzy, fnumA, fnumB, Operation.Mul, Color.Purple);
                if (chkOperationDiv.Checked) drawResultIntervalBasedGraph(ref chartFuzzy, fnumA, fnumB, Operation.Div, Color.Red);

                resetGraphCoordinate(fnumA, fnumB);
            }
            else //if (radEPBased.Checked)
            {
                if (chkOperationAdd.Checked) drawResultEPBasedGraph(ref chartFuzzy, fnumA, fnumB, Operation.Add, Color.Magenta);
                if (chkOperationSub.Checked) drawResultEPBasedGraph(ref chartFuzzy, fnumA, fnumB, Operation.Sub, Color.Chocolate);
                if (chkOperationMul.Checked) drawResultEPBasedGraph(ref chartFuzzy, fnumA, fnumB, Operation.Mul, Color.Purple);
                if (chkOperationDiv.Checked) drawResultEPBasedGraph(ref chartFuzzy, fnumA, fnumB, Operation.Div, Color.Red);

                resetGraphCoordinate(fnumA, fnumB);
            }
        }

        private void drawTrapezoidFuzzyNumberGraph(ref Chart chart, string name, TrapezoidFuzzyNumber fnum, Color color)
        {
            // chart by line
            Series series = chart.Series.Add(name);
            series.ChartType = SeriesChartType.Line;
            series.BorderWidth = 2;
            series.Color = color;

            series.Points.AddXY(fnum.BottomLeft, 0);
            series.Points.AddXY(fnum.TopLeft, 1);
            series.Points.AddXY(fnum.TopRight, 1);
            series.Points.AddXY(fnum.BottomRight, 0);

            // chart by point
            Series seriesPoint = chartFuzzy.Series.Add(name + "_point");
            seriesPoint.ChartType = SeriesChartType.Point;
            seriesPoint.BorderWidth = 2;
            seriesPoint.Color = color;
            seriesPoint.IsVisibleInLegend = false;
            decimal y = 0;
            Interval acut;
            while (y <= 1)
            {
                acut = fnum.AlphaCut(y);
                seriesPoint.Points.AddXY(acut.LowerBound, y);
                seriesPoint.Points.AddXY(acut.UpperBound, y);
                y = y + smooth;
            }

        }

        private void drawResultIntervalBasedGraph(ref Chart chart, TrapezoidFuzzyNumber fnumA, TrapezoidFuzzyNumber fnumB, Operation operation, Color color)
        {
            // chart by line
            Series series = chart.Series.Add(operation.ToString());
            series.ChartType = SeriesChartType.Line;
            series.BorderWidth = 2;
            series.Color = color;
            // chart by point
            Series seriesPoint = chart.Series.Add(operation.ToString() + "_point");
            seriesPoint.ChartType = SeriesChartType.Point;
            seriesPoint.BorderWidth = 2;
            seriesPoint.Color = color;
            seriesPoint.IsVisibleInLegend = false;

            // calculate result points list
            decimal y = 0;
            Interval acut, a, b;
            List<CPoint> resultPointListLeft = new List<CPoint>();
            List<CPoint> resultPointListRight = new List<CPoint>();
            while (y <= 1)
            {
                a = fnumA.AlphaCut(y);
                b = fnumB.AlphaCut(y);
                acut = ArithmeticInterval.Calculate(operation, a, b);

                resultPointListLeft.Add(new CPoint(acut.LowerBound, y));
                resultPointListRight.Add(new CPoint(acut.UpperBound, y));
                y += smooth;
            }

            // draw the graph
            foreach (CPoint p in resultPointListLeft.OrderBy(i => i.x).OrderBy(i=>i.y))
            {
                // by line
                series.Points.AddXY(p.x, p.y);
                // by point
                seriesPoint.Points.AddXY(p.x, p.y);
            }
            foreach (CPoint p in resultPointListRight.OrderBy(i => i.x).OrderByDescending(i => i.y))
            {
                // by line
                series.Points.AddXY(p.x, p.y);
                // by point
                seriesPoint.Points.AddXY(p.x, p.y);
            }

        }

        private void drawResultEPBasedGraph(ref Chart chart, TrapezoidFuzzyNumber fnumA, TrapezoidFuzzyNumber fnumB, Operation operation, Color color)
        {
            // chart by line
            Series series = chart.Series.Add(operation.ToString());
            series.ChartType = SeriesChartType.Line;
            series.BorderWidth = 2;
            series.Color = color;
            // chart by point
            Series seriesPoint = chart.Series.Add(operation.ToString() + "_point");
            seriesPoint.ChartType = SeriesChartType.Point;
            seriesPoint.BorderWidth = 2;
            seriesPoint.Color = color;
            seriesPoint.IsVisibleInLegend = false;

            // calculate result points list
            decimal xA, xB, xResult;
            decimal aProbability, bProbability, minProbability;
            CPoint tempPoint = null;
            List<CPoint> resultPointList = new List<CPoint>();
            xA = fnumA.BottomLeft;
            while (xA <= fnumA.BottomRight)
            {
                xB = fnumB.BottomLeft;
                while (xB <= fnumB.BottomRight)
                {
                    xResult = ExtensionPrinciple.Calculate(operation, xA, xB);
                    aProbability = fnumA.Probability(xA);
                    bProbability = fnumB.Probability(xB);
                    minProbability = Math.Min(aProbability, bProbability);

                    tempPoint = resultPointList.FirstOrDefault(p => p.x == xResult);
                    if (tempPoint == null)
                    {
                        resultPointList.Add(new CPoint(xResult, minProbability));
                    }
                    else
                    {
                        tempPoint.y = Math.Max(tempPoint.y, minProbability);
                    }

                    xB += smooth;
                }

                xA += smooth;
            }



            // draw the graph
            foreach (CPoint p in resultPointList.OrderBy(i => i.x))
            {
                // by line
                //series.Points.AddXY(p.x, p.y);
                // by point
                seriesPoint.Points.AddXY(p.x, p.y);
            }

        }

        private void resetGraphCoordinate(TrapezoidFuzzyNumber fnumA, TrapezoidFuzzyNumber fnumB)
        {
            // reset coordinate
            decimal minAxisX = Math.Min(fnumA.BottomLeft, fnumB.BottomLeft);
            Interval acut;
            if (chkOperationAdd.Checked)
            {
                acut = ArithmeticInterval.Calculate(Operation.Add, fnumA.AlphaCut(0), fnumB.AlphaCut(0));
                minAxisX = Math.Min(minAxisX, acut.LowerBound);
            }
            if (chkOperationSub.Checked)
            {
                acut = ArithmeticInterval.Calculate(Operation.Sub, fnumA.AlphaCut(0), fnumB.AlphaCut(0));
                minAxisX = Math.Min(minAxisX, acut.LowerBound);
            }
            if (chkOperationMul.Checked)
            {
                acut = ArithmeticInterval.Calculate(Operation.Mul, fnumA.AlphaCut(0), fnumB.AlphaCut(0));
                minAxisX = Math.Min(minAxisX, acut.LowerBound);
            }
            if (chkOperationDiv.Checked && !fnumB.IsZero())
            {
                acut = ArithmeticInterval.Calculate(Operation.Div, fnumA.AlphaCut(0), fnumB.AlphaCut(0));
                minAxisX = Math.Min(minAxisX, acut.LowerBound);
            }
            chartFuzzy.ChartAreas[0].AxisX.Minimum = (int)Math.Floor(minAxisX);
        }

        private bool validateAndGetInput(out TrapezoidFuzzyNumber fnumA, out TrapezoidFuzzyNumber fnumB)
        {
            bool result = true;
            fnumA = new TrapezoidFuzzyNumber();
            fnumB = new TrapezoidFuzzyNumber();
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
                    epInValid.SetError(lblInvalidNumA, "Invalid input");
                    //MessageBox.Show("The input A is not a Trapezoid Fuzzy Number.", "Invalid input");
                    result = false;
                }
                else if (!fnumB.IsValid())
                {
                    epInValid.SetError(lblInvalidNumB, "Invalid input");
                    //MessageBox.Show("The input B is not a Trapezoid Fuzzy Number.", "Invalid input");
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
