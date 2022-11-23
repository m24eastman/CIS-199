// Grading ID: R6979
//Program 1
//September 22nd, 2020
// CIS 199-01

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Program_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }


        //the following actions are taken when the calculate button is pressed
        private void calculateButton_Click(object sender, EventArgs e)
        {

            const int first_room_labor = 50; // first room labor price is 50 dollars
            const int feet_to_yards = 9; // to calculate feet to yards, you must divide by 9
            const double extra_hardwood = 0.1; // it costs an extra 10% in our estimates for waste
            const double price_of_underlayment = 4.25; // we charge the client $4.25 per square yard of underlayment
            const double labor_cost = 3.25; // we charge an additional $3.25 per square yard for labor

            double width; // sets variable for width of room
            double length; // sets variable for length of room
            double sq_yards; // sets variable for amount of square yards
            double hw_cost; // sets variable for hardwood cost

            width = double.Parse(widthBox.Text); // converts to double
            length = double.Parse(lengthBox.Text); // converts to double
            sq_yards = double.Parse(priceBox.Text); // converts to double
            hw_cost = double.Parse(priceBox.Text); // hw_cost is double

            //sets new variables needed
            double area = 0;
            double ul_cost = 0;
            double first_room_cost = 0;
            double labor_cost_2 = 0;
            double total_cost = 0;

            //formula to calculate the square yards
            area = width * length / feet_to_yards;
            sqyardsOutput.Text = area.ToString("0.0");

            //formula to calculate hardwood cost
            hw_cost = (area * hw_cost * extra_hardwood) + (area * hw_cost);
            hardwoodcostOutput.Text = hw_cost.ToString("C");

            // if underlayment is not needed, nothing will happen
            if (underlaymentBox.Text == "0") { }
            //if underlayment is needed, this is formula
            if (underlaymentBox.Text == "1") { ul_cost = price_of_underlayment * area; } 
            underlaycostOutput.Text = ul_cost.ToString("C");

            //if it is not first room, nothing will happen
            if (firstroomBox.Text == "0") { }
            //if it is the first room, this is the formula
            if (firstroomBox.Text == "1") { first_room_cost = first_room_labor; }

            //formula to calculate labor cost
            labor_cost_2 = (area * labor_cost) + first_room_cost;
            laborcostOutput.Text = labor_cost_2.ToString("C");

            //formula to calculate the total cost
            total_cost = labor_cost_2 + hw_cost + ul_cost;
            totalcostOutput.Text = total_cost.ToString("C");


        }
    }
}


