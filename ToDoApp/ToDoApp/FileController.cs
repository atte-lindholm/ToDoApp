using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoApp
{
    internal class FileController
    {
        public static List<ToDoTask> LoadFromFile(List<ToDoTask> taskList)
        {
            // Get the path to the project directory
            string projectDirectory = AppDomain.CurrentDomain.BaseDirectory;

            // Specify the file name
            string fileName = "tasks.txt";

            // Combine the project directory and file name to get the full path
            string filePath = Path.Combine(projectDirectory, fileName);

            try
            {
                if (File.Exists(filePath))
                {
                    using (StreamReader reader = new StreamReader(filePath))
                    {
                        while (!reader.EndOfStream)
                        {
                            string title = reader.ReadLine()?.Replace("Title: ", "");
                            string description = reader.ReadLine()?.Replace("Description: ", "");
                            string dueDateStr = reader.ReadLine()?.Replace("Due Date: ", "");

                            if (DateTime.TryParse(dueDateStr, out DateTime dueDate))
                            {
                                taskList.Add(new ToDoTask { TaskTitle = title, TaskDescription = description, TaskDueDate = dueDate });
                            }
                        }
                    }
                }
                return taskList;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while loading from the file: {ex.Message}");
            }
            return taskList;
        }

        public static void SaveToFile(List<ToDoTask> taskList)
        {
            // Get the path to the project directory
            string projectDirectory = AppDomain.CurrentDomain.BaseDirectory;

            // Specify the file name
            string fileName = "tasks.txt";

            // Combine the project directory and file name to get the full path
            string filePath = Path.Combine(projectDirectory, fileName);

            try
            {
                // Clear the existing content of the file
                File.WriteAllText(filePath, string.Empty);

                // Append the new tasks to the file
                using (StreamWriter writer = new StreamWriter(filePath, true))
                {
                    foreach (ToDoTask task in taskList)
                    {
                        // Write task properties to the file
                        writer.WriteLine($"Title: {task.TaskTitle}");
                        writer.WriteLine($"Description: {task.TaskDescription}");
                        writer.WriteLine($"Due Date: {task.TaskDueDate}");
                    }
                }

                MessageBox.Show("Data saved to file successfully.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while saving to the file: {ex.Message}");
            }
        }
    }
}
