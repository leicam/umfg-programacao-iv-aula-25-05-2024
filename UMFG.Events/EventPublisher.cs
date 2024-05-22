using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UMFG.Events
{
    internal delegate void PublisherEventHandler(string value);

    internal class EventPublisher
    {
        private string _value;
        public event PublisherEventHandler publisherEvent;

        public string Value
        {
            set
            {
                _value = value;
                publisherEvent(_value);
            }
        }

    }
}
