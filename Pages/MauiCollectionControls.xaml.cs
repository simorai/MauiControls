using MauiControls.Models;

namespace MauiControls.Pages;

public partial class MauiCollectionControls : ContentPage
{
    public MauiCollectionControls()
    {
        InitializeComponent();
        BindingContext = new Models.FotoViewModel();
    }

    private void AlertaCinto_OnChanged(object sender, ToggledEventArgs e)
    {
        DisplayAlert("Alerta Cinto", $"Cinto de segurança {(e.Value ? "ligado" : "desligado")}", "OK");
    }

    //private async void CarouselView_CurrentItemChanged(object sender, CurrentItemChangedEventArgs e)
    //{
    //    if (e.CurrentItem != null && e.PreviousItem != null)
    //    {
    //        Foto anterior = e.PreviousItem as Foto;
    //        Foto proxima = e.CurrentItem as Foto;
    //        await DisplayAlert("Foto Troca", $"Anterior: {anterior.Nome} - Próxima: {proxima.Nome}", "OK");
    //    }
    //}
}