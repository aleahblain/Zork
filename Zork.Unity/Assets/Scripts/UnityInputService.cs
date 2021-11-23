using UnityEngine;
using Zork;
using TMPro;
using System;

public class UnityInputService : MonoBehaviour, IInputService
{
    [SerializeField]
    private TMP_InputField InputField;

    public event EventHandler<string> InputReceived;

    void Update()
    {
        if (Input.GetKey(KeyCode.Return))
        {
            if (string.IsNullOrWhiteSpace(InputField.text) == false)
            {
                string inputString = InputField.text.Trim().ToUpper();
                InputReceived?.Invoke(this, inputString);
            }

            InputField.text = string.Empty;
        }
    }
}
