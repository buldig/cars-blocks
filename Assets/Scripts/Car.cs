using UnityEngine;

public class Car : MonoBehaviour
{
    [SerializeField] private float _speed;

    private Rigidbody _rigidbody;


    void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        Vector3 movement = transform.forward * _speed * Time.deltaTime;
        _rigidbody.MovePosition(_rigidbody.position + movement);

        Destroy(gameObject, 20);
    }
}