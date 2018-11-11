// B2517
// Program1
// 9-27-2016
// CIS 199-75
// This program is a quote system for a painting company. It takes the square feet of the wall, desired coats, and the price of paint and calculates the quote for total square feet, gallons of paint required, hours required for labor, the cost of paint, labor cost, and the total price amount of the job.

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Program1
{
    public partial class Program1 : Form
    {
        public Program1()
        {
            InitializeComponent();
        }      
           // This button will calculate the quote pricing and amounts for the painting job when pressed.
        private void calculateTotalsButton_Click(object sender, EventArgs e)
        {
            //Declare variables to use in calculations.
        double gallonsRequired; //Gallons of paint required
        double hoursRequired; //Hours of labor required
        double costOfPaint; //Cost of paint for the job
        double laborCost; // Cost of labor
        double totalSqFt; //Total square feet to be painted
        double wallSpace; // Wall space
        double coatsDesired; //Coats of paint desired
        double paintPrice; // Price of paint
        double totalAmount; // Total amount for job
        double gallonsToBuy; // Declare variable to use for the math ceiling.
            
            wallSpace = double.Parse(wallSpaceTextBox.Text); //This allows the entered wall space to be used for calculation.
            coatsDesired = double.Parse(coatsDesiredTextBox.Text); //This allows the entered coats desired to be used for calculation.
            paintPrice = double.Parse(priceOfPaintTextBox.Text); //This allows the entered paint price to be used for calculation.

            const double WALLSQFTRATE = 275; //Declare a constant rate for the wall square feet to be used to find gallons required.
            const double HOURSPERGAL = 8; //Declare a constant for the hours per gallon to be used to calculate hours of labor.
            const double WAGEPERHOUR = 12.50; //Declare a constant for the wage per hour to be used to calculate the labor cost.

            totalSqFt = wallSpace * coatsDesired; //Expression to calculate the total square feet.

            gallonsRequired = totalSqFt / WALLSQFTRATE; //Expression to calculate the gallons required.
            gallonsToBuy = Math.Ceiling(gallonsRequired); //This is used to round the gallons required up.
        
            costOfPaint = gallonsToBuy * paintPrice; //Expression to calculate the cost of paint.

            hoursRequired = gallonsRequired * HOURSPERGAL; //Expression to calculate hours required.

            laborCost = hoursRequired * WAGEPERHOUR; //Expression to calculate the labor cost.

            totalAmount = laborCost + costOfPaint; //Expression to calculate the total cost of the job.


            totalSqFtOutputLabel.Text = totalSqFt.ToString(); //This allows the totalSqFt string to show in the totalSqFtOutputLabel.
            hoursRequiredOutputLabel.Text = hoursRequired.ToString("n1"); //This allows the hoursRequired string to show in the hoursRequiredOutputLabel.
            gallonsRequiredOutputLabel.Text = gallonsRequired.ToString("n0"); //This allows the gallonsRequired string to show in the gallonsRequiredOutputLabel.
            costOfPaintOutputLabel.Text = costOfPaint.ToString("c"); //This allows the costOfPaint string to show in the costOfPaintOutputLabel as a currency amount.
            laborCostOutputLabel.Text = laborCost.ToString("c"); //This allows the laborCost string to show in the laborCostOutputLabel as a currency amount.
            totalAmountOutputLabel.Text = totalAmount.ToString("c"); //This allows the totalAmount string to show in the totalAmountOutputLabel as a currency amount.


        }
    }
}
