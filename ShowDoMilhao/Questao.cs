namespace ShowDoMilhao;

public class Questao : IEquatable<Questao>
{
    // Texto de Pergunta
    public string Pergunta;
    //Texto dos botão 1
    public string Resposta1;
    //Texto dos botão 2
    public string Resposta2;
    //Texto dos botão 3
    public string Resposta3;
    //Texto dos botão 4
    public string Resposta4;
    //Texto dos botão 5
    public string Resposta5;
    // Botão da resposta certa
    public int RespostaCerta;
    //Nível da pergunta
    public int NivelResposta;
    //Label da pergunta
    private Label LabelPergunta;
    //Botão 1
    private Button ButtonResposta1;
    //Botão 2
    private Button ButtonResposta2;
    //Botão 3
    private Button ButtonResposta3;
    //Botão 4
    private Button ButtonResposta4;
    //Botão 5
    private Button ButtonResposta5;
    //Frame  de GameOver
    private Frame FrameGameOver;

    public bool Equals(Questao q)
    {
        return this.NivelResposta == q.NivelResposta && this.Pergunta == q.Pergunta;
    }

    public Questao()
    {

    }

    public Questao(Label labelpergunta, Button button1, Button button2, Button button3, Button button4, Button button5, Frame frameGameOver)
    {
        LabelPergunta = labelpergunta;
        ButtonResposta1 = button1;
        ButtonResposta2 = button2;
        ButtonResposta3 = button3;
        ButtonResposta4 = button4;
        ButtonResposta5 = button5;
        FrameGameOver = frameGameOver;
    }

    public void ConfiguraEstruturaDesenho(Label labelpergunta, Button button1, Button button2, Button button3, Button button4, Button button5, Frame frameGameOver)
    {
        LabelPergunta = labelpergunta;
        ButtonResposta1 = button1;
        ButtonResposta2 = button2;
        ButtonResposta3 = button3;
        ButtonResposta4 = button4;
        ButtonResposta5 = button5;
        FrameGameOver = frameGameOver;
    }

    public void Desenhar()
    {
        LabelPergunta.Text = Pergunta;
        ButtonResposta1.Text = Resposta1;
        ButtonResposta2.Text = Resposta2;
        ButtonResposta3.Text = Resposta3;
        ButtonResposta4.Text = Resposta4;
        ButtonResposta5.Text = Resposta5;

        ButtonResposta1.IsVisible = true;
        ButtonResposta2.IsVisible = true;
        ButtonResposta3.IsVisible = true;
        ButtonResposta4.IsVisible = true;
        ButtonResposta5.IsVisible = true;
        FrameGameOver.IsVisible = false;
    }

    private Button QualButton(int r)
    {
        if (r == 1)
        {
            return ButtonResposta1;
        }
        else if (r == 2)
        {
            return ButtonResposta2;
        }
        else if (r == 3)
        {
            return ButtonResposta3;
        }
        else if (r == 4)
        {
            return ButtonResposta4;
        }
        else if (r == 5)
        {
            return ButtonResposta5;
        }
        else
        {
            return null;
        }
    }

    public bool VerificaResposta(int rr)
    {
        if (RespostaCerta == rr)
        {
            var button = QualButton(rr);
            button.BackgroundColor = Colors.Green; //"#a1c9ae";

            return true;
        }
        else
        {
            var buttonCorreto = QualButton(RespostaCerta);
            var buttonIncorreto = QualButton(rr);
            buttonCorreto.BackgroundColor = Colors.Green; //"#a1c9ae";
            buttonIncorreto.BackgroundColor = Colors.Red; //#e88e8e;

            return false;
        }
    }
}