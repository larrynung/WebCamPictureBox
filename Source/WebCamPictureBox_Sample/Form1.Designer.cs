using System;
namespace WebCamPictureBox_Sample
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該公開 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改這個方法的內容。
        ///
        /// </summary>
        private void InitializeComponent()
        {
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.button4 = new System.Windows.Forms.Button();
			this.button5 = new System.Windows.Forms.Button();
			this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
			this.label1 = new System.Windows.Forms.Label();
			this.statusStrip1 = new System.Windows.Forms.StatusStrip();
			this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
			this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
			this.label2 = new System.Windows.Forms.Label();
			this.nudWidth = new System.Windows.Forms.NumericUpDown();
			this.nudHeight = new System.Windows.Forms.NumericUpDown();
			this.label3 = new System.Windows.Forms.Label();
			this.webCamPictureBox2 = new WebCamPictureBox.WebCamPictureBox();
			this.webCamPictureBox1 = new WebCamPictureBox.WebCamPictureBox();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
			this.statusStrip1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.nudWidth)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.nudHeight)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.webCamPictureBox2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.webCamPictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(31, 305);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(98, 51);
			this.button1.TabIndex = 1;
			this.button1.Text = "Test Connect";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(151, 305);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(98, 51);
			this.button2.TabIndex = 2;
			this.button2.Text = "Start";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(271, 305);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(98, 51);
			this.button3.TabIndex = 3;
			this.button3.Text = "Stop";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// button4
			// 
			this.button4.Location = new System.Drawing.Point(244, 96);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(31, 51);
			this.button4.TabIndex = 5;
			this.button4.Text = ">>";
			this.button4.UseVisualStyleBackColor = true;
			this.button4.Click += new System.EventHandler(this.button4_Click);
			// 
			// button5
			// 
			this.button5.Location = new System.Drawing.Point(391, 305);
			this.button5.Name = "button5";
			this.button5.Size = new System.Drawing.Size(98, 51);
			this.button5.TabIndex = 6;
			this.button5.Text = "Save";
			this.button5.UseVisualStyleBackColor = true;
			this.button5.Click += new System.EventHandler(this.button5_Click);
			// 
			// numericUpDown1
			// 
			this.numericUpDown1.Location = new System.Drawing.Point(93, 277);
			this.numericUpDown1.Maximum = new decimal(new int[] {
            60000,
            0,
            0,
            0});
			this.numericUpDown1.Name = "numericUpDown1";
			this.numericUpDown1.Size = new System.Drawing.Size(57, 22);
			this.numericUpDown1.TabIndex = 7;
			this.numericUpDown1.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
			this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(29, 281);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(58, 12);
			this.label1.TabIndex = 8;
			this.label1.Text = "Frame Rate";
			// 
			// statusStrip1
			// 
			this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2});
			this.statusStrip1.Location = new System.Drawing.Point(0, 360);
			this.statusStrip1.Name = "statusStrip1";
			this.statusStrip1.Size = new System.Drawing.Size(521, 22);
			this.statusStrip1.TabIndex = 9;
			this.statusStrip1.Text = "statusStrip1";
			// 
			// toolStripStatusLabel1
			// 
			this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
			this.toolStripStatusLabel1.Size = new System.Drawing.Size(91, 17);
			this.toolStripStatusLabel1.Text = "Webcam state:";
			// 
			// toolStripStatusLabel2
			// 
			this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
			this.toolStripStatusLabel2.Size = new System.Drawing.Size(34, 17);
			this.toolStripStatusLabel2.Text = "Stop";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(211, 281);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(23, 12);
			this.label2.TabIndex = 11;
			this.label2.Text = "DPI";
			// 
			// nudWidth
			// 
			this.nudWidth.Location = new System.Drawing.Point(240, 277);
			this.nudWidth.Maximum = new decimal(new int[] {
            60000,
            0,
            0,
            0});
			this.nudWidth.Name = "nudWidth";
			this.nudWidth.Size = new System.Drawing.Size(57, 22);
			this.nudWidth.TabIndex = 10;
			this.nudWidth.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
			// 
			// nudHeight
			// 
			this.nudHeight.Location = new System.Drawing.Point(321, 277);
			this.nudHeight.Maximum = new decimal(new int[] {
            60000,
            0,
            0,
            0});
			this.nudHeight.Name = "nudHeight";
			this.nudHeight.Size = new System.Drawing.Size(57, 22);
			this.nudHeight.TabIndex = 12;
			this.nudHeight.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(303, 281);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(13, 12);
			this.label3.TabIndex = 13;
			this.label3.Text = "X";
			// 
			// webCamPictureBox2
			// 
			this.webCamPictureBox2.Image = global::WebCamPictureBox_Sample.Properties.Resources.WebPictureBox;
			this.webCamPictureBox2.Location = new System.Drawing.Point(281, 12);
			this.webCamPictureBox2.Name = "webCamPictureBox2";
			this.webCamPictureBox2.Size = new System.Drawing.Size(228, 251);
			this.webCamPictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
			this.webCamPictureBox2.TabIndex = 4;
			this.webCamPictureBox2.TabStop = false;
			// 
			// webCamPictureBox1
			// 
			this.webCamPictureBox1.Image = global::WebCamPictureBox_Sample.Properties.Resources.WebPictureBox;
			this.webCamPictureBox1.Location = new System.Drawing.Point(12, 12);
			this.webCamPictureBox1.Name = "webCamPictureBox1";
			this.webCamPictureBox1.Size = new System.Drawing.Size(228, 251);
			this.webCamPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
			this.webCamPictureBox1.TabIndex = 0;
			this.webCamPictureBox1.TabStop = false;
			this.webCamPictureBox1.ConnectStateChanged += new EventHandler(this.webCamPictureBox1_WebCamConnectStateChanged);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(521, 382);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.nudHeight);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.nudWidth);
			this.Controls.Add(this.statusStrip1);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.numericUpDown1);
			this.Controls.Add(this.button5);
			this.Controls.Add(this.button4);
			this.Controls.Add(this.webCamPictureBox2);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.webCamPictureBox1);
			this.Name = "Form1";
			this.Text = "WebCam PictureBox Sample";
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
			this.statusStrip1.ResumeLayout(false);
			this.statusStrip1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.nudWidth)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.nudHeight)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.webCamPictureBox2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.webCamPictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private WebCamPictureBox.WebCamPictureBox webCamPictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private WebCamPictureBox.WebCamPictureBox webCamPictureBox2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.NumericUpDown nudWidth;
		private System.Windows.Forms.NumericUpDown nudHeight;
		private System.Windows.Forms.Label label3;
    }
}

