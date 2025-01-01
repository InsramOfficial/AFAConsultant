using AFAConsultant.Models;
using Microsoft.EntityFrameworkCore;

namespace AFAConsultant.Data
{
    public class AppdbContext : DbContext
    {
        public AppdbContext(DbContextOptions<AppdbContext> options) : base(options)
        {
            
        }

        public DbSet<Aboutus> tbl_aboutus { get; set; }
        public DbSet<Contactus> tbl_contactus { get; set; }
        public DbSet<Countries> tbl_countries { get; set; }
        public DbSet<Professionals> tbl_professionals { get; set; }
        public DbSet<QueryMessage> tbl_querymessages { get; set; }
        public DbSet<Review> tbl_review { get; set; }
        public DbSet<Settings> tbl_settings { get; set; }
        public DbSet<Slider> tbl_slider { get; set; }
        public DbSet<User> tbl_user { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Aboutus>().HasData(
                new Aboutus { Id = 1, Title = "ABOUT1",Description = "This is description",Total_Visa_Categories = 31,Total_Team_Members = 21,Total_Visa_Processes = 2000,Success_Rate = 100 }
                );
            modelBuilder.Entity<Contactus>().HasData(
                new Contactus { Id = 1,Address1 = "Kotli",Address2 = "kotli",PhoneNumber1 = "12345",PhoneNumber2 = "12345",Email1 = "naseer@gmail.com",Email2 = "insram@gmail.com",FacebookLink = "facebook.com",TwitterLink = "twitter.com",InstagramLink = "instagram.com",TiktokLink = "tiktok.com"}
                );
            modelBuilder.Entity<Countries>().HasData(
                new Countries { Id = 1,Name = "United Kingdom",Country_PicUrl = "image.jpg", Flag_PicUrl = "image.jpg" }
                );
            modelBuilder.Entity<Professionals>().HasData(
                new Professionals { Id = 1, Name = "Naseer", PhoneNumber = "12345", Email = "naseer@gmail.com", Description = "This is Muhammad Naseer",PicUrl = "image.jpg" }
                );
            modelBuilder.Entity<QueryMessage>().HasData(
                new QueryMessage { Id = 1, Name = "Naseer", Email = "naseershabbir@gmail.com", PhoneNumber = "12345", Subject = "Problem", Message = "This is my Message" },
                new QueryMessage { Id = 2, Name = "Naseer", Email = "naseershabbir@gmail.com", PhoneNumber = "12345", Subject = "Problem", Message = "This is my Message" },
                new QueryMessage { Id = 3, Name = "Naseer", Email = "naseershabbir@gmail.com", PhoneNumber = "12345", Subject = "Problem", Message = "This is my Message" },
                new QueryMessage { Id = 4, Name = "Naseer", Email = "naseershabbir@gmail.com", PhoneNumber = "12345", Subject = "Problem", Message = "This is my Message" }
                );
            modelBuilder.Entity<Review>().HasData(
                new Review { Id = 1, Name = "Muhammad Naseer", Designation = "programmer", Message = "Good", Rating = 4,PicUrl = "image.jpg" },
                new Review { Id = 2, Name = "Muhammad Naseer", Designation = "programmer", Message = "Good", Rating = 4,PicUrl = "image.jpg" },
                new Review { Id = 3, Name = "Muhammad Naseer", Designation = "programmer", Message = "Good", Rating = 4,PicUrl = "image.jpg" },
                new Review { Id = 4, Name = "Muhammad Naseer", Designation = "programmer", Message = "Good", Rating = 4,PicUrl = "image.jpg" },
                new Review { Id = 5, Name = "Muhammad Naseer", Designation = "programmer", Message = "Good", Rating = 4,PicUrl = "image.jpg" },
                new Review { Id = 6, Name = "Muhammad Naseer", Designation = "programmer", Message = "Good", Rating = 4,PicUrl = "image.jpg" }
                );
            modelBuilder.Entity<Settings>().HasData(
                new Settings { Id = 1, Name = "AFAConsultant",LogoFavicon = "image.jpg" }
                );
            modelBuilder.Entity<Slider>().HasData(
                new Slider { Id = 1, Title = "Slider", Description = "This is Slider",PicURL = "image.jpg" }
                );
            modelBuilder.Entity<User>().HasData(
                new User { Id = 1, Username = "admin", Password = "admin", FullName = "Muhammad Naseer",ImageName = "naseer.jpg"}
                );
        }

    }
}
