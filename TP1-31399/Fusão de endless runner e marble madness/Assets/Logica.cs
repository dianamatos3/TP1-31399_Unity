using UnityEngine;  
using UnityEngine.SceneManagement;

public class Logica : MonoBehaviour
{
    public GameObject instrucoes;
    
    public void MudarCena(){
        SceneManager.LoadScene("SampleScene");
    }

    public void MostrarInstrucoes(){
        instrucoes.SetActive(true);
    }
}
