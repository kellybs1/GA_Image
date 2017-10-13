using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

// Icon made by Freepik from www.flaticon.com 

namespace GA_Image
{
    public partial class Form1 : Form
    {
        private Random rand;
        private Graphics canvas;

        //not initialised until used!
        private int pop;
        private double prKeep;
        private double prMut;
        private Bitmap userImage;
        private Bitmap bufferImage;
        private Graphics bufferGraphics;
        private int drawEvery;
        private GAEngineColour gaEng;


        public Form1()
        {
            InitializeComponent();        
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox1.Visible = false;
            buttonStop.Enabled = false;
            buttonRunFile.Enabled = false;
            rand = new Random();
            bufferImage = new Bitmap(panelDraw.Width, panelDraw.Height);
            bufferGraphics = Graphics.FromImage(bufferImage);
            canvas = panelDraw.CreateGraphics();
            drawEvery = -1; //bad value
        }

       
        //loads user values from form
        private void getFormValues()
        {
            pop = (int)numericUpDownPopulation.Value;
            prKeep = (double)numericUpDownPrKeep.Value;
            prMut = (double)numericUpDownPrMutate.Value;
            drawEvery = (int)numericUpDownDrawEvery.Value;
        }

        //confirms user wants to close program
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            //confirm closing with user
            DialogResult confirmClose = MessageBox.Show("Are you sure you want to close?",
                                                       "Close program?",
                                                       MessageBoxButtons.YesNo);
            //if they choose no sto pthe form close
            if (confirmClose == DialogResult.No)
                e.Cancel = true;
        }

        //handle closing form in the middle of doing stuff
        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (gaEng != null)
                gaEng.CancelRunningGA();

            Application.ExitThread();
            Application.Exit();
        }

        private void disableFormControls()
        {
            numericUpDownPopulation.Enabled = false;
            numericUpDownPrKeep.Enabled = false;
            numericUpDownPrMutate.Enabled = false;           
            buttonColour16.Enabled = false;
            buttonOpenFile.Enabled = false;
            buttonRunFile.Enabled = false;
            checkBoxSaveImages.Enabled = false;
            numericUpDownDrawEvery.Enabled = false;
            pictureBox1.Visible = true;
        }

        //enable the form controls for a new run
        //this method should be subscribed to the engine's background workers completed event
        private void enableFormControls(object sender, RunWorkerCompletedEventArgs e)
        {
            numericUpDownPopulation.Enabled = true;
            numericUpDownPrKeep.Enabled = true;
            numericUpDownPrMutate.Enabled = true;
            buttonColour16.Enabled = true;
            buttonOpenFile.Enabled = true;
            checkBoxSaveImages.Enabled = true;
            numericUpDownDrawEvery.Enabled = true;

            //reverse
            pictureBox1.Visible = false;
            buttonStop.Enabled = false;
        }

        //stops current processing
        private void buttonStop_Click(object sender, EventArgs e)
        {
            //confirm stoppage with user
            DialogResult confirmStop = MessageBox.Show("Are you sure you want to stop?",
                                                       "Stop processing?",
                                                       MessageBoxButtons.YesNo);

            //stop if user confirms
            if (confirmStop == DialogResult.Yes)
            {
                //tell the GA to stop
                gaEng.CancelRunningGA();
            }

            //else do nothing
        }

        //button handlers
    
        //let the user choose a bitmap file to open
        private void buttonOpenFile_Click(object sender, EventArgs e)
        {
            //get the user to choose a bitmap file
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "Bitmap file (*.bmp)|*.bmp";
            //if the user correctly selected a file
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                //show the file that's being opened
                textBoxDrawInfo.Text = openFile.FileName;
                //read file into some sort of data structure
                userImage = (Bitmap)Image.FromFile(openFile.FileName, true);
                //allow run button now
                buttonRunFile.Enabled = true;                           
            }
        }

        //triggers running on the current loaded file
        private void buttonRunFile_Click(object sender, EventArgs e)
        {
            getFormValues();
            //init engine now otherwise everything will break
            gaEng = new GAEngineColour(bufferImage, bufferGraphics, canvas, panelDraw.Width, drawEvery, textBoxDrawInfo, userImage, pop, prKeep, prMut);
            //check if image is suitable before running
            if (gaEng.IsImageOK(userImage))
            {
                disableFormControls();
                //make sure engine triggers form controls working
                gaEng.worker.RunWorkerCompleted += enableFormControls;
                //toggle saving images based on form
                if (checkBoxSaveImages.Checked)
                    gaEng.SaveImages = true;

                gaEng.RunGA();
                buttonStop.Enabled = true;
            }
            else
            {
                MessageBox.Show("Image must be square 8,16,32,64,128,256,512px, but is " + userImage.Width + "x" + userImage.Height);
            }
        }

        //test draw button click handler
        private void buttonColour16_Click(object sender, EventArgs e)
        {
            disableFormControls();
            getFormValues();
            //init engine now otherwise everything will break
            gaEng = new GAEngineColour(bufferImage, bufferGraphics, canvas, panelDraw.Width, drawEvery, textBoxDrawInfo, Constants.TARGET_DRAW16, Constants.TARGET_DRAW16.Length, pop, prKeep, prMut);
            //make sure engine triggers form controls working
            gaEng.worker.RunWorkerCompleted += enableFormControls;
            //toggle saving images based on form
            if (checkBoxSaveImages.Checked)
                gaEng.SaveImages = true;

            gaEng.RunGA();
            buttonStop.Enabled = true;
        }

        //end button handlers


        //paint event - basically for minimizing/maximizing/screenshots etc
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            //if the GA isn't using the image, then draw
            if (gaEng != null)
            {
                if (!gaEng.isDrawing) //wait for engine to stop drawing so we can use the canvas/bitmap
                    canvas.DrawImage(bufferImage, 0, 0); //causing threading issues? fixed?
            }
        }
     
    }
}
