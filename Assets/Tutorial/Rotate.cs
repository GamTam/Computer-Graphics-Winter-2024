using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    [SerializeField] private float _moveSpeed;
    
    void Update() {
        transform.Rotate(0, Time.deltaTime * _moveSpeed, 0);
    }
}
