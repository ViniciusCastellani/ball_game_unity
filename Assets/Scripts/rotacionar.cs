using Unity.Properties;
using UnityEngine;

public class rotacionar : MonoBehaviour
{
    public Vector3 velocidadeRotacao;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // X, Y, Z
        transform.Rotate(velocidadeRotacao * Time.deltaTime);
    }
}
