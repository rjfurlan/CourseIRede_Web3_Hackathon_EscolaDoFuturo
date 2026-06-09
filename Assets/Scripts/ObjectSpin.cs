using UnityEngine;

// Faz o objeto ficar rodando
public class ObjectSpin : MonoBehaviour
{
    // Velocidade de rotação do objeto
    public float speed = 100f;

    void Update()
    {
        // Roda o objeto no eixo Y 
        transform.Rotate(new Vector3(0, speed, 0) * Time.deltaTime);
    }
}