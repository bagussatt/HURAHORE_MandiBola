using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CharacterScene : MonoBehaviour
{
    public TMP_InputField namaInput;
    // Start is called before the first frame update
    void Start()
    {


    }

    // Update is called once per frame
    void Update()
    {

    }

    public void SavePlayerName()
    {
        MainManager.Instance.nama = namaInput.text;
        MainManager.Instance.saveNamaData();
        SceneManager.LoadScene(2);
    }
}
