using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TweenTest : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Alpha1))
        {
            transform.localScale = Vector3.zero;
            iTween.ScaleTo(gameObject, iTween.Hash(
                "scale", Vector3.one,
                "easeType", "easeOutBack",
                "time", 0.5f));
        }

        if(Input.GetKeyDown(KeyCode.Alpha2))
        {   
            iTween.MoveBy(gameObject, iTween.Hash(
                "x", Screen.width,
                "easeType", "easeInBack",
                "time", 0.5f));
        }

        if(Input.GetKeyDown(KeyCode.Alpha3))
        {
            iTween.MoveBy(gameObject, iTween.Hash(
                "x", -Screen.width,
                "easeType", "easeOutBounce",
                "time", 1));
        }
    }
}
