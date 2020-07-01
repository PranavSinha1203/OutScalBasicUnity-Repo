using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Level2 : MonoBehaviour
{
    // Start is called before the first frame update

    public Button buttonLevel2;
    public string MasterScene2;

    void Start()
    {
        buttonLevel2.onClick.AddListener(OnButton1Click);
    }

    // Update is called once per frame
    void OnButton1Click()
    {
        SceneManager.LoadScene(MasterScene2);
    }
}
