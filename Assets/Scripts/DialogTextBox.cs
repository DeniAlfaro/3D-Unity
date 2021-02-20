using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogTextBox : MonoBehaviour
{
    [SerializeField]
    Text dialog;

    [SerializeField]
    string message;

    IEnumerator animateText;

    [SerializeField, Range(0.001f, 4f)]
    float animationSpeed;

    public void ClearText() {
        dialog.text = "";
    }

    public void ShowDialong() {
        animateText = Animate(animationSpeed);
        StartCoroutine(animateText);
    }

    public string Message { get => message; set => message = value; }

    public void Animate (float time) {
        int i = 0;
        while (i < Message.Length - 1)
        {
            dialog.text += message[i];
            i++;
            yield return new WaitForSeconds(time);
        }
    }
}
