namespace DataLogger
{
    partial class IntervalSetup
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
            this.label1 = new System.Windows.Forms.Label();
            this.intervalText = new System.Windows.Forms.TextBox();
            this.intervalBox = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(250, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Especifique o intervalo de tempo entre as medições";
            // 
            // intervalText
            // 
            this.intervalText.Location = new System.Drawing.Point(15, 25);
            this.intervalText.Name = "intervalText";
            this.intervalText.Size = new System.Drawing.Size(100, 20);
            this.intervalText.TabIndex = 1;
            this.intervalText.Text = "1";
            // 
            // intervalBox
            // 
            this.intervalBox.FormattingEnabled = true;
            this.intervalBox.Location = new System.Drawing.Point(121, 25);
            this.intervalBox.Name = "intervalBox";
            this.intervalBox.Size = new System.Drawing.Size(121, 21);
            this.intervalBox.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(187, 52);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // IntervalSetup
            // 
            this.AcceptButton = this.button1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.CancelButton = this.button1;
            this.ClientSize = new System.Drawing.Size(299, 86);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.intervalBox);
            this.Controls.Add(this.intervalText);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "IntervalSetup";
            this.ShowInTaskbar = false;
            this.Text = "Intervalo de tempo entre as medições";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.IntervalSetup_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox intervalText;
        private System.Windows.Forms.ComboBox intervalBox;
        private System.Windows.Forms.Button button1;
    }
}