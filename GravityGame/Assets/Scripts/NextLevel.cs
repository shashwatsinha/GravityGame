using UnityEngine;
using System.Collections;

public class NextLevel : MonoBehaviour {
    int currentLevel;
    void Start()
    {
        currentLevel = Application.loadedLevel;
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if(col.gameObject.tag=="Player")
        {
            Application.LoadLevel(currentLevel+1);
        }
    }
}
