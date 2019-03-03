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
    public partial class SettingWindow : UserControl
    {
        public SettingWindow()
        {
            InitializeComponent();
        }

        private void SettingWindow_Load(object sender, EventArgs e)
        {
            this.Visible = false;
            minTempBox.Text = HomeWindow.temp_min.ToString();
            maxTempBox.Text = HomeWindow.temp_max.ToString();
            minHumidBox.Text = HomeWindow.humid_min.ToString();
            maxHumidBox.Text = HomeWindow.humid_max.ToString();
        } 


        #region - Creates a MySqlConnection (dbCon) -

        MySqlConnection dbCon = new MySqlConnection(
                    "Server=remotemysql.com; " +
                    "Database=MxOJ0NTKIO; " +
                    "Uid = MxOJ0NTKIO; " +
                    "Pwd = 7QwUSwSfbA ");

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

        #endregion


        #region - Change Temperature Scale -
        private void fButton_CheckedChanged(object sender, EventArgs e)
        {
            if (fButton.Checked)
            {
                HomeWindow.tempScale = 'F';
            }
            else if (cButton.Checked)
            {
                HomeWindow.tempScale = 'C';
            }
            else
            {
                HomeWindow.tempScale = 'K';
            }
        }

        private void cButton_CheckedChanged(object sender, EventArgs e)
        {
            if (fButton.Checked)
            {
                HomeWindow.tempScale = 'F';
            }
            else if (cButton.Checked)
            {
                HomeWindow.tempScale = 'C';
            }
            else
            {
                HomeWindow.tempScale = 'K';
            }
           
        }

        private void kButton_CheckedChanged(object sender, EventArgs e)
        {
            if (fButton.Checked)
            {
                HomeWindow.tempScale = 'F';
            }
            else if (cButton.Checked)
            {
                HomeWindow.tempScale = 'C';
            }
            else
            {
                HomeWindow.tempScale = 'K';
            }
        }

        #endregion


        #region - Textbox functionality -

        private void timer1_Tick(object sender, EventArgs e)
        {
            lb_success.Visible = false;
            timer1.Stop();
        }

        private void lb_confirm_MouseClick(object sender, MouseEventArgs e)
        {
            bool validValues = false;

            double minTemp, maxTemp, minHumid, maxHumid;

            bool v1, v2, v3, v4;

            v1 = double.TryParse(minTempBox.Text, out minTemp);
            v2 = double.TryParse(maxTempBox.Text, out maxTemp);
            v3 = double.TryParse(minHumidBox.Text, out minHumid);
            v4 = double.TryParse(maxHumidBox.Text, out maxHumid);

            if(v1 == true && v2 == true && v3 == true & v4 == true)
            {
                validValues = true;
            }

            if (validValues)
            {
                if (minTemp > maxTemp || minHumid > maxHumid)
                {
                    minTempBox.Text = HomeWindow.temp_min.ToString();
                    maxTempBox.Text = HomeWindow.temp_max.ToString();

                    minHumidBox.Text = HomeWindow.humid_min.ToString();
                    maxHumidBox.Text = HomeWindow.humid_max.ToString();

                    lb_success.Text = "Minimum can't be higher than maximum";
                    lb_success.ForeColor = Color.Maroon;
                    lb_success.Visible = true;
                    timer1.Start();
                }
                else if (minHumid < 0 || maxHumid > 100)
                {
                    minTempBox.Text = HomeWindow.temp_min.ToString();
                    maxTempBox.Text = HomeWindow.temp_max.ToString();

                    minHumidBox.Text = HomeWindow.humid_min.ToString();
                    maxHumidBox.Text = HomeWindow.humid_max.ToString();

                    lb_success.Text = "Humidity must be bewtween 0% and 100%";
                    lb_success.ForeColor = Color.Maroon;
                    lb_success.Visible = true;
                    timer1.Start();
                }
                else
                {
                    HomeWindow.temp_min = minTemp;
                    HomeWindow.temp_max = maxTemp;

                    HomeWindow.humid_min = minHumid;
                    HomeWindow.humid_max = maxHumid;

                    lb_success.Text = "Changed Successfully";
                    lb_success.ForeColor = Color.DarkGreen;
                    lb_success.Visible = true;
                    timer1.Start();

                }
            }
            else
            {
                minTempBox.Text = HomeWindow.temp_min.ToString();
                maxTempBox.Text = HomeWindow.temp_max.ToString();

                minHumidBox.Text = HomeWindow.humid_min.ToString();
                maxHumidBox.Text = HomeWindow.humid_max.ToString();

                lb_success.Text = "Values must be numbers";
                lb_success.ForeColor = Color.Maroon;
                lb_success.Visible = true;
                timer1.Start();
            }
        }

        #endregion
      
    }
}
