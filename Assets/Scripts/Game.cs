using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Game : MonoBehaviour
{
    private static Game _instance;
    private int _pontuacao;

    public GameObject[] galinhas;
    public GameObject[] ovos;

    public Transform galinhaSpawn;
    public Transform ovoSpawn;

    public Text texto;

    private int _galinhaAtivaIndex;
    private int _ovoAtivoIndex;

    private float _velocidade = VelocidadeInicial;
    private const float VelocidadeInicial = 2f;
    private const float VelocidadeMaxima = 5f;

    public GameObject spawn;

    public static Game Instance
    {
        get
        {
            if (_instance == null)
            {
                GameObject go = new GameObject("Game");
                go.AddComponent<Game>();
                _instance = go.GetComponent<Game>();
            }

            return _instance;
        }
        private set => _instance = value;
    }

    private void Awake()
    {
        _instance = this;
        DesabilitarGalinhasEOvos();
        InvocarNovaGalinhaEOvo();
        _pontuacao = 0;
        AtualizarTexto();
    }

    private void DesabilitarGalinhasEOvos()
    {
        foreach (GameObject go in galinhas)
            go.SetActive(false);

        foreach (GameObject go in ovos)
            go.SetActive(false);
    }

    public void InvocarNovaGalinhaEOvo()
    {
        Vector3 posicaoSpwan = new Vector3(0, spawn.transform.position.y, spawn.transform.position.z);

        posicaoSpwan.x = Random.Range(0, 6);

        spawn.transform.position = posicaoSpwan;

        DesabilitarGalinhasEOvos();

        _galinhaAtivaIndex = Random.Range(0, galinhas.Length);
        _ovoAtivoIndex = Random.Range(0, ovos.Length);

        galinhas[_galinhaAtivaIndex].transform.position = galinhaSpawn.position;
        ovos[_ovoAtivoIndex].transform.position = ovoSpawn.position;

        galinhas[_galinhaAtivaIndex].SetActive(true);
        ovos[_ovoAtivoIndex].SetActive(true);


        if (_velocidade + 0.4f <= VelocidadeMaxima)
            _velocidade += 0.4f;
        else
            _velocidade = VelocidadeMaxima;

        galinhas[_galinhaAtivaIndex].GetComponent<Galinha>().velocidade = _velocidade;
    }

    public void MatarGalinha()
    {
        if (_galinhaAtivaIndex == _ovoAtivoIndex
           || galinhas[_galinhaAtivaIndex].GetComponent<Galinha>() is CoringaGalinha)
        {
            GameOver();
        }
        else
        {
            _pontuacao++;
            AtualizarTexto();
            DesabilitarGalinhasEOvos();
            InvocarNovaGalinhaEOvo();
        }
            
    }

    public int GetPontuacao() => _pontuacao;
    public void SetPontuacao(int valor)
    {
        _pontuacao = valor;
        AtualizarTexto();
    }

    private void AtualizarTexto() => texto.text = _pontuacao.ToString();

    public void GameOver() => SceneManager.LoadScene("Menu");

}
