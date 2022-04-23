using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SinemaCepte.Views
{
    public partial class AboutPage : ContentPage
    {
        public AboutPage()
        {
            InitializeComponent();
            Tickets = GetTickets();
            this.BindingContext = this;
        }
        public ObservableCollection<Ticket> Tickets { get; set; }
        public Ticket SelectedTicket { get; set; }

        private ObservableCollection<Ticket> GetTickets()
        {
            return new ObservableCollection<Ticket>
            {
                new Ticket { MovieTitle = "Bad Boys For LIfe", Image = "https://m.media-amazon.com/images/M/MV5BMWU0MGYwZWQtMzcwYS00NWVhLTlkZTAtYWVjOTYwZTBhZTBiXkEyXkFqcGdeQXVyMTkxNjUyNQ@@._V1_.jpg", ShowingDate = DateTime.Now.AddDays(15), Seats = new int[] { 61, 62, 63 } },
                new Ticket { MovieTitle = "The Old Guard", Image = "https://m.media-amazon.com/images/M/MV5BNDJiZDliZDAtMjc5Yy00MzVhLThkY2MtNDYwNTQ2ZTM5MDcxXkEyXkFqcGdeQXVyMDA4NzMyOA@@._V1_.jpg", ShowingDate = DateTime.Now.AddDays(22), Seats = new int[] { 111, 112 } },
                new Ticket { MovieTitle = "Tenet", Image = "https://upload.wikimedia.org/wikipedia/tr/thumb/2/20/Tenet_filminin_g%C3%BCncel_T%C3%BCrk%C3%A7e_afi%C5%9Fi.jpg/220px-Tenet_filminin_g%C3%BCncel_T%C3%BCrk%C3%A7e_afi%C5%9Fi.jpg", ShowingDate = DateTime.Now.AddDays(25), Seats = new int[] { 12, 25, 35 } },
                new Ticket { MovieTitle = "No Time To Die", Image = "https://i.haberglobal.com.tr/storage/icerik/2020/06/08/yeni-bond-filmi-no-time-to-die-da-seyirciyi-hangi-surpriz-bekliyor_5ede2e3c79ce6.jpg", ShowingDate = DateTime.Now.AddDays(20), Seats = new int[] { 99 } }
            };
        }

        private void TicketSelected(object sender, SelectionChangedEventArgs e)
        {
            if (e.CurrentSelection != null)
            {
                //this.Navigation.PushAsync(new SeatsPage(SelectedTicket));
            }
        }
    }
    public class Ticket
    {
        public string MovieTitle { get; set; }
        public DateTime ShowingDate { get; set; }
        public string Image { get; set; }
        public int[] Seats { get; set; }
    }
}