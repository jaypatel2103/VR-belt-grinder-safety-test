using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManger : MonoBehaviour
{
    // Static instance of GameManager which allows it to be accessed by any other script.
    private static GameManger _instance;
    private int score = 0;
    //public bool isVideoWatched = false;
    public CloseButtonMachine closeButtonMachine;

    // Public static property to access the instance
    public static GameManger Instance
    {
        get
        {
            // If the instance is null, search for an existing instance in the scene
            if (_instance == null)
            {
                _instance = FindObjectOfType<GameManger>();

                // If no instance is found, create a new one
                if (_instance == null)
                {
                    GameObject singleton = new GameObject(typeof(GameManger).ToString());
                    _instance = singleton.AddComponent<GameManger>();
                    DontDestroyOnLoad(singleton);
                }
            }
            return _instance;
        }
    }

    // Awake is called when the script instance is being loaded
    private void Awake()
    {
        // Check if the instance already exists and destroy the new one if it does
        if (_instance == null)
        {
            _instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else if (_instance != this)
        {
            Destroy(gameObject);
        }


    }
    private void Start()
    {
        score = 0;
    }

    public void AddScore(int newScore)
    {
        score += newScore;
    }

    public void Quit()
    {
        // If we are running in a standalone build of the game
#if UNITY_STANDALONE
        Application.Quit();
#endif

        // If we are running in the editor
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#endif
    }

    public void Finish()
    {
        StopMachine();
        if (score == 4)
        {
            GUIManager.Instance.ShowFinish();
            GUIManager.Instance.ShowPass();
        }
        else
        {
            
            GUIManager.Instance.ShowRestart();
            GUIManager.Instance.ShowFail();
        }
    }

    public int Getscore()
    {
        return score;
    }
    public void StopMachine()
    {
        closeButtonMachine.StopMachineAudio();
    }
}
