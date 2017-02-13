namespace COMP1004_W2017_Lesson6
{
    partial class SplashForm
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
            this.components = new System.ComponentModel.Container();
            this.MSHLabel = new System.Windows.Forms.Label();
            this.SplashFormTimer = new System.Windows.Forms.Timer(this.components);
            this.CGLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // MSHLabel
            // 
            this.MSHLabel.AutoSize = true;
            this.MSHLabel.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.MSHLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MSHLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.MSHLabel.Location = new System.Drawing.Point(101, 113);
            this.MSHLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.MSHLabel.Name = "MSHLabel";
            this.MSHLabel.Size = new System.Drawing.Size(227, 29);
            this.MSHLabel.TabIndex = 0;
            this.MSHLabel.Text = "Marvel Super Heros";
            // 
            // SplashFormTimer
            // 
            this.SplashFormTimer.Enabled = true;
            this.SplashFormTimer.Interval = 3000;
            this.SplashFormTimer.Tick += new System.EventHandler(this.SplashFormTimer_Tick);
            // 
            // CGLabel
            // 
            this.CGLabel.AutoSize = true;
            this.CGLabel.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.CGLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.CGLabel.Location = new System.Drawing.Point(128, 142);
            this.CGLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CGLabel.Name = "CGLabel";
            this.CGLabel.Size = new System.Drawing.Size(156, 20);
            this.CGLabel.TabIndex = 1;
            this.CGLabel.Text = "Character Generator";
            // 
            // SplashForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(417, 258);
            this.Controls.Add(this.CGLabel);
            this.Controls.Add(this.MSHLabel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "SplashForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SplashForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label MSHLabel;
        private System.Windows.Forms.Timer SplashFormTimer;
        private System.Windows.Forms.Label CGLabel;
    }
}