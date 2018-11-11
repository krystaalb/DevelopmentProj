//B2517
//Program 4
//December 6th 2016
//CIS 199-75
//This program will construct a library book with the entered information and either display the details, return, or check out the book when the buttons are clicked. 
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prog4
{
    public partial class Form1 : Form
    {
        List<LibraryBook> bookList = new List<LibraryBook>(); //List 

        public Form1()
        {
            InitializeComponent();
        }
        //Preconditions:All fields all a correct value and everything parses.
        //Postconditions:The book will be added to the list. 
        public void addBookButton_Click(object sender, EventArgs e)
        {
            string title; //Title
            string author; //Author
            string publisher; //Publisher
            int copyrightYear; //Copyright Year
            string callNumber; //Call Number

            title = titleTextBox.Text; //Gets information from title text box.
            author = authorTextBox.Text; //Gets information from author text box.
            publisher = publisherTextBox.Text; //Gets information from publisher text box.

            callNumber = callNumberTextBox.Text; //Gets information from 

            if (!(int.TryParse(copyrightYearTextBox.Text, out copyrightYear))) //If it cannot try parse show error message.
            {
                MessageBox.Show("Please enter a valid copyright year!");
            }
            else if (string.IsNullOrEmpty(title)) //If textbox is empty show error message.
            {
                MessageBox.Show("Please enter a title.");
            }
            else if (string.IsNullOrEmpty(author)) //If textbox is empty show error message.
            {
                MessageBox.Show("Please enter an author.");
            }
            else if (string.IsNullOrEmpty(publisher)) //If textbox is empty show error message.
            {
                MessageBox.Show("Please enter a publisher.");
            }
            else if (string.IsNullOrEmpty(callNumber)) //If textbox is empty show error message.
            {
                MessageBox.Show("Please enter a call number");
            }
            else
            {   //Everything validates
                //Create book
                //Add book to list
                //Add book title to listbox
                LibraryBook myBook = new LibraryBook(title, author, publisher, copyrightYear, callNumber);
                bookList.Add(myBook);
                libraryBookListBox.Items.Add(myBook.Title);

                //Clears text boxes
                titleTextBox.Clear();
                authorTextBox.Clear();
                publisherTextBox.Clear();
                copyrightYearTextBox.Clear();
                callNumberTextBox.Clear();
            }
        }

        //Preconditions:A book must be selected from the list.
        //Postconditions:A message box will show the details associated with being a library book.
        //If one is not selected an error message will occur. 
        private void detailsButton_Click(object sender, EventArgs e)
        {
            int index = libraryBookListBox.SelectedIndex - 1; //Index looks one less because the index starts at zero.
            if (libraryBookListBox.SelectedIndex == 0) //If index is zero show details.
            {
                MessageBox.Show(bookList[libraryBookListBox.SelectedIndex].ToString());
            }

          else  if (libraryBookListBox.SelectedIndex == -1) //If index is less than zero show error message.
                {
                    MessageBox.Show("Please select a book.");
                }
            else
            { //Look for the index positions beyond zero.
                index++;

                MessageBox.Show(bookList[libraryBookListBox.SelectedIndex].ToString()); //Details
            }

        }
        //Preconditions:A book has been selected and is not already checked out. 
        //Postconditions:The book will be checked out.
        private void checkOutButton_Click(object sender, EventArgs e)
        {
           int index = libraryBookListBox.SelectedIndex - 1; //Index looks one less because the index starts at zero.
            if (libraryBookListBox.SelectedIndex == 0) //If index is zero check book out. 
            {
                bookList[libraryBookListBox.SelectedIndex].CheckOut();//ischeckedout == true.
                MessageBox.Show(bookList[libraryBookListBox.SelectedIndex].Title + " has been checked out."); //Book has been checked out message.
            }
                else if (libraryBookListBox.SelectedIndex == -1) //If index is less than zero show error message.
            {
                MessageBox.Show("Please select a book.");
            }

            else
            {//Look for the index positions beyond zero.
                index++;
                bookList[libraryBookListBox.SelectedIndex].CheckOut(); //Check out. ischeckedout ==true.
                MessageBox.Show(bookList[libraryBookListBox.SelectedIndex].Title + " has been checked out."); //Check out

            }
            
        }
        //Preconditions:A book has been selected and is checked out.
        //Postconditions:The book will be returned.
        private void returnButton_Click(object sender, EventArgs e)
        {
            int index = libraryBookListBox.SelectedIndex - 1; //Index looks one less because the index starts at zero.
            if (libraryBookListBox.SelectedIndex == 0) //Select book

            {
                bookList[libraryBookListBox.SelectedIndex].ReturnToShelf(); //Returns to shelf. ischeckedout == false.

                MessageBox.Show(bookList[libraryBookListBox.SelectedIndex].Title + " has been returned to the shelf");
            }
          else if (libraryBookListBox.SelectedIndex == -1) //Not in index display error message.
            {
                MessageBox.Show("Please select a book.");
            }

            else
            {//Looks index of the book if it is greater than 0
                index++;
                bookList[libraryBookListBox.SelectedIndex].ReturnToShelf(); //Returns to shelf/ ischeckedout = false
                MessageBox.Show(bookList[libraryBookListBox.SelectedIndex].Title + " has been returned to the shelf.");//Messagebox
            }          
     }
   }
 }

    
