using System;
using System.Text;
using System.Collections.Generic;
using NUnit.Framework;
using onlineSpaBooking;

namespace onlineSpaBooking.Test
{

    [TestFixture]
    public class BookingTest




    {
        Booking b1 = new Booking(10, "body massage", "combo2", "chennai", 1000, "ayurvedic");
        [Test]

       
            // Booking b1 = new Booking(10, "body massage", "combo2", "chennai", 1000, "ayurvedic");

            public void TestBooking()
            {


                Assert.AreEqual(10, b1.BookingId);
                Assert.AreEqual("body massage", b1.PackName);
                Assert.AreEqual("combo2", b1.PackType);
                Assert.AreEqual("chennai", b1.Address);
                Assert.AreEqual(1000, b1.PackCost);
                Assert.AreEqual("ayurvedic", b1.PackDetails);

            }
        


    }

}

     