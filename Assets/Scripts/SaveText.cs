using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SaveText : MonoBehaviour
{

    public static SaveText Instance;

    private InputField inputField;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }

        inputField = GetComponent<InputField>();
    }

    public string GetEnteredText()
    {
        return inputField.text;
    }
}
