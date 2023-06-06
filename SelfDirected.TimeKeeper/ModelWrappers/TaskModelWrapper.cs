using FluentValidation;
using SelfDirected.TimeKeeper.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelfDirected.TimeKeeper.ModelWrappers
{
    public class TaskModelWrapper : ITaskModelWrapper
    {
        private readonly TaskModel taskModel;
        private readonly IValidator<TaskModel> validator;

        public TaskModelWrapper(TaskModel taskModel, IValidator<TaskModel> validator)
        {
            this.taskModel = taskModel;
            this.validator = validator;
        }

        public int Id
        {
            get => taskModel.Id;
            set
            {
                taskModel.Id = value;
                Validate();
            }
        }

        public int ActivityId
        {
            get => taskModel.ActivityId;
            set
            {
                taskModel.ActivityId = value;
                Validate();
            }
        }

        public DateTime CreatedTimestamp
        {
            get => taskModel.CreatedTimestamp;
            set
            {
                taskModel.CreatedTimestamp = value;
                Validate();
            }
        }

        public string Title
        {
            get => taskModel.Title;
            set
            {
                taskModel.Title = value;
                Validate();
            }
        }

        public string Description
        {
            get => taskModel.Description;
            set
            {
                taskModel.Description = value;
                Validate();
            }
        }

        public int TimeToCompletionHours
        {
            get => taskModel.TimeToCompletionHours;
            set
            {
                taskModel.TimeToCompletionHours = value;
                Validate();
            }
        }

        public int TimeToCompletionMinutes
        {
            get => taskModel.TimeToCompletionMinutes;
            set
            {
                taskModel.TimeToCompletionMinutes = value;
                Validate();
            }
        }

        public DateTime CompletedTimestamp
        {
            get => taskModel.CompletedTimestamp;
            set
            {
                taskModel.CompletedTimestamp = value;
                Validate();
            }
        }

        public bool IsCompleted
        {
            get => taskModel.IsCompleted;
            set
            {
                taskModel.IsCompleted = value;
                Validate();
            }
        }

        public bool IsValid => validator.Validate(taskModel).IsValid;

        private void Validate()
        {
            validator.ValidateAndThrow(taskModel);
        }
    }
}

