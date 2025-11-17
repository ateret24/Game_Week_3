using UnityEngine;

/**
**This script gives the player automatic bonus points over time.
**Every few seconds it adds a fixed amount of score to the NumberFieldGUI.
 */

public class TimeScoreBonus : MonoBehaviour
{
    [SerializeField] NumberFieldGUI scoreField; 
    [SerializeField] float interval = 5f; // Time interval in seconds 
    [SerializeField] int pointsPerInterval = 2; // Points to add each interval

    float timer = 0f;

    void Update()
    {
        timer += Time.deltaTime;

        if (timer >= interval)
        {
            timer -= interval; 

            if (scoreField != null)
            {
                scoreField.AddNumber(pointsPerInterval);
            }
            else
            {
                Debug.LogError("TimeScoreAdder: scoreField is not assigned!");
            }
        }
    }
}
