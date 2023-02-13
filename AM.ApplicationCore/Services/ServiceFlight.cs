using AM.ApplicationCore.Domain;
using AM.ApplicationCore.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Services
{
    public class ServiceFlight : IServiceFlight
    {
        public List<Flight> Flights { get; set;}=new List<Flight>();

        public List<DateTime> GetFlightDates(string destination)
        {
            List<DateTime> listDate =new List<DateTime>();
            //for(int i =0; i < Flights.Count; i++)
            //{
            //    if (Flights[i].Destination == destination)
            //    {
            //        listDate.Add(Flights[i].FlightDate);
            //    }
            //}
            foreach (Flight flight in Flights)
            {
                if (flight.Destination == destination)
                {
                    listDate.Add(flight.FlightDate);
                }
            }
            return listDate;
            
        }

        public void GetFlights(string filterType, string filterValue)
        {
            switch (filterType)
            {
                case "destination":
                    foreach (var item in Flights)
                    {
                        if (item.Destination == filterValue)
                        {
                            Console.WriteLine(item);
                        }
                    }
                    break;
                case "FlightDate":
                    foreach (var item in Flights)
                    {
                        if (item.FlightDate == DateTime.Parse(filterValue))
                        {
                            Console.WriteLine(item);
                        }
                    }
                    break;
                case "departure":
                    foreach (var item in Flights)
                    {
                        if (item.Departure == filterValue)
                        {
                            Console.WriteLine(item);
                        }
                    }
                    break;
                case "Flightid":
                    foreach (var item in Flights)
                    {
                        if (item.FlightId == int.Parse(filterValue))
                        {
                            Console.WriteLine(item);
                        }
                    }
                    break;

            }
        }

        public int ProgrammedFlightNumber(DateTime startDate)
        {
            throw new NotImplementedException();
        }
        public IEnumerable<DateTime> GetFlightdates(string destination)
        {
            var query = from flight in Flights
                        where flight.Destination == destination
                        select flight.FlightDate;
            return query;
        }

        public void ShowFlightDetails(Plane plane)
        {
            foreach (var item in plane.Flights)
            {
                Console.WriteLine(item.Destination);
                Console.WriteLine(item.FlightDate);
            }
        }
    }
}
