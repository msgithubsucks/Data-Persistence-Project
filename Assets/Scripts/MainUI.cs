using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

[DefaultExecutionOrder(1000)]
public class MainUI : MonoBehaviour
{
    public TMP_InputField playerNameInput;

    void Start()
    {
        this.playerNameInput.text = UIManager.Instance.playerName;
    }

    public void StartGame()
    {
        SceneManager.LoadScene(1);
    }

    public void PopNameInput ()
    {
        this.playerNameInput.gameObject.SetActive(true);
    }
}
