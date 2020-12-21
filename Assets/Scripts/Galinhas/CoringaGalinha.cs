public class CoringaGalinha : Galinha
{
    private const int ValorParaAumentar = 3;

    public override void ColidiuComOvoAlien() => AumentarPontuacao(ValorParaAumentar);
    public override void ColidiuComOvoFantasma() => AumentarPontuacao(ValorParaAumentar);
    public override void ColidiuComOvoNormal() => AumentarPontuacao(ValorParaAumentar);
    public override void ColidiuComOvoRobo() => AumentarPontuacao(ValorParaAumentar);
    public override void ColidiuComOvoFormando() => AumentarPontuacao(ValorParaAumentar);
}
