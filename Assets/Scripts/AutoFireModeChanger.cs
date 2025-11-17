using UnityEngine;

/**
 * This component automatically changes the fire mode of a ClickSpawner every few seconds.
 */

public class AutoFireModeChanger : MonoBehaviour
{
    [SerializeField] ClickSpawner spawner;  // reference to the ClickSpawner whose mode we want to change
    [SerializeField] float interval = 6f;

    float timer = 0f;
    int mode = 0;

    void Update()
    {
        timer += Time.deltaTime;

        if (timer >= interval)
        {
            timer = 0f;
            ChangeMode();
        }
    }

    void ChangeMode()
    {
        mode = (mode + 1) % 3;

        switch (mode)
        {
            case 0:
                spawner.SetSpawnVelocity(new Vector3(0, 5, 0));   //regular speed
                break;

            case 1:
                spawner.SetSpawnVelocity(new Vector3(0, 8, 0));   // speeder
                break;

            case 2:
                spawner.SetSpawnVelocity(new Vector3(0, 12, 0));  // super speed
                break;
        }
    }
}
