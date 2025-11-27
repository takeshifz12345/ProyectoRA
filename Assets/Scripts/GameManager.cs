using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    public int indexModel;

    public GameObject[] models;

    public Sprite[] imagesModels;

    public string[] namesModels;

    public Vector3 positionModel = new Vector3(0f, 0f, 0f);

    public Vector3 scaleModel = new Vector3(0.1f, 0.1f, 0.1f);

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;

            DontDestroyOnLoad(gameObject);
        }
        else if (Instance != this)
        {
            Destroy(gameObject);

            return;
        }
    }

    public void Iniciar()
    {
        GameObject model = Instantiate(models[indexModel], positionModel, Quaternion.identity);

        model.transform.localScale = scaleModel;
    }
}