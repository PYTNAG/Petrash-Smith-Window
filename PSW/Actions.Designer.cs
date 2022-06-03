namespace PSW
{
    partial class Actions
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
            this.Home = new System.Windows.Forms.Button();
            this.RegistrationModule = new System.Windows.Forms.Button();
            this.CheckModule = new System.Windows.Forms.Button();
            this.TechModule = new System.Windows.Forms.Button();
            this.MainModule = new System.Windows.Forms.Button();
            this.Time = new System.Windows.Forms.Label();
            this.Day = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Home
            // 
            this.Home.Location = new System.Drawing.Point(12, 12);
            this.Home.Name = "Home";
            this.Home.Size = new System.Drawing.Size(271, 70);
            this.Home.TabIndex = 0;
            this.Home.Text = "Домой (Пропустить день)";
            this.Home.UseVisualStyleBackColor = true;
            this.Home.Click += new System.EventHandler(this.MoveToHome);
            // 
            // RegistrationModule
            // 
            this.RegistrationModule.Location = new System.Drawing.Point(12, 88);
            this.RegistrationModule.Name = "RegistrationModule";
            this.RegistrationModule.Size = new System.Drawing.Size(271, 70);
            this.RegistrationModule.TabIndex = 1;
            this.RegistrationModule.Text = "Учётная Часть / УЧ";
            this.RegistrationModule.UseVisualStyleBackColor = true;
            this.RegistrationModule.Click += new System.EventHandler(this.MoveToRegistrationModule);
            // 
            // CheckModule
            // 
            this.CheckModule.Location = new System.Drawing.Point(12, 164);
            this.CheckModule.Name = "CheckModule";
            this.CheckModule.Size = new System.Drawing.Size(271, 70);
            this.CheckModule.TabIndex = 2;
            this.CheckModule.Text = "Проверочная Часть / ПЧ";
            this.CheckModule.UseVisualStyleBackColor = true;
            this.CheckModule.Click += new System.EventHandler(this.MoveToCheckModule);
            // 
            // TechModule
            // 
            this.TechModule.Location = new System.Drawing.Point(12, 240);
            this.TechModule.Name = "TechModule";
            this.TechModule.Size = new System.Drawing.Size(271, 70);
            this.TechModule.TabIndex = 3;
            this.TechModule.Text = "Техническая Часть / ТЧ";
            this.TechModule.UseVisualStyleBackColor = true;
            this.TechModule.Click += new System.EventHandler(this.MoveToTechModule);
            // 
            // MainModule
            // 
            this.MainModule.Location = new System.Drawing.Point(12, 316);
            this.MainModule.Name = "MainModule";
            this.MainModule.Size = new System.Drawing.Size(271, 70);
            this.MainModule.TabIndex = 4;
            this.MainModule.Text = "Основная Часть / ОЧ";
            this.MainModule.UseVisualStyleBackColor = true;
            this.MainModule.Click += new System.EventHandler(this.MoveToMainModule);
            // 
            // Time
            // 
            this.Time.AutoSize = true;
            this.Time.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Time.Location = new System.Drawing.Point(322, 50);
            this.Time.Name = "Time";
            this.Time.Size = new System.Drawing.Size(86, 32);
            this.Time.TabIndex = 5;
            this.Time.Text = "10:53";
            // 
            // Day
            // 
            this.Day.AutoSize = true;
            this.Day.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Day.Location = new System.Drawing.Point(322, 9);
            this.Day.Name = "Day";
            this.Day.Size = new System.Drawing.Size(106, 32);
            this.Day.TabIndex = 6;
            this.Day.Text = "День 0";
            // 
            // Actions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 398);
            this.Controls.Add(this.Day);
            this.Controls.Add(this.Time);
            this.Controls.Add(this.MainModule);
            this.Controls.Add(this.TechModule);
            this.Controls.Add(this.CheckModule);
            this.Controls.Add(this.RegistrationModule);
            this.Controls.Add(this.Home);
            this.Name = "Actions";
            this.Text = "Действия";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Home;
        private System.Windows.Forms.Button RegistrationModule;
        private System.Windows.Forms.Button CheckModule;
        private System.Windows.Forms.Button TechModule;
        private System.Windows.Forms.Button MainModule;
        private System.Windows.Forms.Label Time;
        private System.Windows.Forms.Label Day;
    }
}