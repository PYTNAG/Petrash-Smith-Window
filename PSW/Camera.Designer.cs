namespace PSW
{
    partial class Camera
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
            this.fix_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // fix_btn
            // 
            this.fix_btn.Location = new System.Drawing.Point(155, 128);
            this.fix_btn.Name = "fix_btn";
            this.fix_btn.Size = new System.Drawing.Size(420, 153);
            this.fix_btn.TabIndex = 0;
            this.fix_btn.Text = "FIX";
            this.fix_btn.UseVisualStyleBackColor = true;
            this.fix_btn.Click += new System.EventHandler(this.FixCamera);
            // 
            // Camera
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.fix_btn);
            this.Name = "Camera";
            this.Text = "Camera";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button fix_btn;
    }
}