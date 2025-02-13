using Moq;
using Xunit;

namespace TicketBookingCore.Tests
{
    public class TicketBookingRequestProcessorTests 
    {
        private readonly Mock<ITicketBookingRespository> _ticketBookingRespositoryMock;
        private readonly TicketBookingRequestProcessor _processor;
        private readonly TicketBookingRequest _request;

        public TicketBookingRequestProcessorTests()
        {
            _ticketBookingRespositoryMock = new Mock<ITicketBookingRespository>();
            _processor = new TicketBookingRequestProcessor(_ticketBookingRespositoryMock.Object);
            _request = new TicketBookingRequest
            {
                Firstname = "John",
                Lastname = "Doe",
                Email = "john.doe@example.com"
            };
        }

        [Fact]
        public void ShouldThrowExceptionIfRequestIsNull()
        {
            // Act & Assert
            var exception = Assert.Throws<ArgumentNullException>(() => _processor.Book(null));
            Assert.Equal("request", exception.ParamName);
        }

        [Fact]
        public void ShouldSaveToDatabase()
        {
            // Arrange
            TicketBooking savedTicketBooking = null;

            // Setup the save method to capture the saved ticket booking
            _ticketBookingRespositoryMock.Setup(x => x.Save(It.IsAny<TicketBooking>()))
                .Callback<TicketBooking>(ticketBooking => 
                {
                    savedTicketBooking = ticketBooking;
                });

            // Act
            _processor.Book(_request);

            // Assert
            _ticketBookingRespositoryMock.Verify(x => x.Save(It.IsAny<TicketBooking>()), Times.Once);
            Assert.NotNull(savedTicketBooking);
            Assert.Equal(_request.Firstname, savedTicketBooking.Firstname);
            Assert.Equal(_request.Lastname, savedTicketBooking.Lastname);
            Assert.Equal(_request.Email, savedTicketBooking.Email);
        }

        [Fact]
        public void ShouldReturnTicketBookingResultWithRequestValues()
        {
            // Act
            var result = _processor.Book(_request);

            // Assert
            Assert.NotNull(result);
            Assert.Equal(_request.Firstname, result.Firstname);
            Assert.Equal(_request.Lastname, result.Lastname);
            Assert.Equal(_request.Email, result.Email);
        }
    }
}