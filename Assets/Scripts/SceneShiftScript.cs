using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneShiftScript : MonoBehaviour
{
    public string destination;

    void SceneShift()
    {
        SceneManager.LoadScene(destination);
    }

    public void ScriptShiftScene(string scene)
    {
        SceneManager.LoadScene(scene);
    }
}
