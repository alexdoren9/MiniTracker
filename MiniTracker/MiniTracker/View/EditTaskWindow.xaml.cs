using MiniTracker.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using MiniTracker.ViewModel;
using Task = MiniTracker.Model.Task;

namespace MiniTracker.View
{
    /// <summary>
    /// Логика взаимодействия для EditTaskWindow.xaml
    /// </summary>
    public partial class EditTaskWindow : Window
    {
        public EditTaskWindow(ListViewItem taskEdit)
        {
            InitializeComponent();
            DataContext = new MiniTrackerVM();
            MiniTrackerVM.SelectedTask = taskEdit;
            Task Item = (Task)taskEdit.Content;
            MiniTrackerVM.NameofTask = Item.TaskName;
            MiniTrackerVM.DescriptionofTask = Item.TaskDescription;
        }
    }
}
