using Xamarin.Forms;
using ProjetIncident.Core.ViewModel;
using System;

namespace ProjetIncident
{
    public partial class ProjetIncidentPage : ContentPage
    {

        public ProjetIncidentPage()
        {
            this.BindingContext = new Core.ViewModel.ProjetIncidentViewModel();
            ((Core.ViewModel.ProjetIncidentViewModel)BindingContext).MonTexte = "Welcome ";
            InitializeComponent();
        }
        void Handle_Clicked(object sender, System.EventArgs e)
        {
            ((Core.ViewModel.ProjetIncidentViewModel)BindingContext).MonTexte = "After click";
        }

        void Handle_Ajout(object sender, System.EventArgs e)
        {
            ((ProjetIncidentViewModel)BindingContext).MaListe.Add("New élément");
        }

        void Handle_Sup(object sender, System.EventArgs e)
        {
            ((ProjetIncidentViewModel)BindingContext).MaListe.Remove(((ProjetIncidentViewModel)BindingContext).MaSelection);
        }
		public async void Back_Clicked(object sender, EventArgs e)
		{
			await Navigation.PopAsync();
		}
	}
}