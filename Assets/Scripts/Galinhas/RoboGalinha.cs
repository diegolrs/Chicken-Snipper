public class RoboGalinha : Galinha
{
    public override void ColidiuComOvoAlien() => GameOver();
    public override void ColidiuComOvoFantasma() => GameOver();
    public override void ColidiuComOvoNormal() => GameOver();
    public override void ColidiuComOvoRobo() => AumentarPontuacao(1);
    public override void ColidiuComOvoFormando() => GameOver();
}
