using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuManager : MonoBehaviour
{
    public static MainMenuManager Instance;
    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
        
    }
    public void StartGame() => SceneManager.LoadScene(1);
    public void LoadMainMenu() => SceneManager.LoadScene(0);
    public void ExitGame()
    {
        print("Ценок");
        //Application.Quit();
    }
}
