using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class SpawnObjects : MonoBehaviour
{
    public GameObject Object;

    private void Start()
    {
        for (int i = 0; i < GameManager.Instance.models.Length; i++)
        {
            GameObject instance = Instantiate(Object, gameObject.transform.position, Quaternion.identity, gameObject.transform);

            instance.GetComponentInChildren<Image>().sprite = GameManager.Instance.imagesModels[i];
            instance.GetComponentInChildren<TextMeshProUGUI>().text = GameManager.Instance.namesModels[i];
            instance.GetComponent<ButtonsClick>().index = i;
        }
    }
}