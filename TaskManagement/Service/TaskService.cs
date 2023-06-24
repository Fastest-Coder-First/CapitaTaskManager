
//create static class to read data from file
using TaskManagement.Models;

namespace TaskManagement.Service
{
    public class TaskService
    {
        private static List<CapTask> tasks = new List<CapTask>();

        //add some data to the list
        static TaskService()
        {
            tasks.Add(new CapTask()
            {
                Id = 1,
                TaskName = "Task 1",
                TaskDescription = "Task 1 Description",
                TaskDueDate = DateTime.Now.AddDays(1),
                TaskStatus = "New"
            });

            tasks.Add(new CapTask()
            {
                Id = 2,
                TaskName = "Task 2",
                TaskDescription = "Task 2 Description",
                TaskDueDate = DateTime.Now.AddDays(2),
                TaskStatus = "New"
            });

            tasks.Add(new CapTask()
            {
                Id = 3,
                TaskName = "Task 3",
                TaskDescription = "Task 3 Description",
                TaskDueDate = DateTime.Now.AddDays(3),
                TaskStatus = "New"
            });
        }

        //create a method to add task to the list
        public static void AddTask(CapTask task)
        {
            tasks.Add(task);
        }

        //remove task from the list
        public static void RemoveTask(CapTask task)
        {
            tasks.Remove(task);
        }

        //return the list of tasks
        public static List<CapTask> GetTasks()
        {
            return tasks;
        }

        //update the task
        public static void UpdateTask(CapTask task)
        {
            tasks.Remove(tasks.Find(t => t.Id == task.Id));
            tasks.Add(task);
        }
    }
}
