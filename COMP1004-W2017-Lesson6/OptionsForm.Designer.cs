namespace COMP1004_W2017_Lesson6
{
    partial class OptionsForm
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
            this.AcceptButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.FunctonGroupBox = new System.Windows.Forms.GroupBox();
            this.ExponentCheckBox = new System.Windows.Forms.CheckBox();
            this.SquareRootCheckBox = new System.Windows.Forms.CheckBox();
            this.LayoutGroupBox = new System.Windows.Forms.GroupBox();
            this.ScientificRadioButton = new System.Windows.Forms.RadioButton();
            this.StandardRadioButton = new System.Windows.Forms.RadioButton();
            this.FontButton = new System.Windows.Forms.Button();
            this.CalculatorFontDialog = new System.Windows.Forms.FontDialog();
            this.FunctonGroupBox.SuspendLayout();
            this.LayoutGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // AcceptButton
            // 
            this.AcceptButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.AcceptButton.Location = new System.Drawing.Point(20, 331);
            this.AcceptButton.Margin = new System.Windows.Forms.Padding(5);
            this.AcceptButton.Name = "AcceptButton";
            this.AcceptButton.Size = new System.Drawing.Size(125, 35);
            this.AcceptButton.TabIndex = 0;
            this.AcceptButton.Text = "Accept";
            this.AcceptButton.UseVisualStyleBackColor = true;
            this.AcceptButton.Click += new System.EventHandler(this._acceptButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelButton.Location = new System.Drawing.Point(295, 331);
            this.CancelButton.Margin = new System.Windows.Forms.Padding(5);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(125, 35);
            this.CancelButton.TabIndex = 1;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this._cancelButton_Click);
            // 
            // FunctonGroupBox
            // 
            this.FunctonGroupBox.Controls.Add(this.ExponentCheckBox);
            this.FunctonGroupBox.Controls.Add(this.SquareRootCheckBox);
            this.FunctonGroupBox.Location = new System.Drawing.Point(20, 18);
            this.FunctonGroupBox.Margin = new System.Windows.Forms.Padding(5);
            this.FunctonGroupBox.Name = "FunctonGroupBox";
            this.FunctonGroupBox.Padding = new System.Windows.Forms.Padding(5);
            this.FunctonGroupBox.Size = new System.Drawing.Size(181, 145);
            this.FunctonGroupBox.TabIndex = 2;
            this.FunctonGroupBox.TabStop = false;
            this.FunctonGroupBox.Text = "Function";
            // 
            // ExponentCheckBox
            // 
            this.ExponentCheckBox.AutoSize = true;
            this.ExponentCheckBox.Location = new System.Drawing.Point(8, 58);
            this.ExponentCheckBox.Name = "ExponentCheckBox";
            this.ExponentCheckBox.Size = new System.Drawing.Size(104, 24);
            this.ExponentCheckBox.TabIndex = 1;
            this.ExponentCheckBox.Text = "Exponent";
            this.ExponentCheckBox.UseVisualStyleBackColor = true;
            // 
            // SquareRootCheckBox
            // 
            this.SquareRootCheckBox.AutoSize = true;
            this.SquareRootCheckBox.Location = new System.Drawing.Point(9, 28);
            this.SquareRootCheckBox.Name = "SquareRootCheckBox";
            this.SquareRootCheckBox.Size = new System.Drawing.Size(130, 24);
            this.SquareRootCheckBox.TabIndex = 0;
            this.SquareRootCheckBox.Text = "Square Root";
            this.SquareRootCheckBox.UseVisualStyleBackColor = true;
            // 
            // LayoutGroupBox
            // 
            this.LayoutGroupBox.Controls.Add(this.ScientificRadioButton);
            this.LayoutGroupBox.Controls.Add(this.StandardRadioButton);
            this.LayoutGroupBox.Location = new System.Drawing.Point(247, 18);
            this.LayoutGroupBox.Margin = new System.Windows.Forms.Padding(5);
            this.LayoutGroupBox.Name = "LayoutGroupBox";
            this.LayoutGroupBox.Padding = new System.Windows.Forms.Padding(5);
            this.LayoutGroupBox.Size = new System.Drawing.Size(181, 145);
            this.LayoutGroupBox.TabIndex = 3;
            this.LayoutGroupBox.TabStop = false;
            this.LayoutGroupBox.Text = "Layout";
            //this.LayoutGroupBox.Enter += new System.EventHandler(this.LayoutGroupBox_Enter);
            // 
            // ScientificRadioButton
            // 
            this.ScientificRadioButton.AutoSize = true;
            this.ScientificRadioButton.Location = new System.Drawing.Point(9, 58);
            this.ScientificRadioButton.Name = "ScientificRadioButton";
            this.ScientificRadioButton.Size = new System.Drawing.Size(101, 24);
            this.ScientificRadioButton.TabIndex = 1;
            this.ScientificRadioButton.Text = "Scientific";
            this.ScientificRadioButton.UseVisualStyleBackColor = true;
            // 
            // StandardRadioButton
            // 
            this.StandardRadioButton.AutoSize = true;
            this.StandardRadioButton.Checked = true;
            this.StandardRadioButton.Location = new System.Drawing.Point(9, 28);
            this.StandardRadioButton.Name = "StandardRadioButton";
            this.StandardRadioButton.Size = new System.Drawing.Size(101, 24);
            this.StandardRadioButton.TabIndex = 0;
            this.StandardRadioButton.TabStop = true;
            this.StandardRadioButton.Text = "Standard";
            this.StandardRadioButton.UseVisualStyleBackColor = true;
            this.StandardRadioButton.CheckedChanged += new System.EventHandler(this._calculatorRadioButton_CheckedChanged);
            // 
            // FontButton
            // 
            this.FontButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.FontButton.Location = new System.Drawing.Point(28, 248);
            this.FontButton.Margin = new System.Windows.Forms.Padding(5);
            this.FontButton.Name = "FontButton";
            this.FontButton.Size = new System.Drawing.Size(125, 35);
            this.FontButton.TabIndex = 4;
            this.FontButton.Text = "Font";
            this.FontButton.UseVisualStyleBackColor = true;
            this.FontButton.Click += new System.EventHandler(this._fontButton_Click);
            // 
            // CalculatorFontDialog
            // 
            this.CalculatorFontDialog.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CalculatorFontDialog.MaxSize = 24;
            this.CalculatorFontDialog.MinSize = 10;
            // 
            // OptionsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 374);
            this.ControlBox = false;
            this.Controls.Add(this.FontButton);
            this.Controls.Add(this.LayoutGroupBox);
            this.Controls.Add(this.FunctonGroupBox);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.AcceptButton);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "OptionsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OptionsForm";
            this.FunctonGroupBox.ResumeLayout(false);
            this.FunctonGroupBox.PerformLayout();
            this.LayoutGroupBox.ResumeLayout(false);
            this.LayoutGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button AcceptButton;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.GroupBox FunctonGroupBox;
        private System.Windows.Forms.CheckBox ExponentCheckBox;
        private System.Windows.Forms.CheckBox SquareRootCheckBox;
        private System.Windows.Forms.GroupBox LayoutGroupBox;
        private System.Windows.Forms.RadioButton ScientificRadioButton;
        private System.Windows.Forms.RadioButton StandardRadioButton;
        private System.Windows.Forms.Button FontButton;
        private System.Windows.Forms.FontDialog CalculatorFontDialog;
    }
}