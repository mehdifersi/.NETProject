using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Domain
{
    public class Passenger
    {
        public int PasseportNumber { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }    
        public string PhoneNumber { get; set; }
        public DateTime BirthDate { get; set; }
        public ICollection<Flight> Flights { get; set; }

        //public bool CheckProfile (string first_name,string last_name)
        //{
        //    if(FirstName == first_name && LastName == last_name)
        //        return true;
        //    return false;
            
        //}
        //public bool CheckProfile(string first_name, string last_name,string email)
        //{
        //    if (EmailAddress==email && FirstName == first_name && LastName == last_name)
        //        return true;
        //    return false;

        //}
        public bool CheckProfile(string first_name, string last_name, string email=null)
        {
            if (email == null)
            {
                if (FirstName == first_name && LastName == last_name)
                    return true;
                return false;
            }
            else 
            {
                if (EmailAddress == email && FirstName == first_name && LastName == last_name)
                    return true;
                return false;
            }
        }
        public virtual void PassengerType()
        {
            Console.WriteLine("I'm a passenger");
        }


    }

}
