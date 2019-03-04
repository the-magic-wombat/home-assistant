namespace HomeAssistantDemo
{
    partial class StatsWindow
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart_temp_day = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.chart_humid_day = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.chart_temp_day)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_humid_day)).BeginInit();
            this.SuspendLayout();
            // 
            // chart_temp_day
            // 
            this.chart_temp_day.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(217)))), ((int)(((byte)(221)))));
            this.chart_temp_day.BorderSkin.BackColor = System.Drawing.Color.White;
            chartArea3.AxisX.IsLabelAutoFit = false;
            chartArea3.AxisX.LabelStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            chartArea3.AxisX.TitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(66)))), ((int)(((byte)(80)))));
            chartArea3.AxisY.LogarithmBase = 2D;
            chartArea3.AxisY.TextOrientation = System.Windows.Forms.DataVisualization.Charting.TextOrientation.Horizontal;
            chartArea3.AxisY.TitleAlignment = System.Drawing.StringAlignment.Near;
            chartArea3.AxisY.TitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(66)))), ((int)(((byte)(80)))));
            chartArea3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(217)))), ((int)(((byte)(221)))));
            chartArea3.Name = "ChartArea1";
            this.chart_temp_day.ChartAreas.Add(chartArea3);
            this.chart_temp_day.Location = new System.Drawing.Point(8, 27);
            this.chart_temp_day.Name = "chart_temp_day";
            this.chart_temp_day.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Pastel;
            series3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(66)))), ((int)(((byte)(80)))));
            series3.BorderWidth = 2;
            series3.ChartArea = "ChartArea1";
            series3.Color = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(90)))), ((int)(((byte)(131)))));
            series3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            series3.LabelForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(66)))), ((int)(((byte)(80)))));
            series3.Name = "Temperature";
            this.chart_temp_day.Series.Add(series3);
            this.chart_temp_day.Size = new System.Drawing.Size(466, 154);
            this.chart_temp_day.TabIndex = 4;
            this.chart_temp_day.Text = "chart4";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(66)))), ((int)(((byte)(80)))));
            this.label1.Location = new System.Drawing.Point(123, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(268, 27);
            this.label1.TabIndex = 7;
            this.label1.Text = "Recent Temperatures (°C)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(66)))), ((int)(((byte)(80)))));
            this.label2.Location = new System.Drawing.Point(144, 184);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(215, 27);
            this.label2.TabIndex = 9;
            this.label2.Text = "Recent Humidity (%)";
            // 
            // chart_humid_day
            // 
            this.chart_humid_day.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(217)))), ((int)(((byte)(221)))));
            this.chart_humid_day.BorderSkin.BackColor = System.Drawing.Color.White;
            chartArea4.AxisX.IsLabelAutoFit = false;
            chartArea4.AxisX.LabelStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            chartArea4.AxisX.TitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(66)))), ((int)(((byte)(80)))));
            chartArea4.AxisY.LogarithmBase = 2D;
            chartArea4.AxisY.TextOrientation = System.Windows.Forms.DataVisualization.Charting.TextOrientation.Horizontal;
            chartArea4.AxisY.TitleAlignment = System.Drawing.StringAlignment.Near;
            chartArea4.AxisY.TitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(66)))), ((int)(((byte)(80)))));
            chartArea4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(217)))), ((int)(((byte)(221)))));
            chartArea4.Name = "ChartArea1";
            this.chart_humid_day.ChartAreas.Add(chartArea4);
            this.chart_humid_day.Location = new System.Drawing.Point(8, 202);
            this.chart_humid_day.Name = "chart_humid_day";
            this.chart_humid_day.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Pastel;
            series4.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(66)))), ((int)(((byte)(80)))));
            series4.BorderWidth = 2;
            series4.ChartArea = "ChartArea1";
            series4.Color = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(90)))), ((int)(((byte)(131)))));
            series4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            series4.LabelForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(66)))), ((int)(((byte)(80)))));
            series4.Name = "Humidity";
            this.chart_humid_day.Series.Add(series4);
            this.chart_humid_day.Size = new System.Drawing.Size(466, 154);
            this.chart_humid_day.TabIndex = 8;
            this.chart_humid_day.Text = "chart4";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 10000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // StatsWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(217)))), ((int)(((byte)(221)))));
            this.Controls.Add(this.label2);
            this.Controls.Add(this.chart_humid_day);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chart_temp_day);
            this.Name = "StatsWindow";
            this.Size = new System.Drawing.Size(502, 356);
            this.Load += new System.EventHandler(this.StatsWindow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart_temp_day)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_humid_day)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_temp_day;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_humid_day;
        private System.Windows.Forms.Timer timer1;
    }
}
