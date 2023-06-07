using HotelProject.EntityLayer.Concrate;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.DAL.Concrete
{
    public class Context:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=DESKTOP-HQIEVQ0\\SQLEXPRESS;database=hotelDb;uid=sa;pwd=123");
        }

        public DbSet<Room> Rooms { get; set; }
        public DbSet<Staff> Staffs { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<Subscribe> Subscribes { get; set; }
        public DbSet<Testimonial> Testimonials { get; set; }
    }
}
