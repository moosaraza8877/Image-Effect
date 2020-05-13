namespace ImageEffect
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbtnGreen = new System.Windows.Forms.RadioButton();
            this.rbtnBlue = new System.Windows.Forms.RadioButton();
            this.rbtnRed = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.btnBrightnessSet = new System.Windows.Forms.Button();
            this.txtBrightness = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnGrayScale = new System.Windows.Forms.Button();
            this.btnNegative = new System.Windows.Forms.Button();
            this.btnloadImage = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Ivory;
            this.panel1.Controls.Add(this.btnReset);
            this.panel1.Controls.Add(this.btnloadImage);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(774, 225);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(460, 5);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(262, 217);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(52, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(262, 217);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbtnGreen);
            this.groupBox1.Controls.Add(this.rbtnBlue);
            this.groupBox1.Controls.Add(this.rbtnRed);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnBrightnessSet);
            this.groupBox1.Controls.Add(this.txtBrightness);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnGrayScale);
            this.groupBox1.Controls.Add(this.btnNegative);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 243);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(774, 226);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Edit";
            // 
            // rbtnGreen
            // 
            this.rbtnGreen.AutoSize = true;
            this.rbtnGreen.Location = new System.Drawing.Point(668, 149);
            this.rbtnGreen.Name = "rbtnGreen";
            this.rbtnGreen.Size = new System.Drawing.Size(68, 24);
            this.rbtnGreen.TabIndex = 8;
            this.rbtnGreen.TabStop = true;
            this.rbtnGreen.Text = "Green";
            this.rbtnGreen.UseVisualStyleBackColor = true;
            this.rbtnGreen.CheckedChanged += new System.EventHandler(this.rbtnGreen_CheckedChanged);
            // 
            // rbtnBlue
            // 
            this.rbtnBlue.AutoSize = true;
            this.rbtnBlue.Location = new System.Drawing.Point(588, 149);
            this.rbtnBlue.Name = "rbtnBlue";
            this.rbtnBlue.Size = new System.Drawing.Size(57, 24);
            this.rbtnBlue.TabIndex = 7;
            this.rbtnBlue.TabStop = true;
            this.rbtnBlue.Text = "Blue";
            this.rbtnBlue.UseVisualStyleBackColor = true;
            this.rbtnBlue.CheckedChanged += new System.EventHandler(this.rbtnBlue_CheckedChanged);
            // 
            // rbtnRed
            // 
            this.rbtnRed.AutoSize = true;
            this.rbtnRed.Location = new System.Drawing.Point(510, 149);
            this.rbtnRed.Name = "rbtnRed";
            this.rbtnRed.Size = new System.Drawing.Size(53, 24);
            this.rbtnRed.TabIndex = 6;
            this.rbtnRed.TabStop = true;
            this.rbtnRed.Text = "Red";
            this.rbtnRed.UseVisualStyleBackColor = true;
            this.rbtnRed.CheckedChanged += new System.EventHandler(this.rbtnRed_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(436, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Filter :";
            // 
            // btnBrightnessSet
            // 
            this.btnBrightnessSet.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnBrightnessSet.Enabled = false;
            this.btnBrightnessSet.Location = new System.Drawing.Point(668, 59);
            this.btnBrightnessSet.Name = "btnBrightnessSet";
            this.btnBrightnessSet.Size = new System.Drawing.Size(68, 29);
            this.btnBrightnessSet.TabIndex = 4;
            this.btnBrightnessSet.Text = "Set";
            this.btnBrightnessSet.UseVisualStyleBackColor = false;
            this.btnBrightnessSet.Click += new System.EventHandler(this.btnBrightnessSet_Click);
            // 
            // txtBrightness
            // 
            this.txtBrightness.BackColor = System.Drawing.Color.White;
            this.txtBrightness.Location = new System.Drawing.Point(569, 59);
            this.txtBrightness.Name = "txtBrightness";
            this.txtBrightness.ReadOnly = true;
            this.txtBrightness.Size = new System.Drawing.Size(86, 27);
            this.txtBrightness.TabIndex = 0;
            this.txtBrightness.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(436, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Brightness Level :";
            // 
            // btnGrayScale
            // 
            this.btnGrayScale.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnGrayScale.Enabled = false;
            this.btnGrayScale.Location = new System.Drawing.Point(52, 141);
            this.btnGrayScale.Name = "btnGrayScale";
            this.btnGrayScale.Size = new System.Drawing.Size(114, 41);
            this.btnGrayScale.TabIndex = 1;
            this.btnGrayScale.Text = "Gray Scale";
            this.btnGrayScale.UseVisualStyleBackColor = false;
            this.btnGrayScale.Click += new System.EventHandler(this.btnGrayScale_Click);
            // 
            // btnNegative
            // 
            this.btnNegative.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnNegative.Enabled = false;
            this.btnNegative.Location = new System.Drawing.Point(52, 52);
            this.btnNegative.Name = "btnNegative";
            this.btnNegative.Size = new System.Drawing.Size(114, 41);
            this.btnNegative.TabIndex = 3;
            this.btnNegative.Text = "Negative";
            this.btnNegative.UseVisualStyleBackColor = false;
            this.btnNegative.Click += new System.EventHandler(this.btnNegative_Click);
            // 
            // btnloadImage
            // 
            this.btnloadImage.BackColor = System.Drawing.Color.White;
            this.btnloadImage.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnloadImage.Location = new System.Drawing.Point(320, 184);
            this.btnloadImage.Name = "btnloadImage";
            this.btnloadImage.Size = new System.Drawing.Size(27, 23);
            this.btnloadImage.TabIndex = 2;
            this.btnloadImage.Text = "...";
            this.btnloadImage.UseVisualStyleBackColor = false;
            this.btnloadImage.Click += new System.EventHandler(this.btnloadImage_Click);
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.White;
            this.btnReset.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(320, 147);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(27, 31);
            this.btnReset.TabIndex = 3;
            this.btnReset.Text = "x";
            this.btnReset.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(798, 481);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Image Filter";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.RadioButton rbtnGreen;
        private System.Windows.Forms.RadioButton rbtnBlue;
        private System.Windows.Forms.RadioButton rbtnRed;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnBrightnessSet;
        private System.Windows.Forms.TextBox txtBrightness;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGrayScale;
        private System.Windows.Forms.Button btnNegative;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnloadImage;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

