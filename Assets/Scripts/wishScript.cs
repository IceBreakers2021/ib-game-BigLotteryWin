using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class wishScript : MonoBehaviour {
    public Button button;
    public Text buttonText;
    public string playerSide;
    public void SetSpace ()
    {
        buttonText.text = playerSide;
        button.interactable = false;
    }
}