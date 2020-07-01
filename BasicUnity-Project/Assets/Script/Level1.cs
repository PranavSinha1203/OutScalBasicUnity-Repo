using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Level1 : MonoBehaviour
{
    // Start is called before the first frame update

    public Button buttonLevel1;
    public string MasterScene1;

    void Start()
    {
        buttonLevel1.onClick.AddListener(OnButton1Click);
    }

    // Update is called once per frame
    void OnButton1Click()
    {
        SceneManager.LoadScene(MasterScene1);
    }
}
