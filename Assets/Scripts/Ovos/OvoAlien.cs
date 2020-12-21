using UnityEngine;

public class OvoAlien : MonoBehaviour, IOvo
{
    public void Colidiu(Galinha galinha) => galinha.ColidiuComOvoAlien();
}
