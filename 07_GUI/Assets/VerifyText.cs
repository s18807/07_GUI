using System.Collections;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class VerifyText : MonoBehaviour
{
    string text;

    private void OnGUI()
    {
        text = GetComponent<TMP_InputField>().text;
        if (text == "") GetComponent<TMP_InputField>().image.color = Color.red;
        else GetComponent<TMP_InputField>().image.color = Color.white;
        text = Regex.Replace(text,@"[^a-zA-Z]","");
        GetComponent<TMP_InputField>().text = text;
    }
}
