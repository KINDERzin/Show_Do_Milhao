namespace ShowDoMilhao;

public partial class Universitario : IAjuda
{
    public override void RealizaAjuda(Questao questao)
    {
        var porcentagem = 100;

        for (int i = 0; i < 5; i++)
        {
            int numRandomico = 0;

            if(porcentagem > 0)
            {
                numRandomico = Random.Shared.Next(0, porcentagem);
                porcentagem -= numRandomico; 

                switch(i)
                {
                    case 0:
                        BtnResp01.Text += ":" + numRandomico.ToString() + "%";
                        break;
                    
                    case 1:
                        BtnResp02.Text += ":" + numRandomico.ToString() + "%";
                        break;
                    
                    case 2:
                        BtnResp03.Text += ":" + numRandomico.ToString() + "%";
                        break;
                    
                    case 3:
                        BtnResp04.Text += ":" + numRandomico.ToString() + "%";
                        break;

                    case 4:
                        BtnResp05.Text += ":" + numRandomico.ToString() + "%";
                        break;
                }
            }
        }
    }
}