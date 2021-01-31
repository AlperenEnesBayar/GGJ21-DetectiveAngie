using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class winManager : MonoBehaviour
{
    public List<Sprite> sprites; 
    public Text next;
    public Text Feature;
    public Image choosen;
    public Image Answer;
    public Text winnig;
    public AudioSource AudioSource;
    public AudioClip win;
    public AudioClip loose;

    // Start is called before the first frame update
    void Start()
    {
        Feature.text = "Defination was " + Player.Instance.Features[Player.Instance.current_level];

        if (Player.Instance.current_level + 1 < Player.Instance.Levels.Count)
        {
            if (Player.Instance.isWin)
            {
                AudioSource.clip = win;
                next.text = "Next Level";
                winnig.text = "You Win!";
            }
            else if (Player.Instance.isMissed)
            {
                AudioSource.clip = loose;
                next.text = "Retry";
                winnig.text = "You Missed!";
            }
            else
            {
                AudioSource.clip = loose;
                next.text = "Retry";
                winnig.text = "You Lose!";
            }
        }
        else
        {
            if (Player.Instance.isWin)
            {
                AudioSource.clip = win;
                next.text = "You beat the whole game!";
                winnig.text = "You Win!";
            }
            else if (Player.Instance.isMissed)
            {
                AudioSource.clip = loose;
                next.text = "Retry";
                winnig.text = "You Missed!";
            }
            else
            {
                AudioSource.clip = loose;
                next.text = "Retry";
                winnig.text = "You Lose!";
            }
        }

        AudioSource.Play();

        Color yellow = new Color(242, 243, 219);
        Color white = Color.white;

        if (Player.Instance.isMissed)
        {
            choosen.color = yellow;
            Answer.color = yellow;

            choosen.sprite = null;
            Answer.sprite = null;
        }
        else
        {
            choosen.color = white;
            Answer.color = white;

            choosen.sprite = sprites[int.Parse(Player.Instance.choosen)];
            Answer.sprite = sprites[int.Parse(Player.Instance.Killers[Player.Instance.current_level])];
        }
        

    }

   
}
