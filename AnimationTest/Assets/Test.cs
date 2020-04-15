using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha5))
        {
            transform.localScale = Vector3.zero;

            //To : "scale", Vector3.one,
            // 0 -> 1
            iTween.ScaleTo(gameObject,
                iTween.Hash(
                    "scale", Vector3.one,
                    "easeType", "easeOutBack",
                    "time", 0.5f
                ));
            
        }
    }
}
