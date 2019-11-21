using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player12 : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
    public int numberOfCoins = 0;
    public int lifes = 3;

    public GM gm;
    public GM gmLives;
    public coin coin;
   
    [SerializeField]
    float minY;
    void Start()
    {
        gm = GameObject.Find("Camera").GetComponent<GM>();

    }

    // Update is called once per frame
    [System.Obsolete]
    void Update()
    {

        //gmLives = GameObject.Find("Camera").GetComponent<GM>();
        if (transform.position.y < minY)
        {
            Application.LoadLevel("menu");



        }
    }

    [System.Obsolete]
    void OnCollisionEnter(Collision collision)
    {
        //  string currentLevel = collision.gameObject.GetComponent<ep>().level;
        if (collision.gameObject.tag == "K")
        {
            gm = GameObject.Find("Camera").GetComponent<GM>();
            Destroy(collision.gameObject);
            numberOfCoins++;
            gm.addcoin();
            
            PlayerPrefs.SetInt("numberOfCoins", numberOfCoins);
            if (numberOfCoins == 3) 
            {
                Application.LoadLevel("Level2Moon");
            }
            if (numberOfCoins == 9)
            {
                Application.LoadLevel("Level3Earth");
            }
            if (numberOfCoins == 13)
            {
                Application.LoadLevel("MENU");

            }

        }
        if (collision.gameObject.tag == "Ep")
        {
            Application.LoadLevel(collision.gameObject.GetComponent<ep>().level);
        }
    }
}
