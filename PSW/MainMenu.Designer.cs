namespace PSW
{
    partial class MainMenu
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
            this.NewGame = new System.Windows.Forms.Button();
            this.Load = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // NewGame
            // 
            this.NewGame.Location = new System.Drawing.Point(12, 12);
            this.NewGame.Name = "NewGame";
            this.NewGame.Size = new System.Drawing.Size(390, 52);
            this.NewGame.TabIndex = 0;
            this.NewGame.Text = "Новая игра";
            this.NewGame.UseVisualStyleBackColor = true;
            this.NewGame.Click += new System.EventHandler(this.NewGame_Click);
            // 
            // Load
            // 
            this.Load.AutoSize = true;
            this.Load.Location = new System.Drawing.Point(12, 71);
            this.Load.Name = "Load";
            this.Load.Size = new System.Drawing.Size(390, 52);
            this.Load.TabIndex = 1;
            this.Load.Text = "Загрузить";
            this.Load.UseVisualStyleBackColor = true;
            this.Load.Click += new System.EventHandler(this.Load_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(414, 135);
            this.Controls.Add(this.Load);
            this.Controls.Add(this.NewGame);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MainMenu";
            this.Text = "Окно Петраша-Смита v.0.0.0/0";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button NewGame;
        private System.Windows.Forms.Button Load;
    }
}

