using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ScenePause : MonoBehaviour
{
    public TextMeshProUGUI text;
    private void Awake()
    {
        Time.timeScale = 0;
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)) {
            Time.timeScale = 1;
            text.enabled = false;
        }
    }
}
