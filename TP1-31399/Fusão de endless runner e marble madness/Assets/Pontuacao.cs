using UnityEngine;
using TMPro;

public class Pontuacao : MonoBehaviour
{
    public static int pontos = 0;
    public TextMeshProUGUI textoPontuacao;

    void Start()
    {
        pontos = 0; // reinicia a pontuação sempre que o jogo começa
    }

    void Update()
    {
        textoPontuacao.text = "Pontos: " + pontos.ToString();
    }
}
