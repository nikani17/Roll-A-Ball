using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class RestartGameController : MonoBehaviour
{
    [SerializeField] private Button restartGameButton;

    private void Awake()
    {
        restartGameButton.onClick.AddListener(OnRestartGameButtonClicked);
    }

    private void OnRestartGameButtonClicked()
    {
        SceneManager.LoadScene("Game");
    }
}
