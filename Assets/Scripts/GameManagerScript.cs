using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GameManagerScript : MonoBehaviour
{
    public void play()
    {
        SceneManager.LoadScene("SpaceChaserGamePlay");
    }
    public void ret()
    {
        SceneManager.LoadScene("SpaceChaserMainMenu");
    }
}
