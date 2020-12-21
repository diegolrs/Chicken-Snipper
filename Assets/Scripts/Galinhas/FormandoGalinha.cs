public class FormandoGalinha : Galinha
{
    public override void ColidiuComOvoAlien() => GameOver();
    public override void ColidiuComOvoFantasma() => GameOver();
    public override void ColidiuComOvoNormal() => GameOver();
    public override void ColidiuComOvoRobo() => GameOver();
    public override void ColidiuComOvoFormando() => AumentarPontuacao(1);
}
