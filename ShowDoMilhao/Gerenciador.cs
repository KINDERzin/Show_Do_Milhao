using Show_Do_Milhao;

namespace ShowDoMilhao;

public class Gerenciador{

    List<Questao> listaQuestoes = new List<Questao>();
    List<int> listaQuestaoRespondida = new List<int>();
    Questao questaoAtual;
    public Gerenciador(Label labelPergunta, Button buttonResposta01, Button buttonResposta02, Button buttonResposta03, Button buttonResposta04, Button buttonResposta05){
        CriarQuestoes(labelPergunta, buttonResposta01, buttonResposta02, buttonResposta03, buttonResposta04, buttonResposta05);
    }

    void CriarQuestoes(Label labelPergunta, Button buttonRespota01, Button buttonResposta02, Button buttonResposta03, Button buttonResposta04, Button buttonResposta05){
        
    }

    public void ProximaQuestao(){
        var numRandom = Random.Shared.Next(0, listaQuestoes.Count- 1);

        while(listaQuestaoRespondida.Contains(numRandom)){
            numRandom = Random.Shared.Next(0,listaQuestoes.Count - 1);
        } 

        listaQuestaoRespondida.Add(numRandom);
        questaoAtual = listaQuestoes[numRandom];
        questaoAtual.Desenhar();
    }

    public async void VerificaCorreta(int rr){
        if(questaoAtual.VerificaResposta(rr)){
            await Task.Delay(1000);
            ProximaQuestao();
        }
    }
}