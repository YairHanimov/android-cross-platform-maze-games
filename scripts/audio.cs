using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class audio : MonoBehaviour
{
    // Start is called before the first frame update
    private void update()
    {
        DontDestroyOnLoad(transform.gameObject);
    }
}
