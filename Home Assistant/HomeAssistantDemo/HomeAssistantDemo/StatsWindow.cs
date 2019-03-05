using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Windows.Forms.DataVisualization.Charting;

namespace HomeAssistantDemo
{
    public partial class StatsWindow : UserControl
    {
        public StatsWindow()
        {
            InitializeComponent();
        }

        private void StatsWindow_Load(object sender, EventArgs e)
        {
            this.Visible = false;

            timer1_Tick(sender, e);
   
            #region - Sets properties for the charts -

            //Temperature chart
            chart_temp_day.ChartAreas[0].AxisY.Minimum = 5;
            chart_temp_day.ChartAreas[0].AxisY.Maximum = 30;

            chart_temp_day.ChartAreas[0].AxisY.MajorGrid.Enabled = false;
            chart_temp_day.ChartAreas[0].AxisY2.MajorGrid.Enabled = false;
            
            chart_temp_day.ChartAreas[0].AxisX.MajorGrid.Enabled = false;
            chart_temp_day.ChartAreas[0].AxisX2.MajorGrid.Enabled = false;

            chart_temp_day.ChartAreas[0].AxisY.MajorTickMark.Enabled = false;

            chart_temp_day.ChartAreas[0].AxisX2.Enabled = AxisEnabled.True;
            chart_temp_day.ChartAreas[0].AxisY2.Enabled = AxisEnabled.True;

            chart_temp_day.ChartAreas[0].AxisY2.MajorTickMark.Enabled = false;
            chart_temp_day.ChartAreas[0].AxisY2.LabelStyle.Enabled = false;

            chart_temp_day.ChartAreas[0].AxisX2.MajorTickMark.Enabled = false;
            chart_temp_day.ChartAreas[0].AxisX2.LabelStyle.Enabled = false;

            chart_temp_day.Series["Temperature"].IsValueShownAsLabel = true;

            chart_temp_day.ChartAreas[0].AxisX.LabelStyle.IsEndLabelVisible = false;

            //Humidity chart
            chart_humid_day.ChartAreas[0].AxisY.Minimum = 0;
            chart_humid_day.ChartAreas[0].AxisY.Maximum = 100;

            chart_humid_day.ChartAreas[0].AxisY.MajorGrid.Enabled = false;
            chart_humid_day.ChartAreas[0].AxisY2.MajorGrid.Enabled = false;

            chart_humid_day.ChartAreas[0].AxisX.MajorGrid.Enabled = false;
            chart_humid_day.ChartAreas[0].AxisX2.MajorGrid.Enabled = false;

            chart_humid_day.ChartAreas[0].AxisY.MajorTickMark.Enabled = false;

            chart_humid_day.ChartAreas[0].AxisX2.Enabled = AxisEnabled.True;
            chart_humid_day.ChartAreas[0].AxisY2.Enabled = AxisEnabled.True;

            chart_humid_day.ChartAreas[0].AxisY2.MajorTickMark.Enabled = false;
            chart_humid_day.ChartAreas[0].AxisY2.LabelStyle.Enabled = false;

            chart_humid_day.ChartAreas[0].AxisX2.MajorTickMark.Enabled = false;
            chart_humid_day.ChartAreas[0].AxisX2.LabelStyle.Enabled = false;

            chart_humid_day.Series["Humidity"].IsValueShownAsLabel = true;

            chart_humid_day.ChartAreas[0].AxisX.LabelStyle.IsEndLabelVisible = false;           

            #endregion
        }

        #region - Chart updating -

        List<double> tempValues = new List<double>();
        List<double> humidValues = new List<double>();
        List<string> timeValues = new List<string>();

