using UnityEngine;
using UnityEngine.UI;

public class DialogueManager : MonoBehaviour
{
    public Text dialogText; // Refer�ncia para o texto do di�logo
    public Button nextButton; // Bot�o para avan�ar o di�logo
    private string[] dialogueLines; // Linhas de di�logo
    private int currentLine = 0; // �ndice da linha atual

    void Start()
    {
        // Inicialmente, o texto estar� vazio
        dialogText.text = "";

        // Configurar o bot�o para avan�ar
        nextButton.onClick.AddListener(NextDialogueLine);
    }

    // Fun��o chamada para iniciar o di�logo
    public void StartDialogue(string[] lines)
    {
        dialogueLines = lines;
        currentLine = 0;

        // Exibir a primeira linha
        DisplayDialogueLine();
    }

    // Fun��o que exibe o pr�ximo texto do di�logo
    void DisplayDialogueLine()
    {
        if (currentLine < dialogueLines.Length)
        {
            dialogText.text = dialogueLines[currentLine]; // Exibe a linha de di�logo
        }
        else
        {
            dialogText.text = ""; // Se o di�logo acabar, o texto fica vazio
        }
    }

    // Fun��o para avan�ar para a pr�xima linha de di�logo
    void NextDialogueLine()
    {
        currentLine++;
        DisplayDialogueLine();
    }
}
