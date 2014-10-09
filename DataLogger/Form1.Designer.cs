namespace DataLogger
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.portMenu = new System.Windows.Forms.ToolStripDropDownButton();
            this.timeInterval = new System.Windows.Forms.ToolStripDropDownButton();
            this.measureTime = new System.Windows.Forms.ToolStripDropDownButton();
            this.intervalTimer = new System.Windows.Forms.Timer(this.components);
            this.measureTimer = new System.Windows.Forms.Timer(this.components);
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.startProcess = new System.Windows.Forms.Button();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.portMenu,
            this.timeInterval,
            this.measureTime});
            this.statusStrip1.Location = new System.Drawing.Point(0, 308);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(609, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // portMenu
            // 
            this.portMenu.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.portMenu.Image = ((System.Drawing.Image)(resources.GetObject("portMenu.Image")));
            this.portMenu.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.portMenu.Name = "portMenu";
            this.portMenu.Size = new System.Drawing.Size(48, 20);
            this.portMenu.Text = "Porta";
            this.portMenu.Click += new System.EventHandler(this.portMenu_Click);
            // 
            // timeInterval
            // 
            this.timeInterval.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.timeInterval.Image = ((System.Drawing.Image)(resources.GetObject("timeInterval.Image")));
            this.timeInterval.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.timeInterval.Name = "timeInterval";
            this.timeInterval.Size = new System.Drawing.Size(120, 20);
            this.timeInterval.Text = "Intervalo de tempo";
            this.timeInterval.Click += new System.EventHandler(this.timeInterval_Click);
            // 
            // measureTime
            // 
            this.measureTime.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.measureTime.Image = ((System.Drawing.Image)(resources.GetObject("measureTime.Image")));
            this.measureTime.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.measureTime.Name = "measureTime";
            this.measureTime.Size = new System.Drawing.Size(131, 20);
            this.measureTime.Text = "Intervalo de medição";
            this.measureTime.Click += new System.EventHandler(this.measureTime_Click);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.CreatePrompt = true;
            this.saveFileDialog1.DefaultExt = "csv";
            this.saveFileDialog1.FileName = "data_logger";
            this.saveFileDialog1.Filter = "CSV|*.csv";
            this.saveFileDialog1.InitialDirectory = "C:\\";
            // 
            // startProcess
            // 
            this.startProcess.Image = global::DataLogger.Properties.Resources.start_icon_16;
            this.startProcess.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.startProcess.Location = new System.Drawing.Point(538, 12);
            this.startProcess.Name = "startProcess";
            this.startProcess.Size = new System.Drawing.Size(59, 24);
            this.startProcess.TabIndex = 1;
            this.startProcess.Text = "Iniciar";
            this.startProcess.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.startProcess.UseVisualStyleBackColor = true;
            this.startProcess.Click += new System.EventHandler(this.startProcess_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(609, 330);
            this.Controls.Add(this.startProcess);
            this.Controls.Add(this.statusStrip1);
            this.Name = "Main";
            this.Text = "DataLogger";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripDropDownButton portMenu;
        private System.Windows.Forms.ToolStripDropDownButton timeInterval;
        private System.Windows.Forms.ToolStripDropDownButton measureTime;
        private System.Windows.Forms.Timer intervalTimer;
        private System.Windows.Forms.Timer measureTimer;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button startProcess;
    }
}

