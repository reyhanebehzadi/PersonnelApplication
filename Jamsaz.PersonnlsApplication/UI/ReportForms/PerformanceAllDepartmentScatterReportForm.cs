using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms.DataVisualization.Charting;
using Jamsaz.Common;
using Jamsaz.PersonnlsApplication.BusinessObjects.Data;
using Microsoft.Reporting.WinForms;
using Margins = System.Drawing.Printing.Margins;

namespace Jamsaz.PersonnlsApplication.UI.ReportForms
{
    public partial class PerformanceAllDepartmentScatterReportForm : BasePersianForm
    {
        public string DepartmentName;
        private MemoryStream _stream;
        public IList<PerformanceByDepartmentResult> Source;
        public PerformanceAllDepartmentScatterReportForm()
        {
            InitializeComponent();
        }
        public PerformancEvaluationMaster Master { get; set; }
        private void PerformanceReportForm_Load(object sender, EventArgs e)
        {
            try
            {
                printDocument1.DefaultPageSettings.Landscape = true;
                PerformanceAllDepartmentResultBindingSource.DataSource = Source;
                performanceByDepartmentResultBindingSource.DataSource = Source;

                var maxScore = Source.Max(x => x.Score).Value;
                var average = Source.Average(x => x.Score).Value;
                var variance = Source.Sum(x => Math.Pow((x.Score - average).Value, 2)) / Source.Count;
                var enheraf = Math.Sqrt(variance);

                var mMinesA = average - enheraf;
                var mMines2A = mMinesA - enheraf;
                var mMines3A = mMines2A - enheraf;

                var mPlusA = average + enheraf;
                var mPlus2A = mPlusA + enheraf;
                var mPlus3A = mPlus2A + enheraf;

                chart1.Series.Clear();
                var series1 = new Series
                {
                    Name = "Series1",
                    Color = Color.Black,
                    IsVisibleInLegend = false,
                    IsXValueIndexed = true,
                    ChartType = SeriesChartType.Point,
                };

                chart1.ChartAreas[0].AxisX.MajorGrid.LineColor = Color.Azure;
                chart1.ChartAreas[0].AxisY.MajorGrid.LineColor = Color.Azure;
                chart1.ChartAreas[0].AxisY.Maximum = maxScore + 10;
                chart1.ChartAreas[0].AxisX.Maximum = Source.Count + 5;
                chart1.Series.Add(series1);
                chart1.Series[0].SmartLabelStyle.AllowOutsidePlotArea = LabelOutsidePlotAreaStyle.Yes;
                chart1.Series[0].SmartLabelStyle.IsMarkerOverlappingAllowed = false;
                chart1.Series[0].SmartLabelStyle.MovingDirection = LabelAlignmentStyles.Right;

                for (var i = 0; i < Source.Count; i++)
                {
                    series1.Points.AddXY(i, Source[i].Score);
                    series1.Points[i].Label = (i + 1).ToString();
                    series1.Points[i].MarkerStyle = MarkerStyle.Circle;
                    series1.Points[i].AxisLabel = i.ToString();
                }

                var pPoint3A = new DataPoint(0, mPlus3A);
                chart1.ChartAreas[0].AxisY.StripLines.Add(
                    new StripLine
                    {
                        BorderColor = Color.Green,
                        IntervalOffset = pPoint3A.YValues[0],
                        Text = "μ + 3a",
                        TextAlignment = StringAlignment.Near,
                    });

                var pPoint2A = new DataPoint(0, mPlus2A);
                chart1.ChartAreas[0].AxisY.StripLines.Add(
                    new StripLine
                    {
                        BorderColor = Color.Green,
                        IntervalOffset = pPoint2A.YValues[0],
                        Text = "μ + 2a",
                        TextAlignment = StringAlignment.Near,
                    });

                var pPointA = new DataPoint(0, mPlusA);
                chart1.ChartAreas[0].AxisY.StripLines.Add(
                    new StripLine
                    {
                        BorderColor = Color.Green,
                        IntervalOffset = pPointA.YValues[0],
                        Text = "μ + a",
                        TextAlignment = StringAlignment.Near
                    });

                var middleValuePoint = new DataPoint(0, average);
                chart1.ChartAreas[0].AxisY.StripLines.Add(
                    new StripLine
                    {
                        BorderColor = Color.Black,
                        IntervalOffset = middleValuePoint.YValues[0],
                        Text = "average",
                        TextAlignment = StringAlignment.Near
                    });

                var mPoint3A = new DataPoint(0, mMines3A);
                chart1.ChartAreas[0].AxisY.StripLines.Add(
                    new StripLine
                    {
                        BorderColor = Color.Red,
                        IntervalOffset = mPoint3A.YValues[0],
                        Text = "μ - 3a",
                        TextAlignment = StringAlignment.Near
                    });

                var mPoint2A = new DataPoint(0, mMines2A);
                chart1.ChartAreas[0].AxisY.StripLines.Add(
                    new StripLine
                    {
                        BorderColor = Color.Red,
                        IntervalOffset = mPoint2A.YValues[0],
                        Text = "μ - 2a",
                        TextAlignment = StringAlignment.Near
                    });

                var mPointA = new DataPoint(0, mMinesA);
                chart1.ChartAreas[0].AxisY.StripLines.Add(
                    new StripLine
                    {
                        BorderColor = Color.Red,
                        IntervalOffset = mPointA.YValues[0],
                        Text = "μ - a",
                        TextAlignment = StringAlignment.Near
                    });

                chart1.Invalidate();
            }
            catch (Exception ex)
            {
                Helper.ShowMessage("هیچ اطلاعاتی برای گزارش گیری وجود ندارد");
            }
        }

