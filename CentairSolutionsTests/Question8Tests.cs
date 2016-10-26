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
        public void FilledDiamondTest()
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
    }
}
