public class AlienGalinha : Galinha
{
    public override void ColidiuComOvoAlien() => AumentarPontuacao(1);
    public override void ColidiuComOvoFantasma() => GameOver();
    public override void ColidiuComOvoNormal() => GameOver();
    public override void ColidiuComOvoRobo() => GameOver();
    public override void ColidiuComOvoFormando() => GameOver();
}
