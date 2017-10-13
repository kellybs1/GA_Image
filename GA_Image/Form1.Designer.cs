namespace GA_Image
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
            this.numericUpDownPopulation = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.numericUpDownPrKeep = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownPrMutate = new System.Windows.Forms.NumericUpDown();
            this.panelDraw = new System.Windows.Forms.Panel();
            this.buttonColour16 = new System.Windows.Forms.Button();
            this.buttonStop = new System.Windows.Forms.Button();
            this.textBoxDrawInfo = new System.Windows.Forms.TextBox();
            this.buttonOpenFile = new System.Windows.Forms.Button();
            this.buttonRunFile = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.checkBoxSaveImages = new System.Windows.Forms.CheckBox();
            this.numericUpDownDrawEvery = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPopulation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPrKeep)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPrMutate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDrawEvery)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // numericUpDownPopulation
            // 
            this.numericUpDownPopulation.Increment = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numericUpDownPopulation.Location = new System.Drawing.Point(127, 561);
            this.numericUpDownPopulation.Maximum = new decimal(new int[] {
            512,
            0,
            0,
            0});
            this.numericUpDownPopulation.Minimum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.numericUpDownPopulation.Name = "numericUpDownPopulation";
            this.numericUpDownPopulation.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownPopulation.TabIndex = 1;
            this.numericUpDownPopulation.Value = new decimal(new int[] {
            16,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 563);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Population";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 597);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Probability to keep";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 630);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Probability to mutate";
            // 
            // numericUpDownPrKeep
            // 
            this.numericUpDownPrKeep.DecimalPlaces = 1;
            this.numericUpDownPrKeep.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numericUpDownPrKeep.Location = new System.Drawing.Point(127, 595);
            this.numericUpDownPrKeep.Maximum = new decimal(new int[] {
            9,
            0,
            0,
            65536});
            this.numericUpDownPrKeep.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numericUpDownPrKeep.Name = "numericUpDownPrKeep";
            this.numericUpDownPrKeep.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownPrKeep.TabIndex = 5;
            this.numericUpDownPrKeep.Value = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            // 
            // numericUpDownPrMutate
            // 
            this.numericUpDownPrMutate.DecimalPlaces = 7;
            this.numericUpDownPrMutate.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numericUpDownPrMutate.Location = new System.Drawing.Point(127, 628);
            this.numericUpDownPrMutate.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            327680});
            this.numericUpDownPrMutate.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            327680});
            this.numericUpDownPrMutate.Name = "numericUpDownPrMutate";
            this.numericUpDownPrMutate.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownPrMutate.TabIndex = 6;
            this.numericUpDownPrMutate.Value = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            // 
            // panelDraw
            // 
            this.panelDraw.Location = new System.Drawing.Point(12, 12);
            this.panelDraw.Name = "panelDraw";
            this.panelDraw.Size = new System.Drawing.Size(512, 512);
            this.panelDraw.TabIndex = 10;
            // 
            // buttonColour16
            // 
            this.buttonColour16.Location = new System.Drawing.Point(289, 598);
            this.buttonColour16.Name = "buttonColour16";
            this.buttonColour16.Size = new System.Drawing.Size(235, 23);
            this.buttonColour16.TabIndex = 11;
            this.buttonColour16.Text = "Test Draw";
            this.buttonColour16.UseVisualStyleBackColor = true;
            this.buttonColour16.Click += new System.EventHandler(this.buttonColour16_Click);
            // 
            // buttonStop
            // 
            this.buttonStop.BackColor = System.Drawing.Color.Gainsboro;
            this.buttonStop.ForeColor = System.Drawing.Color.Black;
            this.buttonStop.Location = new System.Drawing.Point(289, 628);
            this.buttonStop.Name = "buttonStop";
            this.buttonStop.Size = new System.Drawing.Size(235, 23);
            this.buttonStop.TabIndex = 15;
            this.buttonStop.Text = "Stop";
            this.buttonStop.UseVisualStyleBackColor = false;
            this.buttonStop.Click += new System.EventHandler(this.buttonStop_Click);
            // 
            // textBoxDrawInfo
            // 
            this.textBoxDrawInfo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxDrawInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDrawInfo.Location = new System.Drawing.Point(321, 531);
            this.textBoxDrawInfo.Name = "textBoxDrawInfo";
            this.textBoxDrawInfo.ReadOnly = true;
            this.textBoxDrawInfo.Size = new System.Drawing.Size(203, 22);
            this.textBoxDrawInfo.TabIndex = 16;
            this.textBoxDrawInfo.TabStop = false;
            this.textBoxDrawInfo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // buttonOpenFile
            // 
            this.buttonOpenFile.Location = new System.Drawing.Point(12, 530);
            this.buttonOpenFile.Name = "buttonOpenFile";
            this.buttonOpenFile.Size = new System.Drawing.Size(107, 23);
            this.buttonOpenFile.TabIndex = 17;
            this.buttonOpenFile.Text = "Open File";
            this.buttonOpenFile.UseVisualStyleBackColor = true;
            this.buttonOpenFile.Click += new System.EventHandler(this.buttonOpenFile_Click);
            // 
            // buttonRunFile
            // 
            this.buttonRunFile.Location = new System.Drawing.Point(139, 530);
            this.buttonRunFile.Name = "buttonRunFile";
            this.buttonRunFile.Size = new System.Drawing.Size(108, 23);
            this.buttonRunFile.TabIndex = 18;
            this.buttonRunFile.Text = "Run File";
            this.buttonRunFile.UseVisualStyleBackColor = true;
            this.buttonRunFile.Click += new System.EventHandler(this.buttonRunFile_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(310, 662);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "Save image on draw";
            // 
            // checkBoxSaveImages
            // 
            this.checkBoxSaveImages.AutoSize = true;
            this.checkBoxSaveImages.Location = new System.Drawing.Point(289, 661);
            this.checkBoxSaveImages.Name = "checkBoxSaveImages";
            this.checkBoxSaveImages.Size = new System.Drawing.Size(15, 14);
            this.checkBoxSaveImages.TabIndex = 20;
            this.checkBoxSaveImages.UseVisualStyleBackColor = true;
            // 
            // numericUpDownDrawEvery
            // 
            this.numericUpDownDrawEvery.Location = new System.Drawing.Point(127, 659);
            this.numericUpDownDrawEvery.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numericUpDownDrawEvery.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDownDrawEvery.Name = "numericUpDownDrawEvery";
            this.numericUpDownDrawEvery.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownDrawEvery.TabIndex = 21;
            this.numericUpDownDrawEvery.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 661);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 13);
            this.label5.TabIndex = 22;
            this.label5.Text = "Draw every n gens";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(289, 530);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(22, 22);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(538, 687);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.numericUpDownDrawEvery);
            this.Controls.Add(this.checkBoxSaveImages);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.buttonRunFile);
            this.Controls.Add(this.buttonOpenFile);
            this.Controls.Add(this.textBoxDrawInfo);
            this.Controls.Add(this.buttonStop);
            this.Controls.Add(this.buttonColour16);
            this.Controls.Add(this.panelDraw);
            this.Controls.Add(this.numericUpDownPrMutate);
            this.Controls.Add(this.numericUpDownPrKeep);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numericUpDownPopulation);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "GA";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPopulation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPrKeep)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPrMutate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDrawEvery)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.NumericUpDown numericUpDownPopulation;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numericUpDownPrKeep;
        private System.Windows.Forms.NumericUpDown numericUpDownPrMutate;
        private System.Windows.Forms.Panel panelDraw;
        private System.Windows.Forms.Button buttonColour16;
        private System.Windows.Forms.Button buttonStop;
        private System.Windows.Forms.TextBox textBoxDrawInfo;
        private System.Windows.Forms.Button buttonOpenFile;
        private System.Windows.Forms.Button buttonRunFile;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox checkBoxSaveImages;
        private System.Windows.Forms.NumericUpDown numericUpDownDrawEvery;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

