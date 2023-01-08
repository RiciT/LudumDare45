using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundDelete : MonoBehaviour
{
    public Transform Player;

    public Sprite RedBg;
    public Sprite OrangeBg;
    public Sprite YellowBg;
    public Sprite GreenBg;
    public Sprite BlueBg;
    public Sprite PurpleBg;
    public Sprite RosaBg;

    // Start is called before the first frame update
    void Start()
    {
        if (this.name == "Background")
        {
            int r = Random.Range(1, 7);
            if (r == 1)
            {
                this.GetComponent<SpriteRenderer>().sprite = RedBg;
            }
            else if (r == 2)
            {
                this.GetComponent<SpriteRenderer>().sprite = OrangeBg;
            }
            else if (r == 3)
            {
                this.GetComponent<SpriteRenderer>().sprite = YellowBg;
            }
            else if (r == 4)
            {
                this.GetComponent<SpriteRenderer>().sprite = GreenBg;
            }
            else if (r == 5)
            {
                this.GetComponent<SpriteRenderer>().sprite = BlueBg;
            }
            else if (r == 6)
            {
                this.GetComponent<SpriteRenderer>().sprite = PurpleBg;
            }
            else if (r == 7)
            {
                this.GetComponent<SpriteRenderer>().sprite = RosaBg;
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (this.transform.position.x < Player.position.x - 40 && this.name != "Background")
        {
            Destroy(this.gameObject);
        }
        if (Input.GetKeyDown(KeyCode.Keypad1) || Input.GetKeyDown(KeyCode.Alpha1))
        {
            this.GetComponent<SpriteRenderer>().sprite = RedBg;
        }
        else if (Input.GetKeyDown(KeyCode.Keypad2) || Input.GetKeyDown(KeyCode.Alpha2))
        {
            this.GetComponent<SpriteRenderer>().sprite = OrangeBg;
        }
        else if (Input.GetKeyDown(KeyCode.Keypad3) || Input.GetKeyDown(KeyCode.Alpha3))
        {
            this.GetComponent<SpriteRenderer>().sprite = YellowBg;
        }
        else if (Input.GetKeyDown(KeyCode.Keypad4) || Input.GetKeyDown(KeyCode.Alpha4))
        {
            this.GetComponent<SpriteRenderer>().sprite = GreenBg;
        }
        else if (Input.GetKeyDown(KeyCode.Keypad5) || Input.GetKeyDown(KeyCode.Alpha5))
        {
            this.GetComponent<SpriteRenderer>().sprite = BlueBg;
        }
        else if (Input.GetKeyDown(KeyCode.Keypad6) || Input.GetKeyDown(KeyCode.Alpha6))
        {
            this.GetComponent<SpriteRenderer>().sprite = PurpleBg;
        }
        else if (Input.GetKeyDown(KeyCode.Keypad7) || Input.GetKeyDown(KeyCode.Alpha7))
        {
            this.GetComponent<SpriteRenderer>().sprite = RosaBg;
        }
    }
}
