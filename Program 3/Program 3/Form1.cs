// Grading ID: R6979
// Program 3
// October 5th, 2020
// CIS 199-01
//This program will ask the user for a state, product number, and amount of product
// it will output the discount, tax, total cost, and initial cost to the user
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Program_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // arrays with descriptions
        double[] discounts = { 0.06, 0.0717, 0.07, 0.0874 }; // sets an array for the discount rates for each state
        double[] cost = { 7.87, 9.51, 10.73, 9.99, 11.99, 5.00, 4.58 }; // sets an array for the cost of each product

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            // sets variables with descriptions
            int PRODUCT; // sets an integer for the product number
            int QUANTITY; // sets an integer for the quantity of product purchased
            double INITIALCOST; // sets double for the initial cost label output box
            double DISCOUNTEDCOST = 0; // sets double for the discounted cost label output box
            double TAX; // sets double for the tax amount label output box
            double TOTALCOST; // sets double for the total cost label output box

            Int32.TryParse(productBox.Text, out PRODUCT);
            if (PRODUCT >= 1001 && PRODUCT <= 1007)
            {
                //calculating discount cost
                Int32.TryParse(quantityBox.Text, out QUANTITY);
                INITIALCOST = cost[(PRODUCT % 10) - 1] * QUANTITY;
                if (QUANTITY <= 4)
                    DISCOUNTEDCOST = INITIALCOST;
                else if (QUANTITY >= 5 && QUANTITY <= 9)
                    DISCOUNTEDCOST = INITIALCOST - INITIALCOST * 0.05;
                else if (QUANTITY >= 10 && QUANTITY <= 19)
                    DISCOUNTEDCOST = INITIALCOST - INITIALCOST * 0.1;
                else if (QUANTITY >= 20)
                    DISCOUNTEDCOST = INITIALCOST - INITIALCOST * 0.15;

                //tax formula
                TAX = DISCOUNTEDCOST * discounts[stateComboBox.SelectedIndex];

                //total cost formula
                TOTALCOST = DISCOUNTEDCOST + TAX;

                //assigns variables to output boxes
                initialcostOutput.Text = INITIALCOST.ToString("C2");
                discountedcostOutput.Text = DISCOUNTEDCOST.ToString("C2");
                taxOutput.Text = TAX.ToString("C2");
                totalpriceOutput.Text = TOTALCOST.ToString("C2");
            }
            else
            {
                MessageBox.Show("Invalid Product Number");
            }

        }
    }
}
