using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public string firstLevel;

    [SerializeField]
    public GameObject panel;

    [SerializeField]
    public GameObject Settings;

    [SerializeField]
    public GameObject MainMenu;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
 
    public void loadlevel(string level)
    {
        SceneManager.LoadScene(level);

    }

    public void StartGame()
    {
        SceneManager.LoadScene(firstLevel);
    }

    public void OpenOptions()
    {

    }

    public void CloseOptions()
    {

    }

    public void QuitGame()
    {
        Application.Quit();
    }

    public void hidePanel(GameObject panel)
    {
        panel.gameObject.SetActive(false);
    }

    public void showPanel(GameObject panel)
    {
        panel.gameObject.SetActive(true);
    }

}
