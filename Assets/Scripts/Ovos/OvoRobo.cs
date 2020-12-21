using UnityEngine;

public class OvoRobo : MonoBehaviour, IOvo
{
    public void Colidiu(Galinha galinha) => galinha.ColidiuComOvoRobo();
}
