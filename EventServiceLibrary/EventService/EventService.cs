using System;
using System.Diagnostics;

namespace EventServiceLibrary
{
    public class EventService : IEventService
    {
        public void WriteMessage(string message)
        {
            try
            {
                if(!EventLog.SourceExists("EventSource"))
                {
                    EventLog.CreateEventSource("EventSource", "eventLogName");
                }
                // Create an EventLog instance and assign its source.
                EventLog myLog = new EventLog
                {
                    Source = "EventSource"
                };

                // Write an informational entry to the event log.    
                myLog.WriteEntry(message, EventLogEntryType.Error, 10000, 12, null);
                    }
            catch(Exception ex)
            {
                throw ex;
            }
        }
    }
}
