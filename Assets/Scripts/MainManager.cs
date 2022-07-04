using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;


public class MainManager : MonoBehaviour
{
    [System.Serializable]

    class SaveData
    {
        public int bestScore;
        public string bestPlayerName;
    }
    public void SaveHighScore()
    {
        SaveData data = new SaveData();
        data.bestScore = bestScore;
        data.bestPlayerName = bestPlayerName;
        string json = JsonUtility.ToJson(data);
        File.WriteAllText(Application.persistentDataPath + "/savefile.json", json);
    }
    public void LoadHighScore()
    {
        string path = Application.persistentDataPath + "/savefile.json";
        if (File.Exists(path))
        {
            string json = File.ReadAllText(path);
            SaveData data = JsonUtility.FromJson<SaveData>(json);
            bestScore = data.bestScore;
            bestPlayerName = data.bestPlayerName;
        }
    }
    public static MainManager instance;
    public int bestScore;
    public string playerName;
    public string bestPlayerName; 
    void Start()
    {
        bestScore = 0;
        bestPlayerName = "";
        playerName = "";
    }

    void Update()
    {
        
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
