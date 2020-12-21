using UnityEngine;

public class OvoFormando : MonoBehaviour, IOvo
{
    public void Colidiu(Galinha galinha) => galinha.ColidiuComOvoFormando();
}
