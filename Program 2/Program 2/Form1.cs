// R6979
//Program 2
// October 15th, 2020
// CIS 199-01
//This program takes input from the user for a packages weight, the distance it travels, and how many delivery days
// it uses this information to display the different prices of three different companies
// and displays which company is the cheapest to use for the user.
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Program_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            //variables


            double weight; // variable for weight may be a decimal
            double distance; // variable for distance in miles may be a decimal
            int days; // variable for days to deliver

            if (double.TryParse(weightBox.Text, out weight))
            {
                if (double.TryParse(distanceBox.Text, out distance))
                {
                    if (int.TryParse(daysBox.Text, out days))
                    {

                        //company A equations are below
                        if (days > 0 && days < 2)
                        {
                            companyAOutput.Text = $"{(weight * 1) + (distance * 0.02) + 20}";
                        }
                        else if (days > 1 && days < 3)
                        {
                            companyAOutput.Text = $"{(weight * 1) + (distance * 0.02) + 17}";
                        }
                        else if (days > 2 && days < 4)
                        {
                            companyAOutput.Text = $"{(weight * 1) + (distance * 0.02) + 15}";
                        }
                        else if (days > 3 && days < 8)
                        {
                            companyAOutput.Text = $"{(weight * 1) + (distance * 0.02) + 10}";
                        }
                        else if (days > 7)
                        {
                            companyAOutput.Text = $"{(weight * 1) + (distance * 0.02) + 7}";
                        }


                        //company B calculations are below
                        if (weight < 10 && days > 0 && days < 5)
                        {
                            companyBOutput.Text = $"{(3.0) + (distance * 0.1) + (10)}";
                        }
                        else if (weight >= 10 && weight < 50 && days > 0 & days < 5)
                        {
                            companyBOutput.Text = $"{(5.0) + (distance * 0.1) + (10)}";
                        }
                        else if (weight >= 50 && weight < 100 && days > 0 && days < 5)
                        {
                            companyBOutput.Text = $"{(10) + (distance * 0.1) + (10)}";
                        }
                        else if (weight >= 100 && weight < 200 && days > 0 && days < 5)
                        {
                            companyBOutput.Text = $"{(20) + (distance * 0.1) + (10)}";
                        }
                        else if (weight >= 200 && days > 0 && days < 5)
                        {
                            companyBOutput.Text = $"{(weight * 0.15) + (distance * 0.1) + (10)}";
                        }
                        else if (weight < 10 && days > 4)
                        {
                            companyBOutput.Text = $"{(3.0) + (distance * 0.1) + (7.0)}";
                        }
                        else if (weight >= 10 && weight < 50 && days > 4)
                        {
                            companyBOutput.Text = $"{(5.0) + (distance * 0.1) + (7.0)}";
                        }
                        else if (weight >= 50 && weight < 100 && days > 4)
                        {
                            companyBOutput.Text = $"{(10.0) + (distance * 0.1) + (7.0)}";
                        }
                        else if (weight >= 100 && weight < 200 && days > 4)
                        {
                            companyBOutput.Text = $"{(20.0) + (distance * 0.1) + (7.0)}";
                        }
                        else if (weight >= 200 && days > 4)
                        {
                            companyBOutput.Text = $"{(weight * 0.15) + (distance * 0.1) + (7.0)}";
                        }


                        //company C calculations are below
                        double daysC = 20.0;// sets variable for a constance delivery day price

                        if (distance >= 1000)
                        {
                            companyCOutput.Text = $"{(40.0) + (weight * 0.25) + (daysC)}";
                        }
                        else if (distance >= 750 && distance < 1000)
                        {
                            companyCOutput.Text = $"{(35.0) + (weight * 0.25) + (daysC)}";
                        }
                        else if (distance >= 500 && distance < 750)
                        {
                            companyCOutput.Text = $"{(25.0) + (weight * 0.25) + (daysC)}";
                        }
                        else if (distance >= 200 && distance < 500)
                        {
                            companyCOutput.Text = $"{(15.0) + (weight * 0.25) + (daysC)}";
                        }
                        else if (distance >= 0 && distance < 200)
                        {
                            companyCOutput.Text = $"{(10) + (weight * 0.25) + (daysC)}";
                        }



                        string lowestCostCompany; // string variable for final result
                        double ComA; // variable to compare cost companies
                        double ComB; // variable to compare cost companies
                        double ComC; // variable to compare cost companies

                        ComA = double.Parse(companyAOutput.Text);
                        ComB = double.Parse(companyBOutput.Text);
                        ComC = double.Parse(companyCOutput.Text);

                        //if company A has lowest cost, it will display in the results output label
                        if (ComA < ComB && ComA < ComC)
                        {
                            lowestCostCompany = "A";
                        }
                        // if company B has lowest cost, it will display in the results output label
                        else if (ComB < ComA && ComB < ComC)
                        {
                            lowestCostCompany = "B";
                        }
                        // if company C has lowest cost, it will display in the results output label
                        else
                        {
                            lowestCostCompany = "C";
                        }

                        // In the end, display the string in the label
                        resultsOutput.Text = $"The lowest cost company is : {lowestCostCompany}";

                    }
                    else
                    {
                        MessageBox.Show("Invalid Delivery Days");
                    }
                }
                else
                {
                    MessageBox.Show("Invalid Distance");
                }
            }
            else
            {
                MessageBox.Show("Invalid Weight");
            }
        }
    }
}

