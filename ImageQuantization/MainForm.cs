using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImageQuantization
{
     public partial class MainForm : Form

     {
        RGBPixel[,] ImageMatrix;
        public string type_filter= "Quantization";
          public MainForm()
          {
               InitializeComponent();
          }


        private void chooseImage_Click(object sender, EventArgs e)
        {
            // intialization the tools
            ClusterK.Value = 0; // -> O(1)
            factor.Value = 1;  // -> O(1)
            txtMST.Text = null;  // -> O(1)
            txtDisColor.Text = null;  // -> O(1)
            factor.Text = "1";  // -> O(1)
            maskSize.Text = "3";  // -> O(1)
            Preimage.Image = null;  // -> O(1)
            OpenFileDialog openFileDialog1 = new OpenFileDialog();  // -> O(1)
            if (openFileDialog1.ShowDialog() == DialogResult.OK)  // -> O(1)
            {
                //Open the browsed image and display it
                string OpenedFilePath = openFileDialog1.FileName;  // -> O(1)
                ImageMatrix = ImageOperations.OpenImage(OpenedFilePath);  // -> O(W*H)
                ImageOperations.DisplayImage(ImageMatrix, Preimage, 0); // -> O(W*H)
            }
            txtWidth.Text = ImageOperations.GetWidth(ImageMatrix).ToString();   // -> O(1)
            txtHeight.Text = ImageOperations.GetHeight(ImageMatrix).ToString();  // -> O(1)
        }

        private void Quantize_Click(object sender, EventArgs e)
        {
            btnQuantize.Text = "Quantize Image";
            type_filter = "Quantization";
            factor.Visible = false;
            label4.Visible = false;
            label11.Visible = true;
            label10.Visible = true;
            label9.Visible = true;
            txtMST.Visible = true;
            txtDisColor.Visible = true;
            ClusterK.Visible = true;

            maskSize.Visible = false;
            maskSize_label.Visible = false;

            panelLeft.Location = new Point(140, 120);
        }

        private void floyed_Click(object sender, EventArgs e)
        {
            btnQuantize.Text = "Filter Image";
            factor.Visible = true;
            label4.Visible = true;
            label11.Visible = false;
            label10.Visible = false;
            label9.Visible = false;
            txtMST.Visible = false;
            txtDisColor.Visible = false;
            ClusterK.Visible = false;

            maskSize.Visible = false;
            maskSize_label.Visible = false;
            label4.Text = "Factor";

            type_filter = "floyed";
            panelLeft.Location = new Point(140, 210);
        }

        private void median_Click(object sender, EventArgs e)
        {
            btnQuantize.Text = "Filter Image";
            factor.Visible = true;
            label4.Visible = true;
            label11.Visible = false;
            label10.Visible = false;
            label9.Visible = false;
            txtMST.Visible = false;
            txtDisColor.Visible = false;
            ClusterK.Visible = false;

            maskSize.Visible = false;
            maskSize_label.Visible = false;
            label4.Text = "Factor";

            type_filter = "median";
            panelLeft.Location = new Point(140, 290);
        }

        private void Gaussian_Click(object sender, EventArgs e)
        {
            btnQuantize.Text = "Filter Image";
            factor.Visible = true;
            label4.Visible = true;
            label11.Visible = false;
            label10.Visible = false;
            label9.Visible = false;
            txtMST.Visible = false;
            txtDisColor.Visible = false;
            ClusterK.Visible = false;

            maskSize.Visible = false;
            maskSize_label.Visible = false;
            label4.Text = "Factor";

            type_filter = "Gaussien";
            panelLeft.Location = new Point(140, 380);
        }

        private void Atkinson_Click(object sender, EventArgs e)
        {
            btnQuantize.Text = "Filter Image";
            factor.Visible = true;
            label4.Visible = true;
            label11.Visible = false;
            label10.Visible = false;
            label9.Visible = false;
            txtMST.Visible = false;
            txtDisColor.Visible = false;
            ClusterK.Visible = false;

            maskSize.Visible = false;
            maskSize_label.Visible = false;
            label4.Text = "Factor";

            type_filter = "Atk";
            panelLeft.Location = new Point(140, 460);
        }

      

        private void gaussSmooth_Click(object sender, EventArgs e)
        {
            btnQuantize.Text = "Filter Image";
            factor.Visible = true;
            label4.Visible = true;
            label11.Visible = false;
            label10.Visible = false;
            label9.Visible = false;
            txtMST.Visible = false;
            txtDisColor.Visible = false;
            ClusterK.Visible = false;

            maskSize.Visible = true;
            maskSize_label.Visible = true;
            label4.Text = "Gauss Sigma";

            type_filter = "gauss smooth";
            panelLeft.Location = new Point(140, 550);
        }


        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////


        private void btnQuantize_Click(object sender, EventArgs e)
        {
            int K = (int)ClusterK.Value;  // -> O(1)
            txtDisColor.Text = ImageAnalytics.Find_Distinct_Color(ImageMatrix).ToString();  // -> O(W*H)
            txtMST.Text = (Math.Round(ImageAnalytics.MinimumSpanningTree(), 2)).ToString(); // -> O(E Log V)
            DetectNumOfClusters x = new DetectNumOfClusters(ImageAnalytics.edges);  // -> O(E*V)
            if (K == 0) K = x.k; // -> O(1)
            QuantizeImage.Extract_K_Cluster(K); // -> O(K*D)
            QuantizeImage.Find_K_Cluster(); // -> O(D)
            ImageOperations.DisplayImage(ImageMatrix, PostImage, 1); //O(N^2) where N is the height or the weight of image
            ClusterK.Value = K;                       // print the number of cluster if changed // -> O(1)
           
        }

        private void btnGaussSmooth_Click(object sender, EventArgs e)
        {
            double sigma = (double)factor.Value; // -> O(1)
            int maskSize_ = (int)maskSize.Value; // -> O(1)
            RGBPixel[,] ImageFilltered = ImageMatrix; // -> O(1)
            ImageFilltered = ImageOperations.GaussianFilter1D(ImageMatrix, maskSize_, sigma); //->  O(W*H)
            ImageOperations.DisplayImage(ImageFilltered, PostImage, 0); //->  O(W*H)
        }

        private void FloyedBtn_Click(object sender, EventArgs e)
        {
            int factor_ = (int)factor.Value;  // -> O(1)
            RGBPixel[,] ImageFilltered;  // -> O(1)
            ImageFilltered = FloyedDither.Floyed_Dithering(factor_, ImageMatrix);  // ->>O(H * W)
            ImageOperations.DisplayImage(ImageFilltered, PostImage, 0);  // ->>O(H * W)
        }

        private void MedianBtn_Click(object sender, EventArgs e)
        {
            Bitmap orgPic = new Bitmap(this.Preimage.Image); // -> O(1)
            Bitmap tmpPic = new Bitmap(this.Preimage.Image); // -> O(1)
            int Factor = (int)factor.Value; // -> O(1)
            MedianFilter.Median_Filter(orgPic, Factor, ref tmpPic); //  [-> O(N Log N))]
            PostImage.Image = tmpPic; // -> O(1)
        }

        private void SurfaceBlurBtn_Click(object sender, EventArgs e)
        {
            Bitmap bitMapO = new Bitmap(this.Preimage.Image); // -> O(1)
            Bitmap bitMapF = new Bitmap(this.Preimage.Image); // -> O(1)
            int Factor = (int)factor.Value; // -> O(1)
            GaussianBlur GB = new GaussianBlur(bitMapO);  // ->>O(H * W)
            bitMapF = GB.Process(Factor);  // ->>O(H * W)
            PostImage.Image = bitMapF; // -> O(1)
        }

        private void NonFloyedBtn_Click(object sender, EventArgs e)
        {
            int factor_ = (int)factor.Value; // -> O(1)
            RGBPixel[,] ImageFilltered; // -> O(1)
            ImageFilltered = AtkinsonDither.Atkinson_Dithering(ImageMatrix, factor_); // ->>O(H * W)
            ImageOperations.DisplayImage(ImageFilltered, PostImage, 0); // -> O(1)
        }

        private void btnQuantize_Click_1(object sender, EventArgs e)
        {
            Stopwatch stopWatch = Stopwatch.StartNew(); // get the current time in miliseconds  // -> O(1)
            if (type_filter == "Quantization")
                btnQuantize_Click(sender,e);

            else if (type_filter == "floyed")
            {
                FloyedBtn_Click(sender, e);
            }
            else if (type_filter == "median")
            {
                MedianBtn_Click(sender, e);
            }
            else if (type_filter == "Gaussien")
            {
                SurfaceBlurBtn_Click(sender, e);
            }
            else if (type_filter == "Atk")
            {
                NonFloyedBtn_Click(sender, e);
            }
            else//gauss smooth
            {
                btnGaussSmooth_Click(sender, e);
            }
            stopWatch.Stop();
            Time.Text = stopWatch.Elapsed.ToString(); // -> O(1)
        }

       
    }
}
