using Reservation.Api.Infrastructure;
using Reservation.Api.Models;

namespace Reservation.Api.Services
{
    public class ReservationService : IReservationService
    {
        public ReservationDto GetReservationId(int id)
        {
            return new ReservationDto()
            {
                Amount = (new Random().Next(1,1000)),
                CheckInDate = DateTime.Now.AddDays(10),
                CheckOutDate = DateTime.Now.AddDays(20),
                PnrNo = "1oko1",
                ReservationDate = DateTime.Now,
                Id = (new Random().Next(id, 100)),
            };
        }
    }
}