using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Realization
{
    public class Task
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime startDate { get; set; }
        public DateTime endDate { get; set; }
        public State state { get; set; }
    }
    public enum State
    { 
    Open,
    InProgress,
    Close
    }
    public class Tasks
    {
        List<Task> Task = new List<Task>();
        public void AddTask(Task t) { }
    }
}
