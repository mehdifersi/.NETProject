using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AM.ApplicationCore.Domain;
namespace AM.ApplicationCore.Domain
{
    public static class TestData
    {
        static Plane plane1 = new Plane()
        {
            Capacity = 150,
            PlaneType = PlaneType.Boing,
            ManufactureDate = new DateTime(2015, 02, 03)
        };
        static Plane plane2 = new Plane()
        {
            Capacity = 250,
            PlaneType = PlaneType.Airbus,
            ManufactureDate = new DateTime(2020, 11, 11)
        };
        static Staff staff1 = new Staff()
        {
            FirstName = "captain",
            LastName = "captain",
            EmailAddress = "Captain.captain@gmail.com",
            BirthDate = new DateTime(1965, 01, 01),
            EmployementDate = new DateTime(1999, 01, 01),
            Salary = 99999
        };
        static Staff staff2 = new Staff()
        {
            FirstName = "hostess1",
            LastName = "hostess1",
            EmailAddress = "hostess1.hostess1@gmail.com",
            BirthDate = new DateTime(1995, 01, 01),
            EmployementDate = new DateTime(2020, 01, 01),
            Salary = 999
        };
        static Staff staff3 = new Staff()
        {
            FirstName = "captain",
            LastName = "captain",
            EmailAddress = "Captain.captain@gmail.com",
            BirthDate = new DateTime(1996, 01, 01),
            EmployementDate = new DateTime(2020, 01, 01),
            Salary = 999
        };
        static Traveller traveller1 = new Traveller() 
        {
            FirstName = "Traveller1",
            LastName = "Traveller1",
            EmailAddress = "Traveller1.Traveller1@gmail.com",
            BirthDate = new DateTime(1980, 01, 01),
            HealthInformation="No troubbles",
            Nationality="American"
        };
        static Traveller traveller2 = new Traveller()
        {
            FirstName = "Traveller2",
            LastName = "Traveller2",
            EmailAddress = "Traveller2.Traveller2@gmail.com",
            BirthDate = new DateTime(1981, 01, 01),
            HealthInformation = "Some troubbles",
            Nationality = "French"
        };
        static Traveller traveller3 = new Traveller()
        {
            FirstName = "Traveller3",
            LastName = "Traveller3",
            EmailAddress = "Traveller3.Traveller3@gmail.com",
            BirthDate = new DateTime(1982, 01, 01),
            HealthInformation = "No troubbles",
            Nationality = "Tunisian"
        };
        static Traveller traveller4 = new Traveller()
        {
            FirstName = "Traveller4",
            LastName = "Traveller4",
            EmailAddress = "Traveller4.Traveller4@gmail.com",
            BirthDate = new DateTime(1983, 01, 01),
            HealthInformation = "Some troubbles",
            Nationality = "American"
        };
        static Traveller traveller5 = new Traveller()
        {
            FirstName = "Traveller5",
            LastName = "Traveller5",
            EmailAddress = "Traveller5.Traveller5@gmail.com",
            BirthDate = new DateTime(1984, 01, 01),
            HealthInformation = "Some troubbles",
            Nationality = "Spanish"
        };
         public static List<Flight> listFlights =new List<Flight>()
         {
             new Flight() {FlightDate= new DateTime(2022, 01, 01),Destination="Paris",EffectiveArrival= new DateTime(2022, 01, 01),Plane=plane2,EstimatedDuration=110,Passengers = new List<Passenger> {traveller1, traveller2, traveller3, traveller4, traveller5 }},
             new Flight() {FlightDate= new DateTime(2022, 02, 01),Destination="Paris",EffectiveArrival= new DateTime(2022, 02, 01),Plane=plane1,EstimatedDuration=105},
             new Flight() {FlightDate= new DateTime(2022, 03, 01),Destination="Paris",EffectiveArrival= new DateTime(2022, 03, 01),Plane=plane1,EstimatedDuration=100},
             new Flight() {FlightDate= new DateTime(2022, 04, 01),Destination="Madrid",EffectiveArrival= new DateTime(2022, 04, 01),Plane=plane1,EstimatedDuration=130},
             new Flight() {FlightDate= new DateTime(2022, 05, 01),Destination="Madrid",EffectiveArrival= new DateTime(2022, 05, 01),Plane=plane1,EstimatedDuration=105},
             new Flight() {FlightDate= new DateTime(2022, 06, 01),Destination="Lisbonne",EffectiveArrival= new DateTime(2022, 06, 01),Plane=plane2,EstimatedDuration=200}
         };

        


    }
}
