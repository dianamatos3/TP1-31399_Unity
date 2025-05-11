using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverBotoes : MonoBehaviour
{
    public void Recomeçar()
    {
        Pontuacao.pontos = 0;
        SceneManager.LoadScene("SampleScene"); 
    }

    public void IrParaMenu()
    {
        Pontuacao.pontos = 0;
        SceneManager.LoadScene("Menu");
    }
}
