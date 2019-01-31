using UnityEngine.SceneManagement;
using UnityEngine;

public class levelcomplete : MonoBehaviour {

    public void LoadNextLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
