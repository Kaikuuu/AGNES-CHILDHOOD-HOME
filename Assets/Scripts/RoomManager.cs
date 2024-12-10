using UnityEngine;
using UnityEngine.UI;

public class RoomManager : MonoBehaviour
{
    public Image backgroundImage; // Referência à imagem de fundo
    public Sprite[] roomSprites; // Lista de imagens das salas
    public Button leftButton;  // Botão de retroceder
    public Button rightButton; // Botão de avançar
    void Start()
    {
        // Certifique-se de que a sala inicial está sendo exibida
        if (roomSprites.Length > 0)
        {
            backgroundImage.sprite = roomSprites[currentRoomIndex];
        }

        // Atualize os botões para refletir a sala inicial
        UpdateButtons();
    }


    private int currentRoomIndex = 0; // Índice da sala atual

    public void ChangeRoom(int roomIndex)
    {
        if (roomIndex >= 0 && roomIndex < roomSprites.Length)
        {
            currentRoomIndex = roomIndex;
            backgroundImage.sprite = roomSprites[roomIndex];
            UpdateButtons(); // Atualiza o estado dos botões
        }
        else
        {
            Debug.LogWarning("Índice da sala é inválido!");
        }
    }

    public void NextRoom()
    {
        // Avança para a próxima sala se possível
        ChangeRoom(currentRoomIndex + 1);
    }

    public void PreviousRoom()
    {
        // Retrocede para a sala anterior se possível
        ChangeRoom(currentRoomIndex - 1);
    }

    public void UpdateButtons()
    {
        leftButton.interactable = currentRoomIndex > 0; // Ativa o botão apenas se não estiver na primeira sala
        rightButton.interactable = currentRoomIndex < roomSprites.Length - 1; // Ativa o botão apenas se não estiver na última sala
    }



}

