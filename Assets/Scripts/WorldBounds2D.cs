using UnityEngine;

/**
 * This component keeps the GameObject within the given 2D world bounds.
 * If the object goes out of bounds in the X direction, it wraps around to the other side.
 * If it goes out of bounds in the Y direction, it is clamped to the bounds.
 */

public class WorldBounds2D : MonoBehaviour
{
    [SerializeField] Collider2D worldBounds;

    private void Awake()
    {
        if (!worldBounds)
        {
            GameObject boundsObject = GameObject.FindGameObjectWithTag("WorldBounds");
            if (boundsObject)
            {
                worldBounds = boundsObject.GetComponent<Collider2D>();
            }
            else
            {
                Debug.LogWarning("WorldBounds2D: No 'WorldBounds' object found!");
            }
        }
    }

    private void LateUpdate()
    {
        if (!worldBounds) return;

        Bounds b = worldBounds.bounds;
        Vector3 pos = transform.position;

        // --- X WRAP ---
        if (pos.x < b.min.x)
            pos.x = b.max.x;
        else if (pos.x > b.max.x)
            pos.x = b.min.x;

        // --- Y CLAMP ---
        pos.y = Mathf.Clamp(pos.y, b.min.y, b.max.y);

        transform.position = pos;
    }
}
