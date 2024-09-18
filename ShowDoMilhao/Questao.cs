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

    private Button ButtonResposta1;
    private Button ButtonResposta2;
    private Button ButtonResposta3;
    private Button ButtonResposta4;
    private Button ButtonResposta5;

    public Questao(){

    }

    public void DesenhaTela(Label labelPergunta, Button buttonResposta1, Button buttonResposta2, Button buttonResposta3, Button buttonResposta4, Button buttonResposta5){
        LabelPergunta = labelPergunta;
        ButtonResposta1 = buttonResposta1;
        ButtonResposta2 = buttonResposta2;
        ButtonResposta3 = buttonResposta3;
        ButtonResposta4 = buttonResposta4;
        ButtonResposta5 = buttonResposta5;
    }

    /*public void VerificatResposta(int respostaSelecionada){
        if RespostaCerta = respostaSelecionada;
        {

        }
    }*/

    private Button QualButton(int r){
        if(r == 1){
            return ButtonResposta1;
        }
        else if(r == 2){
            return ButtonResposta2;
        }
        else if (r == 3){
            return ButtonResposta3;
        }
        else if (r == 4){
            return ButtonResposta4;
        }
        else if (r == 5 ){
            return ButtonResposta5;
        }
        else{
            return null;
        }
    }

    public bool VerificaResposta(int rr){
        if(RespostaCerta == rr){
            var button = QualButton(rr);
            button.BackgroundColor = Colors.Green; //"#a1c9ae";
            return true;
        }
        else{
            var buttonCorreto = QualButton(RespostaCerta);
            var buttonIncorreto = QualButton(rr);
            buttonCorreto.BackgroundColor = Colors.Green; //"#a1c9ae";
            buttonIncorreto.BackgroundColor = Colors.Red; //#e88e8e;

            return false;
        }
    }
}