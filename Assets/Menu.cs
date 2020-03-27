using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Menu : MonoBehaviour
{
    // Start is called before the first frame update
    public Button PlaySoloButton;
    public Button PlayDuoButton;
    public Button QuitButton;
    public Button MenuButton;
        
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ToMenu()
    {
        SceneManager.LoadScene(0);
    }
    public void PlayDuo()
    {
        SceneManager.LoadScene(1);
    }
    public void PlaySolo()
    {
        SceneManager.LoadScene(4);
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
