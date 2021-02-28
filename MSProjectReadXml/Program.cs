using System;

namespace MSProjectReadXml
{
    static class Program
    {
        static void Main(string[] args)
        {
            ReadXmlProject readXmlProject = new ReadXmlProject();
            readXmlProject.LoadFile(@"Resources\Demo.xml");
            Project project = readXmlProject.Deserialize();

            project.Tasks.ForEach(task =>
            {
                Console.WriteLine($"Task: {task.Name}");
            });
        }
    }
}
