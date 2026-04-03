using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Over : MonoBehaviour
{
    public GameObject gameoverui;
    public Text score;

    void OnEnable()
    {
        SateliteMovment.playerinfo += load;
    }

    void OnDisable()
    {
        SateliteMovment.playerinfo -= load;
    }
    void Start()
    {
        gameoverui.SetActive(false);
    }

    void load()
    {
        Debug.Log("Event Called");
        score.text = BulletMovment.score.ToString() + " Points";
        gameoverui.SetActive(true);
    }
}
