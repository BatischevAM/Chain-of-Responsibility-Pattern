using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chain_of_Responsibility_Pattern
{
    public class EventRequest
    {
        public EventType EventType { get; set; }
        public string Content { get; set; }

        public EventRequest(EventType eventType, string content)
        {
            EventType = eventType;
            Content = content;
        }
    }

    public enum EventType
    {
        Click,
        KeyPress,
        MouseOver
    }
}
