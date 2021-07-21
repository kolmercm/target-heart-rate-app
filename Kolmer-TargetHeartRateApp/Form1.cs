using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//Your name: Conor M. Kolmer
//Description: Gives user their prompted THR Target Heart rate based on Age and type of Activity completed.
//Date Created: 9/05/2020


namespace Kolmer_TargetHeartRateApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            ageInput.Text = String.Empty;
            activityInput.SelectedIndex = 0;
            outputView.Items.Clear();

        }

        private void displayTHRButton_Click(object sender, EventArgs e)
        {
            if (ageInput.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Please enter a value for age");
                return;

            }
            int i;

            int.TryParse(this.ageInput.Text, out i);

            if (!(i > -1) || !(i < 101))

            {
                MessageBox.Show("Please enter an age between 1 and 100.");
                return;

            }
            //Age
            outputView.Items.Add(ageInput.Text);

            // Start Target Heart Calcualtion 


            //Calculate Maximum Heart Rate from ageInput
            int ageValue = Int32.Parse(ageInput.Text);
            int MHR = 220 - ageValue;

            //Calculate bpm for each selected Activity

            //Figure out what activity corresponds to what level of intensity; moderate or vigorous based on user input
            string activityValue = activityInput.Text;
            Debug.WriteLine(activityValue);


            //Given Activity type and its intensity calculate the low and high end THR ranges
            double lowendPercentage;
            double highendPercentage;

            if (activityValue.Contains("Moderate"))
            {
                Debug.WriteLine("Moderate Activity");
                lowendPercentage = .50;
                highendPercentage = .70;
            }


            else if (activityValue.Contains("Vigorous"))
            {
                Debug.WriteLine("Vigorous Activity");
                lowendPercentage = .70;
                highendPercentage = .85;
            }
            else
            {
                //could cause error 
                lowendPercentage = 0;
                highendPercentage = 0;
            }

            //Calculate low end BPM (is MHR * low end %)
            double lowendBPM = MHR * lowendPercentage;
            double highendBPM = MHR * highendPercentage;

            //Round the high and low end BPM
            Debug.WriteLine(lowendBPM);
            Debug.WriteLine(highendBPM);
            double roundedlowendBPM = Math.Round(lowendBPM);
            double roundedhighendBPM = Math.Round(highendBPM);

            // Outputs results to user
            outputView.Items[0].SubItems.Add(MHR + " (bpm) ");
            outputView.Items[0].SubItems.Add(activityInput.Text);
            outputView.Items[0].SubItems.Add( roundedlowendBPM + "to" + roundedhighendBPM + "(beats per minute)");

            //Target Heart Rate Value added to outputView


        }

    }
}
