namespace ImageQuantization
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
            this.button4 = new System.Windows.Forms.Button();
            this.Quantize = new System.Windows.Forms.Button();
            this.Atkinson = new System.Windows.Forms.Button();
            this.Gaussian = new System.Windows.Forms.Button();
            this.median = new System.Windows.Forms.Button();
            this.PostImage = new System.Windows.Forms.PictureBox();
            this.panelLeft = new System.Windows.Forms.Panel();
            this.button6 = new System.Windows.Forms.Button();
            this.Preimage = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Filter = new System.Windows.Forms.Panel();
            this.maskSize = new System.Windows.Forms.NumericUpDown();
            this.maskSize_label = new System.Windows.Forms.Label();
            this.ClusterK = new System.Windows.Forms.NumericUpDown();
            this.txtDisColor = new System.Windows.Forms.TextBox();
            this.txtMST = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.factor = new System.Windows.Forms.NumericUpDown();
            this.txtHeight = new System.Windows.Forms.TextBox();
            this.txtWidth = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnQuantize = new System.Windows.Forms.Button();
            this.chooseImage = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gaussSmooth = new System.Windows.Forms.Button();
            this.floyed = new System.Windows.Forms.Button();
            this.Time = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PostImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Preimage)).BeginInit();
            this.Filter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.maskSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ClusterK)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.factor)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // button4
            // 
            this.button4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(1055, 23);
            this.button4.Margin = new System.Windows.Forms.Padding(2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(97, 25);
            this.button4.TabIndex = 19;
            this.button4.Text = "H : M : S";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // Quantize
            // 
            this.Quantize.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Quantize.BackgroundImage")));
            this.Quantize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Quantize.FlatAppearance.BorderSize = 0;
            this.Quantize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Quantize.ForeColor = System.Drawing.Color.White;
            this.Quantize.Location = new System.Drawing.Point(20, 109);
            this.Quantize.Margin = new System.Windows.Forms.Padding(2);
            this.Quantize.Name = "Quantize";
            this.Quantize.Size = new System.Drawing.Size(95, 61);
            this.Quantize.TabIndex = 5;
            this.Quantize.Text = "Quantization";
            this.Quantize.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Quantize.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Quantize.UseVisualStyleBackColor = true;
            this.Quantize.Click += new System.EventHandler(this.Quantize_Click);
            // 
            // Atkinson
            // 
            this.Atkinson.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Atkinson.BackgroundImage")));
            this.Atkinson.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Atkinson.FlatAppearance.BorderSize = 0;
            this.Atkinson.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Atkinson.ForeColor = System.Drawing.Color.White;
            this.Atkinson.Location = new System.Drawing.Point(20, 440);
            this.Atkinson.Margin = new System.Windows.Forms.Padding(2);
            this.Atkinson.Name = "Atkinson";
            this.Atkinson.Size = new System.Drawing.Size(95, 84);
            this.Atkinson.TabIndex = 4;
            this.Atkinson.Text = "Atkinson";
            this.Atkinson.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Atkinson.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Atkinson.UseVisualStyleBackColor = true;
            this.Atkinson.Click += new System.EventHandler(this.Atkinson_Click);
            // 
            // Gaussian
            // 
            this.Gaussian.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Gaussian.BackgroundImage")));
            this.Gaussian.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Gaussian.FlatAppearance.BorderSize = 0;
            this.Gaussian.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Gaussian.ForeColor = System.Drawing.Color.White;
            this.Gaussian.Location = new System.Drawing.Point(20, 355);
            this.Gaussian.Margin = new System.Windows.Forms.Padding(2);
            this.Gaussian.Name = "Gaussian";
            this.Gaussian.Size = new System.Drawing.Size(95, 81);
            this.Gaussian.TabIndex = 3;
            this.Gaussian.Text = "Gaussien ";
            this.Gaussian.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Gaussian.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Gaussian.UseVisualStyleBackColor = true;
            this.Gaussian.Click += new System.EventHandler(this.Gaussian_Click);
            // 
            // median
            // 
            this.median.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("median.BackgroundImage")));
            this.median.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.median.FlatAppearance.BorderSize = 0;
            this.median.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.median.ForeColor = System.Drawing.Color.White;
            this.median.Location = new System.Drawing.Point(20, 269);
            this.median.Margin = new System.Windows.Forms.Padding(2);
            this.median.Name = "median";
            this.median.Size = new System.Drawing.Size(95, 81);
            this.median.TabIndex = 2;
            this.median.Text = "Medain";
            this.median.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.median.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.median.UseVisualStyleBackColor = true;
            this.median.Click += new System.EventHandler(this.median_Click);
            // 
            // PostImage
            // 
            this.PostImage.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.PostImage.BackColor = System.Drawing.Color.Black;
            this.PostImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.PostImage.ErrorImage = null;
            this.PostImage.Image = ((System.Drawing.Image)(resources.GetObject("PostImage.Image")));
            this.PostImage.InitialImage = null;
            this.PostImage.Location = new System.Drawing.Point(663, 60);
            this.PostImage.Margin = new System.Windows.Forms.Padding(2);
            this.PostImage.Name = "PostImage";
            this.PostImage.Size = new System.Drawing.Size(564, 366);
            this.PostImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PostImage.TabIndex = 18;
            this.PostImage.TabStop = false;
            // 
            // panelLeft
            // 
            this.panelLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.panelLeft.Location = new System.Drawing.Point(140, 120);
            this.panelLeft.Margin = new System.Windows.Forms.Padding(2);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(4, 47);
            this.panelLeft.TabIndex = 17;
            // 
            // button6
            // 
            this.button6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Location = new System.Drawing.Point(867, 22);
            this.button6.Margin = new System.Windows.Forms.Padding(2);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(62, 25);
            this.button6.TabIndex = 16;
            this.button6.Text = "TIME";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // Preimage
            // 
            this.Preimage.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Preimage.BackColor = System.Drawing.Color.Black;
            this.Preimage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Preimage.ErrorImage = null;
            this.Preimage.Image = ((System.Drawing.Image)(resources.GetObject("Preimage.Image")));
            this.Preimage.InitialImage = null;
            this.Preimage.Location = new System.Drawing.Point(151, 60);
            this.Preimage.Margin = new System.Windows.Forms.Padding(2);
            this.Preimage.Name = "Preimage";
            this.Preimage.Size = new System.Drawing.Size(502, 366);
            this.Preimage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Preimage.TabIndex = 14;
            this.Preimage.TabStop = false;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(507, 21);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(225, 25);
            this.label1.TabIndex = 13;
            this.label1.Text = "Image Quantization";
            // 
            // Filter
            // 
            this.Filter.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Filter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(40)))), ((int)(((byte)(47)))));
            this.Filter.Controls.Add(this.maskSize);
            this.Filter.Controls.Add(this.maskSize_label);
            this.Filter.Controls.Add(this.ClusterK);
            this.Filter.Controls.Add(this.txtDisColor);
            this.Filter.Controls.Add(this.txtMST);
            this.Filter.Controls.Add(this.label9);
            this.Filter.Controls.Add(this.label10);
            this.Filter.Controls.Add(this.label11);
            this.Filter.Controls.Add(this.factor);
            this.Filter.Controls.Add(this.txtHeight);
            this.Filter.Controls.Add(this.txtWidth);
            this.Filter.Controls.Add(this.label6);
            this.Filter.Controls.Add(this.label5);
            this.Filter.Controls.Add(this.label4);
            this.Filter.Controls.Add(this.btnQuantize);
            this.Filter.Controls.Add(this.chooseImage);
            this.Filter.Location = new System.Drawing.Point(151, 2);
            this.Filter.Margin = new System.Windows.Forms.Padding(2);
            this.Filter.Name = "Filter";
            this.Filter.Size = new System.Drawing.Size(840, 278);
            this.Filter.TabIndex = 12;
            // 
            // maskSize
            // 
            this.maskSize.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskSize.Location = new System.Drawing.Point(506, 123);
            this.maskSize.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.maskSize.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.maskSize.Name = "maskSize";
            this.maskSize.Size = new System.Drawing.Size(121, 23);
            this.maskSize.TabIndex = 42;
            this.maskSize.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.maskSize.Visible = false;
            // 
            // maskSize_label
            // 
            this.maskSize_label.AutoSize = true;
            this.maskSize_label.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskSize_label.Location = new System.Drawing.Point(379, 123);
            this.maskSize_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.maskSize_label.Name = "maskSize_label";
            this.maskSize_label.Size = new System.Drawing.Size(114, 25);
            this.maskSize_label.TabIndex = 41;
            this.maskSize_label.Text = "Mask Size";
            this.maskSize_label.Visible = false;
            // 
            // ClusterK
            // 
            this.ClusterK.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClusterK.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.ClusterK.Location = new System.Drawing.Point(273, 170);
            this.ClusterK.Maximum = new decimal(new int[] {
            200000000,
            0,
            0,
            0});
            this.ClusterK.Name = "ClusterK";
            this.ClusterK.Size = new System.Drawing.Size(81, 23);
            this.ClusterK.TabIndex = 40;
            // 
            // txtDisColor
            // 
            this.txtDisColor.Location = new System.Drawing.Point(439, 170);
            this.txtDisColor.Margin = new System.Windows.Forms.Padding(2);
            this.txtDisColor.Name = "txtDisColor";
            this.txtDisColor.Size = new System.Drawing.Size(84, 20);
            this.txtDisColor.TabIndex = 39;
            // 
            // txtMST
            // 
            this.txtMST.Location = new System.Drawing.Point(63, 170);
            this.txtMST.Margin = new System.Windows.Forms.Padding(2);
            this.txtMST.Name = "txtMST";
            this.txtMST.Size = new System.Drawing.Size(108, 20);
            this.txtMST.TabIndex = 38;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(393, 138);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(162, 25);
            this.label9.TabIndex = 35;
            this.label9.Text = "Distinct Colors";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(235, 138);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(144, 25);
            this.label10.TabIndex = 36;
            this.label10.Text = "#Of Clusters";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(91, 138);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(57, 25);
            this.label11.TabIndex = 37;
            this.label11.Text = "MST";
            // 
            // factor
            // 
            this.factor.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.factor.Location = new System.Drawing.Point(179, 123);
            this.factor.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.factor.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.factor.Name = "factor";
            this.factor.Size = new System.Drawing.Size(121, 23);
            this.factor.TabIndex = 34;
            this.factor.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.factor.Visible = false;
            // 
            // txtHeight
            // 
            this.txtHeight.Location = new System.Drawing.Point(573, 66);
            this.txtHeight.Margin = new System.Windows.Forms.Padding(2);
            this.txtHeight.Name = "txtHeight";
            this.txtHeight.Size = new System.Drawing.Size(84, 20);
            this.txtHeight.TabIndex = 19;
            // 
            // txtWidth
            // 
            this.txtWidth.Location = new System.Drawing.Point(573, 28);
            this.txtWidth.Margin = new System.Windows.Forms.Padding(2);
            this.txtWidth.Name = "txtWidth";
            this.txtWidth.Size = new System.Drawing.Size(84, 20);
            this.txtWidth.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(485, 56);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 25);
            this.label6.TabIndex = 14;
            this.label6.Text = "height";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(485, 24);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 25);
            this.label5.TabIndex = 13;
            this.label5.Text = "width";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(23, 123);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 25);
            this.label4.TabIndex = 12;
            this.label4.Text = "Factor";
            this.label4.Visible = false;
            // 
            // btnQuantize
            // 
            this.btnQuantize.Location = new System.Drawing.Point(306, 24);
            this.btnQuantize.Margin = new System.Windows.Forms.Padding(2);
            this.btnQuantize.Name = "btnQuantize";
            this.btnQuantize.Size = new System.Drawing.Size(154, 45);
            this.btnQuantize.TabIndex = 1;
            this.btnQuantize.Text = "Quantize Image";
            this.btnQuantize.UseVisualStyleBackColor = true;
            this.btnQuantize.Click += new System.EventHandler(this.btnQuantize_Click_1);
            // 
            // chooseImage
            // 
            this.chooseImage.Location = new System.Drawing.Point(126, 24);
            this.chooseImage.Margin = new System.Windows.Forms.Padding(2);
            this.chooseImage.Name = "chooseImage";
            this.chooseImage.Size = new System.Drawing.Size(156, 45);
            this.chooseImage.TabIndex = 0;
            this.chooseImage.Text = "Choose Image";
            this.chooseImage.UseVisualStyleBackColor = true;
            this.chooseImage.Click += new System.EventHandler(this.chooseImage_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.gaussSmooth);
            this.panel1.Controls.Add(this.floyed);
            this.panel1.Controls.Add(this.Quantize);
            this.panel1.Controls.Add(this.Atkinson);
            this.panel1.Controls.Add(this.Gaussian);
            this.panel1.Controls.Add(this.median);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(138, 635);
            this.panel1.TabIndex = 11;
            // 
            // gaussSmooth
            // 
            this.gaussSmooth.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("gaussSmooth.BackgroundImage")));
            this.gaussSmooth.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gaussSmooth.FlatAppearance.BorderSize = 0;
            this.gaussSmooth.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gaussSmooth.ForeColor = System.Drawing.Color.White;
            this.gaussSmooth.Location = new System.Drawing.Point(20, 528);
            this.gaussSmooth.Margin = new System.Windows.Forms.Padding(2);
            this.gaussSmooth.Name = "gaussSmooth";
            this.gaussSmooth.Size = new System.Drawing.Size(95, 84);
            this.gaussSmooth.TabIndex = 7;
            this.gaussSmooth.Text = "Gauss Smooth";
            this.gaussSmooth.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.gaussSmooth.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.gaussSmooth.UseVisualStyleBackColor = true;
            this.gaussSmooth.Click += new System.EventHandler(this.gaussSmooth_Click);
            // 
            // floyed
            // 
            this.floyed.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("floyed.BackgroundImage")));
            this.floyed.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.floyed.FlatAppearance.BorderSize = 0;
            this.floyed.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.floyed.ForeColor = System.Drawing.Color.White;
            this.floyed.Location = new System.Drawing.Point(20, 185);
            this.floyed.Margin = new System.Windows.Forms.Padding(2);
            this.floyed.Name = "floyed";
            this.floyed.Size = new System.Drawing.Size(95, 81);
            this.floyed.TabIndex = 6;
            this.floyed.Text = "Floyed";
            this.floyed.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.floyed.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.floyed.UseVisualStyleBackColor = true;
            this.floyed.Click += new System.EventHandler(this.floyed_Click);
            // 
            // Time
            // 
            this.Time.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Time.FlatAppearance.BorderSize = 0;
            this.Time.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Time.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Time.Location = new System.Drawing.Point(937, 23);
            this.Time.Margin = new System.Windows.Forms.Padding(2);
            this.Time.Name = "Time";
            this.Time.Size = new System.Drawing.Size(129, 25);
            this.Time.TabIndex = 20;
            this.Time.Text = "00:00:00";
            this.Time.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(40)))), ((int)(((byte)(47)))));
            this.panel2.Controls.Add(this.Filter);
            this.panel2.Location = new System.Drawing.Point(151, 430);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1116, 278);
            this.panel2.TabIndex = 41;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(40, 23);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(63, 54);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 0;
            this.pictureBox3.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(1256, 632);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.Time);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.PostImage);
            this.Controls.Add(this.panelLeft);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.Preimage);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainForm";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.PostImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Preimage)).EndInit();
            this.Filter.ResumeLayout(false);
            this.Filter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.maskSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ClusterK)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.factor)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

          }

          #endregion

          private System.Windows.Forms.Button button4;
          private System.Windows.Forms.Button Quantize;
          private System.Windows.Forms.Button Atkinson;
          private System.Windows.Forms.Button Gaussian;
          private System.Windows.Forms.Button median;
          private System.Windows.Forms.PictureBox PostImage;
          private System.Windows.Forms.Panel panelLeft;
          private System.Windows.Forms.Button button6;
          private System.Windows.Forms.PictureBox Preimage;
          private System.Windows.Forms.Label label1;
          private System.Windows.Forms.Panel Filter;
          private System.Windows.Forms.Panel panel1;
          private System.Windows.Forms.Button floyed;
          private System.Windows.Forms.Button Time;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.NumericUpDown ClusterK;
        private System.Windows.Forms.TextBox txtDisColor;
        private System.Windows.Forms.TextBox txtMST;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.NumericUpDown factor;
        private System.Windows.Forms.TextBox txtHeight;
        private System.Windows.Forms.TextBox txtWidth;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnQuantize;
        private System.Windows.Forms.Button chooseImage;
        private System.Windows.Forms.Button gaussSmooth;
        private System.Windows.Forms.NumericUpDown maskSize;
        private System.Windows.Forms.Label maskSize_label;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}

