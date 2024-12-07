using UnityEngine;
using UnityEngine.UI;

public class ChronoManager : MonoBehaviour
{
    public float timeLimit = 10f; // Temps limite en secondes
    private float timeRemaining;
    public Text timerText; // Référence à un Text UI

    private bool isRunning = false;

    void Start()
    {
        timeRemaining = timeLimit;
        isRunning = true;
    }

    void Update()
    {
        if (isRunning)
        {
            timeRemaining -= Time.deltaTime;
            if (timeRemaining <= 0)
            {
                timeRemaining = 0;
                isRunning = false;
                EndChronoMode();
            }

            UpdateTimerUI();
        }
    }

    void UpdateTimerUI()
    {
        timerText.text = "Temps restant : " + Mathf.Ceil(timeRemaining).ToString() + " s";
    }

    void EndChronoMode()
    {
        // Logique de fin de partie Chrono
        Debug.Log("Temps écoulé !");
    }
}
