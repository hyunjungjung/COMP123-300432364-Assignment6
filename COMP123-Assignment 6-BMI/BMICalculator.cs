﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/**
 * Author : Joanne Jung
 * Student # : 300432364
 * Date : August, 4th, 2016
 * Description : Main program for BMI Calculator App
 * Version : 0.0.2 : Added UI controls to the app with input restriction
 */
namespace COMP123_Assignment_6_BMI
{
   /**
   * <summary>
   * This class is the "driver" class for our program
   * </summary>
   * 
   * @class Program
   */
    public partial class BMICalculator : Form
    {
        public BMICalculator()
        {
            InitializeComponent();
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        /**
         * <summary>
         * This eventhandler clears the content of the form when clicked
         * </summary>
         * 
         * @method ClearButton_Click
         * @param {object} sender
         * @param {EventArgs} e
         */
        private void ClearButton_Click(object sender, EventArgs e)
        {
            HeightTextBox.Text = "";
            WeightTextBox.Text = "";
            BMIResultBox.Text = "";
            BMIResultBox.BackColor = Color.Bisque;
            BMIScaleBox.Text = "";
            BMIScaleBox.BackColor = Color.Bisque;
        }

        /**
         * <summary>
         * This eventhandler calculate the BMI and display on the textboxes
         * </summary>
         * 
         * @method CalculateButton_Click
         * @param {object} sender
         * @param {EventArgs} e
         */
        private void CalculateButton_Click(object sender, EventArgs e)
        {
            // local variables
            double height = 0, weight = 0, BMI;

            try {
                height = Convert.ToDouble(HeightTextBox.Text);
                weight = Convert.ToDouble(WeightTextBox.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Fill out the forms");
            }
            
            if (HeightTextBox.Text == "" || WeightTextBox.Text == "") 
            {  
                HeightTextBox.Focus();
                HeightTextBox.SelectAll();
                WeightTextBox.Focus();
                WeightTextBox.SelectAll();
            }
            else if (height < 0 || weight < 0)
            {
                MessageBox.Show("Please provide positive values");
            }
            else if (height > 0 && weight > 0)
            {
                // in case the input is in imperial 
                if (ImperialButton.Checked == true)
                {
                    // calculate BMI in imperial
                    BMI = (weight * 703) / (height * height);
                    BMIResultBox.Text = string.Format("{0:f1}",BMI);
                    BMIResultBox.BackColor = Color.LightSalmon;
                    BMIScaleBox.BackColor = Color.LightSalmon;

                    // determine the BMI 
                    if (BMI < 18.5)
                    {
                        this.BMIScaleBox.Text = ("Underweight");
                        
                    }
                    else if (BMI >= 18.5 && BMI <= 24.9)
                    {
                        this.BMIScaleBox.Text = ("Normal");
                    }
                    else if (BMI >= 25 && BMI <= 29.9)
                    {
                        this.BMIScaleBox.Text = ("Overweight");
                    }
                    else if (BMI >= 30)
                    {
                        this.BMIScaleBox.Text = ("Obese");
                    }
                }
                // in case the input is in metric units
                else if (MetricUnitsButton.Checked == true)
                {
                    BMI = weight /((height * height)/10000);
                    BMIResultBox.Text = string.Format("{0:f1}", BMI);
                    BMIResultBox.BackColor = Color.LightSalmon;
                    BMIScaleBox.BackColor = Color.LightSalmon;
                    BMIProgressBar.Maximum = 100;

                    // determine the BMI
                    if (BMI < 18.5)
                    {
                        this.BMIScaleBox.Text = ("Underweight");

                    }
                    else if (BMI >= 18.5 && BMI <= 24.9)
                    {
                        this.BMIScaleBox.Text = ("Normal");
                    }
                    else if (BMI >= 25 && BMI <= 29.9)
                    {
                        this.BMIScaleBox.Text = ("Overweight");
                    }
                    else if (BMI >= 30)
                    {
                        this.BMIScaleBox.Text = ("Obese");
                    }
                }
            }
        }

        private void BMIScaleBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void HeightTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8 && ch !=46)
            {
                e.Handled = true;
            }
        }

        private void WeightTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }
    }
}
