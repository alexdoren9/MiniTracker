using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniTracker.Model
{
    public class Task
    {
        public Guid TaskId { get; set; }

        public string TaskName { get; set; }

        public string TaskDescription { get; set; }

        public string Background { get; set; }
    }
}
