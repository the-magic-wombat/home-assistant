using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using MySql.Data.MySqlClient;

namespace HomeAssistantDemo
{
    public partial class mainForm : Form
    {
        

        public mainForm()
        {
            InitializeComponent();

            // rounds the corners of the program window
            this.FormBorderStyle = FormBorderStyle.None;    
            Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            homePanel.BackColor = Color.FromArgb(25, 66, 80);   //loads the program with "clicked" button

        }

        private void mainForm_Load(object sender, EventArgs e)
        {
            
        }


        #region - Left panel click events -

        private void homePanel_MouseClick(object sender, MouseEventArgs e)
        {
            togglePanelsColor(homePanel);
            displayWindow(homePanel);
        }

        private void settingsPanel_MouseClick(object sender, MouseEventArgs e)
        {
            togglePanelsColor(settingsPanel);
            displayWindow(settingsPanel);
        }

        private void statsPanel_MouseClick(object sender, MouseEventArgs e)
        {
            togglePanelsColor(statsPanel);
            displayWindow(statsPanel);
        }

        private void displayWindow (Panel clickedPanel)
        {
            homeWindow.Visible = false;
            statsWindow.Visible = false;
            settingsWindow.Visible = false;

            if(clickedPanel.Name == "homePanel")
            {
                homeWindow.Visible = true;
            }

            if (clickedPanel.Name == "statsPanel")
            {
                statsWindow.Visible = true;
            }

            if (clickedPanel.Name == "settingsPanel")
            {
                settingsWindow.Visible = true;
            }
        }

        private void togglePanelsColor(Panel clickedPanel)
        {
            homePanel.BackColor = Color.FromArgb(72, 117, 131);
            statsPanel.BackColor = Color.FromArgb(72, 117, 131);
            settingsPanel.BackColor = Color.FromArgb(72, 117, 131);
            clickedPanel.BackColor = Color.FromArgb(25, 66, 80);     // Color of the clicked panel
        }

        #endregion


        #region - Creates a MySqlConnection (dbCon) -

        MySqlConnection dbCon = new MySqlConnection(
                    "Server=remotemysql.com; " +
                    "Database=MxOJ0NTKIO; " +
                    "Uid = MxOJ0NTKIO; " +
                    "Pwd = 7QwUSwSfbA ");

        #endregion


        #region - Makes "X" and "-" to work -

        private void lb_close_MouseClick(object sender, MouseEventArgs e)
        {
            this.Close();
        }

        private void lb_minimize_MouseClick(object sender, MouseEventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        # endregion


        #region - Allows moving of the form -

        int mouseX = 0, mouseY = 0; 
        private bool clicked = false; 

        public bool Clicked
        {
            get
            {
                return this.clicked;
            }
            set
            {
                this.clicked = value;
            }
        }

    public void topPanel_MouseDown(object sender, MouseEventArgs e)
        {
            clicked = true;
            mouseX = e.X;
            mouseY = e.Y;
            
        }

        private void topPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (clicked == true)
            {
                this.SetDesktopLocation(MousePosition.X - mouseX, MousePosition.Y - mouseY);
            }
        }

        private void topPanel_MouseUp(object sender, MouseEventArgs e)
        {
            clicked = false;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        #endregion


        #region - Creates round rectangle (to round the edges of the window) - 

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,     // x-coordinate of upper-left corner
            int nTopRect,      // y-coordinate of upper-left corner
            int nRightRect,    // x-coordinate of lower-right corner
            int nBottomRect,   // y-coordinate of lower-right corner
            int nWidthEllipse, // height of ellipse
            int nHeightEllipse // width of ellipse
        );

        #endregion

    }
}
