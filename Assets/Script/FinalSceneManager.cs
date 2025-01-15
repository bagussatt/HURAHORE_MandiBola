using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinalSceneManager : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI nameText;
    public TextMeshProUGUI bestScoreText;
    public TextMeshProUGUI bestNameText;

    // Start is called before the first frame update  
    void Start()
    {
        // Menampilkan score saat ini  
        scoreText.text = "Score: " + MainManager.Instance.score.ToString();
        nameText.text = "Nama: " + MainManager.Instance.nama; 
    }

    // Update is called once per frame  
    void Update()
    {

    }

    public void BackToMainMenu()
    {
        SceneManager.LoadScene(0);
    }

    public void PlayAgain()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        SceneManager.LoadScene(2);
    }
}
