using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GameLoaderScript : MonoBehaviour
{
    public void play()
    {
        SceneManager.LoadScene("SpaceChaserGamePlay");
    }
}
