using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StartScript : MonoBehaviour
{
    public Button nothingButton;

    public void NothingPressed()
    {
        nothingButton.gameObject.SetActive(false);
    }
}
