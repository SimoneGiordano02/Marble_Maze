using UnityEngine;
using TMPro;

public class VictoryTrigger : MonoBehaviour
{
    public GameObject victoryText;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Ball"))
        {
            // Attiva la scritta di vittoria
            victoryText.SetActive(true);

            // Ferma il tempo (opzionale)
            Time.timeScale = 0f;
        }
    }
}
