using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelfDirected.TimeKeeper.Models
{
    public class TaskModel : IDataModel
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }

        public int ActivityId { get; set; }

        public DateTime CreatedTimestamp { get; set; }
        
        public string Title { get; set; }

        public string Description { get; set; }

        public int TimeToCompletionHours { get; set; }

        public int TimeToCompletionMinutes { get; set; }

        public DateTime CompletedTimestamp { get; set; }

        public bool IsCompleted { get; set; }

    }
}
