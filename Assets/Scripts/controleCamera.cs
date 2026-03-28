using UnityEngine;

public class controleDaCamera : MonoBehaviour
{
    public GameObject jogador;
    public Vector3 distancia;

    void Start()
    {
        distancia = transform.position - jogador.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = jogador.transform.position + distancia;
    }
}
