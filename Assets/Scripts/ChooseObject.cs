using UnityEngine;
using UnityEngine.UI;

public class ChooseObject : MonoBehaviour
{
    [SerializeField] private ProgrammManager _programmManagerScript;

    [SerializeField] private Button _button;

    [SerializeField] private GameObject _choosedObject;

    private void OnEnable()
    {
        _button.onClick.AddListener(ChooseObjectFunction);
    }

    private void OnDisable()
    {
        _button.onClick.RemoveListener(ChooseObjectFunction);
    }

    void ChooseObjectFunction()
    {
        Instantiate(_choosedObject, _programmManagerScript.hits[0].pose.position, _choosedObject.transform.rotation);
    }
}