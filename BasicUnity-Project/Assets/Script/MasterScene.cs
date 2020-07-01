using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class MasterScene : MonoBehaviour
{
    // Start is called before the first frame update
    public Button button1;
    public Button button2;
    public Button button3;
    public string Level1, Level2, Level3;
    void Start()
    {
        button1.onClick.AddListener(OnButton1Click);
        button2.onClick.AddListener(OnButton2Click);
        button3.onClick.AddListener(OnButton3Click);
    }

    void OnButton1Click()
    {
        SceneManager.LoadScene(Level1);
    }
    void OnButton2Click()
    {
        SceneManager.LoadScene(Level2);
    }
    void OnButton3Click()
    {
        SceneManager.LoadScene(Level3);
    }
}
