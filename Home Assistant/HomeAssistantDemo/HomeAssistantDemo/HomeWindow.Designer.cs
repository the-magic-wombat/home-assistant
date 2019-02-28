namespace HomeAssistantDemo
{
    partial class HomeWindow
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
            this.temperaturePicture = new System.Windows.Forms.PictureBox();
            this.humidityPicture = new System.Windows.Forms.PictureBox();
            this.lb_temp = new System.Windows.Forms.Label();
            this.lb_humid = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.temperaturePicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.humidityPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // temperaturePicture
            // 
            this.temperaturePicture.Image = global::HomeAssistantDemo.Properties.Resources.temperature_symbol__colored_;
            this.temperaturePicture.Location = new System.Drawing.Point(271, 217);
            this.temperaturePicture.Name = "temperaturePicture";
            this.temperaturePicture.Size = new System.Drawing.Size(20, 57);
            this.temperaturePicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.temperaturePicture.TabIndex = 1;
            this.temperaturePicture.TabStop = false;
            // 
            // humidityPicture
            // 
            this.humidityPicture.BackColor = System.Drawing.Color.Transparent;
            this.humidityPicture.Image = global::HomeAssistantDemo.Properties.Resources.humidity_symbol__colored_;
            this.humidityPicture.ImageLocation = "";
            this.humidityPicture.InitialImage = null;
            this.humidityPicture.Location = new System.Drawing.Point(261, 112);
            this.humidityPicture.Name = "humidityPicture";
            this.humidityPicture.Size = new System.Drawing.Size(43, 57);
            this.humidityPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.humidityPicture.TabIndex = 0;
            this.humidityPicture.TabStop = false;
            // 
            // lb_temp
            // 
            this.lb_temp.AutoSize = true;
            this.lb_temp.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lb_temp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(66)))), ((int)(((byte)(80)))));
            this.lb_temp.Location = new System.Drawing.Point(325, 235);
            this.lb_temp.Name = "lb_temp";
            this.lb_temp.Size = new System.Drawing.Size(75, 39);
            this.lb_temp.TabIndex = 2;
            this.lb_temp.Text = "0°C";
            // 
            // lb_humid
            // 
            this.lb_humid.AutoSize = true;
            this.lb_humid.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lb_humid.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(66)))), ((int)(((byte)(80)))));
            this.lb_humid.Location = new System.Drawing.Point(333, 130);
            this.lb_humid.Name = "lb_humid";
            this.lb_humid.Size = new System.Drawing.Size(67, 39);
            this.lb_humid.TabIndex = 3;
            this.lb_humid.Text = "0%";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // HomeWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(217)))), ((int)(((byte)(221)))));
            this.Controls.Add(this.lb_humid);
            this.Controls.Add(this.lb_temp);
            this.Controls.Add(this.temperaturePicture);
            this.Controls.Add(this.humidityPicture);
            this.Name = "HomeWindow";
            this.Size = new System.Drawing.Size(632, 428);
            this.Load += new System.EventHandler(this.HomeWindow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.temperaturePicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.humidityPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox temperaturePicture;
        private System.Windows.Forms.PictureBox humidityPicture;
        private System.Windows.Forms.Label lb_temp;
        private System.Windows.Forms.Label lb_humid;
        private System.Windows.Forms.Timer timer1;
    }
}
