namespace TheBookProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            var a1 = new Author();
            a1.FirstName = "Bob";
            a1.LastName = "Smith";
            a1.MiddleName = "Mark";

            Console.WriteLine(a1.FirstName);
            Console.WriteLine(a1.MiddleName);
            */
            /*
            Book bookObject = new Book(); //create the memory that represents a book

            Book bookObjectWithValues = new Book('E', 200, "CSharp Fundamentals", 100.0, true); 

            Book myBook = new Book('H', 200, "aefd", 50.5, true);


            //Desjardins
            Console.WriteLine(bookObject.GetTitle());
            Console.WriteLine(bookObjectWithValues.GetTitle());
            Console.WriteLine(myBook.GetTitle());

            //Want to display the title of any book?


            Console.WriteLine(myBook.GetIfItIsNewAndPrice());
            Console.WriteLine(bookObjectWithValues.GetIfItIsNewAndPrice());
            Console.WriteLine(bookObject.GetIfItIsNewAndPrice());

            //var userInput = Console.ReadLine();
            
            myBook.SetTitle(Console.ReadLine());

            Console.WriteLine(bookObject.GetTitle());
            Console.WriteLine(bookObjectWithValues.GetTitle());
            Console.WriteLine(myBook.GetTitle());

            myBook.ConvertGenre(); */

            /*
            
            Console.WriteLine(Person.GetNextNumber());

            var personObject = new Person("Mathew");
            Console.WriteLine(personObject.GetName());
            Console.WriteLine(personObject.GetEmpID());
            Console.WriteLine(Person.GetNextNumber());
            var personObject1 = new Person("Rachel");
            Console.WriteLine(personObject1.GetName());
            Console.WriteLine(personObject1.GetEmpID());
            Console.WriteLine(Person.GetNextNumber());
            */


            var book = new Book();

            Console.Write("What is the author's first name? ");

            var firstName = Console.ReadLine();

            Console.Write("What is the author's middle name? ");

            var middleName = Console.ReadLine();

            Console.Write("What is the author's last name? ");

            var lastName = Console.ReadLine();


            book.SetAuthor(firstName, middleName, lastName);

            Console.WriteLine(book.GetAllOfAuthorsInfo());

        }
    }
}