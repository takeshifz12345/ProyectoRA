using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonsClick : MonoBehaviour
{
    public int index;

    public void GoToScene()
    {
        GameManager.Instance.indexModel = index;
        SceneManager.sceneLoaded += OnSceneLoaded;
        SceneManager.LoadScene("AR");
    }

    private void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        if (scene.name == "AR")
        {
            GameManager.Instance.Iniciar();
            SceneManager.sceneLoaded -= OnSceneLoaded;
        }
    }
}