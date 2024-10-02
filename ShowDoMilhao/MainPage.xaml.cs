using Windows.ApplicationModel.VoiceCommands;

namespace ShowDoMilhao;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
    }

    public void botaoComecar(object sender, EventArgs e){
        Application.Current.MainPage = new GamePage();
    }
}