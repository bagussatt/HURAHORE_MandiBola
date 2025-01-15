using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameSceneManager : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    private int score;
    public TextMeshProUGUI nameText;

    // Start is called before the first frame update  
    void Start()
    {
        nameText.text = MainManager.Instance.nama;
    }

}
