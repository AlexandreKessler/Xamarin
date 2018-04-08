using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace ProjetIncident.Core.View
{
    public partial class CreateAccount : ContentPage
    {
		List<Member> member;
        public CreateAccount()
		{
			member = new List<Member>();
			InitializeComponent();
		}
		public void OnSave(object o, EventArgs e)
		{
			member.Add(new Member(
									FirstName.Text,
									LastName.Text,
									SetDateTime(
										Date.Date,
										Time.Time.Hours,
										Time.Time.Minutes,
										Time.Time.Seconds
									)
								)
						);

		}

		public async void OnView(object o, EventArgs e)
		{
            await DisplayAlert("Members", member[0].FirstName + "," + member[0].LastName + "," + member[0].DateTime, "Cancel");
		}

        public async void Next_Page(object o, EventArgs e)
        {
            await Navigation.PushAsync(new ProjetIncidentPage());
        }

        private DateTime SetDateTime(DateTime date, int hour, int minute, int seconds)
		{
			return new DateTime(date.Year, date.Month, date.Day, hour, minute, seconds);
		}
	}

}
