using UnityEngine;
using UnityEngine.UI;

public class DialogueManager : MonoBehaviour
{
    public Text dialogText; // Referência para o texto do diálogo
    public Button nextButton; // Botão para avançar o diálogo
    private string[] dialogueLines; // Linhas de diálogo
    private int currentLine = 0; // Índice da linha atual

    void Start()
    {
        // Inicialmente, o texto estará vazio
        dialogText.text = "";

        // Configurar o botão para avançar
        nextButton.onClick.AddListener(NextDialogueLine);
    }

    // Função chamada para iniciar o diálogo
    public void StartDialogue(string[] lines)
    {
        dialogueLines = lines;
        currentLine = 0;

        // Exibir a primeira linha
        DisplayDialogueLine();
    }

    // Função que exibe o próximo texto do diálogo
    void DisplayDialogueLine()
    {
        if (currentLine < dialogueLines.Length)
        {
            dialogText.text = dialogueLines[currentLine]; // Exibe a linha de diálogo
        }
        else
        {
            dialogText.text = ""; // Se o diálogo acabar, o texto fica vazio
        }
    }

    // Função para avançar para a próxima linha de diálogo
    void NextDialogueLine()
    {
        currentLine++;
        DisplayDialogueLine();
    }
}
