using SelfDirected.TimeKeeper.Models;
using SelfDirected.TimeKeeper.ModelWrappers;
using SelfDirected.TimeKeeper.Validators;
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
        public void InstantiateWrapper_ShouldPass()
        {
            //Arrange
            ITaskModelWrapper wrapper;
            var model = new TaskModel();
            TaskValidator validator = new TaskValidator();

            //Act
            wrapper = new TaskModelWrapper(model, validator);

            //Assert
            Assert.NotNull(wrapper);
            
        }
    }
}
