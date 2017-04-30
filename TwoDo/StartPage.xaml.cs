using System;
using System.Collections.Generic;
using System.Linq;
using TwoDo.Data;
using TwoDo.StandardLib.Models;
using TwoDo.StandardLib.ViewModels;
using Windows.UI.Xaml.Controls;

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
      SeedDB();
      PopulateTodos();
    }

    private void SeedDB()
    {
      var todos = new List<ToDoItem>
            {
                new ToDoItem { Name = "Groceries", Created = DateTime.Now, Expires = DateTime.Now.AddHours(5) },
                new ToDoItem { Name = "Exercise", Created = DateTime.Now, Expires = DateTime.Now.AddHours(7) }
            };

      using (var db = new TwoDoContext())
      {
        db.ToDos.AddRange(todos);
        db.SaveChanges();
      }
    }

    private void PopulateTodos()
    {
      using (var db = new TwoDoContext())
      {
        var todos = db.ToDos.ToList();
        ToDoListView.ItemsSource = todos;
      }
    }
  }
}
