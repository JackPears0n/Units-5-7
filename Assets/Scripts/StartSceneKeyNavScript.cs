using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.SceneManagement;

public class StartSceneKeyNavScript : MonoBehaviour
{
    public GameObject currentMenu;

    bool audioToggledOff;
    float sfxVol;
    float musicVol;

    [Header("Menus")]
    public GameObject startScreen;
    public GameObject startMenu;
    public GameObject istructionsScreen;
    public GameObject optionsMenu;
    public GameObject quitMenu;

    [Header("Audio")]
    public GameObject sFXSlider;
    public GameObject musicSlider;
    public AudioMixer sFXAudioMixer;
    public AudioMixer musicAudioMixer;

    private SceneShiftScript sss;
    private ImprovedAudioManager am;

    // Start is called before the first frame update
    void Start()
    {
        currentMenu = startScreen;
        audioToggledOff = false;

        sss = GetComponent<SceneShiftScript>();
        am = GetComponent<ImprovedAudioManager>();
    }

    // Update is called once per frame
    void Update()
    {
        // Start screen keyboard navigation
        if (currentMenu == startScreen)
        {
            // Continue input
            if (Input.GetKeyUp(KeyCode.RightArrow))
            {
                startScreen.SetActive(false);
                startMenu.SetActive(true);
                currentMenu = startMenu;
            }

            // Quit input
            if (Input.GetKeyDown(KeyCode.LeftArrow))
            {
                startScreen.SetActive(false);
                quitMenu.SetActive(true);
                currentMenu = quitMenu;
            }
        }

        // Start menu keyboard navigation
        if (currentMenu == startMenu)
        {
            // Options key
            if (Input.GetKeyDown(KeyCode.UpArrow))
            {
                startMenu.SetActive(false);
                optionsMenu.SetActive(true);
                currentMenu = optionsMenu;
            }

            // Play key
            if (Input.GetKeyUp(KeyCode.RightArrow))
            {
                    startMenu.SetActive(false);
                    istructionsScreen.SetActive(true);
                    currentMenu = istructionsScreen;
            }

            // Quit key
            if (Input.GetKeyDown(KeyCode.LeftArrow))
            {
                startMenu.SetActive(false);
                quitMenu.SetActive(true);
                currentMenu = quitMenu;
            }

        }

        // Instructions screen navigation
        if (currentMenu == istructionsScreen)
        {
            if (Input.GetKeyDown(KeyCode.RightArrow))
            {
                SceneManager.LoadScene("Level1");
            }

            if (Input.GetKeyDown(KeyCode.LeftArrow))
            {
                istructionsScreen.SetActive(false);
                startMenu.SetActive(true);
                currentMenu = startMenu;
            }

        }

        // Options menu navigation
        if (currentMenu == optionsMenu)
        {
            // Makes sure the sliders toggle on
            sFXSlider.SetActive(true);
            musicSlider.SetActive(true);

            /*
            // Increase music volume
            if (Input.GetKeyDown(KeyCode.Q))
            {
                am._MusicVolume = +10;
            }

            // Decrease music volume
            if (Input.GetKeyDown(KeyCode.W))
            {
                am._MusicVolume = -10;
            }

            // Increase SFX volume
            if (Input.GetKeyDown(KeyCode.E))
            {
                am._SFXVol = +10;
            }

            // Decrease SFX volume
            if (Input.GetKeyDown(KeyCode.R))
            {
                am._SFXVol = -10;
            }

            // Toggles audio
            // Needs a look at
            if (Input.GetKeyDown(KeyCode.T))
            {
                if (!audioToggledOff)
                {
                    sFXAudioMixer.SetFloat("SFXVol", 0f);
                    musicAudioMixer.SetFloat("MusicVol", 0f);
                }
                else
                {
                    sfxVol = PlayerPrefs.GetFloat("SFX Mixer");
                    musicVol = PlayerPrefs.GetFloat("Music Mixer");
                    sFXAudioMixer.SetFloat("SFXVol", sfxVol);
                    musicAudioMixer.SetFloat("MusicVol", musicVol);
                }
            }
            */

            // Plays a special effect for testing
            if (Input.GetKeyDown(KeyCode.Return))
            {
                am.PlaySFX("Sword drawn");
            }

            // Goes to start menu
            if (Input.GetKeyDown(KeyCode.LeftArrow))
            {
                optionsMenu.SetActive(false);
                startMenu.SetActive(true);
                currentMenu = startMenu;
            }
        }

        // Quit menu navigation
        if (currentMenu == quitMenu)
        {
            if (Input.GetKeyDown(KeyCode.N))
            {
                quitMenu.SetActive(false);
                startMenu.SetActive(true);
                currentMenu = startMenu;
            }

            if (Input.GetKeyDown(KeyCode.Y))
            {
                Application.Quit();
                UnityEditor.EditorApplication.isPlaying = false;
            }
        }

        // Makes sure the sliders toggle off
        if (currentMenu != optionsMenu)
        {
            sFXSlider.SetActive(false);
            musicSlider.SetActive(false);
        }

    }

    public void ChangeCurrentMenu(GameObject menu)
    {
        currentMenu = menu;
    }
}
