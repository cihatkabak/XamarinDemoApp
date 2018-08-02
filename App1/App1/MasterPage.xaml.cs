using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace App1
{
    public partial class MasterPage : ContentPage
    {
        public ListView listView { get { return lstScreens; } }

        public ObservableCollection<ClassFiles.MasterPageItem> masterpageItem { get; set; }
        public MasterPage()
        {
            

            InitializeComponent();

            masterpageItem = new ObservableCollection<ClassFiles.MasterPageItem>();
            masterpageItem.Add(new ClassFiles.MasterPageItem
            {
                Title = "Anasayfa",
                IconSource="home.png",
                TargetType = typeof(Pages.HomePage),
                
            });
            masterpageItem.Add(new ClassFiles.MasterPageItem
            {
                Title = "Hakkımızda",
                IconSource = "info.png",
                TargetType = typeof(Pages.About)
            });
            masterpageItem.Add(new ClassFiles.MasterPageItem
            {
                Title = "İletişim",
                TargetType = typeof(Pages.Contacts),
                IconSource="contact.png"
            });
            masterpageItem.Add(new ClassFiles.MasterPageItem
            {
                Title = "Giriş",
                IconSource = "test.png",
                TargetType = typeof(Pages.LoginPage)
            });
            //masterpageItem.Add(new ClassFiles.MasterPageItem
            //{
            //    Title = "Kayıt Ol",
            //    IconSource = "test.png",
            //    TargetType = typeof(Pages.SignUp)
            //});
            listView.ItemsSource = masterpageItem;
            //var MainPage = new NavigationPage(new Pages.LoginPage(masterpageItem));
        }
    }
}
