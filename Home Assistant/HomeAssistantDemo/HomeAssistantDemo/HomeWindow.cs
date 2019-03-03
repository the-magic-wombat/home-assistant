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

namespace HomeAssistantDemo
{
    public partial class HomeWindow : UserControl
    {
        public static double temp_min = 18, temp_max = 24;
        public static char tempScale = 'C';

        public static double humid_min = 35, humid_max = 50;

        public HomeWindow()
        {
            InitializeComponent();
        }

        private void HomeWindow_Load(object sender, EventArgs e)
        {
            this.Visible = true;
            lb_temp_C.Text = Math.Round(latestTemperature(), 2) + "°" + tempScale;   //sets the temperature to the latest one
            lb_humid.Text = Math.Round(latestHumidity(), 2) + "%";  //sets the humidity to the latest one
            onlineOfflineSwitch();
        }


        #region - Reload Connection -

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            onlineOfflineSwitch();
            Cursor.Current = Cursors.Default;
        }

        private void onlineOfflineSwitch()
        {
            if (isAvailable(dbCon))
            {
                lb_status.Text = "Online";
                lb_status.ForeColor = Color.DarkGreen;
                timer1.Start();
            }
            else
            {
                lb_status.Text = "Offline";
                lb_status.ForeColor = Color.Maroon;
            }
        }
        #endregion


        #region - Temperature and humidity label updater -


        private void timer1_Tick(object sender, EventArgs e)    //timer for updating temperature info
        {
           
            if (MouseButtons == MouseButtons.None )  //the if prevents lag when moving the form
            {
                double currentTemp = Math.Round(latestTemperature(), 2);
                double currentHumid = Math.Round(latestHumidity(), 2);

                if (tempScale == 'C')
                {
                    lb_temp_C.Text = currentTemp + "°" + tempScale;

                    if (currentTemp < temp_min)
                    {
                        lb_temp_status.Text = "Too low";
                    }
                    else if (currentTemp > temp_max)
                    {
                        lb_temp_status.Text = "Too high";
                    }
                    else
                    {
                        lb_temp_status.Text = "Normal";
                    }
                }
                else if (tempScale == 'F')
                {
                    lb_temp_C.Text = (currentTemp * 1.8 + 32) + "°" + tempScale;

                    if (currentTemp < temp_min)
                    {
                        lb_temp_status.Text = "Too low";
                    }
                    else if (currentTemp > temp_max)
                    {
                        lb_temp_status.Text = "Too high";
                    }
                    else
                    {
                        lb_temp_status.Text = "Normal";
                    }
                }
                else
                {
                    lb_temp_C.Text = (currentTemp + 273.15) + "°" + tempScale;

                    if (currentTemp < temp_min)
                    {
                        lb_temp_status.Text = "Too low";
                    }
                    else if (currentTemp > temp_max)
                    {
                        lb_temp_status.Text = "Too high";
                    }
                    else
                    {
                        lb_temp_status.Text = "Normal";
                    }
                }

                lb_humid.Text = currentHumid + "%";

                if (currentHumid < humid_min)
                {
                    lb_humidity_status.Text = "Too low";
                }
                else if (currentHumid > humid_max)
                {
                    lb_humidity_status.Text = "Too high";
                }
                else
                {
                    lb_humidity_status.Text = "Normal";
                }
            }
                      
        }

        private double latestTemperature() //returns the latest info about the temperature from the DB
        {
            double t;

            if(isAvailable(dbCon))
            { 
             
                    dbCon.Open();

                using (dbCon)
                {
                    MySqlCommand command = new MySqlCommand(
                    "SELECT temperature FROM MxOJ0NTKIO.current ORDER BY id DESC LIMIT 1", dbCon);

                    t = double.Parse(command.ExecuteScalar().ToString());
                }
                dbCon.Close();
                return t;
            }
            else
            {
                timer1.Stop();  //prevents enless loop
                return 0;
            }
        }
        
        private double latestHumidity()
        {
            double h;

            if (isAvailable(dbCon))
            {

                dbCon.Open();

                using (dbCon)
                {
                    MySqlCommand command = new MySqlCommand(
                    "SELECT humidity FROM MxOJ0NTKIO.current ORDER BY id DESC LIMIT 1", dbCon);

                    h = double.Parse(command.ExecuteScalar().ToString());
                }
                dbCon.Close();
                return h;
            }
            else
            {
                timer1.Stop();  //prevents enless loop
                return 0;
            }
        }

        private bool isAvailable(MySqlConnection conn)  //checks if the connection is working
        {
            try
            {
                conn.Open();
                conn.Close();
            }
            catch (MySqlException)
            {
                return false;
            }

            return true;
        }

        protected void uptateScale()
        {
            lb_temp_C.Text = latestTemperature() + "°" + tempScale;
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
