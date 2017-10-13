using System;
using System.Drawing;


namespace GA_Image
{
 /*
 *
 * Class: GABeing
 * Description: Base class for Genetic Algorithm classes that manage chromosome data
 * Author: Brendan Kelly
 * Date: 27/9/2017
 */

    public abstract class GABeing : IComparable
    {
        public int Cost {get; set;}
        public abstract int CompareTo(object obj);

        public abstract void ComputeFitness();
    }


    /*
    * Class: GABeingColour
    * Description: Child GABeing that manages beings with chromosomes comprised of Colour objects
    * Author: Brendan Kelly
    * Date: 29/9/2017
    */
    public class GABeingColour : GABeing
    {
        public Color[] Data { get; set; }
        private Color[] target;
        private int nData;

        public GABeingColour(Color[] inData, Color[] inTarget)
        {
            Data = inData;
            nData = Data.Length;
            target = inTarget;
            ComputeFitness();
        }
        public override int CompareTo(object obj)
        {
            //check type and cast if type is correct
            GABeingColour otherGuy;
            if (obj is GABeingColour)
                otherGuy = (GABeingColour)obj;
            else
                throw new ArgumentException("Comparing object is not type GABeingColour. Can not continue.");

            //if this object's cost is less than the other guy's this guy goes first
            if (Cost < otherGuy.Cost)
                return -1;
            else
                return 1; //otherwise it doesn't matter
        }

        public override void ComputeFitness()
        {
            Cost = 0; //reset
            for (int i = 0; i < nData; i++)
            {
                //fet corresponding colours
                Color currentCol = Data[i];
                Color targetCol = target[i]; 
                //calculate differences
                int diffR = Math.Abs(currentCol.R - targetCol.R);
                int diffB = Math.Abs(currentCol.B - targetCol.B);
                int diffG = Math.Abs(currentCol.G - targetCol.G);
                int diffs = diffR + diffB + diffG;
                //total
                Cost += diffs;
            }
        }
    }


}
