using UnityEngine;

public class Moeda : MonoBehaviour
{
    public float rotacao;

    void FixedUpdate() 
    {
        transform.Rotate(0, 0, rotacao);
    }

    void OnTriggerEnter(Collider other) 
    {
        if(other.CompareTag("Player")){
            Pontuacao.pontos++;
            Destroy(gameObject);
        }
        
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
