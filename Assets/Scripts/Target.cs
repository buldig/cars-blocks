using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour
{
    [SerializeField] private List<Rigidbody> _rigidbodies = new List<Rigidbody>();

    void Start()
    {
        foreach (var item in _rigidbodies)
        {
            item.isKinematic = true;
        }

        StartCoroutine(enumerator());
    }

    IEnumerator enumerator()
    {
        yield return new WaitForSeconds(1f);

        foreach (var item in _rigidbodies)
        {
            item.isKinematic = false;
        }
    }
}
