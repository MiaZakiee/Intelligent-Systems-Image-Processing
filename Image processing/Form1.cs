using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Image_processing
{
    public partial class Form1 : Form
    {

        Bitmap loaded;
        Bitmap processed;

        public Form1()
        {
            InitializeComponent();
        }

        private void monoHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            processed = new Bitmap(loaded.Width, loaded.Height);
            Color pixel;


            for (int x = 0; x < loaded.Width; x++)
            {
                for (int y = 0; y < loaded.Height; y++)
                {
                    pixel = loaded.GetPixel(x, y);
                    processed.SetPixel(x, y, pixel);
                }
            }

            pictureBox2.Image = processed;
        }

        private void dIPToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void oToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            processed.Save(saveFileDialog1.FileName);
        }

        private void greyscalingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            processed = new Bitmap(loaded.Width, loaded.Height);
            Color pixel;
            Color gray;
            int average;
            for (int x = 0; x < loaded.Width; x++)
            {
                for (int y = 0; y < loaded.Height; y++)
                {
                    pixel = loaded.GetPixel(x, y);
                    average = (pixel.R + pixel.G + pixel.B) / 3;
                    gray = Color.FromArgb(average, average, average);
                    processed.SetPixel(x, y, gray);
                }
            }

            pictureBox2.Image = processed;
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            loaded = new Bitmap(openFileDialog1.FileName);
            pictureBox1.Image = loaded;
        }

        private void pixelCopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            processed = new Bitmap(loaded.Width, loaded.Height);
            Color pixel;

            for (int x = 0; x < loaded.Width; x++)
            {
                for (int y = 0; y < loaded.Height; y++)
                {
                    pixel = loaded.GetPixel(x, y);
                    processed.SetPixel(x, y, pixel);
                }
            }

            pictureBox2.Image = processed;
        }

        private void inversionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InvertImage(ref loaded, ref processed);
            pictureBox2.Image = processed;
        }

        private void sepiaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            processed = new Bitmap(loaded.Width, loaded.Height);
            Color pixel;

            for (int x = 0; x < loaded.Width; x++)
            {
                for (int y = 0; y < loaded.Height; y++)
                {
                    pixel = loaded.GetPixel(x, y);

                    int red = (int)(0.393 * pixel.R + 0.769 * pixel.G + 0.189 * pixel.B);
                    int green = (int)(0.349 * pixel.R + 0.686 * pixel.G + 0.168 * pixel.B);
                    int blue = (int)(0.272 * pixel.R + 0.534 * pixel.G + 0.131 * pixel.B);

                    red = Math.Min(255, red);
                    green = Math.Min(255, green);
                    blue = Math.Min(255, blue);

                    Color newPixel = Color.FromArgb(red,green,blue);

                    processed.SetPixel(x, y, newPixel);
                }
            }
            pictureBox2.Image = processed;
        }

        // CS50 tings haHAHAHHA
        //void sepia(int height, int width, RGBTRIPLE image[height][width])
        //{
        //    float red, green, blue;
        //    float sred, sgreen, sblue;
        //    for (int i = 0; i < height; i++)
        //    {
        //        for (int j = 0; j < width; j++)
        //        {
        //            red = image[i][j].rgbtRed;
        //            green = image[i][j].rgbtGreen;
        //            blue = image[i][j].rgbtBlue;

        //            sred = round((red * 0.393) + (green * 0.769) + (blue * 0.189));
        //            sgreen = round((red * 0.349) + (green * 0.686) + (blue * 0.168));
        //            sblue = round((red * 0.272) + (green * 0.534) + (blue * 0.131));

        //            image[i][j].rgbtRed = fmin(255, sred);
        //            image[i][j].rgbtGreen = fmin(255, sgreen);
        //            image[i][j].rgbtBlue = fmin(255, sblue);
        //        }
        //    }
        //    return;
        //}

        private void histogramToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Histogram(ref loaded, ref processed);
            pictureBox2.Image = processed;
        }

        public static void InvertImage(ref Bitmap loadedImage, ref Bitmap processedImage)
        {
            processedImage = new Bitmap(loadedImage.Width, loadedImage.Height);
            Color pixel;

            for (int x = 0; x < loadedImage.Width; x++)
            {
                for (int y = 0; y < loadedImage.Height; y++)
                {
                    pixel = loadedImage.GetPixel(x, y);

                    Color inverted = Color.FromArgb(255 - pixel.R, 255 - pixel.G, 255 - pixel.B);
                    processedImage.SetPixel(x, y, inverted);
                }
            }
        }


        public static void Histogram(ref Bitmap a, ref Bitmap b)
        {
            Color sample;
            Color gray;
            Byte graydata;
            //Grayscale Convertion;
            for (int x = 0; x < a.Width; x++)
            {
                for (int y = 0; y < a.Height; y++)
                {
                    sample = a.GetPixel(x, y);
                    graydata = (byte)((sample.R + sample.G + sample.B) / 3);
                    gray = Color.FromArgb(graydata, graydata, graydata);
                    a.SetPixel(x, y, gray);
                }
            }

            //histogram 1d data;
            int[] histdata = new int[256]; // array from 0 to 255
            for (int x = 0; x < a.Width; x++)
            {
                for (int y = 0; y < a.Height; y++)
                {
                    sample = a.GetPixel(x, y);
                    histdata[sample.R]++; // can be any color property r,g or b
                }
            }

            // Bitmap Graph Generation
            // Setting empty Bitmap with background color
            b = new Bitmap(256, 800);
            for (int x = 0; x < 256; x++)
            {
                for (int y = 0; y < 800; y++)
                {
                    b.SetPixel(x, y, Color.White);
                }
            }
            // plotting points based from histdata
            for (int x = 0; x < 256; x++)
            {
                for (int y = 0; y < Math.Min(histdata[x] / 5, b.Height - 1); y++)
                {
                    b.SetPixel(x, (b.Height - 1) - y, Color.Black);
                }
            }
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }
    }
}
