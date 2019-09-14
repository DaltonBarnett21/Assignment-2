using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    private bool GameHasEnded = false;

    public rotator r;
    public Spawner s;
    public Animator animator;
    

    public void EndGame()
    {
        if (GameHasEnded)
            return;

        r.enabled = false;
        s.enabled = false;

        animator.SetTrigger("EndGame");

        GameHasEnded = true;
       
    }

    public void RestartLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
