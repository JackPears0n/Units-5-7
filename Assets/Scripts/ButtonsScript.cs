using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonsScript : MonoBehaviour
{
    //private StartSceneKeyNavScript ssknv;
    private ImprovedAudioManager am;
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

    public void SetDiffEasy()
    {
        PlayerPrefs.SetString("Difficulty", "Easy");
    }
    public void SetDiffMid()
    {
        PlayerPrefs.SetString("Difficulty", "Medium");
    }
    public void SetDiffHard()
    {
        PlayerPrefs.SetString("Difficulty", "Hard");
    }
}
