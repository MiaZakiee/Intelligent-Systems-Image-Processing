using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using AForge.Video;
using AForge.Video.DirectShow;

namespace DigitalImageProcessing
{
    public partial class Part2 : Form
    {
        Bitmap imageB, imageA, resultImage;
        private bool isVideoOn = false;
        private FilterInfoCollection videoDevices;  // List of available video devices
        private VideoCaptureDevice videoSource;     // Video capture device
        private readonly object imageLock = new object();   // lock for thread safety
        public Part2()
        {
            InitializeComponent();
        }
        private void SubtractForm_Load(object sender, EventArgs e)
        {
            LoadVideoDevices();
        }

        private void SubtractForm_Closing(object sender, FormClosingEventArgs e)
        {
            StopVideo();
            this.Owner.Dispose();
        }

        private void backToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StopVideo();
            this.Hide();
            (this.Owner).Show();
        }

        private void btnUploadImg1_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            imageB = new Bitmap(openFileDialog1.FileName);
            pictureBox1.Image = imageB;
            isVideoOn = false;
        }

        private void btnUploadImg2_Click(object sender, EventArgs e)
        {
            openFileDialog2.ShowDialog();
        }

        private void openFileDialog2_FileOk(object sender, CancelEventArgs e)
        {
            imageA = new Bitmap(openFileDialog2.FileName);
            pictureBox2.Image = imageA;
        }

        private void btnSubtract_Click(object sender, EventArgs e)
        {
            if (imageA == null || imageB == null) return;

            if (isVideoOn)
            {
                subtractTimer.Enabled = true;
            } else
            {
                BasicDIP.SubtractImage(ref imageB, ref imageA, ref resultImage, ChromaColorBox.BackColor);
                pictureBox3.Image?.Dispose();
                pictureBox3.Image = resultImage;
            }
        }

        private void subtractTimer_Tick(object sender, EventArgs e)
        {
            Bitmap b;
            lock (imageLock)
            {
                b = (Bitmap)imageB.Clone();
            }

            resultImage?.Dispose();
            resultImage = new Bitmap(b.Width, b.Height);

            BasicDIP.SubtractImage(ref b, ref imageA, ref resultImage, ChromaColorBox.BackColor);

            pictureBox3.Image?.Dispose();
            pictureBox3.Image = resultImage;

            b.Dispose();
        }

        //For Video 
        private void LoadVideoDevices()
        {
            videoDevices = new FilterInfoCollection(FilterCategory.VideoInputDevice);

            if (videoDevices.Count == 0)
            {
                MessageBox.Show("No camera detected.");
                return;
            }

            vidONToolStripMenuItem.DropDown.Items.Clear();

            // Creating menu item for each video device
            foreach (FilterInfo device in videoDevices)
            {
                ToolStripMenuItem deviceItem = new ToolStripMenuItem(device.Name);
                deviceItem.Tag = device.MonikerString;
                deviceItem.Click += StartVCDClick;
                vidONToolStripMenuItem.DropDownItems.Add(deviceItem);
            }
        }

        private void StartVCDClick(object sender, EventArgs e)
        {
            StopVideo();

            ToolStripMenuItem selectedItem = sender as ToolStripMenuItem;
            string monikerString = selectedItem?.Tag.ToString();

            if (monikerString != null)
            {
                videoSource = new VideoCaptureDevice(monikerString);
                videoSource.NewFrame += VideoSource_NewFrame;
                videoSource.Start();
                isVideoOn = true;
            }
        }

        private void btnSelectColor_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                ChromaColorBox.BackColor = colorDialog1.Color;
            }
        }

        private void vidOFFToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StopVideo();
        }

        private void videoFilterOFFToolStripMenuItem_Click(object sender, EventArgs e)
        {
            subtractTimer.Stop();
        }

        private void VideoSource_NewFrame(object sender, NewFrameEventArgs e)
        {
            lock (imageLock)
            {
                imageB?.Dispose(); // dispose previous frame
                imageB = (Bitmap)e.Frame.Clone(); // clone new frame
            }

            pictureBox1.Image?.Dispose(); // Dispose previous frame
            pictureBox1.Image = (Bitmap)imageB.Clone();
        }

        private void StopVideo()
        {
            if (videoSource != null && videoSource.IsRunning)
            {
                videoSource.SignalToStop();
                videoSource.WaitForStop();
                videoSource = null;
                isVideoOn = false;
                subtractTimer.Stop();
            }
        }
    }
}
