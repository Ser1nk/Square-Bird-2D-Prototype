using UnityEngine;

public class Move : MonoBehaviour
{
    [SerializeField] private GameObject _gameObject;

    [SerializeField] private Vector2 _direction;

    [SerializeField] private float _speed;

    public bool isMove;

    private void Update()
    {
        MoveObject();
    }

    public void MoveObject()
    {
        if (isMove)
        {
            gameObject.transform.Translate(_direction * _speed * Time.deltaTime);
        }
    }

    public void StopMoveObject()
    {
        isMove = false;
    }
}