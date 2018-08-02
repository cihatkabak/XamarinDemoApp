using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using App1.Pages;
using Xamarin.Forms;

namespace App1
{
    public partial class MainPage : MasterDetailPage
    {
        public MainPage()
        {
            InitializeComponent();
           /* MasterBehavior = MasterBehavior.Popover;*///new
            MasterPage.listView.ItemSelected += OnItemSelected;
            Master = MasterPage;
            NavigationPage page = new NavigationPage(new Pages.HomePage(MasterPage.masterpageItem)) { BarBackgroundColor = Color.FromHex("#008AFF") };
            
            Detail = page;
        }

        private void OnItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            
            var item = e.SelectedItem as ClassFiles.MasterPageItem;
            if (item != null)
            {
                Page displayPage = (Page)Activator.CreateInstance(item.TargetType);
                NavigationPage page = new NavigationPage(displayPage) { BarBackgroundColor = Color.FromHex("#008AFF") };
                Detail = page;

                MasterPage.listView.SelectedItem = null;
                IsPresented = false;
            }
        }
    }
}
