using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using ViagemOnboarding.Models;

namespace ViagemOnboarding.ViewModels
{
    public partial class ViagemOnboardingViewModel : ObservableObject
    {
        [ObservableProperty]
        private List<ViagemOnboardingItem> itens;

        [ObservableProperty]
        [NotifyPropertyChangedFor(nameof(IsLastPosicao))]
        [NotifyPropertyChangedFor(nameof(ExibirBotaoProximo))]
        private int _posicao;

        public bool IsLastPosicao => Posicao == Itens.Count - 1;

        public bool ExibirBotaoProximo => !IsLastPosicao;

        public ViagemOnboardingViewModel()
        {
            Itens = new List<ViagemOnboardingItem>
            {
                new ViagemOnboardingItem
                {
                    Titulo = "Explore\nExotic Destinations",
                    Descricao = "Embark on a virtual journey through stunning destinations worldwide.",
                    ImageUrl = "step1.png"
                },
                new ViagemOnboardingItem
                {
                    Titulo = "Discover\nLocal Gems",
                    Descricao = "Uncover hidden gems and local favorites recommended by fellow travelers.",
                    ImageUrl = "step2.png"
                },
                new ViagemOnboardingItem
                {
                    Titulo = "Plan\nYour Perfect Trip",
                    Descricao = "Create personalized itineraries tailored to your preferences and interests.",
                    ImageUrl = "step3.png"
                },
                new ViagemOnboardingItem
                {
                    Titulo = "Capture and Share\nMemories",
                    Descricao = "Preserve your travel memories with our in-app photo and journaling features.",
                    ImageUrl = "step4.png"
                }
            };
        }

        [RelayCommand]
        private void Proximo()
        {
            if (Posicao < Itens.Count - 1)
            {
                Posicao++;
            }
        }

        [RelayCommand]
        private async Task ComecarAsync()
        {
            // Lógica para navegar para a página principal da aplicação
            // Exemplo: await Shell.Current.GoToAsync("//MainPage");
        }
    }
}