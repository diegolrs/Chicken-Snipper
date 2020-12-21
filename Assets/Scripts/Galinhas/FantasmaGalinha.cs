public class FantasmaGalinha : Galinha
{
    public override void ColidiuComOvoAlien() => GameOver();
    public override void ColidiuComOvoFantasma() => AumentarPontuacao(1);
    public override void ColidiuComOvoNormal() => GameOver();
    public override void ColidiuComOvoRobo() => GameOver();
    public override void ColidiuComOvoFormando() => GameOver();
}
