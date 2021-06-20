using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using TodoREST.Data;

namespace TodoREST
{
    public partial class App : Application
    {
        public static TodoItemManager TodoManager { get; private set; }

        public App()
        {
            InitializeComponent();
            TodoManager = new TodoItemManager(new RestService());
            MainPage = new NavigationPage(new Views.TodoListPage());
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
