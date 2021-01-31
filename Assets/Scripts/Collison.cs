using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collison : MonoBehaviour
{
    public GameObject arrest;
    bool asd = false;
    List<string> cols;
    public AudioSource AudioSource;

    private void Start()
    {
        cols = new List<string>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "NPC")
        {
            AudioSource.Play();
            cols.Add(collision.name);
        }
    }

    void OnTriggerStay2D(Collider2D other)
    {
        if (other.tag == "NPC")
        {
            arrest.SetActive(true);
            asd = true;
        }               
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if (other.tag == "NPC")
        {
            cols.Remove(other.name);
            arrest.SetActive(false);
            asd = false;
        }        
    }

    private void Update()
    {
        if(asd)
        {
            if(Input.GetKeyDown("space"))
            {
                if(cols.Contains(Player.Instance.Killers[Player.Instance.current_level]))
                {
                    Player.Instance.choosen = Player.Instance.Killers[Player.Instance.current_level];
                    Player.Instance.isWin = true;
                    Player.Instance.isDone = true;
                }
                else
                {
                    Player.Instance.choosen = cols[0];
                    Player.Instance.isWin = false;
                    Player.Instance.isDone = true;
                }   
            }              
        }
    }
}

