using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ListViewGroup
{
    public partial class MainPage : ContentPage
    {
        List<City> listCities;

        void InitCity(string nameCountry)
        {
            listCities = new List<City>();


            listCities.Add(new City {id = "1", name = "Hà Nội", image = "hanoi.jpg" ,nameCountry="Việt Nam"});
            listCities.Add(new City { id = "2", name = "Hồ Chí Minh", image = "hcm.jpg" , nameCountry = "Việt Nam" });
            listCities.Add(new City { id = "3", name = "Đà Nẵng", image = "dn.jpg" , nameCountry = "Việt Nam" });



            listCities.Add(new City { id = "4", name = "Seoul", image = "hq1.jpg", nameCountry = "Hàn Quốc" });
            listCities.Add(new City { id = "5", name = "Busan", image = "hq2.jpg" , nameCountry = "Hàn Quốc" });


            listCities.Add(new City { id = "4", name = "Sydney", image = "uc1.jpg", nameCountry = "Úc" });
            listCities.Add(new City { id = "5", name = "Melbourne", image = "uc2.jpg", nameCountry = "Úc" });


            listCities.Add(new City { id = "4", name = "Liverpool", image = "anh1.jpg", nameCountry = "Anh Quốc" });
            listCities.Add(new City { id = "5", name = "Manchester", image = "anh2.jpg", nameCountry = "Anh Quốc" });


            if (nameCountry == "Tất cả" || nameCountry == "")
            {
                listcity.ItemsSource = listCities;
            }
            else
            {
                List<City> listcitySelected;
                listcitySelected = new List<City>();
                foreach (City city in listCities)
                {
                    if (nameCountry == city.nameCountry)
                    {
                        listcitySelected.Add(city);
                    }
                }
                listcity.ItemsSource = listcitySelected;
            }

            
        }
        public MainPage()
        {
            InitializeComponent();
            pickCountry.ItemsSource = new string[] { "Tất cả", "Việt Nam", "Hàn Quốc", "Úc", "Anh Quốc" };
            InitCity(nameCountry:"");

            
        }

        private void pickCountry_SelectedIndexChanged(object sender, EventArgs e)
        {
            var pickerCountry = (Picker)sender;

            int index = pickCountry.SelectedIndex;
            if (index >= 0)
            {
                string nameCountry = pickCountry.Items[index].ToString();
                InitCity(nameCountry:nameCountry);
            }
        }
    }
}
