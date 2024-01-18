using UnityEngine;
using UnityEngine.UI;

public class SpawnCar : MonoBehaviour
{
    [SerializeField] private ProgrammManager _programmManagerScript;

    [SerializeField] private Button _button;
    [SerializeField] private CarController _carController;
    [SerializeField] private Car _carPrefab;

    private void OnEnable()
    {
        _button.onClick.AddListener(ClickSpawn);
    }

    private void OnDisable()
    {
        _button.onClick.RemoveListener(ClickSpawn);
    }

    void ClickSpawn()
    {
        Instantiate(_carPrefab, _programmManagerScript.hits[0].pose.position, _carPrefab.transform.rotation);
        _carController.AddCar(_carPrefab);
    }
}