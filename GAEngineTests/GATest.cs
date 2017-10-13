using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using GA_Image;

namespace GAEngineTests
{
    /*
   * Class: StubGAEngine
   * Description: Basic implementation of GAEngine for testing base methods
   * Author: Brendan Kelly
   * Date: 14/10/2017
   */
    public class StubGAEngine : GAEngine
    {
        public StubGAEngine(int inPopulation, double inPrKeep, double inPrMutate) : base(inPopulation, inPrKeep, inPrMutate)
        {
        }

        public override void GenerateRandomBeings()
        {
            throw new NotImplementedException();
        }

        public override void Mutation()
        {
            throw new NotImplementedException();
        }

        public override void RecomputeFitness()
        {
            throw new NotImplementedException();
        }

        public override void Reproduction()
        {
            throw new NotImplementedException();
        }

        public override void RunGA()
        {
            throw new NotImplementedException();
        }
    }



    /*
    *
    * Class: GAEngineTests
    * Description: Tests for base genetic algorithm methods
    * Author: Brendan Kelly
    * Date: 27/9/2017
    */

    [TestClass]
    public class GATest
    {
        [TestMethod]
        public void TestRankSumComputesAccurateSum()
        {
            StubGAEngine testEngine = new StubGAEngine(16, 0.5, 0.01);
            testEngine.ComputeCP();
            testEngine.
        }
    }
}
