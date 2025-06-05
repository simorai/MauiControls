using System.Globalization;
using System.Threading.Tasks;

namespace MauiControls.Pages;

public partial class MauiSetValueControls : ContentPage
{
    public MauiSetValueControls()
    {
        InitializeComponent();
    }

    private async void CheckBox1_CheckedChanged(object sender, CheckedChangedEventArgs e)
    {
        if (e.Value)
        {
            await DisplayAlert("Checkbox", "Checkbox is checked", "OK");
        }
        else
        {
            await DisplayAlert("Checkbox", "Checkbox is unchecked", "OK");
        }
    }

    private async void CheckBox2_CheckedChanged(object sender, CheckedChangedEventArgs e)
    {
        if (e.Value)
        {
            await DisplayAlert("Checkbox", "Checkbox is checked", "OK");
        }
        else
        {
            await DisplayAlert("Checkbox", "Checkbox is unchecked", "OK");
        }

    }


    private async void CheckBox3_CheckedChanged(object sender, CheckedChangedEventArgs e)
    {
        if (e.Value)
        {
            await DisplayAlert("Checkbox", "Checkbox is checked", "OK");
        }
        else
        {
            await DisplayAlert("Checkbox", "Checkbox is unchecked", "OK");
        }
    }

    private void slider1_ValueChanged(object sender, ValueChangedEventArgs e)
    {
        double value = Math.Round(slider1.Value, 2);
        lblSlider.Text = value.ToString();
    }

    private void stepper1_ValueChanged(object sender, ValueChangedEventArgs e)
    {
        double value = e.NewValue;
        lblStepper.Text = string.Format($"Steller value {value}");
    }

    private async void switch1_Toggled(object sender, ToggledEventArgs e)
    {
        if (e.Value)
        {
            await DisplayAlert("Switch", "Switch is ON", "OK");
        }
        else
        {
            await DisplayAlert("Switch", "Switch is OFF", "OK");
        }
    }

    private async void DatePicker_DateSelected(object sender, DateChangedEventArgs e)
    {
        CultureInfo culture = new CultureInfo("pt-BR");
        var data = ((DatePicker)sender).Date;
        var selectedDate = data.ToString("d", culture);
        await DisplayAlert("Selected Date", $"You selected: {selectedDate}", "OK");
    }

    private async void time1_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
    {
        if (time1 != null)
        {
            var selectedTime = time1.Time.ToString(@"hh\:mm");
            await DisplayAlert("Selected Time", $"You selected: {selectedTime}", "OK");
        }
    }
}