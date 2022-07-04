using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class MenuUIHandler : MonoBehaviour
{
    public string newPlayerName;
    public TextMeshProUGUI playerNameText;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void PlayerName()
    {
        newPlayerName = playerNameText.text;
        MainManager.instance.playerName = newPlayerName;
    }
    public void StartNew()
    {
        SceneManager.LoadScene(1);
    }
}
