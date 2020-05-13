using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImageEffect
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnNegative_Click(object sender, EventArgs e)
        {
            try
            {
                Bitmap bmp = new Bitmap(pictureBox1.Image);
                int height, width, x, y, r, g, b, a;
                height = bmp.Height;
                width = bmp.Width;
                Color c;
                for (y = 0; y < height; y++)
                {
                    for (x = 0; x < width; x++)
                    {
                        c = bmp.GetPixel(x, y);
                        r = c.R;
                        r = 255 - r;
                        g = c.G;
                        g = 255 - g;
                        b = c.B;
                        b = 255 - b;
                        a = c.A;
                        bmp.SetPixel(x, y, Color.FromArgb(a, r, g, b));
                    }
                }
                pictureBox2.Image = bmp;
            }
            catch (Exception)
            {

            }
        }

        private void btnGrayScale_Click(object sender, EventArgs e)
        {
            try
            {
                Bitmap bmp = new Bitmap(pictureBox1.Image);
                int height, width, x, y, r, g, b, a, avg;
                avg = 0;
                height = bmp.Height;
                width = bmp.Width;
                Color c;
                for (y = 0; y < height; y++)
                {
                    for (x = 0; x < width; x++)
                    {
                        c = bmp.GetPixel(x, y);
                        r = c.R;
                        g = c.G;
                        b = c.B;
                        a = c.A;
                        avg = (r + g + b) / 3;
                        bmp.SetPixel(x, y, Color.FromArgb(a, avg, avg, avg));
                    }
                }
                pictureBox2.Image = bmp;
            }
            catch(Exception)
            {

            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            try
            {
                pictureBox1.Visible = false;
                pictureBox2.Image = null;
                txtBrightness.Text = "";
                btnNegative.Enabled = false;
                btnGrayScale.Enabled = false;
                btnBrightnessSet.Enabled = false;
                txtBrightness.ReadOnly = true;
            }
            catch(Exception)
            {

            }
        }

        private void btnloadImage_Click(object sender, EventArgs e)
        {
            try
            {
                pictureBox1.Visible = true;
                pictureBox2.Visible = true;
                openFileDialog1.ShowDialog();
                pictureBox1.Image = System.Drawing.Bitmap.FromFile(openFileDialog1.FileName);
                btnNegative.Enabled = true;
                btnGrayScale.Enabled = true;
                btnBrightnessSet.Enabled = true;
                txtBrightness.ReadOnly = false;
            }
            catch(Exception)
            {

            }
        }

        private void btnBrightnessSet_Click(object sender, EventArgs e)
        {
            try
            {
                rbtnRed.Checked = false;
                rbtnBlue.Checked = false;
                rbtnGreen.Checked = false;

                Bitmap bmp = new Bitmap(pictureBox1.Image);
                int height, width, brightness, x, y, a, r, g, b;
                height = bmp.Height;
                width = bmp.Width;
                Color c;
                brightness = Convert.ToInt32(txtBrightness.Text);
                if (brightness > 255)
                {
                    txtBrightness.Text = 255.ToString();
                    brightness = 255;
                }
                if (brightness < 0)
                {
                    txtBrightness.Text = 1.ToString();
                    brightness = 1;
                }
                for (y = 0; y < height; y++)
                {
                    for (x = 0; x < width; x++)
                    {
                        c = bmp.GetPixel(x, y);
                        r = c.R;
                        g = c.G;
                        b = c.B;
                        a = c.A;
                        r = r + brightness;
                        g = g + brightness;
                        b = b + brightness;
                        if (r > 255)
                            r = 255;
                        if (r < 0)
                            r = 1;
                        if (g > 255)
                            g = 255;
                        if (g < 0)
                            g = 1;
                        if (b > 255)
                            b = 255;
                        if (b < 0)
                            b = 1;
                        bmp.SetPixel(x, y, Color.FromArgb(a, r, g, b));
                    }
                }
                pictureBox2.Image = bmp;
            }
            catch(Exception)
            {

            }
        }

        private void rbtnRed_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                txtBrightness.Text = "";

                Bitmap bmp = new Bitmap(pictureBox1.Image);
                int height, width, x, y, r, g, b, a;
                height = bmp.Height;
                width = bmp.Width;
                Color c;
                for (y = 0; y < height; y++)
                {
                    for (x = 0; x < width; x++)
                    {
                        c = bmp.GetPixel(x, y);
                        r = c.R;
                        g = c.G;
                        g = 0;
                        b = c.B;
                        b = 0;
                        a = c.A;
                        bmp.SetPixel(x, y, Color.FromArgb(a, r, g, b));
                    }
                }
                pictureBox2.Image = bmp;
            }
            catch(Exception)
            {

            }
        }

        private void rbtnBlue_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                txtBrightness.Text = "";

                Bitmap bmp = new Bitmap(pictureBox1.Image);
                int height, width, x, y, r, g, b, a;
                height = bmp.Height;
                width = bmp.Width;
                Color c;
                for (y = 0; y < height; y++)
                {
                    for (x = 0; x < width; x++)
                    {
                        c = bmp.GetPixel(x, y);
                        r = c.R;
                        r = 0;
                        g = c.G;
                        g = 0;
                        b = c.B;
                        a = c.A;
                        bmp.SetPixel(x, y, Color.FromArgb(a, r, g, b));
                    }
                }
                pictureBox2.Image = bmp;
            }
            catch(Exception)
            {

            }
        }

        private void rbtnGreen_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                txtBrightness.Text = "";

                Bitmap bmp = new Bitmap(pictureBox1.Image);
                int height, width, x, y, r, g, b, a;
                height = bmp.Height;
                width = bmp.Width;
                Color c;
                for (y = 0; y < height; y++)
                {
                    for (x = 0; x < width; x++)
                    {
                        c = bmp.GetPixel(x, y);
                        r = c.R;
                        r = 0;
                        g = c.G;
                        b = c.B;
                        b = 0;
                        a = c.A;
                        bmp.SetPixel(x, y, Color.FromArgb(a, r, g, b));
                    }
                }
                pictureBox2.Image = bmp;
            }
            catch(Exception)
            {

            }
        }
    }
}
