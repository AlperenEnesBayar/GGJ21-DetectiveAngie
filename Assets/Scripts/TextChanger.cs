using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextChanger : MonoBehaviour
{
    public Text Level;
    public Text Features;

    void Start()
    {
        Level.text = "Level: " + (Player.Instance.current_level + 1).ToString() + "/" + Player.Instance.Levels.Count.ToString();
        Features.text = Player.Instance.Features[Player.Instance.current_level];
    }

    
}
