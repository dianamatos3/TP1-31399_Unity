using UnityEngine;
using TMPro;

public class MostrarPontuacaoFinal : MonoBehaviour
{
    public TextMeshProUGUI textoPontuacao;

    void Start()
    {
        textoPontuacao.text = "Pontuação Final: " + Pontuacao.pontos.ToString();
    }
}
