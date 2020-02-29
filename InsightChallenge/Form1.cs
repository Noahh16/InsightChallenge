using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

/// <summary>
/// This is my program created for the Insight Group Technologies
/// coding challenge. It was completed by me (Noah Haig).
/// </summary>
namespace InsightChallenge
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// On formload, it sets up and generates the graph
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {
            generateStart(customerChart);
            drawGraph(customerChart);
        }

        Color supplierColor = Color.Empty; // Global var for supplier color
        int counter = 0; // Counter for customers;

        /// <summary>
        /// Draws the graph containing all of the supplier and customer information
        /// connecting the closest supplier to each customer
        /// </summary>
        /// <param name="customerChart">The chart object to be drawn on</param>
        private void drawGraph(Chart customerChart)
        {
            DataPointCollection suppliers = customerChart.Series["Suppliers"].Points;
            DataPointCollection customers = customerChart.Series["Customers"].Points;
            
            // Loops the customers searching for closest supplier
            foreach (var custPoint in customers)
            {
                // Sets flags/temp supplier to compare to
                counter++;
                DataPoint closestSupplier = suppliers.ElementAt(0);
                double closestDistance = double.MaxValue;

                // Loops suppliers and changes closest as it finds them
                foreach (var suppPoint in suppliers)
                {
                    double distance = double.MaxValue;
                    try
                    {
                         distance = calcDistance(custPoint, suppPoint);
                    }
                    catch (Exception ex)
                    {
                        // Does nothing since the temp distance is max. It will not change anything
                        // In future if reading in from external datasource, will throw error to check source data
                    }
                    if (distance < closestDistance)
                    {
                        closestDistance = distance;
                        closestSupplier = suppPoint;
                    }
                }

                // Generates a separate series to produce a single line between Customers and the closest Supplier
                Series lineSeries = new Series("Customer" + counter);
                lineSeries.Points.Add(new DataPoint(custPoint.XValue, custPoint.YValues));
                lineSeries.Points.Add(new DataPoint(closestSupplier.XValue, closestSupplier.YValues));
                lineSeries.ChartType = SeriesChartType.Line;
                lineSeries.Color = convertToColor(closestSupplier.GetCustomProperty("supplierColor"));
                lineSeries.IsVisibleInLegend = false;
                
                customerChart.Series.Add(lineSeries);
            }
        }

        /// <summary>
        /// Redraws the graph when a new point has been added
        /// </summary>
        /// <param name="customerChart">The Chart that will be drawn to</param>
        private void redrawGraph(Chart customerChart)
        {
            Series customers = customerChart.Series["Customers"];
            Series suppliers = customerChart.Series["Suppliers"];
            ArrayList removeAt = new ArrayList();

            // Adds each series that is to be removed into an arraylist
            foreach (Series series in customerChart.Series)
            {
                if (!(series.Equals(customers) || series.Equals(suppliers)))
                {
                    removeAt.Add(series);
                }
            }

            // Removes the series
            foreach (Series series in removeAt)
            {
                customerChart.Series.Remove(series);
            }
            // Done separately like this because it wont delete while looping through original seriescollection

            counter = 0;
            drawGraph(customerChart);
        }

        /// <summary>
        /// Returns a color object from a string passed into it of format (a,r,g,b)
        /// </summary>
        /// <param name="colString">String containing the color in format (a,r,g,b)</param>
        /// <returns>Color object containing the color converted</returns>
        private Color convertToColor(string colString)
        {
            Color color = Color.Empty;
            try
            {
                string[] split = colString.Split(',');
                color =  Color.FromArgb(int.Parse(split[0]), int.Parse(split[1]), int.Parse(split[2]), int.Parse(split[3]));
            } catch (Exception ex)
            {
                throw new Exception("Invalid string format. Can't convert to Color.");
            }
            return color;
        }

        /// <summary>
        /// Calculates the distance betwe
        /// </summary>
        /// <param name="p1">DataPoint 1 to compare</param>
        /// <param name="p2">DataPoint 2 to compare</param>
        /// <returns>Double containing the distance between the two points</returns>
        private double calcDistance(DataPoint p1, DataPoint p2)
        {
            return Math.Sqrt(
                    Math.Pow(p2.XValue - p1.XValue, 2) + Math.Pow(p2.YValues[0] - p1.YValues[0], 2)
                    );
        }

        /// <summary>
        /// Randomly generates 5 suppliers and 100 customers
        /// </summary>
        /// <param name="customerChart">The chart to add Customer and Supplier series' to</param>
        private void generateStart(Chart customerChart)
        {
            // Generates random supplier and customer info to start
            Random random = new Random();

            // 100 Demand points (customers)
            for (int i = 0; i < 100; i++)
            {
                DataPoint dataPoint = new DataPoint(random.Next(0, 500), random.Next(0, 500));
                customerChart.Series["Customers"].Points.Add(dataPoint);

            }

            // 5 supply points (Suppliers)
            for (int i = 0; i < 5; i++)
            {
                // Generates DataPoint location and Color
                DataPoint dataPoint = new DataPoint(random.Next(0, 500), random.Next(0, 500));
                Color supplierColor = GenerateColor(random);

                // Saves a random colour to their supplier DataPoint
                dataPoint.SetCustomProperty("supplierColor", $"{supplierColor.A},{supplierColor.R},{supplierColor.G},{supplierColor.B}");
                Console.WriteLine(supplierColor.ToString());

                // Adds supplier to series
                customerChart.Series["Suppliers"].Points.Add(dataPoint);
            }
        }

        /// <summary>
        /// Creates a random color by random rgb values
        /// </summary>
        /// <param name="random">Random object passed in</param>
        /// <returns></returns>
        private Color GenerateColor(Random random)
        {
            // Random passed in because instantiating many randoms at once increases chance
            // of same colours being generated due to how random works (same/similar seed)
            return Color.FromArgb(random.Next(0, 256), random.Next(0, 256), random.Next(0, 256));
        }

        /// <summary>
        /// When button is clicked, dialog is opened up to get user color selection
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void colorPickerButtoni_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                supplierColor = colorDialog1.Color;
            }
        }

        /// <summary>
        /// Sets enabled on color button depending on which radio is selected
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void customerRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (customerRadioButton.Checked == true)
            {
                colorPickerButtoni.Enabled = false;
            }  
            else
            {
                colorPickerButtoni.Enabled = true;
            }

        }

        /// <summary>
        /// Sets enabled on color button depending on which radio is selected
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void supplierRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (supplierRadioButton.Checked == true)
            {
                colorPickerButtoni.Enabled = true;
            }
            else
            {
                colorPickerButtoni.Enabled = false;
            }
        }

        /// <summary>
        /// Does appropriate validation and adds point to the chart.
        /// Redraws once added
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void addPointButton_Click(object sender, EventArgs e)
        {
            bool passX = int.TryParse(xTextBox.Text, out int x);
            bool pasSy = int.TryParse(yTextBox.Text, out int y);

            try
            {
                if (passX && pasSy)
                {
                    // Different things are done when supplier vs customer
                    if (customerRadioButton.Checked)
                    {
                        customerChart.Series["Customers"].Points.AddXY(x, y);
                        redrawGraph(customerChart);
                        clearForm();
                    }
                    else if (supplierRadioButton.Checked) // if supplier checked
                    {
                        if (!(supplierColor.IsEmpty)) // if supplierColor is set
                        {
                            DataPoint supplierPoint = new DataPoint(x, y);
                            supplierPoint.SetCustomProperty("supplierColor", $"{supplierColor.A},{supplierColor.R},{supplierColor.G},{supplierColor.B}");
                            customerChart.Series["Suppliers"].Points.Add(supplierPoint);
                            redrawGraph(customerChart);
                            clearForm();
                        }
                        else // Color check failed
                        {
                            errorLabel.Text = "Supplier color is not selected, please try again!";
                        }

                    } else
                    {
                        errorLabel.Text = "Point type not selected, please try again!";
                    }
                }
                else // coord check failed
                {
                    errorLabel.Text = "Coordinate error, please try again!";
                }
            } catch (Exception ex)
            {
                errorLabel.Text = ex.Message;
            }

        }

        /// <summary>
        /// Clears the form inputs to become default.
        /// </summary>
        private void clearForm()
        {
            customerRadioButton.Checked = false;
            supplierRadioButton.Checked = false;
            xTextBox.Text = "";
            yTextBox.Text = "";
            errorLabel.Text = "";
            supplierColor = Color.Empty;
        }
    }
}
