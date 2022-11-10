using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using Microsoft.EntityFrameworkCore;

namespace EF_Core_InMemory
{
    internal class Program
    {
        static HotelContext _HotelContext = new HotelContext();

        static void Main(string[] args)
        {
            CreateEntries();
            ChangeEntries();
            DeleteEntries();
            GetEntries();
        }

        static void CreateEntries()
        {
            _HotelContext.Bookings.Add(new HotelContext.HotelBooking
            {
                Customer_Name = "Person A",
                EmailAdress = "PersonA@AnbieterA.com",
                BookingDate = DateTime.Now,
                IsPaymentRecieved = false,
                RoomNumber = 1,
                BookingNumber = 1
            });

            _HotelContext.Bookings.Add(new HotelContext.HotelBooking
            {
                Customer_Name = "Person B",
                EmailAdress = "PersonB@AnbieterA.com",
                BookingDate = DateTime.Now,
                IsPaymentRecieved = false,
                RoomNumber = 2,
                BookingNumber = 2
            });

            _HotelContext.Bookings.Add(new HotelContext.HotelBooking
            {
                Customer_Name = "Person C",
                EmailAdress = "PersonC@AnbieterA.com",
                BookingDate = DateTime.Now,
                IsPaymentRecieved = false,
                RoomNumber = 3,
                BookingNumber = 3
            });
            _HotelContext.SaveChanges();
        }

        static void ChangeEntries()
        {
            var Entry1 = _HotelContext.Bookings.Where(b => b.Customer_Name == "Person B").FirstOrDefault();
            if (Entry1 != null)
            {
                Entry1.IsPaymentRecieved = true;
                _HotelContext.SaveChanges();
            }

            var Entry2 = _HotelContext.Bookings.Where(b => b.BookingNumber == 2).FirstOrDefault();
            if (Entry2 != null)
            {
                Entry2.EmailAdress = "PersonB@AnbieterB.com";
                _HotelContext.SaveChanges();
            }
        }

        static void DeleteEntries()
        {
            var Entry1 = _HotelContext.Bookings.Where(b => b.Customer_Name == "Person C").FirstOrDefault();
            if (Entry1 != null)
            {
                _HotelContext.Bookings.Remove(Entry1);
            }
            _HotelContext.SaveChanges();
        }

        static void GetEntries()
        {
            foreach (var booking in _HotelContext.Bookings.Where(b => b.IsPaymentRecieved == true))
            {
                Console.WriteLine(String.Format("Der Kunde {0} hat am {1} das Zimmer {2} gebucht", booking.Customer_Name, booking.BookingDate.Date, booking.RoomNumber));
            }
        }
    }
}

public class HotelContext : DbContext
{
    public DbSet<HotelBooking> Bookings { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseInMemoryDatabase(databaseName: "ef_core_examples");
    }

    public class HotelBooking
    {
        public int Id { get; set; }
        public string? Customer_Name { get; set; }
        public string? EmailAdress { get; set; }
        public DateTime BookingDate { get; set; }
        public Boolean IsPaymentRecieved { get; set; }
        public int RoomNumber { get; set; }
        public int BookingNumber { get; set; }
    }
}