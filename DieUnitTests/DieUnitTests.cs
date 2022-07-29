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
        public void DieClassExists()
        {
            d.Should().NotBeNull();
        }
        /*
        [TestMethod]
        public void DieHasAllDefaultValues()
        {
            d.Name.Should().Be("d6");
            d.NumSides.Should().Be(6);
            d.CurrentSide.Should().BeInRange(1, 6);
        }
        
        
        [TestMethod]
        public void RollSetsSideCorrectly()
        {
            for (int i = 0; i <1000; i++)
            {
                d.Roll();
                d.CurrentSide.Should().BeInRange(1, 6);
            }
            
        }
        
        [TestMethod]
        public void DieHasCustomSides()
        {
            Die di = new Die(8);
            di.Name.Should().Be("d8");
            di.NumSides.Should().Be(8);
            di.CurrentSide.Should().BeInRange(1, 8);
        }
        */
    }
}

