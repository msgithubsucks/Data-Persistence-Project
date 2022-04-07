using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

[DefaultExecutionOrder(1000)]
public class UIManager : MonoBehaviour
{
    public static readonly string DEFAULT_PLAYER_NAME = "Player Name";

    public static UIManager Instance;

    public TMP_InputField playerNameInput;
    public TMP_Text inputDefaultText;
    public string playerName;

    private void Awake()
    {
        if (Instance != null)
        {
            Destroy(gameObject);
            return;
        }

        Instance = this;
        DontDestroyOnLoad(gameObject);
    }

    private void Start()
    {
        this.playerName = DEFAULT_PLAYER_NAME;
        this.playerNameInput.text = UIManager.Instance.playerName;
        this.inputDefaultText.text = UIManager.Instance.playerName;
    }

    public void StartGame()
    {
        this.playerName = this.playerNameInput.text;
        SceneManager.LoadScene(1);
    }
}
