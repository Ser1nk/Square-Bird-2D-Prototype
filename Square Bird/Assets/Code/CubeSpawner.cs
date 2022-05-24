using UnityEngine;

[RequireComponent(typeof(Spawn))]
public class CubeSpawner : MonoBehaviour
{
    private Spawn _spawnObject;

    [SerializeField] private GameObject _childObject;

    [SerializeField] private GameObject _parentObject;

    private void Start()
    {
        _spawnObject = GetComponent<Spawn>();
    }

    public void CreateCube()
    {
        _spawnObject.Create(_childObject, _parentObject);
    }
}
