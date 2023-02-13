// See https://aka.ms/new-console-template for more information
using AM.ApplicationCore.Domain;
using AM.ApplicationCore.Services;

//Console.WriteLine("Hello, World!");
////Plane plane1 = new Plane();
////plane1.Capacity= 200;
////plane1.PlaneID = 1;
////plane1.ManufactureDate = new DateTime(2023,02,02);
////plane1.PlaneType = PlaneType.Boing;


////Plane plane2 =new Plane(PlaneType.Airbus,350,new DateTime(2023,01,31));


//Plane plane3 = new Plane()
//{
//    Capacity = 100,
//    PlaneType = PlaneType.Boing,
//    ManufactureDate = DateTime.Now
//};

//Passenger passenger1 = new Passenger()
//{
//      FirstName= "Test1",
//      LastName= "Test2",
//      EmailAddress="Test@test.test"
//};

//Staff staff1 = new Staff();

//Traveller traveller1 = new Traveller();

//Console.WriteLine(passenger1.CheckProfile("Test1", "Test2", "Test@test.test"));

//staff1.PassengerType();

//traveller1.PassengerType();

ServiceFlight serviceFlight=new ServiceFlight();
serviceFlight.Flights = TestData.listFlights;