using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheBookProject
{
    public class Author
    {
        private string _middleName;

        public string FirstName { get; set; }
        /* public string MiddleName 
         {
           get
             {
                 return _middleName.ToUpper();
             } 

           set
             {
                 _middleName = value;
             }
         }*/

        public string MiddleName { get; set; }
        public string LastName { get; set; }


        public Author()
        {
            FirstName = "";
            LastName = "";
            MiddleName = "";
        }

        public Author(Author otherObj)
        {
            FirstName = otherObj.FirstName;
            LastName = otherObj.LastName;
            MiddleName = otherObj.MiddleName;
        }

        public Author(string firstName, string middleName, string lastName)
        {
            FirstName = firstName;
            MiddleName = middleName;
            LastName = lastName;
        }

        public override string ToString()
        {
            return $"{FirstName} {MiddleName} {LastName}";
        }

        public bool Equals(Author otherObj)

        {
            return FirstName == otherObj.FirstName && 
                    MiddleName == otherObj.MiddleName && 
                    LastName == otherObj.LastName;   
        }

        /*
        public string GetMiddleName()
        {
            return MiddleName.ToUpper();
        }
        */
    }
}
