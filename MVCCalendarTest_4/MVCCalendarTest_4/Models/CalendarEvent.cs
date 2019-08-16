namespace MVCCalendarTest_4.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class CalendarEvent : DbContext
    {
        public CalendarEvent()
            : base("name=CalendarEvent")
        {
        }

        public virtual DbSet<Event> Events { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
