namespace todoapp
{
    internal class Program
    {
        static List<Task> AllTasks = new List<Task>();

        public static void Main(string[] args)
        {
            AddTask(1, "Posprzątać pokój", "poodkurzać");
            ShowAllTasks();
        }

        public static void AddTask(int id, string taskName, string taskDescription)
        {
            Task newTask = new Task(id, taskName, taskDescription);
            AllTasks.Add(newTask);
        }
        /*
                public void AddTaskDescription()
                {

                }

                public void RemoveTask()
                {

                }*/

        public static void ShowAllTasks()
        {
            foreach (var task in AllTasks)
            {
                Console.WriteLine($"Id {task.Id} Nazwa {task.TaskName} Opis {task.TaskDescription}");
            }
        }
    }
}