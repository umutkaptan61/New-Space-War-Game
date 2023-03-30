using UnityEngine;
using UnityEngine.SceneManagement;

public class StageFinish : MonoBehaviour
{

    public void BackToMainMenu()
    {
        SceneManager.LoadScene("FirstScene", LoadSceneMode.Single);
    }

    public void SelectLevel(string levelName)
    {
        SceneManager.LoadScene(levelName, LoadSceneMode.Single);
    }
}
