using UnityEngine;

public class OvoFantasma : MonoBehaviour, IOvo
{
    public void Colidiu(Galinha galinha) => galinha.ColidiuComOvoFantasma();
}
