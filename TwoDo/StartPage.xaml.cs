using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using TwoDo.Models;
using TwoDo.ViewModels;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace TwoDo
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class StartPage : Page
    {
        private StartPageViewModel _viewModel { get; }

        public StartPage()
        {
            this.InitializeComponent();

            _viewModel = new StartPageViewModel();
            PopulateTodos();
        }

        private void PopulateTodos()
        {
            _viewModel.ToDos = new List<ToDoItem>
            {
                new ToDoItem { Name = "Groceries", Expires = DateTime.Now.AddHours(5) },
                new ToDoItem { Name = "Exercise", Expires = DateTime.Now.AddHours(7) }
            };

            ToDoListView.ItemsSource = _viewModel.ToDos;
        }

        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {
            var checkbox = sender as CheckBox;
            var todo = checkbox.DataContext as ToDoItem;

            todo.Complete = checkbox.IsChecked ?? false;
        }
    }
}
