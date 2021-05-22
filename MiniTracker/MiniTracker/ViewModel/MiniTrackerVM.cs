using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MiniTracker.Model;
using MiniTracker.View;
using MiniTracker.Model.Data;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace MiniTracker.ViewModel
{
    public class MiniTrackerVM : INotifyPropertyChanged
    {
        /*задачи*/

        #region

        private List<MiniTracker.Model.Task> allTasks = DataMethod.GetAllTasks();

        public List<MiniTracker.Model.Task> AllTasks
        {
            get { return allTasks; }
            set
            {
                allTasks = value;
                NotifyPropertyChanged("AllTasks");
            }
        }

        private List<ListViewItem> ITEMS = DataMethod.GetAllTItems();

        public List<ListViewItem> AllItems
        {
            get { return ITEMS; }
            set
            {
                ITEMS = value;
                NotifyPropertyChanged("AllTasks");
            }
        }

        

        #endregion

        /*свойства задачи*/

        #region

        public static string NameofTask { get; set; }

        public static string DescriptionofTask { get; set; }

        public static string Background { get; set; }

        #endregion

        /*свойство выделенной задачи*/

        #region

        public static ListViewItem SelectedTask { get; set; }

        #endregion

        /*создание задачи*/

        #region

        private RelayCommand addTask;
        public RelayCommand AddTask
        {
            get
            {
                return addTask ?? new RelayCommand(obj =>
                {
                    Window window = obj as Window;
                    string resultStr = "";
                    if (NameofTask == null || NameofTask.Replace(" ", "").Length == 0)
                    {
                        if (DescriptionofTask == null || DescriptionofTask.Replace(" ", "").Length == 0)
                        {
                            SetBlockControl(window, "TaskDescriptionBlock");
                        }
                        SetBlockControl(window, "TaskNameBlock");
                    }
                    else
                    {
                        resultStr = DataMethod.CreateTask(NameofTask, DescriptionofTask);
                        ShowMessage(resultStr);
                        UpdateAllTasksView();
                        NameofTask = "";
                        DescriptionofTask = "";
                        window.Close();
                    }
                }
                );
            }
        }

        #endregion

        /*удаление задачи*/

        #region

        private RelayCommand deleteTask;
        public RelayCommand DeleteTask
        {
            get
            {
                return deleteTask ?? new RelayCommand(obj =>
                {
                    string resultStr = "Задача не выбрана. Необходимо выбрать задачу";
                    if (SelectedTask != null)
                    {
                        resultStr = DataMethod.DeleteTask((Model.Task)SelectedTask.Content);
                        UpdateAllTasksView();
                    }
                    SetNullValuesToProperties();
                    ShowMessage(resultStr);
                }
                );
            }
        }

        #endregion

        /*редактирование задачи*/

        #region

        private RelayCommand editTask;

        public RelayCommand EditTask
        {
            get
            {
                return editTask ?? new RelayCommand(obj =>
                {
                    Window window = obj as Window;
                    string resultStr = "Задача не выбрана. Необходимо выбрать задачу";
                    if (SelectedTask != null)
                    {
                        resultStr = DataMethod.EditTask((Model.Task)SelectedTask.Content, NameofTask, DescriptionofTask);

                        UpdateAllTasksView();
                        SetNullValuesToProperties();
                        ShowMessage(resultStr);
                        window.Close();
                    }
                    else
                    {
                        ShowMessage(resultStr);
                    }
                }
                );
            }
        }

        #endregion

        /*отметка о решении задачи*/

        #region
        
        private RelayCommand decisionTask;

        public RelayCommand DecisionTask
        {
            get
            {
                return decisionTask ?? new RelayCommand(obj =>
                {
                    string resultStr = "Задача не выбрана. Необходимо выбрать задачу";
                    if (SelectedTask != null)
                    {
                        resultStr = DataMethod.DecisionTask((Model.Task)SelectedTask.Content, "Green");
                        
                        UpdateAllTasksView();
                        SetNullValuesToProperties();
                        ShowMessage(resultStr);
                    }
                    else
                    {
                        ShowMessage(resultStr);
                    }
                }
                );
            }
        }
        
        #endregion

        /*команды на открытие окон*/

        #region

        private RelayCommand openAddTaskWindow;
        public RelayCommand OpenAddTaskWindow
        {
            get
            {
                return openAddTaskWindow ?? new RelayCommand(obj => { OpenAddTaskWindowMethod(); });
            }
        }

        private RelayCommand openEditTaskWindow;
        public RelayCommand OpenEditTaskWindow
        {
            get
            {
                return openEditTaskWindow ?? new RelayCommand(obj =>
                {
                    if (SelectedTask != null)
                    {
                        OpenEditTaskWindowMethod(SelectedTask);
                    }
                }
                );
            }
        }

        #endregion

        /*методы на открытие окон*/

        #region
        private void OpenAddTaskWindowMethod()
        {
            AddTaskWindow newTaskWindow = new AddTaskWindow();
            newTaskWindow.Owner = Application.Current.MainWindow;
            newTaskWindow.WindowStartupLocation = WindowStartupLocation.CenterOwner;
            newTaskWindow.ShowDialog();
        }

        private void OpenEditTaskWindowMethod(ListViewItem task)
        {
            EditTaskWindow editTaskWindow = new EditTaskWindow(task);
            editTaskWindow.Owner = Application.Current.MainWindow;
            editTaskWindow.WindowStartupLocation = WindowStartupLocation.CenterOwner;
            editTaskWindow.ShowDialog();
        }

        #endregion

        /*команда на выделение красным пустой области, необходимой для заполнения*/

        #region

        private void SetBlockControl(Window window, string blockName)
        {
            Control block = window.FindName(blockName) as Control;
            block.BorderBrush = Brushes.Red;
        }

        #endregion

        /*обновление данных*/

        #region

        private void SetNullValuesToProperties()
        {
            NameofTask = null;
            DescriptionofTask = null;
        }
 
        private void UpdateAllTasksView()
        {
            AllTasks = DataMethod.GetAllTasks();
            MainWindow.AllTasksView.ItemsSource = null;
            MainWindow.AllTasksView.Items.Clear();
            ITEMS.Clear();
            foreach (var task in AllTasks)
            {
                ListViewItem Item = new ListViewItem();
                Item.Background = (SolidColorBrush)new BrushConverter().ConvertFromString(task.Background);
                Item.Content =  task;
                ITEMS.Add(Item);
                MainWindow.AllTasksView.ItemsSource = ITEMS;
            }
            MainWindow.AllTasksView.Items.Refresh();
        }
        #endregion

        /*метод вызова диалогового окна*/

        #region

        private void ShowMessage(string message)
        {
            MessageWindow messageWindow = new MessageWindow(message);
            messageWindow.Owner = Application.Current.MainWindow;
            messageWindow.WindowStartupLocation = WindowStartupLocation.CenterOwner;
            messageWindow.ShowDialog();
        }

        #endregion

        /*реализация интерфейса*/

        #region

        public event PropertyChangedEventHandler PropertyChanged;

        private void NotifyPropertyChanged(String propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        #endregion
    }
}
