//B2517
//Program 2
//October 16 2016
//CIS 199-75
//This program will show the earliest registration day and time for the last name and amount of credit hours entered. 

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Program2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string registrationTime; //Stores registration time
        string registrationDay; //Stores registration day



        private void enterInfoButton_Click(object sender, EventArgs e) //When clicked the program will show the earliest day and time for registration according to the entered information.
        {
            string errorMessage = ("Please enter a correct value"); //Stores the error message to be used in the output label
            const string EARLYMORNINGREG = "8:30 AM"; //Earliest time
            const string MIDMORNINGREG = "10:00 AM"; //Second earliest time
            const string LATEMORNINGREG = "11:30 AM"; //Third earliest time
            const string MIDAFTERNOONREG = "2:00 PM"; //Fourth time
            const string LATEAFTERNOONREG = "4:00 PM"; //Last time
            const string seniorsDay = "Friday, November 4"; //Senior registration day
            const string juniorsDay = "Monday, November 7"; //Junior registration day
            const string sophomoreDay1 = "Wednesday, November 9"; // First day for sophomores to register
            const string sophomoreDay2 = "Thursday, November 10"; //Second day for sophomores to register
            const string freshmanDay1 = "Friday, November 11"; //First day for freshman to register
            const string freshmanDay2 = "Monday, November 14"; //Second day for freshman to register

            double creditHours; //Credit hours
            bool seniorReg; //Credit hours to be a senior is true
            bool juniorReg; //Credit hours to be a junior is true
            bool sophomoreReg; //Credit hours to be a sophomore is true
            bool freshmanReg; //Credit hours to be a freshman is true

            if (!double.TryParse(creditHoursTextBox.Text, out creditHours) || creditHours < 0) //If statement for if the credit hours are less than zero. 
            {
                regDayTimeOutputLabel.Text = (errorMessage); //Error message if credit hours is an incorrect value or negative.
                return;
            }

            seniorReg = (creditHours > 90); //Senior status
            juniorReg = (creditHours > 60); //Junior status
            sophomoreReg = (creditHours > 30); //Sophomore status
            freshmanReg = (creditHours <= 30); //Freshman status

            string lastName = lastNameTextBox.Text; // Stores what is entered into the last name text box into the string lastname.
            char lastNameChar; //Declares the lastnamechar as a char.
            lastNameChar = lastName[0]; //Stores the lastname value of the first letter into lastnamechar.

            if (lastNameTextBox.Text.Length == 0) //If nothing is typed in the lastname textbox an error should occur.
            {
                regDayTimeOutputLabel.Text = (errorMessage);//Shows error message in the output label.
            }
            

                if (seniorReg || juniorReg) //Goes through time decisions if credithours are senior or junior status.
                {
                    if (seniorReg) { registrationDay = seniorsDay; } else if (juniorReg) { registrationDay = juniorsDay; } //Decides the day to be put into the output label.
                    if (lastNameChar <= 'D') // Last names A-D
                    {
                        registrationTime = MIDAFTERNOONREG; //Registration time is the above constant when it is added to the output label.
                    }
                    else if (lastNameChar <= 'I') //Last Names E-I
                    {
                        registrationTime = LATEAFTERNOONREG; //Registration time is the above constant when it is added to the output label.
                }
                    else if (lastNameChar <= 'O')//Last names J-O
                    {
                        registrationTime = EARLYMORNINGREG; //Registration time is the above constant when it is added to the output label.
                }
                    else if (lastNameChar <= 'S') //Last names P-S
                    {
                        registrationTime = MIDMORNINGREG; //Registration time is the above constant when it is added to the output label.
                }
                    else if
                       (lastNameChar <= 'Z') //Last names T-Z
                    {
                        registrationTime = LATEMORNINGREG; //Registration time is the above constant when it is added to the output label.
                }
                }

                else if (sophomoreReg || freshmanReg) //Decisions to follow is sophomore or freshman status
                {
                    if (lastNameChar <= 'B') //Last names A-B
                    {
                    //Registration time and day are the above constants when it is added to the output label.
                    registrationTime = MIDMORNINGREG;
                        if (sophomoreReg) { registrationDay = sophomoreDay2; } else if (freshmanReg) { registrationDay = freshmanDay2; } 
                }
                    else if (lastNameChar <= 'D') //Last names C-D
                    {
                    //Registration time and day are the above constants when it is added to the output label.
                    registrationTime = LATEMORNINGREG;
                        if (sophomoreReg) { registrationDay = sophomoreDay2; } else if (freshmanReg) { registrationDay = freshmanDay2; } 
                }
                    else if (lastNameChar <= 'F') //Last names E-F
                    {
                    //Registration time and day are the above constants when it is added to the output label.
                    registrationTime = MIDAFTERNOONREG;
                        if (sophomoreReg) { registrationDay = sophomoreDay2; } else if (freshmanReg) { registrationDay = freshmanDay2; }
                }
                    else if (lastNameChar <= 'I') //Last names G-I
                    {
                    //Registration time and day are the above constants when it is added to the output label.
                    registrationTime = LATEAFTERNOONREG;
                        if (sophomoreReg) { registrationDay = sophomoreDay2; } else if (freshmanReg) { registrationDay = freshmanDay2; } 
                }
                    else if (lastNameChar <= 'L') //Last names J-L
                    {
                    //Registration time and day are the above constants when it is added to the output label.
                    registrationTime = EARLYMORNINGREG;
                        if (sophomoreReg) { registrationDay = sophomoreDay1; } else if (freshmanReg) { registrationDay = freshmanDay1; } 
                }
                    else if (lastNameChar <= 'O') //Last name M-O
                    {
                    //Registration time and day are the above constants when it is added to the output label.
                    registrationTime = MIDMORNINGREG;
                        if (sophomoreReg) { registrationDay = sophomoreDay1; } else if (freshmanReg) { registrationDay = freshmanDay1; } 
                }
                    else if (lastNameChar <= 'Q') //Last names P-Q
                    {
                    //Registration time and day are the above constants when it is added to the output label.
                    registrationTime = LATEMORNINGREG;
                        if (sophomoreReg) { registrationDay = sophomoreDay1; } else if (freshmanReg) { registrationDay = freshmanDay1; } 
                }
                    else if (lastNameChar <= 'S') //Last names R-S
                    {
                    //Registration time and day are the above constants when it is added to the output label.
                    registrationTime = MIDAFTERNOONREG;
                        if (sophomoreReg) { registrationDay = sophomoreDay1; } else if (freshmanReg) { registrationDay = freshmanDay1; } 
                }
                    else if (lastNameChar <= 'V')// Last names T-V
                    {
                    //Registration time and day are the above constants when it is added to the output label.
                    registrationTime = LATEAFTERNOONREG;
                        if (sophomoreReg) { registrationDay = sophomoreDay1; } else if (freshmanReg) { registrationDay = freshmanDay1; } 
                }
                    else if (lastNameChar <= 'Z') // Last names W-Z
                    {
                    //Registration time and day are the above constants when it is added to the output label.
                    registrationTime = EARLYMORNINGREG;
                        if (sophomoreReg) { registrationDay = sophomoreDay2; } else if (freshmanReg) { registrationDay = freshmanDay2; } 
                }
                }
                regDayTimeOutputLabel.Text = string.Format("The earliest you can register is {0} at {1}", registrationDay, registrationTime); //Output for day and time of registration.
            }
        }
    }

            
        
    

