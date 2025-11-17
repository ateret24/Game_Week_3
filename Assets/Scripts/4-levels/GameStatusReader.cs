using UnityEngine;

/**
 * This component reades the "playerScore" static variable from the GAME_STATUS static class into this object's number field.
 */
[RequireComponent(typeof(NumberFieldGUI))]
public class GameStatusReader : MonoBehaviour
{


    void Start()
    {
        GetComponent<NumberFieldGUI>().SetNumber(GAME_STATUS.playerScore);
    }

}
