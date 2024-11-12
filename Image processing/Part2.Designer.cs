namespace DigitalImageProcessing
{
    partial class Part2
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.backToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vidONToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vidOFFToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnUploadImgB = new System.Windows.Forms.Button();
            this.btnUploadImgA = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
            this.btnSubtract = new System.Windows.Forms.Button();
            this.subtractTimer = new System.Windows.Forms.Timer(this.components);
            this.btnSelectColor = new System.Windows.Forms.Button();
            this.ChromaColorBox = new System.Windows.Forms.PictureBox();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.videoFilterOFFToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChromaColorBox)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.backToolStripMenuItem,
            this.fileToolStripMenuItem,
            this.vidONToolStripMenuItem,
            this.vidOFFToolStripMenuItem,
            this.videoFilterOFFToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1389, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(14, 26);
            // 
            // backToolStripMenuItem
            // 
            this.backToolStripMenuItem.Name = "backToolStripMenuItem";
            this.backToolStripMenuItem.Size = new System.Drawing.Size(54, 26);
            this.backToolStripMenuItem.Text = "Back";
            this.backToolStripMenuItem.Click += new System.EventHandler(this.backToolStripMenuItem_Click);
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 26);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(123, 26);
            this.saveToolStripMenuItem.Text = "Save";
            // 
            // vidONToolStripMenuItem
            // 
            this.vidONToolStripMenuItem.Name = "vidONToolStripMenuItem";
            this.vidONToolStripMenuItem.Size = new System.Drawing.Size(88, 26);
            this.vidONToolStripMenuItem.Text = "Video ON";
            // 
            // vidOFFToolStripMenuItem
            // 
            this.vidOFFToolStripMenuItem.Name = "vidOFFToolStripMenuItem";
            this.vidOFFToolStripMenuItem.Size = new System.Drawing.Size(91, 24);
            this.vidOFFToolStripMenuItem.Text = "Video OFF";
            this.vidOFFToolStripMenuItem.Click += new System.EventHandler(this.vidOFFToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(35, 108);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(400, 400);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(493, 108);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(400, 400);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Location = new System.Drawing.Point(943, 108);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(400, 400);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 3;
            this.pictureBox3.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label3.Location = new System.Drawing.Point(1081, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 24);
            this.label3.TabIndex = 6;
            this.label3.Text = "Result Image";
            // 
            // btnUploadImgB
            // 
            this.btnUploadImgB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnUploadImgB.Location = new System.Drawing.Point(161, 529);
            this.btnUploadImgB.Name = "btnUploadImgB";
            this.btnUploadImgB.Size = new System.Drawing.Size(131, 35);
            this.btnUploadImgB.TabIndex = 7;
            this.btnUploadImgB.Text = "load image";
            this.btnUploadImgB.UseVisualStyleBackColor = true;
            this.btnUploadImgB.Click += new System.EventHandler(this.btnUploadImg1_Click);
            // 
            // btnUploadImgA
            // 
            this.btnUploadImgA.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnUploadImgA.Location = new System.Drawing.Point(598, 529);
            this.btnUploadImgA.Name = "btnUploadImgA";
            this.btnUploadImgA.Size = new System.Drawing.Size(215, 35);
            this.btnUploadImgA.TabIndex = 8;
            this.btnUploadImgA.Text = "load background";
            this.btnUploadImgA.UseVisualStyleBackColor = true;
            this.btnUploadImgA.Click += new System.EventHandler(this.btnUploadImg2_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // openFileDialog2
            // 
            this.openFileDialog2.FileName = "openFileDialog2";
            this.openFileDialog2.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog2_FileOk);
            // 
            // btnSubtract
            // 
            this.btnSubtract.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnSubtract.Location = new System.Drawing.Point(1078, 529);
            this.btnSubtract.Name = "btnSubtract";
            this.btnSubtract.Size = new System.Drawing.Size(152, 35);
            this.btnSubtract.TabIndex = 9;
            this.btnSubtract.Text = "subtract";
            this.btnSubtract.UseVisualStyleBackColor = true;
            this.btnSubtract.Click += new System.EventHandler(this.btnSubtract_Click);
            // 
            // subtractTimer
            // 
            this.subtractTimer.Interval = 1;
            this.subtractTimer.Tick += new System.EventHandler(this.subtractTimer_Tick);
            // 
            // btnSelectColor
            // 
            this.btnSelectColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelectColor.Location = new System.Drawing.Point(35, 56);
            this.btnSelectColor.Name = "btnSelectColor";
            this.btnSelectColor.Size = new System.Drawing.Size(171, 30);
            this.btnSelectColor.TabIndex = 10;
            this.btnSelectColor.Text = "Select Color";
            this.btnSelectColor.UseVisualStyleBackColor = true;
            this.btnSelectColor.Click += new System.EventHandler(this.btnSelectColor_Click);
            // 
            // ChromaColorBox
            // 
            this.ChromaColorBox.BackColor = System.Drawing.Color.Lime;
            this.ChromaColorBox.Location = new System.Drawing.Point(213, 56);
            this.ChromaColorBox.Name = "ChromaColorBox";
            this.ChromaColorBox.Size = new System.Drawing.Size(30, 30);
            this.ChromaColorBox.TabIndex = 11;
            this.ChromaColorBox.TabStop = false;
            // 
            // videoFilterOFFToolStripMenuItem
            // 
            this.videoFilterOFFToolStripMenuItem.Name = "videoFilterOFFToolStripMenuItem";
            this.videoFilterOFFToolStripMenuItem.Size = new System.Drawing.Size(128, 24);
            this.videoFilterOFFToolStripMenuItem.Text = "Video Filter OFF";
            this.videoFilterOFFToolStripMenuItem.Click += new System.EventHandler(this.videoFilterOFFToolStripMenuItem_Click);
            // 
            // SubtractForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1389, 611);
            this.Controls.Add(this.ChromaColorBox);
            this.Controls.Add(this.btnSelectColor);
            this.Controls.Add(this.btnSubtract);
            this.Controls.Add(this.btnUploadImgA);
            this.Controls.Add(this.btnUploadImgB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "SubtractForm";
            this.Text = "Part 2: Subtract Image Process";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SubtractForm_Closing);
            this.Load += new System.EventHandler(this.SubtractForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChromaColorBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem backToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnUploadImgB;
        private System.Windows.Forms.Button btnUploadImgA;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog2;
        private System.Windows.Forms.Button btnSubtract;
        private System.Windows.Forms.ToolStripMenuItem vidONToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vidOFFToolStripMenuItem;
        private System.Windows.Forms.Timer subtractTimer;
        private System.Windows.Forms.Button btnSelectColor;
        private System.Windows.Forms.PictureBox ChromaColorBox;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.ToolStripMenuItem videoFilterOFFToolStripMenuItem;
    }
}