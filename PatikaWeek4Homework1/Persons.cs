using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatikaWeek4Homework1
{
    public class Persons
    {
        // Fields oluşturuluyor
        private string firstName;
        private string lastName;
        private DateTime birthDate;

        // Properties oluşturuluyor
        public string FirstName
        {
            get
            { 
                return firstName; 
            }
            set
            {
                firstName = value;
            }
                
        }
        public string LastName
        {
            get {
                return lastName; 
            }
            set
            {
               lastName = value;
            }
        }
        
        public DateTime BirthDate
        {
            get
            {
                return birthDate;
            }
            set
            { birthDate = value; }
        }


        //Person bilgileri yazdırılıyor
        public void PersonsPrint()
        {
            Console.WriteLine($" Ad: {FirstName}\n Soyadı: {LastName} \n Doğum Tarihi: {BirthDate.ToShortDateString()} \n\n");

        }
    }
}
