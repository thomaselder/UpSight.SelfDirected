using SelfDirected.TimeKeeper.Models;
using SelfDirected.TimeKeeper.ModelWrappers;
using SelfDirected.TimeKeeper.Validators;
using Moq;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;


namespace SelfDireccted.TimeKeeper.Tests
{
    public class TaskModelWrapperTests
    {
        [Fact]
        public void Constructor_ValidatesTaskModel()
        {
            // Arrange
            var taskModel = new TaskModel();
            var validatorMock = new Mock<IValidator<TaskModel>>();
            validatorMock.Setup(v => v.Validate(taskModel)).Returns(new FluentValidation.Results.ValidationResult());

            // Act
            var wrapper = new TaskModelWrapper(taskModel, validatorMock.Object);

            // Assert
            validatorMock.Verify(v => v.Validate(taskModel), Times.Once);
        }

    

        [Fact]
        public void Validate_ValidatesTaskModel()
        {
            // Arrange
            var taskModel = new TaskModel();
            var validatorMock = new Mock<IValidator<TaskModel>>();
            validatorMock.Setup(v => v.Validate(taskModel)).Returns(new FluentValidation.Results.ValidationResult());
            var wrapper = new TaskModelWrapper(taskModel, validatorMock.Object);

            // Act
            wrapper.Validate();

            // Assert
            validatorMock.Verify(v => v.Validate(taskModel), Times.Once);
        }

        [Fact]
        public void IsValid_ReturnsTrue_WhenTaskModelIsValid()
        {
            // Arrange
            var taskModel = new TaskModel();
            var validatorMock = new Mock<IValidator<TaskModel>>();
            validatorMock.Setup(v => v.Validate(taskModel)).Returns(new FluentValidation.Results.ValidationResult());
            var wrapper = new TaskModelWrapper(taskModel, validatorMock.Object);

            // Act
            var isValid = wrapper.IsValid;

            // Assert
            Assert.True(isValid);
        }

        [Fact]
        public void IsValid_ReturnsFalse_WhenTaskModelIsInvalid()
        {
            // Arrange
            var taskModel = new TaskModel();
            var validationResult = new FluentValidation.Results.ValidationResult(new[]
            {
            new FluentValidation.Results.ValidationFailure("Title", "Title is required.")
        });
            var validatorMock = new Mock<IValidator<TaskModel>>();
            validatorMock.Setup(v => v.Validate(taskModel)).Returns(validationResult);
            var wrapper = new TaskModelWrapper(taskModel, validatorMock.Object);

            // Act
            var isValid = wrapper.IsValid;

            // Assert
            Assert.False(isValid);
        
        }
    }
}
