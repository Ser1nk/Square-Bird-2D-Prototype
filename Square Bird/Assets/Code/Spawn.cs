using UnityEngine;

public class Spawn : MonoBehaviour
{
    public void Create(GameObject originalObject, GameObject spawnPoint)
    {
        Instantiate(originalObject, spawnPoint.transform.position, Quaternion.identity);
    }
}
