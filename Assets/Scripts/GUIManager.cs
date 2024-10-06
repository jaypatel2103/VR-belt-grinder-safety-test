using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GUIManager : MonoBehaviour
{

    // Static instance of GUIManager
    private static GUIManager _instance;

    // Public static property to access the instance
    public static GUIManager Instance
    {
        get
        {
            if (_instance == null)
            {
                _instance = FindObjectOfType<GUIManager>();

                if (_instance == null)
                {
                    GameObject singleton = new GameObject(typeof(GUIManager).ToString());
                    _instance = singleton.AddComponent<GUIManager>();
                    DontDestroyOnLoad(singleton);
                }
            }
            return _instance;
        }
    }

    // References to the panel GameObjects
    public GameObject startPanel;
    public GameObject finishPanel;
    public GameObject restartPanel;
    public GameObject directionPanel;
    public GameObject directionToWSPanel;
    public GameObject passPanel;
    public GameObject failPanel;

    private void Awake()
    {
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
        // Optionally, initialize by showing the main menu panel
        ShowStart();
    }

    // Method to show the main menu panel
    public void ShowStart()
    {
        HideAllPanels();
        startPanel.SetActive(true);
    }

    // Method to show the settings panel
    public void ShowFinish()
    {
        HideAllPanels();
        finishPanel.SetActive(true);
    }

    // Method to show the credits panel
    public void ShowRestart()
    {
        HideAllPanels();
        restartPanel.SetActive(true);
    }
    // Method to show the credits panel
    public void ShowDireaction()
    {
        HideAllPanels();
        directionPanel.SetActive(true);
    }
    // Method to show the credits panel
    public void ShowDireactionToWS()
    {
        HideAllPanels();
        directionToWSPanel.SetActive(true);
    }
    public void ShowPass()
    {
        //HideAllPanels();
        passPanel.SetActive(true);
    }

    public void ShowFail()
    {
        //HideAllPanels();
        failPanel.SetActive(true);
    }
    // Method to hide all panels
    public void HideAllPanels()
    {
        startPanel.SetActive(false);
        finishPanel.SetActive(false);
        restartPanel.SetActive(false);
        directionPanel.SetActive(false);
        failPanel.SetActive(false);
        passPanel.SetActive(false);
        directionToWSPanel.SetActive(false);
    }
}
