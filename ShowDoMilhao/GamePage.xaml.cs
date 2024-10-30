using Microsoft.UI.Text;

namespace ShowDoMilhao;

public partial class GamePage
{
    Gerenciador gerenciador;
    Questao questao;
    public GamePage()
    {
        InitializeComponent();

        gerenciador = new Gerenciador(labelPergunta, Resposta01, Resposta02, Resposta03, Resposta04, Resposta05, labelNivel, labelPontuacao, frameGameOver);
        gerenciador.ProximaQuestao();
    }

    void ClicouBotaoUniversitario01(object s, EventArgs e){
        gerenciador.VerificaCorreta(1);
        frameUniversitarios.IsVisible = false;
    }

    void ClicouBotaoUniversitario02(object s, EventArgs e){
        gerenciador.VerificaCorreta(2);
        frameUniversitarios.IsVisible = false;
    }

    void ClicouBotaoUniversitario03(object s, EventArgs e){
        gerenciador.VerificaCorreta(3);
        frameUniversitarios.IsVisible = false;
    }

    void ClicouBotaoUniversitario04(object s, EventArgs e){
        gerenciador.VerificaCorreta(4);
        frameUniversitarios.IsVisible = false;
    }

    void ClicouBotaoUniversitario05(object s, EventArgs e){
        gerenciador.VerificaCorreta(5);
        frameUniversitarios.IsVisible = false;
    }

    void clicouBotaoResposta01(object sender, EventArgs args)
    {
        gerenciador.VerificaCorreta(1);

        if (questao.RespostaCerta == 1)
            frameGameOver.IsVisible = false;
        else
            frameGameOver.IsVisible = true;
    }

    void clicouBotaoResposta02(object sender, EventArgs args)
    {
        gerenciador.VerificaCorreta(2);

        if (questao.RespostaCerta == 2)
            frameGameOver.IsVisible = false;
        else
            frameGameOver.IsVisible = true;
    }

    void clicouBotaoResposta03(object sender, EventArgs args)
    {
        gerenciador.VerificaCorreta(3);

        if (questao.RespostaCerta == 3)
            frameGameOver.IsVisible = false;
        else
            frameGameOver.IsVisible = true;
    }

    void clicouBotaoResposta04(object sender, EventArgs args)
    {
        gerenciador.VerificaCorreta(4);

        if (questao.RespostaCerta == 4)
            frameGameOver.IsVisible = false;
        else
            frameGameOver.IsVisible = true;
    }

    void clicouBotaoResposta05(object sender, EventArgs e)
    {
        gerenciador.VerificaCorreta(5);

        if (questao.RespostaCerta == 5)
            frameGameOver.IsVisible = false;
        else
            frameGameOver.IsVisible = true;
    }

    void OnUniversitariosClicked(object s, EventArgs e)
    {
        frameUniversitarios.IsVisible = true;
        (s as Button).IsVisible = false;

        var ajuda = new Universitario();
        ajuda.ConfiguraEstruturaDesenho(universitarioUm, universitarioDois, universitarioTres, universitarioQuatro , universitarioCinco);
    }

    int i = 3;

    void OnAjudaPulaClicked(object s, EventArgs e)
    {
        gerenciador.ProximaQuestao();
        i--;
        switch (i)
        {
            case 3:
                botaoPular.ImageSource = "right_arrow_three.png";
                break;

            case 2:
                botaoPular.ImageSource = "right_arrow_two.png";
                break;

            case 1:
                botaoPular.ImageSource = "right_arrow_one.png";
                break;
        }
        if (i < 1)
            (s as Button).IsVisible = false;
    }

    void OnAjudaRetirarCliecked(object s, EventArgs e)
    {
        var ajuda = new RetiraErradas();
        ajuda.ConfiguraEstruturaDesenho(Resposta01, Resposta02, Resposta03, Resposta04, Resposta05);
        ajuda.RealizaAjuda(gerenciador.GetQuestaoAtual());
        (s as Button).IsVisible = false;
    }

    void BotaoRecomecar(object s, EventArgs e)
    {
        gerenciador.Initialize();
        frameGameOver.IsVisible = false;
    }
}