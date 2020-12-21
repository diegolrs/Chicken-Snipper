using UnityEngine;

public class OvoNormal : MonoBehaviour, IOvo
{
    public void Colidiu(Galinha galinha) => galinha.ColidiuComOvoNormal();
}