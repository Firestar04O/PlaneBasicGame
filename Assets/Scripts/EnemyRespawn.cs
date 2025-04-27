using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    private float _horizontal;
    private float _vertical;
    private float _transversal;
    private void Start()
    {
        _horizontal = transform.position.x;
        _vertical = transform.position.y;
        _transversal = transform.position.z;
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Limit")
        {
            transform.position = new Vector3(_horizontal, _vertical, _transversal);
        }
    }
}
