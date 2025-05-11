
using UnityEngine;
using UnityEngine.SceneManagement;

public class MovimentoEsfera : MonoBehaviour
{

    public float movimento;
    Rigidbody corpo;

    float xInput;

    float zInput;

    private void Awake()
    {
        corpo= GetComponent<Rigidbody>();  
    }

    void Start()
    {
        
    }

    private void FixedUpdate()
    {
        xInput = Input.GetAxis("Horizontal");
        zInput = Input.GetAxis("Vertical");

        corpo.AddForce(xInput * movimento, 0, zInput * movimento);
    } 
    
    // Update is called once per frame
    void Update()
    {
        if (transform.position.y < -5f){
            SceneManager.LoadScene("GameOver"); 
        }
    }
}
