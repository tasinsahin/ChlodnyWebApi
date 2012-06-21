namespace DomainClasses.EntitiesChinook
{
    using System;

    public class Event
    {
        public int EventId { get; set; }

        public string EventDescription { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public bool AllDay { get; set; }
    }
}