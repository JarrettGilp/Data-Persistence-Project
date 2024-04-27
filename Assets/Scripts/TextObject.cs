using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class TextObject : MonoBehaviour
{
    public static TextObject instance;
    public TMP_InputField nameInputField;
    public TMP_Text name;
    string nameText;

    private void Awake()
    {
        instance = this;
        DontDestroyOnLoad(gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        name.text = nameInputField.text;
        setNameText(name.text);
    }

    public void setNameText(string nameText)
    {
        this.nameText = nameText;
    }

    public string getNameText()
    {
        return nameText;
    }
}
