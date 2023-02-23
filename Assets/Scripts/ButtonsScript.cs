using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonsScript : MonoBehaviour
{
    //private StartSceneKeyNavScript ssknv;
    public GameObject nextMenu;

    void Start()
    {
        //ssknv = GetComponent<StartSceneKeyNavScript>();
    }

    public void QuitGame()
    {
        Application.Quit();
        UnityEditor.EditorApplication.isPlaying = false;
    }

    /*
    public void OnPush()
    {
        ssknv.ChangeCurrentMenu(nextMenu);
    }
    */
}
