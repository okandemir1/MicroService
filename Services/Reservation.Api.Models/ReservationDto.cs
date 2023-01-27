namespace Reservation.Api.Models
{
    public class ReservationDto
    {
        public int Id { get; set; }
        public string PnrNo { get; set; }
        public DateTime? CheckInDate { get; set; }
        public DateTime? CheckOutDate { get; set; }
        public DateTime? ReservationDate { get; set; }
        public double Amount { get; set; }
    }
}