using UnityEngine;

public abstract class Galinha : MonoBehaviour
{
    public float velocidade;

    public abstract void ColidiuComOvoAlien();
    public abstract void ColidiuComOvoRobo();
    public abstract void ColidiuComOvoFantasma();
    public abstract void ColidiuComOvoNormal();
    public abstract void ColidiuComOvoFormando();

    protected void AumentarPontuacao(int valor)
    {
        Game.Instance.SetPontuacao(Game.Instance.GetPontuacao() + valor);
    }

    protected void GameOver() => Game.Instance.GameOver();

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Ovo"))
        {
            var ovo = other.gameObject.GetComponent<IOvo>();

            if (ovo != null)
            {
                ovo.Colidiu(this);
                Game.Instance.InvocarNovaGalinhaEOvo();
            }
        }
                  
    }

    private void FixedUpdate()
    {
        transform.position += new Vector3(velocidade, 0, 0) * Time.fixedDeltaTime;
    }
}
