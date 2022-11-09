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


           /*

            Console.Write("What is the author's first name? ");

            var firstName = Console.ReadLine();

            Console.Write("What is the author's middle name? ");

            var middleName = Console.ReadLine();

            Console.Write("What is the author's last name? ");

            var lastName = Console.ReadLine();

            Book book = new Book('H', 200, "aefd", 50.5, true, firstName, middleName,lastName);

           

            Console.WriteLine(book);
           */
            //book2 contains some memory address where the location of all the stuff for book2 is stored
            Book book2 = new Book(); //34
            Book book3 = new Book(); // AF

            //shallow copy 
            Book book4 = new Book(book3);

            book3.SetTitle("Java!");

            if(book4.Equals(book3))
            {
                Console.WriteLine("They are equal!");
            }
            else
            {
                Console.WriteLine("They are not equal!");
            }



            Console.WriteLine(book4);

            Console.WriteLine(book3);



        }
    }
}