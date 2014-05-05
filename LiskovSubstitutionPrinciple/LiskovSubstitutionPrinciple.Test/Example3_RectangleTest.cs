using System;
using LiskovSubstitutionPrinciple.Examlpe3;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LiskovSubstitutionPrinciple.Test
{
    /// <summary>
    /// this test fails.. why? because we changed the behaviour of the rectangle class without it knowing it. this is another, although subtle violation of the
    /// the LSP. 
    /// 
    /// this test assumes that we it will always have to do with a rectangle. So where does the fault lie? Might the fault be in the test or is it in the square class?
    /// 
    /// I don't think the fault lies anywhere.. yes you can ensure the rectangle stays true to itself by insuring that its properties can never be the same value
    /// but then mathamatically, this no longer makes sense because a rectangle CAN be a square...
    /// 
    /// again, composition over inheritance. For the many solutions here, the best one would be to treat rectangle and square as two seperate entities that inherit
    /// from an interface called Shape, for ex.
    /// </summary>
    [TestClass]
    public class Example3_RectangleTest
    {
        [TestMethod]
        public void TestRectangle()
        {
            Rectangle rect = RectangleTestFunctions.GetNewRectangle();

            rect.SetWidth(4);
            rect.SetHeight(5);

            Assert.AreEqual(rect.GetArea(), 20);
        }
    }
}
