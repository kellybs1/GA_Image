using System;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace GA_Image
{
    /*
     * Class: GAEngine
     * Description: Base engine class for controlling behaviour of collections of chromosomes
     * Author: Brendan Kelly
     * Date: 27/9/2017
     */

    public abstract class GAEngine
    {
        protected int population;
        protected double prKeep;
        protected double prMutate;
        protected int elite;
        protected int nKeep;
        protected Random rand;
        protected double[] cumulativeProbs;
        protected int[][] breedingPairs; 
        protected int nPairs;

        public GAEngine(int inPopulation, double inPrKeep, double inPrMutate)
        {
            population = inPopulation;
            prKeep = inPrKeep;
            prMutate = inPrMutate;
            nKeep = Convert.ToInt32(population * prKeep);
            cumulativeProbs = new double[nKeep];
            rand = new Random();
            nPairs = nKeep / 2;
            breedingPairs = new int[nPairs][];
        }

        //abstract methods
        public abstract void RunGA();
        public abstract void Reproduction();
        public abstract void Mutation();
        public abstract void RecomputeFitness();
        public abstract void GenerateRandomBeings();


        //virtual methods

        //select the next breeding pair
        public virtual void Selection()
        {
            for (int i = 0; i < nPairs; i++)
            {
                int parent1Index = 0;
                int parent2Index = 0;
                //make sure parents are different
                do
                {
                    //generade random doubles
                    double probM = rand.NextDouble();
                    double probF = rand.NextDouble();
                    //get the indexes of the parents in the ranks
                    parent1Index = selectParent(probM);
                    parent2Index = selectParent(probF);

                } while (parent1Index == parent2Index); //make sure parents are different

                //assign the pairs together
                int[] thisPair = { parent1Index, parent2Index };
                breedingPairs[i] = thisPair; //put them in the breeding pairs
            }
        }

        //sub method for Selection
        //finds the index the randomly generated probably corresponds to
        private int selectParent(double prob)
        {
            for (int i = 0; i < nKeep; i++) //check every cumulative probability
            {
                //if we're less than the current CP we're in its bucket
                if (prob < cumulativeProbs[i])
                    return i;
            }
            return 1;
        }

        //computes cumulative probabilities
        public virtual void ComputeCP()
        {
            int rankSum = sumRanks();
            for (int i = 0; i < nKeep; i++)
            {
                int currentRank = i + 1;
                //invert rank
                int invCurrentRank = (nKeep + 1) - currentRank;
                //calculate the current cumulative probability
                double currentCP = (double)invCurrentRank / rankSum;
                if (i > 0) //add the previous to the current
                    currentCP += cumulativeProbs[i - 1];
                cumulativeProbs[i] = currentCP; //store it
            }    
        }

        //sub method for computeCP
        //gets the sum of ranks
        private int sumRanks()
        {
            int sum = 0;
            for (int i = 1; i <= nKeep; i++)
                sum += i;
            return sum;
        }

    }
      
    /*
     * Class: GAEngineColour
     * Description: Classing controlling behaviour of collections of chromosomes built on an array of Color objects
     * Author: Brendan Kelly
     * Date: 10/10/2017
     */

    public class GAEngineColour : GAEngine
    {
        private int chromLength;
        private GABeingColour[] chromosomes;
        private Color[] target;
        private int totalGenes;
        private int nMutations;
        private TextBox textBox;
        public bool SaveImages { get; set; }
        public BackgroundWorker worker;
        private Bitmap bufferImage;
        private Graphics bufferGraphics;
        private Graphics canvas;
        private int canvasSize;
        private int drawEvery;
        public bool isDrawing { get; set; }

        //constructors
        public GAEngineColour(Bitmap inBufferImage, Graphics inBufferGraphics, Graphics inCanvas, int inCanvasSize, int inDrawEvery,
                              TextBox inTextBox, Color[] inTarget, int inChromLength, int inPopulation, double inPrKeep, double inPrMutate)
                             : base(inPopulation, inPrKeep, inPrMutate)
        {
            textBox = inTextBox;
            target = inTarget;
            chromLength = inChromLength;
            subInitialise(inBufferImage, inBufferGraphics, inCanvas, inCanvasSize, inDrawEvery);
        }

        public GAEngineColour(Bitmap inBufferImage, Graphics inBufferGraphics, Graphics inCanvas, int inCanvasSize, int inDrawEvery,
                            TextBox inTextBox, Bitmap userImage, int inPopulation, double inPrKeep, double inPrMutate)
                     : base(inPopulation, inPrKeep, inPrMutate)
        {
            textBox = inTextBox;
            loadImageToTarget(userImage);
            chromLength = target.Length;
            subInitialise(inBufferImage, inBufferGraphics, inCanvas, inCanvasSize, inDrawEvery);
        }

        //shared initlialisation between constructors
        private void subInitialise(Bitmap inBufferImage, Graphics inBufferGraphics, Graphics inCanvas, int inCanvasSize, int inDrawEvery)
        {
            //graphics and drawing stuff
            isDrawing = false;
            bufferImage = inBufferImage;
            bufferGraphics = inBufferGraphics;
            canvas = inCanvas;
            canvasSize = inCanvasSize;
            drawEvery = inDrawEvery;

            //background worker set up - the GA runs on this worker
            worker = new BackgroundWorker();
            worker.WorkerSupportsCancellation = true;
            worker.DoWork += workerDoWork;

            SaveImages = false;
            chromosomes = new GABeingColour[population];
            GenerateRandomBeings();
            Array.Sort(chromosomes); //it's done by the runGA but it's good to be safe
            elite = Constants.SINGLE_ELITE; //the number the population who are never mutated - top guns
            totalGenes = chromLength * population; //total gene count across entire population
            nMutations = Convert.ToInt32(totalGenes * prMutate); //number of mutations to perform each generation
            ComputeCP();
        }

        //end constructors


        //generated a random population of coloured chromosomes
        public override void GenerateRandomBeings()
        {
            //make a new being for everyone in the population
            for (int pop = 0; pop < population; pop++)
            {
                //new data for the new being
                Color[] newData = new Color[chromLength];
                //generate new being's colour
                for (int digit = 0; digit < chromLength; digit++)
                {
                    int r = rand.Next(Constants.MAX_COLOUR_VAL + 1);
                    int b = rand.Next(Constants.MAX_COLOUR_VAL + 1);
                    int g = rand.Next(Constants.MAX_COLOUR_VAL + 1);
                    Color curColour = Color.FromArgb(r, b, g);
                    newData[digit] = curColour;
                }
                //make the being and give it data
                GABeingColour newguy = new GABeingColour(newData, target);
                //put the being in chromosomes
                chromosomes[pop] = newguy;
            }
        }

        //mutates random genes in the population
        public override void Mutation()
        {
            for (int i = 0; i < nMutations; i++)
            {
                //select random member of population
                int currentChromosome = rand.Next(elite, population);
                //select random gene
                int currentGene = rand.Next(chromLength);
                //generate mutation
                int mutateR = rand.Next(Constants.MAX_COLOUR_VAL + 1);
                int mutateB = rand.Next(Constants.MAX_COLOUR_VAL + 1);
                int mutateG = rand.Next(Constants.MAX_COLOUR_VAL + 1);
                Color mutateCol = Color.FromArgb(mutateR, mutateB, mutateG);
                //apply
                chromosomes[currentChromosome].Data[currentGene] = mutateCol;
            }
        }

        //recomputes all fitnesses
        public override void RecomputeFitness()
        {
            foreach (GABeingColour guy in chromosomes)
                guy.ComputeFitness();
        }


        //creates children from two parents
        public override void Reproduction()
        {
            for (int i = 0; i < nPairs; i++)
            {
                //define a split point in the parent's data
                int splitPoint = rand.Next(0, chromLength - 1);
                //get the current pair's index
                int p1Index = breedingPairs[i][0];
                int p2Index = breedingPairs[i][1];
                //get the current pair
                GABeingColour p1 = chromosomes[p1Index];
                GABeingColour p2 = chromosomes[p2Index];
                //generate two new children
                Color[] child1Data = new Color[chromLength];
                Color[] child2Data = new Color[chromLength];
                //crossover
                for (int digit = 0; digit < chromLength; digit++)
                {
                    if (digit < splitPoint)
                    {
                        child1Data[digit] = p1.Data[digit];
                        child2Data[digit] = p2.Data[digit];
                    }
                    else
                    {
                        child1Data[digit] = p2.Data[digit];
                        child2Data[digit] = p1.Data[digit];
                    }
                }
                GABeingColour child1 = new GABeingColour(child1Data, target);
                GABeingColour child2 = new GABeingColour(child2Data, target);
                //overwrite low ranking chromosomes
                int nextIndex = nKeep + i * 2;
                if (nextIndex < population - 1) //stop index exceptions when prKeep is over 0.5
                {
                    chromosomes[nextIndex] = child1;
                    chromosomes[nextIndex + 1] = child2;
                }
            }
        }

        //run the genetic algorithm
        public override void RunGA()
        {
            worker.RunWorkerAsync();
        }

        private void workerDoWork(object sender, DoWorkEventArgs e)
        {
            //calculate drawing pixel sixes
            int sideSize = (int)Math.Sqrt(chromLength);
            int blockSize = canvasSize / sideSize;

            int generationCounter = 0;

            while (chromosomes[0].Cost > 0)
            {
                //check to see if we've manually cancelled
                if (worker.CancellationPending)
                {
                    //and cancel if so
                    e.Cancel = true;
                    break;
                }
                else
                {
                    //run the GA process
                    Array.Sort(chromosomes);
                    generationCounter++;
                    //drawing/displaying visual updates
                    if (generationCounter == 1 || generationCounter % drawEvery == 0)
                        handleIO(generationCounter, blockSize, sideSize);

                    //standard GA behaviour
                    Selection();
                    Reproduction();
                    Mutation();
                    RecomputeFitness();
                }
            }
        }

        //Allows cancelling the GA mid-progress from an external object
        public void CancelRunningGA()
        {
            if (worker.WorkerSupportsCancellation == true)
                worker.CancelAsync();
        }

        //handles triggering of visuals and file output
        private void handleIO(int generationCounter, int blockSize, int sideSize)
        {
            int currentCost = chromosomes[0].Cost;
            //draw every so-many times - always do this first one
            String output = "Gen: " + generationCounter + ", Cost: " + currentCost;
            Console.WriteLine(output);
            //draw now
            isDrawing = true;

            DrawChromosome(chromosomes[0], bufferGraphics, canvasSize, blockSize, sideSize);
            canvas.DrawImage(bufferImage, 0, 0);
            //if user has set to save images, then save the image
            if (SaveImages)
                FileManager.SaveImage(bufferImage, generationCounter, currentCost);

            isDrawing = false;
            //show updated info text
            setTextBoxInfo(output);
        }


        //handle threaded textbox manipulation
        delegate void StringArgReturningVoidDelegate(string text);
        private void setTextBoxInfo(string info)
        {
            if (textBox.InvokeRequired)
            {
                StringArgReturningVoidDelegate myDel = new StringArgReturningVoidDelegate(setTextBoxInfo);
                textBox.Invoke(myDel, new object[] { info });
            }
            else
                textBox.Text = info;
        }


        //draws the current chromosome
        private void DrawChromosome(GABeingColour guy, Graphics canvas, int canvasSize, int blockSize, int sideSize)
        {
            int index = 0; //index of the color in the chromosome to be drawn
            for (int y = 0; y < sideSize; y++)
            {
                //generate ypos
                int yPos = y * blockSize;
                for (int x = 0; x < sideSize; x++)
                {
                    //generate xpos
                    int xPos = x * blockSize;
                    //generate rectangle 
                    Rectangle drawRect = new Rectangle(xPos, yPos, blockSize, blockSize);
                    //pull the drawing color from the chromosome
                    Color drawCol = guy.Data[index];
                    index++;
                    //draw
                    Brush fill = new SolidBrush(drawCol);
                    canvas.FillRectangle(fill, drawRect);
                }
            }
        }

        //loads user's image into array for target
        private void loadImageToTarget(Bitmap userImage)
        {
            //get image dimensions
            int size = userImage.Width;
            int nPixels = size * size;
            //re-init target array
            target = new Color[nPixels];
            int index = 0;
            //load colours to array
            for (int row = 0; row < size; row++)
            {
                for (int col = 0; col < size; col++)
                {
                    Color myCol = userImage.GetPixel(col, row);
                    target[index] = myCol;
                    index++;
                }
            }
        }

        //checks if image fits my flippin' parameters
        public bool IsImageOK(Bitmap userImage)
        {
            //if image isn't square
            if (userImage.Width != userImage.Height)
                return false;

            //if image isn't one of the supported sizes
            if (!Constants.ACCEPTED_IMAGE_SIZES.Contains(userImage.Width))
                return false;

            return true; //default return
        }


    }
}
