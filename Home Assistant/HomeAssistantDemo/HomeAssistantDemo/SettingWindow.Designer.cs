namespace HomeAssistantDemo
{
    partial class SettingWindow
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
            this.fButton = new System.Windows.Forms.RadioButton();
            this.cButton = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.minTempBox = new System.Windows.Forms.TextBox();
            this.lb_confirm = new System.Windows.Forms.Label();
            this.maxTempBox = new System.Windows.Forms.TextBox();
            this.lb_success = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.maxHumidBox = new System.Windows.Forms.TextBox();
            this.minHumidBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.kButton = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // fButton
            // 
            this.fButton.AutoSize = true;
            this.fButton.Font = new System.Drawing.Font("Trebuchet MS", 16F);
            this.fButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(66)))), ((int)(((byte)(80)))));
            this.fButton.Location = new System.Drawing.Point(168, 247);
            this.fButton.Name = "fButton";
            this.fButton.Size = new System.Drawing.Size(138, 31);
            this.fButton.TabIndex = 15;
            this.fButton.Text = "Fahrenheit";
            this.fButton.UseVisualStyleBackColor = true;
            this.fButton.CheckedChanged += new System.EventHandler(this.fButton_CheckedChanged);
            // 
            // cButton
            // 
            this.cButton.AutoSize = true;
            this.cButton.Checked = true;
            this.cButton.Font = new System.Drawing.Font("Trebuchet MS", 16F);
            this.cButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(66)))), ((int)(((byte)(80)))));
            this.cButton.Location = new System.Drawing.Point(25, 247);
            this.cButton.Name = "cButton";
            this.cButton.Size = new System.Drawing.Size(97, 31);
            this.cButton.TabIndex = 16;
            this.cButton.TabStop = true;
            this.cButton.Text = "Celsius";
            this.cButton.UseVisualStyleBackColor = true;
            this.cButton.CheckedChanged += new System.EventHandler(this.cButton_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(217)))), ((int)(((byte)(221)))));
            this.label4.Font = new System.Drawing.Font("Trebuchet MS", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(66)))), ((int)(((byte)(80)))));
            this.label4.Location = new System.Drawing.Point(20, 205);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(213, 27);
            this.label4.TabIndex = 19;
            this.label4.Text = "Temperature Scale:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(217)))), ((int)(((byte)(221)))));
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(66)))), ((int)(((byte)(80)))));
            this.label1.Location = new System.Drawing.Point(20, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(264, 27);
            this.label1.TabIndex = 20;
            this.label1.Text = "Temperature Norm (°C):";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(217)))), ((int)(((byte)(221)))));
            this.label2.Font = new System.Drawing.Font("Trebuchet MS", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(66)))), ((int)(((byte)(80)))));
            this.label2.Location = new System.Drawing.Point(20, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(215, 27);
            this.label2.TabIndex = 21;
            this.label2.Text = "Humidity Norm (%):";
            // 
            // minTempBox
            // 
            this.minTempBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(217)))), ((int)(((byte)(221)))));
            this.minTempBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(66)))), ((int)(((byte)(80)))));
            this.minTempBox.Location = new System.Drawing.Point(287, 54);
            this.minTempBox.Name = "minTempBox";
            this.minTempBox.Size = new System.Drawing.Size(40, 20);
            this.minTempBox.TabIndex = 22;
            this.minTempBox.Text = "0";
            // 
            // lb_confirm
            // 
            this.lb_confirm.AutoSize = true;
            this.lb_confirm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(217)))), ((int)(((byte)(221)))));
            this.lb_confirm.Font = new System.Drawing.Font("Trebuchet MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_confirm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(66)))), ((int)(((byte)(80)))));
            this.lb_confirm.Location = new System.Drawing.Point(386, 66);
            this.lb_confirm.Name = "lb_confirm";
            this.lb_confirm.Size = new System.Drawing.Size(103, 29);
            this.lb_confirm.TabIndex = 23;
            this.lb_confirm.Text = "Confirm";
            this.lb_confirm.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lb_confirm_MouseClick);
            // 
            // maxTempBox
            // 
            this.maxTempBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(217)))), ((int)(((byte)(221)))));
            this.maxTempBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(66)))), ((int)(((byte)(80)))));
            this.maxTempBox.Location = new System.Drawing.Point(333, 54);
            this.maxTempBox.Name = "maxTempBox";
            this.maxTempBox.Size = new System.Drawing.Size(40, 20);
            this.maxTempBox.TabIndex = 24;
            this.maxTempBox.Text = "0";
            // 
            // lb_success
            // 
            this.lb_success.AutoSize = true;
            this.lb_success.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(217)))), ((int)(((byte)(221)))));
            this.lb_success.Font = new System.Drawing.Font("Trebuchet MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_success.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(66)))), ((int)(((byte)(80)))));
            this.lb_success.Location = new System.Drawing.Point(130, 125);
            this.lb_success.Name = "lb_success";
            this.lb_success.Size = new System.Drawing.Size(250, 29);
            this.lb_success.TabIndex = 25;
            this.lb_success.Text = "Changed Successfully";
            this.lb_success.Visible = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 2300;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // maxHumidBox
            // 
            this.maxHumidBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(217)))), ((int)(((byte)(221)))));
            this.maxHumidBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(66)))), ((int)(((byte)(80)))));
            this.maxHumidBox.Location = new System.Drawing.Point(333, 86);
            this.maxHumidBox.Name = "maxHumidBox";
            this.maxHumidBox.Size = new System.Drawing.Size(40, 20);
            this.maxHumidBox.TabIndex = 28;
            this.maxHumidBox.Text = "0";
            // 
            // minHumidBox
            // 
            this.minHumidBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(217)))), ((int)(((byte)(221)))));
            this.minHumidBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(66)))), ((int)(((byte)(80)))));
            this.minHumidBox.Location = new System.Drawing.Point(287, 86);
            this.minHumidBox.Name = "minHumidBox";
            this.minHumidBox.Size = new System.Drawing.Size(40, 20);
            this.minHumidBox.TabIndex = 26;
            this.minHumidBox.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(217)))), ((int)(((byte)(221)))));
            this.label3.Font = new System.Drawing.Font("Trebuchet MS", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(66)))), ((int)(((byte)(80)))));
            this.label3.Location = new System.Drawing.Point(328, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 27);
            this.label3.TabIndex = 29;
            this.label3.Text = "Max";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(217)))), ((int)(((byte)(221)))));
            this.label5.Font = new System.Drawing.Font("Trebuchet MS", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(66)))), ((int)(((byte)(80)))));
            this.label5.Location = new System.Drawing.Point(282, 17);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 27);
            this.label5.TabIndex = 30;
            this.label5.Text = "Min";
            // 
            // kButton
            // 
            this.kButton.AutoSize = true;
            this.kButton.Font = new System.Drawing.Font("Trebuchet MS", 16F);
            this.kButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(66)))), ((int)(((byte)(80)))));
            this.kButton.Location = new System.Drawing.Point(351, 247);
            this.kButton.Name = "kButton";
            this.kButton.Size = new System.Drawing.Size(89, 31);
            this.kButton.TabIndex = 31;
            this.kButton.Text = "Kelvin";
            this.kButton.UseVisualStyleBackColor = true;
            this.kButton.CheckedChanged += new System.EventHandler(this.kButton_CheckedChanged);
            // 
            // SettingWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(217)))), ((int)(((byte)(221)))));
            this.Controls.Add(this.kButton);
            this.Controls.Add(this.cButton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.maxHumidBox);
            this.Controls.Add(this.minHumidBox);
            this.Controls.Add(this.lb_success);
            this.Controls.Add(this.maxTempBox);
            this.Controls.Add(this.lb_confirm);
            this.Controls.Add(this.minTempBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.fButton);
            this.Name = "SettingWindow";
            this.Size = new System.Drawing.Size(502, 356);
            this.Load += new System.EventHandler(this.SettingWindow_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RadioButton fButton;
        private System.Windows.Forms.RadioButton cButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox minTempBox;
        private System.Windows.Forms.Label lb_confirm;
        private System.Windows.Forms.TextBox maxTempBox;
        private System.Windows.Forms.Label lb_success;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox maxHumidBox;
        private System.Windows.Forms.TextBox minHumidBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton kButton;
    }
}
