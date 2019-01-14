using System;
using System.Collections.Generic;
using Xamarin.Forms;


namespace MotiveMe
{
    public partial class MSPage : MasterDetailPage
    {
        public List<MasterPageItem> MenuList { get; set; }

        public MSPage()
        {
            
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);

            MenuList = new List<MasterPageItem>();

            // Creating our pages for menu navigation
            // Here you can define title for item, 
            // icon on the left side, and page that you want to open after selection
            var page1 = new MasterPageItem() { Title = "WelcomePage", TargetType = typeof(WelcomePage) };
            var page2 = new MasterPageItem() { Title = "NotePage", TargetType = typeof(NotePage) };
            var page3 = new MasterPageItem() { Title = "Activity Logs ", TargetType = typeof(ActivityLogsPage) };
            var page4 = new MasterPageItem() { Title = "Alarms", TargetType = typeof(Alarms) };

            // Adding menu items to menuList
            MenuList.Add(page1);
            MenuList.Add(page2);
            MenuList.Add(page3);
            MenuList.Add(page4);


            // Setting our list to be ItemSource for ListView in MainPage.xaml
            navigationDrawerList.ItemsSource = MenuList;

            // Initial navigation, this can be used for our home page
            Detail = new NavigationPage((Page)Activator.CreateInstance(typeof(WelcomePage)));

        }

        void OnMenuItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem is MasterPageItem item)
            {
                Detail = new NavigationPage((Page)Activator.CreateInstance(item.TargetType));
                // masterPage.listView.SelectedItem = null;
                IsPresented = false;
            }
        }
    }
}