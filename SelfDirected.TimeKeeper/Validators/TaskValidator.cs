using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;
using SelfDirected.TimeKeeper.Models;

namespace SelfDirected.TimeKeeper.Validators
{
    public class TaskValidator : AbstractValidator<TaskModel>
    {
        public TaskValidator() 
        {
            RuleFor(task => task.Title).NotEmpty();
            RuleFor(task => task.TimeToCompletionHours).GreaterThan(0).When(task => task.TimeToCompletionMinutes.Equals(0));
            RuleFor(task => task.TimeToCompletionMinutes).GreaterThan(0).When(task => task.TimeToCompletionHours.Equals(0));
            RuleFor(task => task.CreatedTimestamp).NotEmpty();
        }
    }
}
