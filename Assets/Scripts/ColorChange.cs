using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChange : MonoBehaviour
{
    public Sprite Red;
    public Sprite Orange;
    public Sprite Yellow;
    public Sprite Green;
    public Sprite Blue;
    public Sprite Purple;
    public Sprite Rosa;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Keypad1) || Input.GetKeyDown(KeyCode.Alpha1))
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = Red;
        }
        else if (Input.GetKeyDown(KeyCode.Keypad2) || Input.GetKeyDown(KeyCode.Alpha2))
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = Orange;
        }
        else if (Input.GetKeyDown(KeyCode.Keypad3) || Input.GetKeyDown(KeyCode.Alpha3))
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = Yellow;
        }
        else if (Input.GetKeyDown(KeyCode.Keypad4) || Input.GetKeyDown(KeyCode.Alpha4))
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = Green;
        }
        else if (Input.GetKeyDown(KeyCode.Keypad5) || Input.GetKeyDown(KeyCode.Alpha5))
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = Blue;
        }
        else if (Input.GetKeyDown(KeyCode.Keypad6) || Input.GetKeyDown(KeyCode.Alpha6))
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = Purple;
        }
        else if (Input.GetKeyDown(KeyCode.Keypad7) || Input.GetKeyDown(KeyCode.Alpha7))
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = Rosa;
        }
    }
}
