using SinemaCepte.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace SinemaCepte.ViewModels
{
    public class NewItemViewModel : BaseViewModel
    {
        private string movieName;
        private string movieDescription;
        private string movieImageLocation;
        private string movieDateTime;

        public NewItemViewModel()
        {
            SaveCommand = new Command(OnSave, ValidateSave);
            CancelCommand = new Command(OnCancel);
            this.PropertyChanged +=
                (_, __) => SaveCommand.ChangeCanExecute();
        }

        private bool ValidateSave()
        {
            return !String.IsNullOrWhiteSpace(movieName)
                && !String.IsNullOrWhiteSpace(movieDescription)
                && !String.IsNullOrWhiteSpace(movieImageLocation)
                 && !String.IsNullOrWhiteSpace(movieDateTime);
        }

        public string MovieName
        {
            get => movieName;
            set => SetProperty(ref movieName, value);
        }
        public string MovieDescription
        {
            get => movieDescription;
            set => SetProperty(ref movieDescription, value);
        }
        public string MovieImageLocation
        {
            get => movieImageLocation;
            set => SetProperty(ref movieImageLocation, value);
        }

        public string MovieDateTime
        {
            get => movieDateTime;
            set => SetProperty(ref movieDateTime, value);
        }

        public Command SaveCommand { get; }
        public Command CancelCommand { get; }

        private async void OnCancel()
        {
            // This will pop the current page off the navigation stack
            await Shell.Current.GoToAsync("..");
        }

        private async void OnSave()
        {
            Bilet newItem = new Bilet()
            {
                MovieTitle = MovieDescription,

                Image = MovieImageLocation,
            };

            await DataStore.AddItemAsync(newItem);

            // This will pop the current page off the navigation stack
            await Shell.Current.GoToAsync("..");
        }
    }
}
