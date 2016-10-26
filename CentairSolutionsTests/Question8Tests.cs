using System;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CentairSolutions;

namespace CentairSolutionsTests
{
    [TestClass]
    public class Question8DiamondTests
    {


        [TestMethod]
        public void FilledDiamondTest5()
        {
            var myWriter = new StringWriter();
            var diamondeer = new Diamondeer(myWriter);

            string expected = @"
    *    
   * *   
  * * *  
 * * * * 
* * * * *
 * * * * 
  * * *  
   * *   
    *    
";
            diamondeer.PrintDiamond(5, true);
            Assert.AreEqual(expected,
                myWriter.ToString());
        }

        [TestMethod]
        public void EmptyDiamondTest()
        {
            var myWriter = new StringWriter();
            var diamondeer = new Diamondeer(myWriter);

            string expected = @"
    *    
   * *   
  *   *  
 *     * 
*       *
 *     * 
  *   *  
   * *   
    *    
";
            diamondeer.PrintDiamond(5, false);
            Assert.AreEqual(expected,
                myWriter.ToString());
        }


        [TestMethod]
        public void FilledDiamondTest4()
        {
            var myWriter = new StringWriter();
            var diamondeer = new Diamondeer(myWriter);

            string expected = @"
   *   
  * *  
 * * * 
* * * *
 * * * 
  * *  
   *   
";
            diamondeer.PrintDiamond(4, true);
            Assert.AreEqual(expected,
                myWriter.ToString());
        }


        [TestMethod]
        public void FilledDiamondTest2()
        {
            var myWriter = new StringWriter();
            var diamondeer = new Diamondeer(myWriter);

            string expected = @"
 * 
* *
 * 
";
            diamondeer.PrintDiamond(2, true);
            Assert.AreEqual(expected,
                myWriter.ToString());
        }



        [TestMethod]
        public void FilledDiamondTest1()
        {
            var myWriter = new StringWriter();
            var diamondeer = new Diamondeer(myWriter);

            string expected = @"
*
";
            diamondeer.PrintDiamond(1, true);
            Assert.AreEqual(expected,
                myWriter.ToString());
        }

        [TestMethod]
        public void FilledDiamondTest0()
        {
            var myWriter = new StringWriter();
            var diamondeer = new Diamondeer(myWriter);

            string expected = @"
";
            diamondeer.PrintDiamond(0, true);
            Assert.AreEqual(expected,
                myWriter.ToString());
        }

        [TestMethod]
        public void EmptyDiamondTest4()
        {
            var myWriter = new StringWriter();
            var diamondeer = new Diamondeer(myWriter);

            string expected = @"
   *   
  * *  
 *   * 
*     *
 *   * 
  * *  
   *   
";
            diamondeer.PrintDiamond(4, false);
            Assert.AreEqual(expected,
                myWriter.ToString());
        }

        [TestMethod]
        public void EmptyDiamondTest2()
        {
            var myWriter = new StringWriter();
            var diamondeer = new Diamondeer(myWriter);

            string expected = @"
 * 
* *
 * 
";
            diamondeer.PrintDiamond(2, false);
            Assert.AreEqual(expected,
                myWriter.ToString());
        }



        [TestMethod]
        public void EmptyDiamondTest1()
        {
            var myWriter = new StringWriter();
            var diamondeer = new Diamondeer(myWriter);

            string expected = @"
*
";
            diamondeer.PrintDiamond(1, false);
            Assert.AreEqual(expected,
                myWriter.ToString());
        }

        [TestMethod]
        public void EmptyDiamondTest0()
        {
            var myWriter = new StringWriter();
            var diamondeer = new Diamondeer(myWriter);

            string expected = @"
";
            diamondeer.PrintDiamond(0, false);
            Assert.AreEqual(expected,
                myWriter.ToString());
        }
    }
}