        private void listprintBtn_Click(object sender, EventArgs e)
        {
            var average = Source.Average(x => x.Score).Value;
            var sum = Source.Sum(x => x.Score).Value;
            var variance = Source.Sum(x => Math.Pow((x.Score - average).Value, 2)) / Source.Count;
            var enheraf = Math.Sqrt(variance);
            var reportform = new PerformanceByDepartmentChartReportForm
            {
                DepartmentName = DepartmentName,
                Source = Source.ToList(),
                Average = average,
                Sum = sum,
                Variance = variance,
                Enheraf = enheraf
            };
            reportform.Show();
        }

        private void chartprint_Click(object sender, EventArgs e)
        {
            _stream = new MemoryStream();
            chart1.SaveImage(_stream, ChartImageFormat.Bmp);
            printPreviewDialog1.Width = 800;
            printPreviewDialog1.Height = 600;
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs ev)
        {
            using (var chartState = new MemoryStream())
            {
                chart1.Serializer.Save(chartState);
                var transState = ev.Graphics.Save();
                try
                {
                    var chartPosition = new Rectangle(-50, 0, 1024,
                        768);
                    // Display units mean different thing depending if chart is rendered on the display or printed.     
                    // Typically pixels for video displays, and 1/100 inch for printers.     
                    if (ev.Graphics.PageUnit == GraphicsUnit.Display)
                    {
                        // Chart is always expecting to draw in pixels     
                        ev.Graphics.PageUnit = GraphicsUnit.Pixel;

                        // Scale chart size from 1/100 of an inch to expected pixels.     
                        chartPosition.Width *= (int) (ev.Graphics.DpiX/100.0f);
                        chartPosition.Height *= (int) (ev.Graphics.DpiY/100.0f);
                        chartPosition.X *= (int) (ev.Graphics.DpiX/100.0f);
                        chartPosition.Y *= (int) (ev.Graphics.DpiY/100.0f);
                        foreach (var series in chart1.Series)
                        {
                            series.BorderWidth *= (int) (ev.Graphics.DpiX/100.0f);
                        }
                    }
                    chart1.Printing.PrintPaint(ev.Graphics, chartPosition);

                }
                finally
                {
                    ev.Graphics.Restore(transState);
                    chart1.Serializer.Load(chartState);
                }
            }
        }
    }
}
