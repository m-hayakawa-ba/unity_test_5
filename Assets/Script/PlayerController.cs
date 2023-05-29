using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Application.targetFrameRate = 60;
    }

    // Update is called once per frame
    void Update()
    {
        //左矢印が押されたとき
        if (Input.GetKeyDown(KeyCode.LeftArrow)) {
            transform.Translate(-1, 0, 0);
        }

        //右矢印が押されたとき
        if (Input.GetKeyDown(KeyCode.RightArrow)) {
            transform.Translate(1, 0, 0);
        }
    }

    public void LButtonDown()
    {
        transform.Translate(-1, 0, 0);
    }

    public void RButtonDown()
    {
        transform.Translate(1, 0, 0);
    } 
}
