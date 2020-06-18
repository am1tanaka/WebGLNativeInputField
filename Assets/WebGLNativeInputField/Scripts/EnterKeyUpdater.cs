using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnterKeyUpdater : MonoBehaviour
{
    WebGLNativeInputField webGLIF = null;
    [SerializeField]
    Text outputText = null;

    private void Awake()
    {
        webGLIF = GetComponent<WebGLNativeInputField>();
    }

    public void Changed()
    {
        Debug.Log($"Changed {webGLIF.text} {webGLIF.textComponent.text}");
        outputText.text = webGLIF.text;
    }

    public void Ended()
    {
        Debug.Log("Ended {webGLIF.text}");
    }

}
