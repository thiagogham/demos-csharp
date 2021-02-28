using System;
using Xunit;

namespace MSProjectReadXml.Test
{
    public class MSProjectReadXmlTests
    {
        private readonly ReadXmlProject _readXmlProject;

        public MSProjectReadXmlTests()
        {
            _readXmlProject = new ReadXmlProject();
        }

        void LoadFile() => _readXmlProject.LoadFile(@"Resources\Demo.xml");
        Project Deserialize() => _readXmlProject.Deserialize();

        [Fact]
        public void should_project_contain_tasks()
        {
            //Arrange 
            LoadFile();

            //Act  
            var project = Deserialize();

            //Assert
            Assert.NotEmpty(project.Tasks);
        }

        [Fact]
        public void should_project_contain_calendars()
        {
            //Arrange 
            LoadFile();

            //Act  
            var project = Deserialize();

            //Assert
            Assert.NotEmpty(project.Calendars);
        }

        [Fact]
        public void should_project_contain_task_with_datetime()
        {
            //Arrange 
            LoadFile();

            //Act  
            var project = Deserialize();

            //Assert
            Assert.Contains(project.Tasks, task => task.Start.Equals(DateTime.Parse("2021-01-01T08:00:00")));
        }
    }
}
