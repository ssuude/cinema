using SinemaCepte.Models;
using SinemaCepte.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SinemaCepte.Views
{
    public partial class NewItemPage : ContentPage
    {
        public Bilet Item { get; set; }

        public NewItemPage()
        {
            InitializeComponent();
            BindingContext = new NewItemViewModel();
        }
    }
}