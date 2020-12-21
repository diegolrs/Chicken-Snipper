using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NormalGalinha : Galinha
{
    public override void ColidiuComOvoAlien() => GameOver();
    public override void ColidiuComOvoFantasma() => GameOver();
    public override void ColidiuComOvoNormal() => AumentarPontuacao(1); 
    public override void ColidiuComOvoRobo() => GameOver();
    public override void ColidiuComOvoFormando() => GameOver();
}
