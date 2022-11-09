using System;

namespace TheBookProject
{
    public class Book
    {
        //1. attributes - the defining properties for your model

        //Attributes for our book
        //private Author[] authors; 
        private Author author;
        //private string authorFirstName;
        //private string authorLastName;
        //private string authorMiddleName;
        private char genre; //H - Historic, F - Fantasy, C - Comedy, E - Educational 
        private int numberOfPages;
        private string title;
        private double msrp;
        private bool isNew; //Is the book new? Y/N.

        //1a. properties - the defining attributes of a model

        //2. Constructors - the way to build an object

        public Book() // default constructor
        {
            genre = 'E';
            numberOfPages = 1;
            SetTitle("No Name");
            msrp = 1.0; 
            isNew = false;
            author = new Author();

        }

        public Book(char genre, int numberOfPages, string title, double msrp, bool isNew, string firstName, string middleName, string lastName)// paramaterized constructor
        {
            this.genre = genre; 
            this.numberOfPages = numberOfPages;
            SetTitle(title);
            this.msrp = msrp;
            this.isNew = isNew;
            
            author = new Author(firstName, middleName, lastName);

            /*
            author = new Author();
            author.FirstName = firstName;
            author.MiddleName = middleName;
            author.LastName = lastName;
            */
            //SetAuthor(firstName, middleName, lastName);
        }

        public Book(Book otherObj)
        {
            this.genre = otherObj.genre;
            this.numberOfPages = otherObj.numberOfPages;
            SetTitle(otherObj.title);
            this.msrp = otherObj.msrp;
            this.isNew = otherObj.isNew;
            author = new Author(otherObj.author);
        }

        public string GetTitle()
        {
            return title;
        }

        public void SetTitle(string title)
        {
            //we ant all titles in our to AWLAYS be uppercase
            if (title is null || title == " " || title == "")
            {
                title = "no name given";

            }

            this.title = title.ToLower(); 
        }
        public string GetTitleUpperCase()
        {
            return title.ToUpper();
        }

        public string GetIfItIsNewAndPrice()
        {
            string msg = "";
            if(isNew)
            {
                msg += "This book is new! ";
            }
            else
            {
                msg +=  "This book is used! ";
            }

            msg += "\nPrice: " + msrp.ToString("C");

            return msg;
        }

        private string ConvertGenre()
        {
            if(genre == 'E')
            {
                return "educational";
            }

            else if(genre == 'H')
            {
                return "history";
            }

            else if(genre == 'F')
            {
                return "fantasy";
            }

            else
            {
                return "undefined"; 
            }
        }

        public string GetGenreAsString()
        {
            return ConvertGenre(); 
        }

        public Author GetAuthor()
        {
            return author;
        }

       public void SetAuthor(string firstName, string middleName, string lastName)
        {
            author.FirstName = firstName;
            author.MiddleName = middleName;
            author.LastName = lastName;

            //author = new Author(firstName, middleName, lastName);
        }

        public string GetAllOfAuthorsInfo()
        {
            return author.ToString();
        }

        public override string ToString()
        {

            /*genre = 'E';
            numberOfPages = 1;
            SetTitle("No Name");
            msrp = 1.0; 
            isNew = false;
            author = new Author();
            */

            string msg = "";

            if(genre == 'E')
            {
                msg += "Genre: Educational \n";
            }
            else if (genre == 'A')
            {
                msg += "Genre: Action \n";
            }
            else if (genre == 'R')
            {
                msg += "Genre: Romance \n";
            }
            else
            {
                msg += "Genre: Not Defined \n";
            }

            msg += "Number of Pages: " + numberOfPages + "\n";

            msg += "Title: " + title + "\n";

            msg += "MSRP: " + msrp.ToString("C") + "\n";

            if(isNew)
            {
                msg += "This book is new! \n";
            }
            else
            {
                msg += "This book is used!\n";
            }

            msg += "Author: " + author.ToString() + "\n";

            return msg;

        }

        public bool Equals(Book otherObj)
        {
            if(this.genre == otherObj.genre && 
                this.numberOfPages == otherObj.numberOfPages &&
                this.title == otherObj.title &&
                this.msrp == otherObj.msrp &&
                this.isNew == otherObj.isNew &&
                this.author.Equals(otherObj.author))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
