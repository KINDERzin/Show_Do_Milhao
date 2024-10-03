namespace ShowDoMilhao;

public partial class GamePage
{
    Gerenciador gerenciador;
    public GamePage()
    {
        InitializeComponent();

        gerenciador = new Gerenciador(labelPergunta, Resposta01, Resposta02, Resposta03, Resposta04, Resposta05, labelNivel, labelPontuacao);
        gerenciador.ProximaQuestao();
    }

    void clicouBotaoResposta01(object sender, EventArgs args)
    {
        gerenciador.VerificaCorreta(1);
    }

    void clicouBotaoResposta02(object sender, EventArgs args)
    {
        gerenciador.VerificaCorreta(2);
    }

    void clicouBotaoResposta03(object sender, EventArgs args)
    {
        gerenciador.VerificaCorreta(3);
    }

    void clicouBotaoResposta04(object sender, EventArgs args)
    {
        gerenciador.VerificaCorreta(4);
    }

    void clicouBotaoResposta05(object sender, EventArgs e)
    {
        gerenciador.VerificaCorreta(5);
    }

    void OnAjudaPulaClicked(object s, EventArgs e)
    {
        gerenciador.ProximaQuestao();
        (s as Button).IsVisible = false;
    }

    void OnAjudaRetirarCliecked(object s, EventArgs e)
    {
        var ajuda = new RetiraErradas();
        ajuda.ConfiguraEstruturaDesenho(Resposta01, Resposta02, Resposta03, Resposta04, Resposta05);
        ajuda.RealizaAjuda(gerenciador.GetQuestaoAtual());
        (s as Button).IsVisible = false;
    }
}