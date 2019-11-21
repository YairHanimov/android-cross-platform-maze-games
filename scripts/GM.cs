using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GM : MonoBehaviour
{
    [SerializeField]
    public int coins;
    [SerializeField]
   public int lifes;
    // Start is called before the first frame update
    [SerializeField]
    UnityEngine.UI.Text CoinText;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
   public void addcoin()
    {
        coins++;
        CoinText.text = "Coins: " + coins;
    }
    /*
    public void decreaseLives()
    {
        lifes = lifes-1;
        Debug.Log(lifes);
        LifeText.text = "Lives " + lifes;
    }
*/
}
