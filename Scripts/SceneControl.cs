using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class SceneControl : MonoBehaviour {
    private static int enemyCounter;

    public void EnemyEnter ()
    {
        enemyCounter++;
    }

    public void enemyDefeat ()
    {
        enemyCounter--;
        Debug.Log(enemyCounter);

        if (enemyCounter == 0)
        {
            SceneManager.LoadScene("End");
        }
    }

    public void PlayerDefeat ()
    {
        SceneManager.LoadScene("GameOver");
    }
}

