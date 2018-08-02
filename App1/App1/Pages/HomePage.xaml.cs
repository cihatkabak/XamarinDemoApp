using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App1.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class HomePage : ContentPage
    {
        int counter = 0;
        int counter2 = 0;
        int counter3 = 0;
        int counter4 = 0;
        int counter5 = 0;

        public HomePage()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, true);



        }
        ObservableCollection<ClassFiles.MasterPageItem> _masteritem { get; set; }
        public HomePage(ObservableCollection<ClassFiles.MasterPageItem> masteritem)
        {

            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, true); //title bar

            _masteritem = masteritem;

        }
        async void OnImageNameTapped(object sender, EventArgs args)
        {
            
            var answer = await DisplayAlert("Rezerve Ekranı", "Bu Ürünü Rezerve Etmek İstiyor musunuz ?", "Rezerve Et", "Vazgeç");
            if(answer==true&& counter==0)
            {               
                await DisplayAlert("Rezerve Ekranı", "Ürün Rezerve Edilmiştir.", "Kapat");
                counter++;
            }
            else if(answer == true && counter == 1)
            {
                await DisplayAlert("Uyarı", "Ürün Zaten Rezerve Edildi!", "Kapat");
            }
            
            
        }
        async void OnImageNameTapped2(object sender, EventArgs args)
        {

            var answer = await DisplayAlert("Rezerve Ekranı", "Bu Ürünü Rezerve Etmek İstiyor musunuz ?", "Rezerve Et", "Vazgeç");
            if (answer == true && counter2 == 0)
            {
                await DisplayAlert("Rezerve Ekranı", "Ürün Rezerve Edilmiştir.", "Kapat");
                counter2++;
            }
            else if (answer == true && counter2 == 1)
            {
                await DisplayAlert("Uyarı", "Ürün Zaten Rezerve Edildi!", "Kapat");
            }


        }
        async void OnImageNameTapped3(object sender, EventArgs args)
        {

            var answer = await DisplayAlert("Rezerve Ekranı", "Bu Ürünü Rezerve Etmek İstiyor musunuz ?", "Rezerve Et", "Vazgeç");
            if (answer == true && counter3 == 0)
            {
                await DisplayAlert("Rezerve Ekranı", "Ürün Rezerve Edilmiştir.", "Kapat");
                counter3++;
            }
            else if (answer == true && counter3 == 1)
            {
                await DisplayAlert("Uyarı", "Ürün Zaten Rezerve Edildi!", "Kapat");
            }


        }
        async void OnImageNameTapped4(object sender, EventArgs args)
        {

            var answer = await DisplayAlert("Rezerve Ekranı", "Bu Ürünü Rezerve Etmek İstiyor musunuz ?", "Rezerve Et", "Vazgeç");
            if (answer == true && counter4 == 0)
            {
                await DisplayAlert("Rezerve Ekranı", "Ürün Rezerve Edilmiştir.", "Kapat");
                counter4++;
            }
            else if (answer == true && counter4 == 1)
            {
                await DisplayAlert("Uyarı", "Ürün Zaten Rezerve Edildi!", "Kapat");
            }


        }
        async void OnImageNameTapped5(object sender, EventArgs args)
        {

            var answer = await DisplayAlert("Rezerve Ekranı", "Bu Ürünü Rezerve Etmek İstiyor musunuz ?", "Rezerve Et", "Vazgeç");
            if (answer == true && counter5 == 0)
            {
                await DisplayAlert("Rezerve Ekranı", "Ürün Rezerve Edilmiştir.", "Kapat");
                counter5++;
            }
            else if (answer == true && counter5 == 1)
            {
                await DisplayAlert("Uyarı", "Ürün Zaten Rezerve Edildi!", "Kapat");
            }


        }

    }
}