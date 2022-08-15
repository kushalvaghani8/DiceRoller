using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DiceRoller.Models;
using Xamarin.Forms;

namespace DiceRoller
{
    public partial class MainPage : ContentPage
    {

        int val = 0;

        public MainPage()
        {
            InitializeComponent();
        
        }

        void RadioButton_Changed(object sender, CheckedChangedEventArgs args)
        {
            RadioButton button = sender as RadioButton;
            String SelectedValue = button.Value.ToString();
            val = int.Parse(SelectedValue);
        }

        public void DisplyOne(object sender, EventArgs args)
        {
            Result2.IsVisible = false;
            Die die = new Die(val);
            Result1.Text = die.GetCurrentSide().ToString();
        }


        public void DisplyTwo(object sender, EventArgs args)
        {
            Result2.IsVisible = true;
            Die die = new Die(val);
            Die d = new Die(val);
            Result1.Text = die.GetCurrentSide().ToString();
            Result2.Text = d.GetCurrentSide().ToString();
        }

    }
}

