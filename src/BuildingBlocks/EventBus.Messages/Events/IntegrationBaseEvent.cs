using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventBus.Messages.Events
{
    public class IntegrationBaseEvent
    {
        public IntegrationBaseEvent()
        {
            Id= Guid.NewGuid();
            creationDate= DateTime.Now;
        }

        public IntegrationBaseEvent(Guid id, DateTime creationDate)
        {
            Id = id;
            this.creationDate = creationDate;
        }

        public Guid Id { get; set; }
        public DateTime creationDate { get; set; }
    }
}
