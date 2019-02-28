using System;

namespace HomeAssistantDemo
{
    partial class mainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lb_close = new System.Windows.Forms.Label();
            this.sidePanel = new System.Windows.Forms.PictureBox();
            this.topPanel = new System.Windows.Forms.PictureBox();
            this.smallPanelTop = new System.Windows.Forms.PictureBox();
            this.homePanel = new System.Windows.Forms.Panel();
            this.homeLabel = new System.Windows.Forms.Label();
            this.settingsPanel = new System.Windows.Forms.Panel();
            this.settingsLabel = new System.Windows.Forms.Label();
            this.statsPanel = new System.Windows.Forms.Panel();
            this.statsLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.settingsWindow = new HomeAssistantDemo.SettingWindow();
            this.statsWindow = new HomeAssistantDemo.StatsWindow();
            this.homeWindow = new HomeAssistantDemo.HomeWindow();
            this.smallPanelBottom = new System.Windows.Forms.PictureBox();
            this.lb_minimize = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.sidePanel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.topPanel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.smallPanelTop)).BeginInit();
            this.homePanel.SuspendLayout();
            this.settingsPanel.SuspendLayout();
            this.statsPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.smallPanelBottom)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_close
            // 
            this.lb_close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_close.AutoSize = true;
            this.lb_close.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(180)))), ((int)(((byte)(187)))));
            this.lb_close.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lb_close.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(66)))), ((int)(((byte)(80)))));
            this.lb_close.Location = new System.Drawing.Point(828, 12);
            this.lb_close.Margin = new System.Windows.Forms.Padding(0);
            this.lb_close.Name = "lb_close";
            this.lb_close.Size = new System.Drawing.Size(25, 28);
            this.lb_close.TabIndex = 0;
            this.lb_close.Text = "x";
            this.lb_close.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lb_close_MouseClick);
            // 
            // sidePanel
            // 
            this.sidePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(117)))), ((int)(((byte)(131)))));
            this.sidePanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidePanel.Location = new System.Drawing.Point(0, 51);
            this.sidePanel.Name = "sidePanel";
            this.sidePanel.Size = new System.Drawing.Size(190, 432);
            this.sidePanel.TabIndex = 1;
            this.sidePanel.TabStop = false;
            // 
            // topPanel
            // 
            this.topPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(180)))), ((int)(((byte)(187)))));
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Location = new System.Drawing.Point(0, 0);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(862, 51);
            this.topPanel.TabIndex = 2;
            this.topPanel.TabStop = false;
            this.topPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.topPanel_MouseDown);
            this.topPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.topPanel_MouseMove);
            this.topPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.topPanel_MouseUp);
            // 
            // smallPanelTop
            // 
            this.smallPanelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(90)))), ((int)(((byte)(105)))));
            this.smallPanelTop.Location = new System.Drawing.Point(0, 0);
            this.smallPanelTop.Margin = new System.Windows.Forms.Padding(0);
            this.smallPanelTop.Name = "smallPanelTop";
            this.smallPanelTop.Size = new System.Drawing.Size(190, 51);
            this.smallPanelTop.TabIndex = 3;
            this.smallPanelTop.TabStop = false;
            // 
            // homePanel
            // 
            this.homePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(117)))), ((int)(((byte)(131)))));
            this.homePanel.Controls.Add(this.homeLabel);
            this.homePanel.Location = new System.Drawing.Point(0, 51);
            this.homePanel.Margin = new System.Windows.Forms.Padding(0);
            this.homePanel.Name = "homePanel";
            this.homePanel.Size = new System.Drawing.Size(190, 47);
            this.homePanel.TabIndex = 4;
            this.homePanel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.homePanel_MouseClick);
            // 
            // homeLabel
            // 
            this.homeLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.homeLabel.AutoSize = true;
            this.homeLabel.BackColor = System.Drawing.Color.Transparent;
            this.homeLabel.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.homeLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(217)))), ((int)(((byte)(221)))));
            this.homeLabel.Location = new System.Drawing.Point(54, 9);
            this.homeLabel.Name = "homeLabel";
            this.homeLabel.Size = new System.Drawing.Size(75, 29);
            this.homeLabel.TabIndex = 0;
            this.homeLabel.Text = "Home";
            this.homeLabel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.homePanel_MouseClick);
            // 
            // settingsPanel
            // 
            this.settingsPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(117)))), ((int)(((byte)(131)))));
            this.settingsPanel.Controls.Add(this.settingsLabel);
            this.settingsPanel.Location = new System.Drawing.Point(0, 145);
            this.settingsPanel.Margin = new System.Windows.Forms.Padding(0);
            this.settingsPanel.Name = "settingsPanel";
            this.settingsPanel.Size = new System.Drawing.Size(190, 47);
            this.settingsPanel.TabIndex = 5;
            this.settingsPanel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.settingsPanel_MouseClick);
            // 
            // settingsLabel
            // 
            this.settingsLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.settingsLabel.AutoSize = true;
            this.settingsLabel.BackColor = System.Drawing.Color.Transparent;
            this.settingsLabel.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.settingsLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(217)))), ((int)(((byte)(221)))));
            this.settingsLabel.Location = new System.Drawing.Point(45, 9);
            this.settingsLabel.Name = "settingsLabel";
            this.settingsLabel.Size = new System.Drawing.Size(97, 29);
            this.settingsLabel.TabIndex = 1;
            this.settingsLabel.Text = "Settings";
            this.settingsLabel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.settingsPanel_MouseClick);
            // 
            // statsPanel
            // 
            this.statsPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(117)))), ((int)(((byte)(131)))));
            this.statsPanel.Controls.Add(this.statsLabel);
            this.statsPanel.Location = new System.Drawing.Point(0, 98);
            this.statsPanel.Margin = new System.Windows.Forms.Padding(0);
            this.statsPanel.Name = "statsPanel";
            this.statsPanel.Size = new System.Drawing.Size(190, 47);
            this.statsPanel.TabIndex = 5;
            this.statsPanel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.statsPanel_MouseClick);
            // 
            // statsLabel
            // 
            this.statsLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.statsLabel.AutoSize = true;
            this.statsLabel.BackColor = System.Drawing.Color.Transparent;
            this.statsLabel.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statsLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(217)))), ((int)(((byte)(221)))));
            this.statsLabel.Location = new System.Drawing.Point(45, 7);
            this.statsLabel.Name = "statsLabel";
            this.statsLabel.Size = new System.Drawing.Size(106, 29);
            this.statsLabel.TabIndex = 2;
            this.statsLabel.Text = "Statistics";
            this.statsLabel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.statsPanel_MouseClick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.settingsWindow);
            this.panel1.Controls.Add(this.statsWindow);
            this.panel1.Controls.Add(this.homeWindow);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(190, 51);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(672, 432);
            this.panel1.TabIndex = 6;
            // 
            // settingsWindow
            // 
            this.settingsWindow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(217)))), ((int)(((byte)(221)))));
            this.settingsWindow.Location = new System.Drawing.Point(0, 0);
            this.settingsWindow.Name = "settingsWindow";
            this.settingsWindow.Size = new System.Drawing.Size(672, 432);
            this.settingsWindow.TabIndex = 1;
            // 
            // statsWindow
            // 
            this.statsWindow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(217)))), ((int)(((byte)(221)))));
            this.statsWindow.Location = new System.Drawing.Point(0, 0);
            this.statsWindow.Name = "statsWindow";
            this.statsWindow.Size = new System.Drawing.Size(672, 432);
            this.statsWindow.TabIndex = 2;
            // 
            // homeWindow
            // 
            this.homeWindow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(217)))), ((int)(((byte)(221)))));
            this.homeWindow.Location = new System.Drawing.Point(0, 0);
            this.homeWindow.Name = "homeWindow";
            this.homeWindow.Size = new System.Drawing.Size(672, 432);
            this.homeWindow.TabIndex = 0;
            this.homeWindow.Load += new System.EventHandler(this.homeWindow_Load);
            // 
            // smallPanelBottom
            // 
            this.smallPanelBottom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(66)))), ((int)(((byte)(80)))));
            this.smallPanelBottom.Location = new System.Drawing.Point(0, 430);
            this.smallPanelBottom.Margin = new System.Windows.Forms.Padding(0);
            this.smallPanelBottom.Name = "smallPanelBottom";
            this.smallPanelBottom.Size = new System.Drawing.Size(190, 53);
            this.smallPanelBottom.TabIndex = 7;
            this.smallPanelBottom.TabStop = false;
            // 
            // lb_minimize
            // 
            this.lb_minimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_minimize.AutoSize = true;
            this.lb_minimize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(180)))), ((int)(((byte)(187)))));
            this.lb_minimize.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lb_minimize.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(66)))), ((int)(((byte)(80)))));
            this.lb_minimize.Location = new System.Drawing.Point(798, 12);
            this.lb_minimize.Margin = new System.Windows.Forms.Padding(0);
            this.lb_minimize.Name = "lb_minimize";
            this.lb_minimize.Size = new System.Drawing.Size(25, 28);
            this.lb_minimize.TabIndex = 8;
            this.lb_minimize.Text = "—";
            this.lb_minimize.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lb_minimize_MouseClick);
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(862, 483);
            this.Controls.Add(this.lb_minimize);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.smallPanelBottom);
            this.Controls.Add(this.lb_close);
            this.Controls.Add(this.settingsPanel);
            this.Controls.Add(this.statsPanel);
            this.Controls.Add(this.homePanel);
            this.Controls.Add(this.smallPanelTop);
            this.Controls.Add(this.sidePanel);
            this.Controls.Add(this.topPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "mainForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.Load += new System.EventHandler(this.mainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sidePanel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.topPanel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.smallPanelTop)).EndInit();
            this.homePanel.ResumeLayout(false);
            this.homePanel.PerformLayout();
            this.settingsPanel.ResumeLayout(false);
            this.settingsPanel.PerformLayout();
            this.statsPanel.ResumeLayout(false);
            this.statsPanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.smallPanelBottom)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void homeWindow_Load(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.Label lb_close;
        private System.Windows.Forms.PictureBox sidePanel;
        private System.Windows.Forms.PictureBox topPanel;
        private System.Windows.Forms.PictureBox smallPanelTop;
        private System.Windows.Forms.Panel homePanel;
        private System.Windows.Forms.Panel settingsPanel;
        private System.Windows.Forms.Panel statsPanel;
        private System.Windows.Forms.Panel panel1;
        private StatsWindow statsWindow;
        private SettingWindow settingsWindow;
        private HomeWindow homeWindow;
        private System.Windows.Forms.Label homeLabel;
        private System.Windows.Forms.Label statsLabel;
        private System.Windows.Forms.Label settingsLabel;
        private System.Windows.Forms.PictureBox smallPanelBottom;
        private System.Windows.Forms.Label lb_minimize;
    }
}