        private bool isAvailable(MySqlConnection conn)  //checks if the connection is working
        {
            try
            {
                conn.Close();
                conn.Open();
                conn.Close();
            }
            catch (MySqlException)
            {
                return false;
            }

            return true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (isAvailable(dbCon))
            {
                dbCon.Open();

                using (dbCon)
                {
                    MySqlCommand commandTemp = new MySqlCommand(
                    "SELECT temperature FROM MxOJ0NTKIO.current ORDER BY id DESC LIMIT 10", dbCon);

                    MySqlCommand commandHumid = new MySqlCommand(
                    "SELECT humidity FROM MxOJ0NTKIO.current ORDER BY id DESC LIMIT 10", dbCon);

                    MySqlCommand commandTime = new MySqlCommand(
                    "SELECT TIMESTAMPADD(HOUR, 2, time_created) FROM MxOJ0NTKIO.current ORDER BY id DESC LIMIT 10", dbCon);

                    MySqlDataReader readerTemp = commandTemp.ExecuteReader();
                    using (readerTemp)
                    {
                        while (readerTemp.Read())
                        {
                            tempValues.Add(Math.Round(double.Parse(readerTemp["temperature"].ToString()), 2));
                        }
                        tempValues.Reverse();
                    }
                    readerTemp.Close();

                    MySqlDataReader readerHumid = commandHumid.ExecuteReader();
                    using (readerHumid)
                    {
                        while (readerHumid.Read())
                        {
                            humidValues.Add(Math.Round(double.Parse(readerHumid["humidity"].ToString()), 2));
                        }
                        humidValues.Reverse();
                    }
                    readerHumid.Close();

                    MySqlDataReader readerTime = commandTime.ExecuteReader();
                    using (readerTime)
                    {
                        while (readerTime.Read())
                        {
                            string a = readerTime["TIMESTAMPADD(HOUR, 2, time_created)"].ToString();
                            a = a.Remove(0, 11);
                            a = a.Substring(0, a.Length - 3);
                            timeValues.Add(a);
                        }
                        timeValues.Reverse();
                    }
                    readerTime.Close();
                }

                dbCon.Close();

                this.chart_temp_day.Series["Temperature"].Points.Clear();
                this.chart_humid_day.Series["Humidity"].Points.Clear();


                this.chart_temp_day.Series["Temperature"].Points.AddXY(timeValues[0], tempValues[0]);
                this.chart_temp_day.Series["Temperature"].Points.AddXY(timeValues[1], tempValues[1]);
                this.chart_temp_day.Series["Temperature"].Points.AddXY(timeValues[2], tempValues[2]);
                this.chart_temp_day.Series["Temperature"].Points.AddXY(timeValues[3], tempValues[3]);
                this.chart_temp_day.Series["Temperature"].Points.AddXY(timeValues[4], tempValues[4]);
                this.chart_temp_day.Series["Temperature"].Points.AddXY(timeValues[5], tempValues[5]);
                this.chart_temp_day.Series["Temperature"].Points.AddXY(timeValues[6], tempValues[6]);
                this.chart_temp_day.Series["Temperature"].Points.AddXY(timeValues[7], tempValues[7]);
                this.chart_temp_day.Series["Temperature"].Points.AddXY(timeValues[8], tempValues[8]);
                //this.chart_temp_day.Series["Temperature"].Points.AddXY(timeValues[9], tempValues[9]);

                this.chart_humid_day.Series["Humidity"].Points.AddXY(timeValues[0], humidValues[0]);
                this.chart_humid_day.Series["Humidity"].Points.AddXY(timeValues[1], humidValues[1]);
                this.chart_humid_day.Series["Humidity"].Points.AddXY(timeValues[2], humidValues[2]);
                this.chart_humid_day.Series["Humidity"].Points.AddXY(timeValues[3], humidValues[3]);
                this.chart_humid_day.Series["Humidity"].Points.AddXY(timeValues[4], humidValues[4]);
                this.chart_humid_day.Series["Humidity"].Points.AddXY(timeValues[5], humidValues[5]);
                this.chart_humid_day.Series["Humidity"].Points.AddXY(timeValues[6], humidValues[6]);
                this.chart_humid_day.Series["Humidity"].Points.AddXY(timeValues[7], humidValues[7]);
                this.chart_humid_day.Series["Humidity"].Points.AddXY(timeValues[8], humidValues[8]);
                //this.chart_humid_day.Series["Humidity"].Points.AddXY(timeValues[9], humidValues[9]);
            }
        }

        #endregion


        #region - Creates a MySqlConnection (dbCon) -

        MySqlConnection dbCon = new MySqlConnection(
                    "Server=remotemysql.com; " +
                    "Database=MxOJ0NTKIO; " +
                    "Uid = MxOJ0NTKIO; " +
                    "Pwd = 7QwUSwSfbA ");

        #endregion
     
    }
}
