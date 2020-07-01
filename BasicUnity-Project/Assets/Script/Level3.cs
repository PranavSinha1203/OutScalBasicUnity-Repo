using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Level3 : MonoBehaviour
{
    // Start is called before the first frame update

    public Button buttonLevel3;
    public string MasterScene3;

    void Start()
    {
        buttonLevel3.onClick.AddListener(OnButton1Click);
    }

    // Update is called once per frame
    void OnButton1Click()
    {
        SceneManager.LoadScene(MasterScene3);
    }
}