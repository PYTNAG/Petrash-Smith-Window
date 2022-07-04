namespace PSW
{
    partial class Tech
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
            this.OpenCloseBtn = new System.Windows.Forms.Button();
            this.LoadBtn = new System.Windows.Forms.Button();
            this.DeltaBottle = new System.Windows.Forms.GroupBox();
            this.dbReserve = new System.Windows.Forms.ProgressBar();
            this.dbCheckBox = new System.Windows.Forms.CheckBox();
            this.dbReplaceBtn = new System.Windows.Forms.Button();
            this.Gazer12 = new System.Windows.Forms.GroupBox();
            this.g12Reserve = new System.Windows.Forms.ProgressBar();
            this.g12CheckBox = new System.Windows.Forms.CheckBox();
            this.g12ReplaceBtn = new System.Windows.Forms.Button();
            this.PZ = new System.Windows.Forms.GroupBox();
            this.pzReserve = new System.Windows.Forms.ProgressBar();
            this.pzCheckBox = new System.Windows.Forms.CheckBox();
            this.pzReplaceBtn = new System.Windows.Forms.Button();
            this.ChiStop = new System.Windows.Forms.GroupBox();
            this.xstopReserve = new System.Windows.Forms.ProgressBar();
            this.xstopCheckBox = new System.Windows.Forms.CheckBox();
            this.xstopReplaceBtn = new System.Windows.Forms.Button();
            this.ChiCatalyst = new System.Windows.Forms.GroupBox();
            this.xcatReserve = new System.Windows.Forms.ProgressBar();
            this.xcatCheckBox = new System.Windows.Forms.CheckBox();
            this.xcatReplaceBtn = new System.Windows.Forms.Button();
            this.DeltaBottle.SuspendLayout();
            this.Gazer12.SuspendLayout();
            this.PZ.SuspendLayout();
            this.ChiStop.SuspendLayout();
            this.ChiCatalyst.SuspendLayout();
            this.SuspendLayout();
            // 
            // OpenCloseBtn
            // 
            this.OpenCloseBtn.Location = new System.Drawing.Point(12, 405);
            this.OpenCloseBtn.Name = "OpenCloseBtn";
            this.OpenCloseBtn.Size = new System.Drawing.Size(385, 43);
            this.OpenCloseBtn.TabIndex = 20;
            this.OpenCloseBtn.Text = "Открыть / Закрыть";
            this.OpenCloseBtn.UseVisualStyleBackColor = true;
            this.OpenCloseBtn.Click += new System.EventHandler(this.OpenCloseBtn_Click);
            // 
            // LoadBtn
            // 
            this.LoadBtn.Location = new System.Drawing.Point(403, 405);
            this.LoadBtn.Name = "LoadBtn";
            this.LoadBtn.Size = new System.Drawing.Size(385, 43);
            this.LoadBtn.TabIndex = 21;
            this.LoadBtn.Text = "Загрузить (20 минут)";
            this.LoadBtn.UseVisualStyleBackColor = true;
            this.LoadBtn.Click += new System.EventHandler(this.LoadBtn_Click);
            // 
            // DeltaBottle
            // 
            this.DeltaBottle.AutoSize = true;
            this.DeltaBottle.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.DeltaBottle.Controls.Add(this.dbReserve);
            this.DeltaBottle.Controls.Add(this.dbCheckBox);
            this.DeltaBottle.Controls.Add(this.dbReplaceBtn);
            this.DeltaBottle.Location = new System.Drawing.Point(12, 12);
            this.DeltaBottle.Name = "DeltaBottle";
            this.DeltaBottle.Size = new System.Drawing.Size(241, 72);
            this.DeltaBottle.TabIndex = 24;
            this.DeltaBottle.TabStop = false;
            this.DeltaBottle.Text = "δ-Бутыль : Осталось {0}";
            // 
            // dbReserve
            // 
            this.dbReserve.Location = new System.Drawing.Point(6, 25);
            this.dbReserve.Name = "dbReserve";
            this.dbReserve.Size = new System.Drawing.Size(100, 26);
            this.dbReserve.TabIndex = 1;
            this.dbReserve.Value = 100;
            // 
            // dbCheckBox
            // 
            this.dbCheckBox.AutoSize = true;
            this.dbCheckBox.Location = new System.Drawing.Point(217, 31);
            this.dbCheckBox.Name = "dbCheckBox";
            this.dbCheckBox.Size = new System.Drawing.Size(18, 17);
            this.dbCheckBox.TabIndex = 3;
            this.dbCheckBox.UseVisualStyleBackColor = true;
            // 
            // dbReplaceBtn
            // 
            this.dbReplaceBtn.AutoSize = true;
            this.dbReplaceBtn.Location = new System.Drawing.Point(112, 25);
            this.dbReplaceBtn.Name = "dbReplaceBtn";
            this.dbReplaceBtn.Size = new System.Drawing.Size(99, 26);
            this.dbReplaceBtn.TabIndex = 2;
            this.dbReplaceBtn.Text = "Заменить";
            this.dbReplaceBtn.UseVisualStyleBackColor = true;
            // 
            // Gazer12
            // 
            this.Gazer12.AutoSize = true;
            this.Gazer12.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Gazer12.Controls.Add(this.g12Reserve);
            this.Gazer12.Controls.Add(this.g12CheckBox);
            this.Gazer12.Controls.Add(this.g12ReplaceBtn);
            this.Gazer12.Location = new System.Drawing.Point(12, 90);
            this.Gazer12.Name = "Gazer12";
            this.Gazer12.Size = new System.Drawing.Size(241, 72);
            this.Gazer12.TabIndex = 25;
            this.Gazer12.TabStop = false;
            this.Gazer12.Text = "Гейзер-12 : Осталось {0}";
            // 
            // g12Reserve
            // 
            this.g12Reserve.Location = new System.Drawing.Point(6, 25);
            this.g12Reserve.Name = "g12Reserve";
            this.g12Reserve.Size = new System.Drawing.Size(100, 26);
            this.g12Reserve.TabIndex = 1;
            this.g12Reserve.Value = 100;
            // 
            // g12CheckBox
            // 
            this.g12CheckBox.AutoSize = true;
            this.g12CheckBox.Location = new System.Drawing.Point(217, 31);
            this.g12CheckBox.Name = "g12CheckBox";
            this.g12CheckBox.Size = new System.Drawing.Size(18, 17);
            this.g12CheckBox.TabIndex = 3;
            this.g12CheckBox.UseVisualStyleBackColor = true;
            // 
            // g12ReplaceBtn
            // 
            this.g12ReplaceBtn.AutoSize = true;
            this.g12ReplaceBtn.Location = new System.Drawing.Point(112, 25);
            this.g12ReplaceBtn.Name = "g12ReplaceBtn";
            this.g12ReplaceBtn.Size = new System.Drawing.Size(99, 26);
            this.g12ReplaceBtn.TabIndex = 2;
            this.g12ReplaceBtn.Text = "Заменить";
            this.g12ReplaceBtn.UseVisualStyleBackColor = true;
            // 
            // PZ
            // 
            this.PZ.AutoSize = true;
            this.PZ.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.PZ.Controls.Add(this.pzReserve);
            this.PZ.Controls.Add(this.pzCheckBox);
            this.PZ.Controls.Add(this.pzReplaceBtn);
            this.PZ.Location = new System.Drawing.Point(12, 168);
            this.PZ.Name = "PZ";
            this.PZ.Size = new System.Drawing.Size(241, 72);
            this.PZ.TabIndex = 26;
            this.PZ.TabStop = false;
            this.PZ.Text = "12G-PZ : Осталось {0}";
            // 
            // pzReserve
            // 
            this.pzReserve.Location = new System.Drawing.Point(6, 25);
            this.pzReserve.Name = "pzReserve";
            this.pzReserve.Size = new System.Drawing.Size(100, 23);
            this.pzReserve.TabIndex = 1;
            this.pzReserve.Value = 100;
            // 
            // pzCheckBox
            // 
            this.pzCheckBox.AutoSize = true;
            this.pzCheckBox.Location = new System.Drawing.Point(217, 31);
            this.pzCheckBox.Name = "pzCheckBox";
            this.pzCheckBox.Size = new System.Drawing.Size(18, 17);
            this.pzCheckBox.TabIndex = 3;
            this.pzCheckBox.UseVisualStyleBackColor = true;
            // 
            // pzReplaceBtn
            // 
            this.pzReplaceBtn.AutoSize = true;
            this.pzReplaceBtn.Location = new System.Drawing.Point(112, 25);
            this.pzReplaceBtn.Name = "pzReplaceBtn";
            this.pzReplaceBtn.Size = new System.Drawing.Size(99, 26);
            this.pzReplaceBtn.TabIndex = 2;
            this.pzReplaceBtn.Text = "Заменить";
            this.pzReplaceBtn.UseVisualStyleBackColor = true;
            // 
            // ChiStop
            // 
            this.ChiStop.AutoSize = true;
            this.ChiStop.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ChiStop.Controls.Add(this.xstopReserve);
            this.ChiStop.Controls.Add(this.xstopCheckBox);
            this.ChiStop.Controls.Add(this.xstopReplaceBtn);
            this.ChiStop.Location = new System.Drawing.Point(12, 246);
            this.ChiStop.Name = "ChiStop";
            this.ChiStop.Size = new System.Drawing.Size(241, 72);
            this.ChiStop.TabIndex = 27;
            this.ChiStop.TabStop = false;
            this.ChiStop.Text = "χ-Stop : Осталось {0}";
            // 
            // xstopReserve
            // 
            this.xstopReserve.Location = new System.Drawing.Point(6, 25);
            this.xstopReserve.Name = "xstopReserve";
            this.xstopReserve.Size = new System.Drawing.Size(100, 23);
            this.xstopReserve.TabIndex = 1;
            this.xstopReserve.Value = 100;
            // 
            // xstopCheckBox
            // 
            this.xstopCheckBox.AutoSize = true;
            this.xstopCheckBox.Location = new System.Drawing.Point(217, 31);
            this.xstopCheckBox.Name = "xstopCheckBox";
            this.xstopCheckBox.Size = new System.Drawing.Size(18, 17);
            this.xstopCheckBox.TabIndex = 3;
            this.xstopCheckBox.UseVisualStyleBackColor = true;
            // 
            // xstopReplaceBtn
            // 
            this.xstopReplaceBtn.AutoSize = true;
            this.xstopReplaceBtn.Location = new System.Drawing.Point(112, 25);
            this.xstopReplaceBtn.Name = "xstopReplaceBtn";
            this.xstopReplaceBtn.Size = new System.Drawing.Size(99, 26);
            this.xstopReplaceBtn.TabIndex = 2;
            this.xstopReplaceBtn.Text = "Заменить";
            this.xstopReplaceBtn.UseVisualStyleBackColor = true;
            // 
            // ChiCatalyst
            // 
            this.ChiCatalyst.AutoSize = true;
            this.ChiCatalyst.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ChiCatalyst.Controls.Add(this.xcatReserve);
            this.ChiCatalyst.Controls.Add(this.xcatCheckBox);
            this.ChiCatalyst.Controls.Add(this.xcatReplaceBtn);
            this.ChiCatalyst.Location = new System.Drawing.Point(12, 324);
            this.ChiCatalyst.Name = "ChiCatalyst";
            this.ChiCatalyst.Size = new System.Drawing.Size(241, 72);
            this.ChiCatalyst.TabIndex = 28;
            this.ChiCatalyst.TabStop = false;
            this.ChiCatalyst.Text = "χ-Catalyst-5 : Осталось {0}";
            // 
            // xcatReserve
            // 
            this.xcatReserve.Location = new System.Drawing.Point(6, 25);
            this.xcatReserve.Name = "xcatReserve";
            this.xcatReserve.Size = new System.Drawing.Size(100, 23);
            this.xcatReserve.TabIndex = 1;
            this.xcatReserve.Value = 100;
            // 
            // xcatCheckBox
            // 
            this.xcatCheckBox.AutoSize = true;
            this.xcatCheckBox.Location = new System.Drawing.Point(217, 31);
            this.xcatCheckBox.Name = "xcatCheckBox";
            this.xcatCheckBox.Size = new System.Drawing.Size(18, 17);
            this.xcatCheckBox.TabIndex = 3;
            this.xcatCheckBox.UseVisualStyleBackColor = true;
            // 
            // xcatReplaceBtn
            // 
            this.xcatReplaceBtn.AutoSize = true;
            this.xcatReplaceBtn.Location = new System.Drawing.Point(112, 25);
            this.xcatReplaceBtn.Name = "xcatReplaceBtn";
            this.xcatReplaceBtn.Size = new System.Drawing.Size(99, 26);
            this.xcatReplaceBtn.TabIndex = 2;
            this.xcatReplaceBtn.Text = "Заменить";
            this.xcatReplaceBtn.UseVisualStyleBackColor = true;
            // 
            // Tech
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 460);
            this.Controls.Add(this.ChiCatalyst);
            this.Controls.Add(this.ChiStop);
            this.Controls.Add(this.PZ);
            this.Controls.Add(this.Gazer12);
            this.Controls.Add(this.DeltaBottle);
            this.Controls.Add(this.LoadBtn);
            this.Controls.Add(this.OpenCloseBtn);
            this.Name = "Tech";
            this.Text = "Техническая Часть — Панель / login:dr_nowak";
            this.DeltaBottle.ResumeLayout(false);
            this.DeltaBottle.PerformLayout();
            this.Gazer12.ResumeLayout(false);
            this.Gazer12.PerformLayout();
            this.PZ.ResumeLayout(false);
            this.PZ.PerformLayout();
            this.ChiStop.ResumeLayout(false);
            this.ChiStop.PerformLayout();
            this.ChiCatalyst.ResumeLayout(false);
            this.ChiCatalyst.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button OpenCloseBtn;
        private System.Windows.Forms.Button LoadBtn;
        private System.Windows.Forms.GroupBox DeltaBottle;
        private System.Windows.Forms.ProgressBar dbReserve;
        private System.Windows.Forms.CheckBox dbCheckBox;
        private System.Windows.Forms.Button dbReplaceBtn;
        private System.Windows.Forms.GroupBox Gazer12;
        private System.Windows.Forms.ProgressBar g12Reserve;
        private System.Windows.Forms.CheckBox g12CheckBox;
        private System.Windows.Forms.Button g12ReplaceBtn;
        private System.Windows.Forms.GroupBox PZ;
        private System.Windows.Forms.ProgressBar pzReserve;
        private System.Windows.Forms.CheckBox pzCheckBox;
        private System.Windows.Forms.Button pzReplaceBtn;
        private System.Windows.Forms.GroupBox ChiStop;
        private System.Windows.Forms.ProgressBar xstopReserve;
        private System.Windows.Forms.CheckBox xstopCheckBox;
        private System.Windows.Forms.Button xstopReplaceBtn;
        private System.Windows.Forms.GroupBox ChiCatalyst;
        private System.Windows.Forms.ProgressBar xcatReserve;
        private System.Windows.Forms.CheckBox xcatCheckBox;
        private System.Windows.Forms.Button xcatReplaceBtn;
    }
}