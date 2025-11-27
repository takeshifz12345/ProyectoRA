using UnityEngine;

public class SpawnObjects : MonoBehaviour
{
    public GameObject Object;

    private void Start()
    {
        for (int i = 0; i < GameManager.Instance.models.Length; i++)
        {
            Instantiate(Object, gameObject.transform.position, Quaternion.identity, gameObject.transform);
        }
    }
}