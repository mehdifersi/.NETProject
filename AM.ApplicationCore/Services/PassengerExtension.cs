using AM.ApplicationCore.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Services
{
    public static class PassengerExtension
    {
        public static Passenger UpperFullName(Passenger passenger)
        {
            passenger.LastName[0].ToString().ToUpper();
        }

    }
}
