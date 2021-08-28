using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ExercicePipelineCICD;
namespace TestCalcul
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Addition_Bonne()
        {
            double result = Calcul.Addition(1.5, 2.5);

            Assert.AreEqual(4, result);
        }

        [TestMethod]
        public void Addition_Fausse()
        {
            double result = Calcul.Addition(1, 2);

            Assert.AreNotEqual(6, result);
        }

        [TestMethod]
        public void Soustraction_Bonne()
        {
            double result = Calcul.Soustraction(1.5, 2.5);

            Assert.AreEqual(-1, result);
        }

        [TestMethod]
        public void Soustraction_Fausse()
        {
            double result = Calcul.Soustraction(1, 2);

            Assert.AreNotEqual(6, result);
        }

        [TestMethod]
        public void Division_Bonne()
        {
            double result = Calcul.Division(2, 1);

            Assert.AreEqual(2, result); 
        }

        [TestMethod]
        public void Division_Fausse()
        {
            double result = Calcul.Division(1, 2);

            Assert.AreNotEqual(6, result);
        }
        [TestMethod]
        public void Multiplication_Bonne()
        {
            double result = Calcul.Multiplication(5, 5);

            Assert.AreEqual(25, result);
        }

        [TestMethod]
        public void Multiplication_Fausse()
        {
            double result = Calcul.Multiplication(1, 2);

            Assert.AreNotEqual(6, result);
        }
    }
}
