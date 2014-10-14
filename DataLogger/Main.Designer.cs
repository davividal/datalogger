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
            this.toolStripProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
            this.intervalTimer = new System.Windows.Forms.Timer(this.components);
            this.measureTimer = new System.Windows.Forms.Timer(this.components);
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.startProcess = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.collectedData = new System.Windows.Forms.TextBox();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
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
            // toolStripProgressBar1
            // 
            this.toolStripProgressBar1.Name = "toolStripProgressBar1";
            this.toolStripProgressBar1.Size = new System.Drawing.Size(100, 16);
            // 
            // intervalTimer
            // 
            this.intervalTimer.Tick += new System.EventHandler(this.intervalTimer_Tick);
            // 
            // measureTimer
            // 
            this.measureTimer.Tick += new System.EventHandler(this.measureTimer_Tick);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.CreatePrompt = true;
            this.saveFileDialog1.DefaultExt = "csv";
            this.saveFileDialog1.FileName = "data_logger";
            this.saveFileDialog1.Filter = "CSV|*.csv";
            this.saveFileDialog1.InitialDirectory = "C:\\Users";
            this.saveFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialog1_FileOk);
            // 
            // startProcess
            // 
            this.startProcess.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.startProcess.ImageKey = "start-icon 16.png";
            this.startProcess.ImageList = this.imageList1;
            this.startProcess.Location = new System.Drawing.Point(538, 12);
            this.startProcess.Name = "startProcess";
            this.startProcess.Size = new System.Drawing.Size(59, 24);
            this.startProcess.TabIndex = 1;
            this.startProcess.Text = "Iniciar";
            this.startProcess.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.startProcess.UseVisualStyleBackColor = true;
            this.startProcess.Click += new System.EventHandler(this.startProcess_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "start-icon 16.png");
            this.imageList1.Images.SetKeyName(1, "stop-icon.png");
            // 
            // collectedData
            // 
            this.collectedData.Location = new System.Drawing.Point(12, 12);
            this.collectedData.Multiline = true;
            this.collectedData.Name = "collectedData";
            this.collectedData.ReadOnly = true;
            this.collectedData.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.collectedData.Size = new System.Drawing.Size(520, 281);
            this.collectedData.TabIndex = 2;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(609, 330);
            this.Controls.Add(this.collectedData);
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
        private System.Windows.Forms.TextBox collectedData;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar1;
    }
}

