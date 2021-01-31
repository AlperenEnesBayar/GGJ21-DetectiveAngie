using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class playButton : MonoBehaviour
{
    public void goto_levelpassage()
    {
        SceneManager.LoadScene("LevelPassage");
    }
}
