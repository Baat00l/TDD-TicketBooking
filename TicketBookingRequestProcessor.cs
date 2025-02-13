public class TicketBookingRequestProcessor
{
    private readonly ITicketBookingRespository _ticketBookingRespository;

    public TicketBookingRequestProcessor(ITicketBookingRespository ticketBookingRespository)
    {
        _ticketBookingRespository = ticketBookingRespository;
    }

    public TicketBookingResponse Book(TicketBookingRequest request)
    {
        if (request == null)
        {
            throw new ArgumentNullException(nameof(request));
        }

        var ticketBooking = MapRequestToBooking(request);
        _ticketBookingRespository.Save(ticketBooking);

        return MapBookingToResponse(ticketBooking);
    }

    private TicketBooking MapRequestToBooking(TicketBookingRequest request)
    {
        return new TicketBooking
        {
            Firstname = request.Firstname,
            Lastname = request.Lastname,
            Email = request.Email
        };
    }

    private TicketBookingResponse MapBookingToResponse(TicketBooking booking)
    {
        return new TicketBookingResponse
        {
            Firstname = booking.Firstname,
            Lastname = booking.Lastname,
            Email = booking.Email
        };
    }
}