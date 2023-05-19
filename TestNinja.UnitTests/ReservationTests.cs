using TestNinja.Fundamentals;
using Xunit.Sdk;

namespace TestNinja.UnitTests
{
    [TestClass]
    public class ReservationTests
    {
        [TestMethod]
        public void CanBeCancelledBy_UserIsAdmin_ReturnsTrue()
        {
            // Arrange
            var reservation = new Reservation ();
            // Act
            var result = reservation.CanBeCancelledBy(new User { IsAdmin = true }); ;

            // Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void CanBeCancelledBy_SameUserCancellingReservation_ReturnsTrue()
        {
            // Arrange
            var user = new User();
            var reservation = new Reservation { MadeBy = user };
            // Act
            var result = reservation.CanBeCancelledBy(user);

            // Assert
            Assert.IsTrue(result);
        }
        [TestMethod]
        public void CanBeCancelledBy_AnotherUserCancellingReservation_ReturnsFalse()
        {
            // Arrange
            var user = new User();
            var otherUser = new User();
            var reservation = new Reservation { MadeBy = user };
            // Act
            var result = reservation.CanBeCancelledBy(otherUser);

            // Assert
            Assert.IsFalse(result);
        }
    }
}