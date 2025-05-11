using UnityEngine;

public class SeguirCamera : MonoBehaviour
{
    public Transform alvo;
    public Vector3 offset = new Vector3(0, 5, -10); //distancia entre a cãmera e a esfera

    private void LateUpdate()
    {   
        // Move a câmera para acompanhar a bola com uma distância constante
        transform.position = alvo.position + offset;

        // Faz a câmera olhar sempre para bola
        transform.LookAt(alvo);
    }

    /*private void FixedUpdate()
    {
        transform.LookAt(alvo);
    }*/
    void Start()
    {
        
    }

    void Update()
    {
        
    }
}
