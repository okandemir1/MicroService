using Reservation.Api.Models;

namespace Reservation.Api.Infrastructure
{
    public interface IReservationService
    {
        public ReservationDto GetReservationId(int id);
    }
}