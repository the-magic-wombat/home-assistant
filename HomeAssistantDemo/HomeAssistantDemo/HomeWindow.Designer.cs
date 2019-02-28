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
            this.temperaturePicture = new System.Windows.Forms.PictureBox();
            this.humidityPicture = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(66)))), ((int)(((byte)(80)))));
            this.label1.Location = new System.Drawing.Point(320, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 39);
            this.label1.TabIndex = 2;
            this.label1.Text = "0°C";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(66)))), ((int)(((byte)(80)))));
            this.label2.Location = new System.Drawing.Point(320, 235);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 39);
            this.label2.TabIndex = 3;
            this.label2.Text = "0%";
            // 
            // HomeWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(217)))), ((int)(((byte)(221)))));
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}
