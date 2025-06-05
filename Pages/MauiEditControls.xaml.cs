

using System.Threading.Tasks;

namespace MauiControls.Pages;

public partial class MauiEditControls : ContentPage
{
    public MauiEditControls()
    {
        InitializeComponent();
        //define the binging context for the page
        this.BindingContext = this;
        this.IsBusy = false;
        BtnLogin.Clicked += BtnLogin_Clicked;

    }

    private async void BtnLogin_Clicked(object? sender, EventArgs e)
    {
        // Simulate a login process
        this.IsBusy = true;

        //login process simulation
        await Task.Delay(2000);
        Application.Current.MainPage = new NavigationPage(new MainPage());
    }

    //private async void entry1_TextChanged(object sender, TextChangedEventArgs e)
    //{
    //    string oldText = e.OldTextValue;
    //    string newText = e.NewTextValue;
    //    //string myText = entry1.Text;

    //    await DisplayAlert("Text Changed", $"Old: {oldText}\nNew: {newText}\nCurrent: {myText}", "OK");
    //}

    //private async void entry1_Completed(object sender, EventArgs e)
    //{
    //    string text = ((Entry)sender).Text;
    //    await DisplayAlert("Entry Completed", $"You entered: {text}", "OK");
    //}

    //private async void Button_Clicked(object sender, EventArgs e)
    //{
    //    await progressBar.ProgressTo(0.90, 2000, Easing.Linear);
    //}
}