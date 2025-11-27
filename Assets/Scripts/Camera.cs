using UnityEngine;
using Vuforia;

public class Camera : MonoBehaviour
{
    void Awake()
    {
        DontDestroyOnLoad(gameObject);
    }
}