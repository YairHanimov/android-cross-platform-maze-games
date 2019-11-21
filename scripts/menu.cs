using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menu : MonoBehaviour
{ 

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnMouseClick() {
        Debug.Log("tesrtt");

        SceneManager.LoadSceneAsync("Level1Mars");
    }
}
