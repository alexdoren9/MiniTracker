using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MiniTracker.Model.Data;
using System.Windows.Media;

namespace MiniTracker.Model
{
    public static class DataMethod
    {
        /* метод по созданию задачи*/

        public static string CreateTask(string name, string description)
        {
            string result = "Задача уже существует";
            using(MiniTrackerContext db = new MiniTrackerContext())
            {
                /*проверка на наличие задачи*/
                bool checkIsExist = db.Tasks.Any(item => item.TaskName == name);
                if (!checkIsExist)
                {
                    Task newTask = new Task { TaskName = name, TaskDescription = description , Background = "White" };
                    db.Tasks.Add(newTask);
                    db.SaveChanges();
                    result = "Задача добавлена";
                }
                return result;
            }
        }

        /* метод по удалению задачи*/

        public static string DeleteTask(Task task)
        {
            string result = "Данная задача отсутствует";
            using(MiniTrackerContext db = new MiniTrackerContext())
            {
                db.Tasks.Remove(task);
                db.SaveChanges();
                result = "Задача '" + task.TaskName + "' удалена.";
            }
            return result;
        }

        /* метод по редактированию задачи*/

        public static string EditTask(Task oldTask, string newTaskName, string newTaskDescription)
        {
            string result = "Правки не внесены";
            using (MiniTrackerContext db = new MiniTrackerContext())
            {
                Task task = db.Tasks.FirstOrDefault(item => item.TaskId == oldTask.TaskId);
                task.TaskName = newTaskName;
                task.TaskDescription = newTaskDescription;
                db.SaveChanges();
                result = "Задача отредактирована";
            }
            return result;
        }

        /*метод по отметке о решении задачи*/

        public static string DecisionTask(Task Task, string newBackground)
        {
            string result = "Задача не решена";
            using (MiniTrackerContext db = new MiniTrackerContext())
            {
                Task task = db.Tasks.FirstOrDefault(item => item.TaskId == Task.TaskId);
                task.Background = newBackground;
                db.SaveChanges();
                result = "Задача решена!";
            }
            return result;
        }

        /*отобразить список всех задач*/

        public static List<Task> GetAllTasks()
        {
            using (MiniTrackerContext db = new MiniTrackerContext())
            {
                var result = db.Tasks.ToList();
                return result;
            }
        }

        /*изменение цвета фона у решенной задачи*/

        public static List<System.Windows.Controls.ListViewItem> GetAllTItems()
        {

            using (MiniTrackerContext db = new MiniTrackerContext())
            {
                var resultItems = new List<System.Windows.Controls.ListViewItem>();
                var tasks = db.Tasks.ToList();
                foreach (var task in tasks)
                {
                    System.Windows.Controls.ListViewItem Item = new System.Windows.Controls.ListViewItem();
                    Item.Background = (SolidColorBrush)new BrushConverter().ConvertFromString(task.Background);
                    Item.Content = task;
                    resultItems.Add(Item);
                }
                return resultItems;
            }
        }
    }
}
