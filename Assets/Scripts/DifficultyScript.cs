using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DifficultyScript : MonoBehaviour
{
    public static DifficultyScript instance;

    [SerializeField] public Text diffChange;
    void Awake()
    {
        // Stops the GameObject being destroyed,and makes sure there is only one in existance
        if (instance == null)
        {
            // if instance is null, store a reference to this instance
            instance = this;
            DontDestroyOnLoad(gameObject);
            print("dont destroy");
        }
        else
        {
            // Another instance of this gameobject has been made so destroy it as we already have one
            print("do destroy");
            Destroy(gameObject);
        }
    }

    private void Start()
    {
        diffChange.text = PlayerPrefs.GetString("Difficulty").ToString();
    }
}
