using System;
using System.Collections.Generic;
using System.Text;

namespace MauiApp1.ViewModel
{ 
    namespace MauiApp1.ViewModel
    {
        public class DetailFormulaireViewModel
        {
            public Formulaire Formulaire { get; set; }
            public ICommand ValiderCommande { get; }

            public DetailFormulaireViewModel()
            {
                Formulaire = new Formulaire();
                ValiderCommande = new Command(Valider);
            }

            private async void Valider()
            {
                string nom = Formulaire.NomUtilisateur?.Trim().ToLower();

                Accueil accueil = new Accueil();

                if (nom == "user")
                    accueil.MessageBienvenue = "Bienvenue user";
                else
                    accueil.MessageBienvenue = "Vous n'êtes pas identifié";

                // Navigation vers la page d'accueil
                await Shell.Current.GoToAsync($"AccueilPage?message={accueil.MessageBienvenue}");
            }
        }
    }

}
