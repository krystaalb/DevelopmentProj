//B2517
//Program 4
//December 6th 2016
//CIS 199-75
//This program will construct a library book with the information entered into the list box from the text boxes. 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog4
{
    public class LibraryBook  //Class
    {
       private int copyrightyear; //Copyright year property
       private bool ischeckedout; //Checked out property

        //Preconditions:Book data will need to validate.
        //Postconditions: LibraryBook is made.
        public LibraryBook(string title, string author, string publisher, int copyrightyear, string callnumber)
        {
            
            Title = title; //Stores title
            Author = author; //Stores author
            Publisher = publisher; //Stores publisher
            CopyrightYear = copyrightyear; //Stores copyright year
            CallNumber = callnumber; //Stores call nummber
           
        }
        //Accessors
        public string Title { get; set; } //Auto
        public string Author { get; set; } //Auto
        public string Publisher { get; set; } //Auto
        public int CopyrightYear {get { return copyrightyear; } //Returns the copyrightyear if it is not negative.
         

            set {

                if (value >= 0)
                { copyrightyear = value;
                }
                else
                { copyrightyear = 2016; //Default
                }
            } }



        public string CallNumber { get; set; } //Auto

        //Preconditions:The book is on the shelf.
        //Ischeckedout = false
        //Postconditions: The book is checked out.
        //Ischeckedout = true
        public void CheckOut()
        {
            ischeckedout = true; //Bool
        }

        //Preconditions:The book is checked out.
        //Ischeckedout = true
        //Postconditons:The book is returned to the shelf
        //Ischeckedout = false
        public void ReturnToShelf()
        {
            ischeckedout = false; //Bool
        }

        //Preconditions:When a book is created it will always be
        //Ischeckedout = false
        //Postconditions:Returns ischeckedout for selected book
        //Can be true or false
        public bool IsCheckedOut()
        {
            return ischeckedout; //Bool to show if book is on the shelf.
        }

        //Preconditions:All things have been validated.
        //Postconditions:All information is formatted to the to string.
        public override string ToString()
        {
          
            string result;
            result = "Title:" + Title.ToString() + Environment.NewLine + "Author: " + Author.ToString() + Environment.NewLine + "Publisher: " + Publisher.ToString() + Environment.NewLine + "Copyright Year: " + CopyrightYear.ToString("D4") + Environment.NewLine + "Call Number: " + CallNumber.ToString() + Environment.NewLine + "Checked Out: " + ischeckedout.ToString();
            return result;
        }
    }
}

