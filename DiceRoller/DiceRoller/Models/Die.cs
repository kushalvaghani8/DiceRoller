using System;
namespace DiceRoller.Models
{
    public class Die
    {
        
        private string Name { get; set; }

        private int NumSides { get; set; }

        private int CurrentSide { get; set; }

        public Die() // 0 arguments
        {
            Name = "d6";
            NumSides = 6;
            Roll();
        }

        public Die(int numSides) // 1 arugment passing in number of sides
        {
            Name = "d" + numSides;
            NumSides = numSides;
            Roll();
        }

        public void SetSideUp(int newSideUp) //setting up the current side to newSide
        {
            if(newSideUp >=1 && newSideUp <= NumSides)
            this.CurrentSide = newSideUp;
        }

        public void Roll() // roll method, generating random number 
        {
            Random r = new Random();
            CurrentSide = r.Next(NumSides) + 1;
        }

        public String GetName() { return Name; } //getter for Name, after changing public method to private 

        public int GetNumSides() { return NumSides; } //getter for Sides, after changing public method to private

        public int GetCurrentSide() { return CurrentSide; } //getter for CurrentSide, after changing public method to private
    }
}

