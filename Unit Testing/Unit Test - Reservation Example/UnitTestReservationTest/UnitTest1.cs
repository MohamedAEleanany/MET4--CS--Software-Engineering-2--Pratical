using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Unit_Test___Reservation_Example;

namespace UnitTestReservationTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void CanBeCancelledBy_IsAdmin_Senario()
        {
            var reservation = new Reservation();

            var CheckUser = reservation.CanBeCancelledBy(new User { IsAdmin = true });

            Assert.IsTrue(CheckUser);
        }

        [TestMethod]
        public void CanBeCancelledBy_User_Senario()
        {
            var user = new User();
            var reservation = new Reservation() { MadeBy = user};

            var CheckUser = reservation.CanBeCancelledBy(user);

            Assert.IsTrue(CheckUser);
        }

        [TestMethod]
        public void CanBeCancelledBy_Anounmous_Senario()
        {
            var reservation = new Reservation() { MadeBy = new User() };

            var CheckUser = reservation.CanBeCancelledBy(new User ());

            Assert.IsTrue(CheckUser);
        }
    }
}
