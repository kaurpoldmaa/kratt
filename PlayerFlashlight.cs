using UnityEngine;

public class PlayerFlashlight : MonoBehaviour
{
    public Light flashlight;
    private bool isOn;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            isOn = !isOn;
            flashlight.enabled = isOn;
        }
    }

    public bool IsOn()
    {
        return isOn;
    }
}