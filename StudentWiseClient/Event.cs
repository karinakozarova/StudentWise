using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentWiseClient
{
    enum EventType
    {
        OTHER,
        DUTY,
        PARTY
    }

    class Event
    {
        public Event(String title, String description, DateTime start, DateTime end)
        {
            this.EventType = EventType.OTHER;
            this.Title = title;
            this.Description = description;
            this.EndsAt = end;
            this.StartsAt = start;
        }

        public EventType EventType
        {
            get
            {
                return this.EventType;
            }
            set
            {
                if(Enum.IsDefined(typeof(EventType), value))
                {
                    this.EventType = value;
                }
            }
        }

        public String Title
        {
            get
            {
                return this.Title;
            }
            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    return;
                }
                this.Title = value;
            }
        }

        public String Description
        {
            get
            {
                return this.Description;
            }
            set{
                if(String.IsNullOrEmpty(value)){
                    return;
                }
                this.Description = value;
            }
        }

        public DateTime StartsAt
        {
            get;
            set;
        }

        public DateTime EndsAt
        {
            get;
            set;
        }
    }
}
