using UnityEngine;
using UnityEngine.AI;

public class inimigoMovimento : MonoBehaviour
{
    // saber posição do jogador
    public Transform jogador;
    // controla o movimento do inimigo
    private NavMeshAgent inimigo;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        inimigo = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        inimigo.SetDestination(jogador.position);
    }
}
