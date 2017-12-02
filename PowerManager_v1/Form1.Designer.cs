namespace PowerManager_v1
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.HoursLabel = new System.Windows.Forms.Label();
            this.HoursInput = new System.Windows.Forms.TextBox();
            this.lMinutesLabel = new System.Windows.Forms.Label();
            this.MinutesInput = new System.Windows.Forms.TextBox();
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.LeftTimeLabel = new System.Windows.Forms.Label();
            this.TimeLeft = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // HoursLabel
            // 
            this.HoursLabel.AutoSize = true;
            this.HoursLabel.Font = new System.Drawing.Font("Times New Roman", 24F);
            this.HoursLabel.Location = new System.Drawing.Point(12, 32);
            this.HoursLabel.Name = "HoursLabel";
            this.HoursLabel.Size = new System.Drawing.Size(137, 46);
            this.HoursLabel.TabIndex = 0;
            this.HoursLabel.Text = "Hours: ";
            // 
            // HoursInput
            // 
            this.HoursInput.Font = new System.Drawing.Font("Times New Roman", 24F);
            this.HoursInput.Location = new System.Drawing.Point(130, 29);
            this.HoursInput.Name = "HoursInput";
            this.HoursInput.Size = new System.Drawing.Size(76, 53);
            this.HoursInput.TabIndex = 1;
            // 
            // lMinutesLabel
            // 
            this.lMinutesLabel.AutoSize = true;
            this.lMinutesLabel.Font = new System.Drawing.Font("Times New Roman", 24F);
            this.lMinutesLabel.Location = new System.Drawing.Point(227, 32);
            this.lMinutesLabel.Name = "lMinutesLabel";
            this.lMinutesLabel.Size = new System.Drawing.Size(172, 46);
            this.lMinutesLabel.TabIndex = 2;
            this.lMinutesLabel.Text = "Minutes: ";
            // 
            // MinutesInput
            // 
            this.MinutesInput.Font = new System.Drawing.Font("Times New Roman", 24F);
            this.MinutesInput.Location = new System.Drawing.Point(375, 29);
            this.MinutesInput.Name = "MinutesInput";
            this.MinutesInput.Size = new System.Drawing.Size(76, 53);
            this.MinutesInput.TabIndex = 3;
            // 
            // Timer
            // 
            this.Timer.Interval = 1000;
            this.Timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Times New Roman", 24F);
            this.button1.Location = new System.Drawing.Point(20, 117);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(209, 50);
            this.button1.TabIndex = 4;
            this.button1.Text = "ShutDown";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Times New Roman", 24F);
            this.button2.Location = new System.Drawing.Point(265, 117);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(143, 50);
            this.button2.TabIndex = 5;
            this.button2.Text = "Abort";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // LeftTimeLabel
            // 
            this.LeftTimeLabel.AutoSize = true;
            this.LeftTimeLabel.Font = new System.Drawing.Font("Times New Roman", 24F);
            this.LeftTimeLabel.Location = new System.Drawing.Point(27, 210);
            this.LeftTimeLabel.Name = "LeftTimeLabel";
            this.LeftTimeLabel.Size = new System.Drawing.Size(195, 46);
            this.LeftTimeLabel.TabIndex = 6;
            this.LeftTimeLabel.Text = "Time Left: ";
            // 
            // TimeLeft
            // 
            this.TimeLeft.AutoSize = true;
            this.TimeLeft.Font = new System.Drawing.Font("Times New Roman", 24F);
            this.TimeLeft.Location = new System.Drawing.Point(244, 210);
            this.TimeLeft.Name = "TimeLeft";
            this.TimeLeft.Size = new System.Drawing.Size(40, 46);
            this.TimeLeft.TabIndex = 7;
            this.TimeLeft.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(487, 396);
            this.Controls.Add(this.TimeLeft);
            this.Controls.Add(this.LeftTimeLabel);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.MinutesInput);
            this.Controls.Add(this.lMinutesLabel);
            this.Controls.Add(this.HoursInput);
            this.Controls.Add(this.HoursLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = "PowerManager";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label HoursLabel;
        private System.Windows.Forms.TextBox HoursInput;
        private System.Windows.Forms.Label lMinutesLabel;
        private System.Windows.Forms.TextBox MinutesInput;
        private System.Windows.Forms.Timer Timer;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label LeftTimeLabel;
        private System.Windows.Forms.Label TimeLeft;
    }
}

