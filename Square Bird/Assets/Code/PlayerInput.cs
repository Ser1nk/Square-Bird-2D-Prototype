using UnityEngine;

public class PlayerInput : MonoBehaviour
{
    private CubeSpawner _cube;

    private void Start()
    {
        _cube = GetComponent<CubeSpawner>();
    }

    private void Update()
    {
        OnClick();
    }

    public void OnClick()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            _cube.CreateCube();
        }
    }
}
