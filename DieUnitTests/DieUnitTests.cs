using DiceRoller.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FluentAssertions;

namespace DieUnitTests
{
    [TestClass]
    public class DieUnitTests
    {
        private Die d = new Die();

        [TestMethod]
        public void DieClassExists() //checking if the class exists (and is accessable)
        {
            d.Should().NotBeNull();
        }


        [TestMethod]
        public void DieHasAllDefaultValues() //testing that the die has all the predefined values and the side is in range from 1 to 6
        {
            d.GetName().Should().Be("d6"); //calling the getter and comparing it with "d6"
            d.GetNumSides().Should().Be(6);//calling the number of sides getter to check if the value of sides is 6
            d.GetCurrentSide().Should().BeInRange(1, 6); //calling the method get current side to check if the rolled dice range is between 1 to 6
        }


        //[TestMethod]
        //public void DefaultRollSetsSideCorrectly()
        //{
        //    for (int i = 0; i <1000; i++)
        //    {
        //        d.Roll();
        //        d.CurrentSide.Should().BeInRange(1, 6);
        //    }

        //}



        [TestMethod]
        [DataRow(3, "d3")] //passing in the value and checking if die is able to set custom sides, and name
        [DataRow(4, "d4")] //also the range when roll method is called that the range is between 1 to the set number of sides
        [DataRow(8, "d8")]
        [DataRow(10, "d10")]
        [DataRow(12, "d12")]
        [DataRow(20, "d20")]
        public void DieHasCustomSides(int sides, string name)
        {
            Die di = new Die(sides);
            di.GetName().Should().Be(name);
            di.GetNumSides().Should().Be(sides);
            di.GetCurrentSide().Should().BeInRange(1, sides);
        }



        [TestMethod]
        [DataRow(3)]
        [DataRow(4)]
        [DataRow(8)]
        [DataRow(10)]
        [DataRow(12)]
        [DataRow(20)]
        public void RollSetsSideCorrectlyForCustomSides(int sides)
        {
            Die d = new Die(sides);
            for (int i = 0; i < 1000; i++)
            {
                d.Roll();
                d.GetCurrentSide().Should().BeInRange(1, sides);
            }

        }

        /*

        [TestMethod]
        [DataRow(3, 2)]
        [DataRow(5, 10)]
        [DataRow(10, -12)]
        public void SetSideUpSetsValidSide(int sides, int newSide) // yet to commit
        {
            Die d = new Die(sides);
            d.SetSideUp(newSide);
            d.GetCurrentSide().Should().BeInRange(1, sides);
            if (newSide >= 1 && newSide <= sides)
            {
                d.GetCurrentSide().Should().Be(newSide);
            }

        }

*/

        [TestMethod]
        public void GetDefultNameReturnsValue()
        {
            d.GetName().Should().BeOfType<string>();
            d.GetName().Should().Be("d6");
        }

    } }

/*

        [TestMethod]
        public void GetNumSidesReturnsValue()
        {
           
            d.GetNumSides().Should().Be(6);
        }


        [TestMethod]
        public void GetCurrentSideReturnsValue()
        {
            d.GetNumSides().Should().BeInRange(1, 6);
        }

    }
}*/