using CarterGames.Assets.AudioManager;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SoundManager: MonoBehaviour
{
    [Header("READ_ONLY")]
    [SerializeField]
    private int currentSceneIndex;

    [Header("Audio File")]
    [SerializeField]
    private AudioClip menuBGM;
    [SerializeField]
    private AudioClip gameBGM;

    private void OnEnable()
    {
        //Subscribe to sceneLoaded event
        SceneManager.sceneLoaded += OnSceneLoaded;
    }

    // Start is called before the first frame update
    void Start()
    {

    }

    //When scene change -> Check if it's Gameplay scene
    //Play Calm
    void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        //MenuIndex = 0
        //PlayIndex = 1

        //Get the current index
        currentSceneIndex = SceneManager.GetActiveScene().buildIndex;

        //Make sure AudioSource/BGM loop
        if (currentSceneIndex == 0)
        {
            MusicPlayer.instance.ShouldLoop = true;
            MusicPlayer.instance.PlayTrack(menuBGM);
        }

        else
        {
            MusicPlayer.instance.ShouldLoop = true;
            MusicPlayer.instance.PlayTrack(gameBGM);
        }
    }

    public void OnButtonHover(string SFXname)
    {
        AudioManager.instance.Play(SFXname);
    }

    public void OnButtonClick(string SFXname)
    {
        AudioManager.instance.Play(SFXname);
    }


    // Update is called once per frame
    void Update()
    {

    }

    private void OnDisable()
    {
        SceneManager.sceneLoaded -= OnSceneLoaded;
    }

}
