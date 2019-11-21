using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class playbuttem: MonoBehaviour
{

    // Update is called once per frame
    void Update()
    {

    }
    public void OnMouseClick()
    {

        SceneManager.LoadSceneAsync("Level1Mars");
    }
}
