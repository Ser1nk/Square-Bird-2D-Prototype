using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private const string Trap = "Trap";
    private const string Finish = "Finish";

    [SerializeField] private Move _move;
    [SerializeField] private GameManager _gameManager;

    public void Init(Move move, GameManager gameManager)
    {
        _move = move;
        _gameManager = gameManager;
    }

    private void Die()
    {
        _move.StopMoveObject();
        _gameManager.LoseLevel();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag(Trap))
        {
            Debug.Log("Death");

            Die();
        }

        if (other.CompareTag(Finish))
        {
            Debug.Log("Win");

            _gameManager.RestartLevel();
        }
    }
}
