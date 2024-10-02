using ShowDoMilhao;

public class RetiraErradas : IAjuda{
    public override void RealizaAjuda(Questao questao){
        switch(questao.RespostaCerta){
            case 1:
                BtnResp02.IsVisible = false;
                BtnResp03.IsVisible = false;
                BtnResp04.IsVisible = false;

                break;

            case 2:  
                BtnResp01.IsVisible = false;
                BtnResp03.IsVisible = false;
                BtnResp05.IsVisible = false;

                break;

            case 3:
                BtnResp01.IsVisible = false;
                BtnResp02.IsVisible = false;
                BtnResp03.IsVisible = false;

                break;

            case 4:
                BtnResp03.IsVisible = false;
                BtnResp04.IsVisible = false;
                BtnResp05.IsVisible = false;

                break;

            case 5:
                BtnResp02.IsVisible = false;
                BtnResp03.IsVisible = false;
                BtnResp05.IsVisible = false;

                break;
        }
    }
}