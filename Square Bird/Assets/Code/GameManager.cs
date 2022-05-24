using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    [SerializeField] private int _currentLevel;
    [SerializeField] private int _nextLevel;

    [SerializeField] private GameObject _deathPanel;

    [SerializeField] private Move _move;
    //loadlevel();

    public void Init(Move move)
    {
        _move = move;
    }

    public void StartLevel()
    {
        _move.isMove = true;
    }

    public void RestartLevel()
    {
        SceneManager.LoadScene(_currentLevel);
    }

    public void NextLevel()
    {
        SceneManager.LoadScene(_nextLevel);
    }

    public void LoseLevel()
    {
        _deathPanel.SetActive(true);
    }

    public void ExitGame()
    {
        Application.Quit();
    }
}
