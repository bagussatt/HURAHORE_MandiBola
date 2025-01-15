using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System;

public class MainManager : MonoBehaviour
{
    public static MainManager Instance;
    public int score; 
    public string nama;
    public BossSpawn bossSpawn;

    private void Awake()
    {
        if (Instance != null)
        {
            Destroy(gameObject);
            return;
        }
        Instance = this;
        DontDestroyOnLoad(gameObject);
    }

    private void Start()
    {
        
    }

    [Serializable]
    public class ScoreData
    {
        public int scoretot;   
    }

    public class namaData
    {
        public string namaPlay;
    }

    public void AddScore(int scoreToAdd)
    {
        score += scoreToAdd;    
        Debug.Log("Score Updated: " + score);
    }

    public void saveScoreData()
    {
        ScoreData data = new ScoreData();
        data.scoretot = score;

        string json = JsonUtility.ToJson(data);

        File.WriteAllText(Application.dataPath + "/scoresavefile.json", json);
    }

    public void saveNamaData()
    {
        namaData data = new namaData();
        data.namaPlay = nama;

        string json = JsonUtility.ToJson(data);

        File.WriteAllText(Application.dataPath + "/savefile.json", json);
    }

}
