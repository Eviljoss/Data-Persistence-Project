using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class MainManager : MonoBehaviour
{
    public static MainManager instance;
    public int bestScore;
    public string playerName;
    public string bestPlayerName;
    public static GameObject InputField;
    public TextMeshProUGUI playerNameText;
    void Start()
    {
        bestScore = 0;
        bestPlayerName = "";
    }

    void Update()
    {
        
    }
    public void PlayerName()
    {
        playerName = playerNameText.text;
    }
    private void Awake()
    {
        if (instance != null)
        {
            Destroy(gameObject);
            return;
        }
        instance = this;
        DontDestroyOnLoad(gameObject);
    }
}
