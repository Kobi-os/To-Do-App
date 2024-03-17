using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace todoapp
{
    internal class Task
    {

        public string TaskName { get; set; }
        public string TaskDescription { get; set; }

        public int Id { get; set; }

        public Task(int id, string taskName, string taskDescription)
        {
            this.Id = id;
            this.TaskName = taskName;
            this.TaskDescription = taskDescription;

        }


    }
}
