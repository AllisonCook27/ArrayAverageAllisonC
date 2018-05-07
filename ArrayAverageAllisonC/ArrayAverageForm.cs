/*
 * Created by: Allison Cook
 * Created on: May the 4th, 2018
 * Created for: ICS3U Programming
 * Daily Assignment – Day #34 - Introduction to Arrays
 * This program display 10 randomly generated numbers and calculates their average
*/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArrayAverageAllisonC
{
    public partial class frmArrayAverage : Form
    {
        //constant for array lenght
        const int ARRAY_SIZE = 10;
        //making the array
        int[] arrayOfNumbers = new int[ARRAY_SIZE];

        public frmArrayAverage()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            //declare local variables
            int randomNumber;
            int counter;
            Random randomNumberGenerator = new Random();

            //clearing the list box
            lstNumbers.Items.Clear();

            //creating random numbers and adding them to the array
            for (counter = 0; counter < ARRAY_SIZE; counter++)
            {
                //generate the random number
                randomNumber = randomNumberGenerator.Next(1, ARRAY_SIZE);

                //assign the random number to the array at the index of counter
                arrayOfNumbers[counter] = randomNumber;

                //add the random number to the list box
                this.lstNumbers.Items.Add(randomNumber);

                //refresh the form to show the updated list box
                this.Refresh();
            }
        }

        private void btnCalculateAverage_Click(object sender, EventArgs e)
        {
            //decalre local variables
            double average = 0, sum = 0;
            int counter;

            //calculate the sum of all the numbers in the array
            for (counter = 0; counter < arrayOfNumbers.Length; counter++)
            { 
                //adding the number together
                sum = sum + arrayOfNumbers[counter];
            }

            //calculate the average
            average = sum / arrayOfNumbers.Length;

            //display the average
            this.lblAverage.Text = "The average is " + average;
        }
    }
}
