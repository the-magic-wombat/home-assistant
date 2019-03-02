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
        public HomeWindow()
        {
            InitializeComponent();
        }

        private void HomeWindow_Load(object sender, EventArgs e)
        {
            this.Visible = true;
            lb_temp.Text = latestTemperature() + "°";   //sets the temperature to the latest one
        }


        #region - Temperature label updater -

        private void timer1_Tick(object sender, EventArgs e)    //timer for updating temperature info
        {
           
            if (MouseButtons == MouseButtons.None)  //the if prevents lag when moving the form
            {
                lb_temp.Text = latestTemperature() + "°"; 
            }
                      
        }

        private double latestTemperature() //returns the latest info about the temperature from the DB
        {
            double t;

            dbCon.Open();

            using (dbCon)
            {
                MySqlCommand command = new MySqlCommand(
                "SELECT temperature FROM MxOJ0NTKIO.temperature_test ORDER BY id DESC LIMIT 1", dbCon);

                t = double.Parse((command.ExecuteScalar().ToString()));
            }

            dbCon.Close();

            return t;
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
