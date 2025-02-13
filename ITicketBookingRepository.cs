using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketBookingCore
{
    public interface ITicketBookingRespository
    {
        void Save(TicketBooking ticket);
    }
}