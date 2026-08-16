using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    [SerializeField]
    private GameObject mainMenu;

    [SerializeField]
    private GameObject settings;

    [SerializeField]
    private Button exit;

    public void StartGame()
    {
        SceneManager.LoadScene("Scene 9");
    }

    public void Setings()
    {
        mainMenu.SetActive(false);
        settings.SetActive(true);
    }

    public void MainMenu()
    {
        mainMenu.SetActive(true);
        settings.SetActive(false);
    }

    public void Awake()
    {
        DontDestroyOnLoad(gameObject);
        exit.interactable = false;
    }
}
