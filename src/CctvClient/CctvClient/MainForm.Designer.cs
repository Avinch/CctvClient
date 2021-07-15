
namespace CCTVClient
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.cam4 = new System.Windows.Forms.PictureBox();
            this.flowVlcButtons = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.cam3 = new System.Windows.Forms.PictureBox();
            this.cam2 = new System.Windows.Forms.PictureBox();
            this.cam1 = new System.Windows.Forms.PictureBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.chkStartup = new System.Windows.Forms.CheckBox();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cam4)).BeginInit();
            this.flowVlcButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cam3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cam2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cam1)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.cam4, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.flowVlcButtons, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.cam3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.cam2, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.cam1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1075, 831);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // cam4
            // 
            this.cam4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cam4.Location = new System.Drawing.Point(540, 441);
            this.cam4.Name = "cam4";
            this.cam4.Size = new System.Drawing.Size(532, 387);
            this.cam4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.cam4.TabIndex = 6;
            this.cam4.TabStop = false;
            // 
            // flowVlcButtons
            // 
            this.flowVlcButtons.AutoSize = true;
            this.flowVlcButtons.Controls.Add(this.label1);
            this.flowVlcButtons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowVlcButtons.Location = new System.Drawing.Point(540, 3);
            this.flowVlcButtons.Name = "flowVlcButtons";
            this.flowVlcButtons.Padding = new System.Windows.Forms.Padding(5);
            this.flowVlcButtons.Size = new System.Drawing.Size(532, 39);
            this.flowVlcButtons.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 5);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(3, 8, 3, 3);
            this.label1.Size = new System.Drawing.Size(92, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Open in VLC: ";
            // 
            // cam3
            // 
            this.cam3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cam3.Location = new System.Drawing.Point(3, 441);
            this.cam3.Name = "cam3";
            this.cam3.Size = new System.Drawing.Size(531, 387);
            this.cam3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.cam3.TabIndex = 5;
            this.cam3.TabStop = false;
            // 
            // cam2
            // 
            this.cam2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cam2.Location = new System.Drawing.Point(540, 48);
            this.cam2.Name = "cam2";
            this.cam2.Size = new System.Drawing.Size(532, 387);
            this.cam2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.cam2.TabIndex = 4;
            this.cam2.TabStop = false;
            // 
            // cam1
            // 
            this.cam1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cam1.Location = new System.Drawing.Point(3, 48);
            this.cam1.Name = "cam1";
            this.cam1.Size = new System.Drawing.Size(531, 387);
            this.cam1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.cam1.TabIndex = 3;
            this.cam1.TabStop = false;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.Controls.Add(this.btnStart);
            this.flowLayoutPanel1.Controls.Add(this.btnStop);
            this.flowLayoutPanel1.Controls.Add(this.chkStartup);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(5);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(531, 39);
            this.flowLayoutPanel1.TabIndex = 7;
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(8, 8);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(89, 23);
            this.btnStart.TabIndex = 7;
            this.btnStart.Text = "Start Feeds";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click_1);
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(103, 8);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(89, 23);
            this.btnStop.TabIndex = 8;
            this.btnStop.Text = "Stop Feeds";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // chkStartup
            // 
            this.chkStartup.AutoSize = true;
            this.chkStartup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chkStartup.Location = new System.Drawing.Point(198, 8);
            this.chkStartup.Name = "chkStartup";
            this.chkStartup.Size = new System.Drawing.Size(156, 23);
            this.chkStartup.TabIndex = 9;
            this.chkStartup.Text = "Open when computer starts";
            this.chkStartup.UseVisualStyleBackColor = true;
            this.chkStartup.CheckedChanged += new System.EventHandler(this.chkStartup_CheckedChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1075, 831);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CCTV Feeds";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cam4)).EndInit();
            this.flowVlcButtons.ResumeLayout(false);
            this.flowVlcButtons.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cam3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cam2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cam1)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.PictureBox cam4;
        private System.Windows.Forms.PictureBox cam3;
        private System.Windows.Forms.PictureBox cam2;
        private System.Windows.Forms.PictureBox cam1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.FlowLayoutPanel flowVlcButtons;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chkStartup;
    }
}

