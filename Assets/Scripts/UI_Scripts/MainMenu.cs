using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu: MonoBehaviour
{
    [SerializeField] private GameObject optionPanel, creditPanel;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void BackButton()
    {
        optionPanel.SetActive(false);
        creditPanel.SetActive(false);

    }

    public void GoToOption()
    {
        optionPanel.SetActive(true);
    }

    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("Quit Game");
    }

    public void PlayGame(string playSceneIndex)
    {
        SceneManager.LoadScene(playSceneIndex);
    }

    List<int> widthResolution = new List<int>() { 2560, 1920, 1280 };
    List<int> heightResolution = new List<int>() { 1400, 1080, 720 };

    public void SetScreenSize(int index)
    {
        bool fullscreen = Screen.fullScreen;

        int width = widthResolution[index];
        int height = heightResolution[index];

        Screen.SetResolution(width, height, fullscreen);
    }

    public void SetFullScreen(bool _fullscreen)
    {
        Screen.fullScreen = _fullscreen;
    }
}
