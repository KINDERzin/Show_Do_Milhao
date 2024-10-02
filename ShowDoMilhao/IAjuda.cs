using ShowDoMilhao;

public abstract class IAjuda{
    protected Button BtnResp01;
    protected Button BtnResp02;
    protected Button BtnResp03;
    protected Button BtnResp04;
    protected Button BtnResp05;
    protected Frame FrameAjuda;

    public void ConfiguraEstruturaDesenho(Button BtnResp01, Button BtnResp02, Button BtnResp03, Button BtnResp04, Button BtnResp05){
        this.BtnResp01 = BtnResp01;
        this.BtnResp02 = BtnResp02;
        this.BtnResp03 = BtnResp03;
        this.BtnResp04 = BtnResp04;
        this.BtnResp05 = BtnResp05;
    }

    public void ConfiguraEstruturaDesenho(Frame AjudaFrame){
        this.FrameAjuda = FrameAjuda;
    }

    public abstract void RealizaAjuda(Questao questao);
}