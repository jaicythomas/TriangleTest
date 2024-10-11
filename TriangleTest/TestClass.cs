using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TriangleSolver;
using NUnit.Framework;

namespace TriangleTest
{
   [TestFixture]
    public class TriangleTest
    {
        //Test Case for checking Equilateral Tiangle
        [Test]
        public void AnalyzeTriangle_Equilateral()
        {
            //Arrange
            int firstside = 5;
            int secondside = 5;
            int thirdside = 5;

            string expected = "Equilateral triangle";
            //Act
            string actual = Triangle.AnalyzeTriangle(firstside, secondside, thirdside);

            //Assert
            Assert.That(actual, Is.EqualTo(expected));
        }

        //Test case 1 for checking Isoceless Triangle
        [Test]
        public void AnalyzeTriangle_Isoceless1()
        {
            //Arrange
            int firstside = 5;
            int secondside = 5;
            int thirdside = 4;

            string expected = "Isosceles triangle";
            //Act
            string actual = Triangle.AnalyzeTriangle(firstside, secondside, thirdside);

            //Assert
            Assert.That(actual, Is.EqualTo(expected));
        }
        //Test case 2 for checking Isoceless Triangle
        [Test]
        public void AnalyzeTriangle_Isoceless2()
        {
            //Arrange
            int firstside = 7;
            int secondside = 7;
            int thirdside = 4;

            string expected = "Isosceles triangle";
            //Act
            string actual = Triangle.AnalyzeTriangle(firstside, secondside, thirdside);

            //Assert
            Assert.That(actual, Is.EqualTo(expected));
        }
        //Test case 3 for checking Isoceless Triangle
        [Test]
        public void AnalyzeTriangle_Isoceless3()
        {
            //Arrange
            int firstside = 5;
            int secondside = 5;
            int thirdside = 8;

            string expected = "Isosceles triangle";
            //Act
            string actual = Triangle.AnalyzeTriangle(firstside, secondside, thirdside);

            //Assert
            Assert.That(actual, Is.EqualTo(expected));
        }
        //Test case 1 for checking Scalene Triangle
        [Test]
        public void AnalyzeTriangle_Scalene1()
        {
            //Arrange
            int firstside = 3;
            int secondside = 4;
            int thirdside = 5;

            string expected = "Scalene triangle";
            //Act
            string actual = Triangle.AnalyzeTriangle(firstside, secondside, thirdside);

            //Assert
            Assert.That(actual, Is.EqualTo(expected));
        }
        //Test case 2 for checking Scalene Triangle
        [Test]
        public void AnalyzeTriangle_Scalene2()
        {
            //Arrange
            int firstside = 8;
            int secondside = 13;
            int thirdside = 15;

            string expected = "Scalene triangle";
            //Act
            string actual = Triangle.AnalyzeTriangle(firstside, secondside, thirdside);

            //Assert
            Assert.That(actual, Is.EqualTo(expected));
        }
        //Test case 3 for checking Scalene Triangle
        [Test]
        public void AnalyzeTriangle_Scalene3()
        {
            //Arrange
            int firstside = 6;
            int secondside = 11;
            int thirdside = 14;

            string expected = "Scalene triangle";
            //Act
            string actual = Triangle.AnalyzeTriangle(firstside, secondside, thirdside);

            //Assert
            Assert.That(actual, Is.EqualTo(expected));
        }
        //Test case 4 for checking Scalene Triangle
        [Test]
        public void AnalyzeTriangle_Scalene4()
        {
            //Arrange
            int firstside = 5;
            int secondside = 7;
            int thirdside = 9;

            string expected = "Scalene triangle";
            //Act
            string actual = Triangle.AnalyzeTriangle(firstside, secondside, thirdside);

            //Assert
            Assert.That(actual, Is.EqualTo(expected));
        }
        //Test case 5 for checking Scalene Triangle
        [Test]
        public void AnalyzeTriangle_Scalene5()
        {
            //Arrange
            int firstside = 7;
            int secondside = 9;
            int thirdside = 11;

            string expected = "Scalene triangle";
            //Act
            string actual = Triangle.AnalyzeTriangle(firstside, secondside, thirdside);

            //Assert
            Assert.That(actual, Is.EqualTo(expected));
        }
        //Test case 1 for checking zero
        [Test]
        public void AnalyzeTriangle_Zero1()
        {
            //Arrange
            int firstside = 0;
            int secondside = 4;
            int thirdside = 5;

            string expected = "Invalid Triangle - a zero has been detected";
            //Act
            string actual = Triangle.AnalyzeTriangle(firstside, secondside, thirdside);

            //Assert
            Assert.That(actual, Is.EqualTo(expected));
        }
        //Test case 2 for checking zero
        [Test]
        public void AnalyzeTriangle_Zero2()
        {
            //Arrange
            int firstside = 3;
            int secondside = 0;
            int thirdside = 5;

            string expected = "Invalid Triangle - a zero has been detected";
            //Act
            string actual = Triangle.AnalyzeTriangle(firstside, secondside, thirdside);

            //Assert
            Assert.That(actual, Is.EqualTo(expected));
        }
        //Test case 3 for checking zero
        [Test]
        public void AnalyzeTriangle_Zero3()
        {
            //Arrange
            int firstside = 3;
            int secondside = 0;
            int thirdside = 0;

            string expected = "Invalid Triangle - a zero has been detected";
            //Act
            string actual = Triangle.AnalyzeTriangle(firstside, secondside, thirdside);

            //Assert
            Assert.That(actual, Is.EqualTo(expected));
        }
        //Test case 1 for checking invalid
        [Test]
        public void AnalyzeTriangle_Invalid1()
        {
            //Arrange
            int firstside = 3;
            int secondside = 4;
            int thirdside = 8;

            string expected = "INVALID!!";
            //Act
            string actual = Triangle.AnalyzeTriangle(firstside, secondside, thirdside);

            //Assert
            Assert.That(actual, Is.EqualTo(expected));
        }
        //Test case 2 for checking invalid
        [Test]
        public void AnalyzeTriangle_Invalid2()
        {
            //Arrange
            int firstside = 32;
            int secondside = 15;
            int thirdside = 13;

            string expected = "INVALID!!";
            //Act
            string actual = Triangle.AnalyzeTriangle(firstside, secondside, thirdside);

            //Assert
            Assert.That(actual, Is.EqualTo(expected));
        }
        //Test case 3 for checking invalid
        [Test]
        public void AnalyzeTriangle_Invalid3()
        {
            //Arrange
            int firstside = 3;
            int secondside = 9;
            int thirdside = 12;

            string expected = "INVALID!!";
            //Act
            string actual = Triangle.AnalyzeTriangle(firstside, secondside, thirdside);

            //Assert
            Assert.That(actual, Is.EqualTo(expected));
        }
    }
}
