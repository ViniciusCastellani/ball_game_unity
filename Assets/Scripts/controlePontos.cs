using UnityEngine;
using TMPro;

public class controleDePontos : MonoBehaviour
{
    int pontos, totalPontos;
    public TextMeshProUGUI textoPonto;
    public GameObject textoVitoria, textoDerrota;
    GameObject[] coletaveis;

    void Start()
    {
        pontos = 0;

        coletaveis = GameObject.FindGameObjectsWithTag("coletavel");
        totalPontos = coletaveis.Length;

        textoVitoria.SetActive(false);   
        textoDerrota.SetActive(false);
    }

    // fala qual é o colisor, saber que é um objeto colidido (seria a moeda no caso)
    void OnTriggerEnter(Collider objetoColidido)
    {
        if (objetoColidido.CompareTag("coletavel"))
        {
            objetoColidido.gameObject.SetActive(false); 
            
            pontos++;

            Debug.Log(pontos);

            textoPonto.text = "PONTOS: " + pontos.ToString();

            if (pontos >= totalPontos)
            {
                VoceVenceu();
            } 
        }

        // bateu no inimigo
        if (objetoColidido.CompareTag("inimigo"))
        {
            VocePerdeu();
        }
    }

    void VoceVenceu()
    {
        textoVitoria.SetActive(true);
        Time.timeScale = 0.0f;
    }

    void VocePerdeu()
    {
        textoDerrota.SetActive(true);
        Time.timeScale = 0.0f;
    }
    
}