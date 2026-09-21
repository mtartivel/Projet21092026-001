namespace MauiApp1.View;

public partial class DetailFormulaireView : ContentView
{
	<ContentPage xmlns = "http://schemas.microsoft.com/dotnet/2021/maui"
             xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
             xmlns:vm="clr-namespace:MauiApp1.ViewModel"
             x:Class="MauiApp1.View.DetailFormulaireView">

    <ContentPage.BindingContext>
        <vm:DetailFormulaireViewModel />
    </ContentPage.BindingContext>

    <VerticalStackLayout Padding = "20" >

        < Label Text="Entrez votre nom :" FontSize="20" />

        <Entry Placeholder = "Nom utilisateur"
               Text="{Binding Formulaire.NomUtilisateur}" />

        <Button Text = "Valider"
                Command="{Binding ValiderCommande}" />

    </VerticalStackLayout>
</ContentPage>

}