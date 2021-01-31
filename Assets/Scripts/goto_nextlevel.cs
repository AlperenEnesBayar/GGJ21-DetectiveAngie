using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class goto_nextlevel : MonoBehaviour
{

    public Animator Animator;
    public Image black;
    public GameObject black_screen;


    public void goto__nextlevel()
    {
        if(Player.Instance.current_level + 1 < Player.Instance.Levels.Count)
        {
            black_screen.SetActive(true);
            Debug.Log("Work!!!");
            StartCoroutine(Fading());
        }        
        else if(!Player.Instance.isWin)
        {
            black_screen.SetActive(true);
            Debug.Log("Work!!!");
            StartCoroutine(Fading());
        }
    }

    IEnumerator Fading()
    {
      
        Animator.SetBool("isFade", true);
        yield return new WaitUntil(() => black.color.a == 1);
        if (Player.Instance.isWin)
        {
            Player.Instance.isMissed = false;
            Player.Instance.isDone = false;
            Player.Instance.isWin = false;
            Player.Instance.current_level += 1;
            SceneManager.LoadScene("LevelPassage");
        }
        else
        {
            Player.Instance.isMissed = false;
            Player.Instance.isDone = false;
            Player.Instance.isWin = false;
            SceneManager.LoadScene("LevelPassage");
        }
    }
}
