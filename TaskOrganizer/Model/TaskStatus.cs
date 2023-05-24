using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskOrganizer.Model
{
    public enum TaskStatus
    {
        New = 0,
        Active = 1,
        Finished = 2,
        Paused = 3,
        Blocked = 4,
    }
}
