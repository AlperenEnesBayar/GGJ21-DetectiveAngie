using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public Animator Animator;
    public Image black;
    bool isDoning = false;

    public float timeRemaining = 27;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (timeRemaining > 0)
        {
            timeRemaining -= Time.deltaTime;
        }
        else
        {
            if (!isDoning)
            {
                Player.Instance.isMissed = true;
                isDoning = true;
                StartCoroutine(Fading());
            }
        }


        if (!isDoning)
        {
            if (Player.Instance.isDone)
            {
                isDoning = true;
                StartCoroutine(Fading());
            }
        }
        
    }

    IEnumerator Fading()
    {
        Animator.SetBool("isFade", true);
        yield return new WaitUntil(() => black.color.a == 1);
        SceneManager.LoadScene("Elevate");
    }


}
