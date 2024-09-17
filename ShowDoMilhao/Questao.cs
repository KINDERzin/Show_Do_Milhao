namespace Show_Do_Milhao;

public class Questao{

    public string Pergunta;
    public string Resposta1;
    public string Resposta2;
    public string Resposta3;
    public string Resposta4;
    public string Resposta5;

    public int RespostaCerta;
    public int NivelResposta;

    private Label LabelPergunta;

    private Button Button1;
    private Button Button2;
    private Button Button3;
    private Button Button4;
    private Button Button5;

    public Questao(){

    }

    /*public void DesenhaTela(Label labelpergunta, Button1 buttonresposta1, Button2 buttonresposta2, Button3 buttonresposta3, Button4 buttonresposta4, Button5 buttonresposta5){
        LabelPergunta = LabelPergunta;
        Button1 = buttonresposta1;
        Button2 = buttonresposta2;
        Button3 = buttonresposta3;
        Button4 = buttonresposta4;
        Button5 = buttonresposta5;
    }

    public void VerificatResposta(int respostaSelecionada){
        if RespostaCerta = respostaSelecionada;
        {

        }
    }*/

    private Button QualButton(int r){
        if(r == 1){
            return Button1;
        }
        else if(r == 2){
            return Button2;
        }
        else if (r == 3){
            return Button3;
        }
        else if (r == 4){
            return Button4;
        }
        else if (r == 5 ){
            return Button5;
        }
        else{
            return null;
        }
    }

    public bool VerificaResposta(int r){
        if(RespostaCerta == r){
            var button = QualButton(r);
            button.BackgroundColor = Colors.Green; //"#a1c9ae";
            return true;
        }
        else{
            var buttonCorreto = QualButton(RespostaCerta);
            var buttonIncorreto = QualButton(r);
            buttonCorreto.BackgroundColor = Colors.Green; //"#a1c9ae";
            buttonIncorreto.BackgroundColor = Colors.Red; //#e88e8e;

            return false;
        }
    }
}