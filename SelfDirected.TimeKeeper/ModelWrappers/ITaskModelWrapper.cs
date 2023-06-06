using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelfDirected.TimeKeeper.ModelWrappers
{
    public interface ITaskModelWrapper
    {
        int Id { get; set; }
        int ActivityId { get; set; }
        DateTime CreatedTimestamp { get; set; }
        string Title { get; set; }
        string Description { get; set; }
        int TimeToCompletionHours { get; set; }
        int TimeToCompletionMinutes { get; set; }
        DateTime CompletedTimestamp { get; set; }
        bool IsCompleted { get; set; }
        bool IsValid { get; }
    }
}
