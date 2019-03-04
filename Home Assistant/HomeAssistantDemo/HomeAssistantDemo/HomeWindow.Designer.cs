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
            this.lb_temp_C = new System.Windows.Forms.Label();
            this.lb_humid = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lb_temp_status = new System.Windows.Forms.Label();
            this.lb_humidity_status = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lb_status = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.temperaturePicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.humidityPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // temperaturePicture
            // 
            this.temperaturePicture.Image = global::HomeAssistantDemo.Properties.Resources.temperature_symbol__colored_;
            this.temperaturePicture.Location = new System.Drawing.Point(436, 37);
            this.temperaturePicture.Name = "temperaturePicture";
            this.temperaturePicture.Size = new System.Drawing.Size(33, 91);
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
            this.humidityPicture.Location = new System.Drawing.Point(400, 190);
            this.humidityPicture.Name = "humidityPicture";
            this.humidityPicture.Size = new System.Drawing.Size(60, 83);
            this.humidityPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.humidityPicture.TabIndex = 0;
            this.humidityPicture.TabStop = false;
            // 
            // lb_temp_C
            // 
            this.lb_temp_C.AutoSize = true;
            this.lb_temp_C.Font = new System.Drawing.Font("Tahoma", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lb_temp_C.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(66)))), ((int)(((byte)(80)))));
            this.lb_temp_C.Location = new System.Drawing.Point(296, 35);
            this.lb_temp_C.Name = "lb_temp_C";
            this.lb_temp_C.Size = new System.Drawing.Size(62, 35);
            this.lb_temp_C.TabIndex = 2;
            this.lb_temp_C.Text = "0°C";
            // 
            // lb_humid
            // 
            this.lb_humid.AutoSize = true;
            this.lb_humid.Font = new System.Drawing.Font("Tahoma", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lb_humid.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(66)))), ((int)(((byte)(80)))));
            this.lb_humid.Location = new System.Drawing.Point(250, 190);
            this.lb_humid.Name = "lb_humid";
            this.lb_humid.Size = new System.Drawing.Size(59, 35);
            this.lb_humid.TabIndex = 3;
            this.lb_humid.Text = "0%";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 5000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(66)))), ((int)(((byte)(80)))));
            this.label1.Location = new System.Drawing.Point(19, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(284, 35);
            this.label1.TabIndex = 8;
            this.label1.Text = "Current temperature:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(66)))), ((int)(((byte)(80)))));
            this.label3.Location = new System.Drawing.Point(19, 190);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(238, 35);
            this.label3.TabIndex = 9;
            this.label3.Text = "Current humidity:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(66)))), ((int)(((byte)(80)))));
            this.label4.Location = new System.Drawing.Point(19, 238);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(225, 35);
            this.label4.TabIndex = 10;
            this.label4.Text = "Humidity status:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(66)))), ((int)(((byte)(80)))));
            this.label5.Location = new System.Drawing.Point(19, 91);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(274, 35);
            this.label5.TabIndex = 11;
            this.label5.Text = "Temperature status:";
            // 
            // lb_temp_status
            // 
            this.lb_temp_status.AutoSize = true;
            this.lb_temp_status.Font = new System.Drawing.Font("Tahoma", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lb_temp_status.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(66)))), ((int)(((byte)(80)))));
            this.lb_temp_status.Location = new System.Drawing.Point(296, 91);
            this.lb_temp_status.Name = "lb_temp_status";
            this.lb_temp_status.Size = new System.Drawing.Size(106, 35);
            this.lb_temp_status.TabIndex = 12;
            this.lb_temp_status.Text = "Normal";
            // 
            // lb_humidity_status
            // 
            this.lb_humidity_status.AutoSize = true;
            this.lb_humidity_status.Font = new System.Drawing.Font("Tahoma", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lb_humidity_status.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(66)))), ((int)(((byte)(80)))));
            this.lb_humidity_status.Location = new System.Drawing.Point(250, 238);
            this.lb_humidity_status.Name = "lb_humidity_status";
            this.lb_humidity_status.Size = new System.Drawing.Size(106, 35);
            this.lb_humidity_status.TabIndex = 13;
            this.lb_humidity_status.Text = "Normal";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::HomeAssistantDemo.Properties.Resources.reload_icon__colored_;
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(235, 310);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(25, 25);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // lb_status
            // 
            this.lb_status.AutoSize = true;
            this.lb_status.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(217)))), ((int)(((byte)(221)))));
            this.lb_status.Font = new System.Drawing.Font("Trebuchet MS", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_status.ForeColor = System.Drawing.Color.Maroon;
            this.lb_status.Location = new System.Drawing.Point(154, 308);
            this.lb_status.Name = "lb_status";
            this.lb_status.Size = new System.Drawing.Size(82, 27);
            this.lb_status.TabIndex = 16;
            this.lb_status.Text = "Offline";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(217)))), ((int)(((byte)(221)))));
            this.label2.Font = new System.Drawing.Font("Trebuchet MS", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(66)))), ((int)(((byte)(80)))));
            this.label2.Location = new System.Drawing.Point(20, 308);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 27);
            this.label2.TabIndex = 15;
            this.label2.Text = "Connection:";
            // 
            // HomeWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(217)))), ((int)(((byte)(221)))));
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lb_status);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lb_humidity_status);
            this.Controls.Add(this.lb_temp_status);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lb_humid);
            this.Controls.Add(this.lb_temp_C);
            this.Controls.Add(this.temperaturePicture);
            this.Controls.Add(this.humidityPicture);
            this.Name = "HomeWindow";
            this.Size = new System.Drawing.Size(502, 356);
            this.Load += new System.EventHandler(this.HomeWindow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.temperaturePicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.humidityPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox temperaturePicture;
        private System.Windows.Forms.PictureBox humidityPicture;
        private System.Windows.Forms.Label lb_humid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lb_temp_status;
        private System.Windows.Forms.Label lb_humidity_status;
        public System.Windows.Forms.Label lb_temp_C;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lb_status;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.Timer timer1;
    }
}
