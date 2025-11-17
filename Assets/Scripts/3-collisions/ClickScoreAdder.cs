using UnityEngine;
using UnityEngine.InputSystem;

[RequireComponent(typeof(NumberFieldGUI))]
public class ClickScoreAdder : MonoBehaviour
{
    [SerializeField] protected InputAction addAction = new InputAction(type: InputActionType.Button);
    [SerializeField] protected int scoreToAdd;

    void OnEnable() { addAction.Enable(); }
    void OnDisable() { addAction.Disable(); }

    private void Start()
    {
        GetComponent<NumberFieldGUI>().SetNumber(1);
    }

    private void Update()
    {
        if (addAction.WasPressedThisFrame())
        {
            GetComponent<NumberFieldGUI>().AddNumber(scoreToAdd);
        }
    }
}