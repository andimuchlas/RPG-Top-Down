using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Doublsb.Dialog;
using UnityEngine.InputSystem;

public class TestMessage : MonoBehaviour
{
    public DialogManager DialogManager;
    public PlayerController Dingin;
    public GameObject[] Example;

    private void Awake()
    {
        
        var dialogTexts = new List<DialogData>();

        dialogTexts.Add(new DialogData("Hi, /size:init/my name is Li./close/ ", "Li"));

        dialogTexts.Add(new DialogData("I am Sa. Popped out to let you know Asset can show other characters./close/", "Sa"));
        
        dialogTexts.Add(new DialogData("This Asset, The D'Dialog System has many features./close/ ", "Li"));

        DialogManager.Show(dialogTexts);
    }

    private void Show_Example(int index)
    {
        Example[index].SetActive(true);
    }
}
