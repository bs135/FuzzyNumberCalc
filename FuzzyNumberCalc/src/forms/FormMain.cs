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
        Series testSeries;

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
            chartFuzzy.ChartAreas[0].AxisX.ArrowStyle = AxisArrowStyle.Lines;

            chartFuzzy.ChartAreas[0].AxisY.MajorGrid.Enabled = true;
            chartFuzzy.ChartAreas[0].AxisY.MajorGrid.LineColor = Color.LightGray;
            chartFuzzy.ChartAreas[0].AxisY.MinorGrid.Enabled = true;
            chartFuzzy.ChartAreas[0].AxisY.MinorGrid.LineColor = Color.WhiteSmoke;
            chartFuzzy.ChartAreas[0].AxisY.Title = "P";
            chartFuzzy.ChartAreas[0].AxisY.ArrowStyle = AxisArrowStyle.Lines;

        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            chartFuzzy.Series.Clear();

            FuzzyNumberTrapezoid fnumA = new FuzzyNumberTrapezoid();
            FuzzyNumberTrapezoid fnumB = new FuzzyNumberTrapezoid();

            if (validateInput(out fnumA, out fnumB))
            {
                drawChartTrapezoidFuzzyNumber(ref chartFuzzy, "A", fnumA, Color.Green);
                drawChartTrapezoidFuzzyNumber(ref chartFuzzy, "B", fnumB, Color.Blue);

                // test
                testSeries = chartFuzzy.Series.Add("Test");
                testSeries.ChartType = SeriesChartType.Point;
                testSeries.BorderWidth = 2;
                testSeries.Color = Color.Red;
                decimal x = 0;
                for (int i = 0; i < 50; i++)
                {
                    x = ((decimal)i) / 10m;
                    testSeries.Points.AddXY(x, fnumA.Probability(x));
                }
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

        private bool validateInput(out FuzzyNumberTrapezoid fnumA, out FuzzyNumberTrapezoid fnumB)
        {
            bool result = true;
            fnumA = new FuzzyNumberTrapezoid();
            fnumB = new FuzzyNumberTrapezoid();
            decimal val = 0;

            epValidate.Clear();


            // number A
            if (!MathsEvaluator.TryParse(txtABotLeft.Text, out val))
            {
                epValidate.SetError(txtABotLeft, "Invalid input");
                result = false;
            }
            else
            {
                fnumA.BottomLeft = val;
            }


            if (!MathsEvaluator.TryParse(txtABotRight.Text, out val))
            {
                epValidate.SetError(txtABotRight, "Invalid input");
                result = false;
            }
            else
            {
                fnumA.BottomRight = val;
            }


            if (!MathsEvaluator.TryParse(txtATopLeft.Text, out val))
            {
                epValidate.SetError(txtATopLeft, "Invalid input");
                result = false;
            }
            else
            {
                fnumA.TopLeft = val;
            }


            if (!MathsEvaluator.TryParse(txtATopRight.Text, out val))
            {
                epValidate.SetError(txtATopRight, "Invalid input");
                result = false;
            }
            else
            {
                fnumA.TopRight = val;
            }


            // number B

            if (!MathsEvaluator.TryParse(txtBBotLeft.Text, out val))
            {
                epValidate.SetError(txtBBotLeft, "Invalid input");
                result = false;
            }
            else
            {
                fnumB.BottomLeft = val;
            }


            if (!MathsEvaluator.TryParse(txtBBotRight.Text, out val))
            {
                epValidate.SetError(txtBBotRight, "Invalid input");
                result = false;
            }
            else
            {
                fnumB.BottomRight = val;
            }


            if (!MathsEvaluator.TryParse(txtBTopLeft.Text, out val))
            {
                epValidate.SetError(txtBTopLeft, "Invalid input");
                result = false;
            }
            else
            {
                fnumB.TopLeft = val;
            }


            if (!MathsEvaluator.TryParse(txtBTopRight.Text, out val))
            {
                epValidate.SetError(txtBTopRight, "Invalid input");
                result = false;
            }
            else
            {
                fnumB.TopRight = val;
            }



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
            }


            return result;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
