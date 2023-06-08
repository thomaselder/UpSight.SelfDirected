using Moq;
using SelfDirected.TimeKeeper.Databases;
using SelfDirected.TimeKeeper.Models;
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelfDireccted.TimeKeeper.Tests
{
    public class TaskDatabaseTests
    {/*
        private TaskDatabase taskDatabase;
        private Mock<SQLiteAsyncConnection> mockDatabase;

        public TaskDatabaseTests()
        {
            mockDatabase = new Mock<SQLiteAsyncConnection>();
            taskDatabase = new TaskDatabase(mockDatabase.Object);

            mockDatabase.Setup(d => d.CreateTableAsync<TaskModel>(CreateFlags.None)).ReturnsAsync(new CreateTableResult());
        }

        [Fact]
        public async Task GetItemsAsync_ReturnsAllItems()
        {
            // Arrange
            var expectedItems = new List<TaskModel>
        {
            new TaskModel { Id = 1, CreatedTimestamp = DateTime.Now, Title = "Title1", Description = "Description1"},
            new TaskModel { Id = 2, CreatedTimestamp = DateTime.Now, Title = "Title2", Description = "Description2" },
            new TaskModel { Id = 3, CreatedTimestamp = DateTime.Now, Title = "Title3", Description = "Description3" }
        };

            mockDatabase.Setup(d => d.Table<TaskModel>().ToListAsync()).ReturnsAsync(expectedItems);

            // Act
            var items = await taskDatabase.GetItemsAsync();

            // Assert
            Assert.NotNull(items);
            Assert.Equal(expectedItems.Count, items.Count);
            // Add more assertions based on the expected behavior
        }
        */
    }
}
