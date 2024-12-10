using UnityEngine;
using UnityEngine.UI;

public class RoomManager : MonoBehaviour
{
    public Image backgroundImage; // Refer�ncia � imagem de fundo
    public Sprite[] roomSprites; // Lista de imagens das salas
    public Button leftButton;  // Bot�o de retroceder
    public Button rightButton; // Bot�o de avan�ar
    void Start()
    {
        // Certifique-se de que a sala inicial est� sendo exibida
        if (roomSprites.Length > 0)
        {
            backgroundImage.sprite = roomSprites[currentRoomIndex];
        }

        // Atualize os bot�es para refletir a sala inicial
        UpdateButtons();
    }


    private int currentRoomIndex = 0; // �ndice da sala atual

    public void ChangeRoom(int roomIndex)
    {
        if (roomIndex >= 0 && roomIndex < roomSprites.Length)
        {
            currentRoomIndex = roomIndex;
            backgroundImage.sprite = roomSprites[roomIndex];
            UpdateButtons(); // Atualiza o estado dos bot�es
        }
        else
        {
            Debug.LogWarning("�ndice da sala � inv�lido!");
        }
    }

    public void NextRoom()
    {
        // Avan�a para a pr�xima sala se poss�vel
        ChangeRoom(currentRoomIndex + 1);
    }

    public void PreviousRoom()
    {
        // Retrocede para a sala anterior se poss�vel
        ChangeRoom(currentRoomIndex - 1);
    }

    public void UpdateButtons()
    {
        leftButton.interactable = currentRoomIndex > 0; // Ativa o bot�o apenas se n�o estiver na primeira sala
        rightButton.interactable = currentRoomIndex < roomSprites.Length - 1; // Ativa o bot�o apenas se n�o estiver na �ltima sala
    }



}

