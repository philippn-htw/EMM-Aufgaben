using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuManagerBehaviour : MonoBehaviour
{

    public GameObject Menu;

    public Button restartButton;
    public Button returnButton;

    // Start is called before the first frame update
    void Start()
    {
        Menu.SetActive(false);

        restartButton.onClick.AddListener(restartClicked);
        returnButton.onClick.AddListener(returnClicked);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape)) {
            if(Menu.activeSelf) {
                Menu.SetActive(false);
                Time.timeScale=1;
            } else {
                Menu.SetActive(true);
                Time.timeScale=0;
            }
        }
    }

    void returnClicked() {
        Menu.SetActive(false);
        Time.timeScale=1;
    }

    void restartClicked() {
        Menu.SetActive(false);
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        Time.timeScale=1;
    }
}
