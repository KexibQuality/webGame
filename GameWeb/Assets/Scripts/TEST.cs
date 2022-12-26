using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class TEST : MonoBehaviour
{
    [SerializeField] private float _height;
    [SerializeField] private Color color;
    [SerializeField] private Vector3 _position;
    [SerializeField] private Vector3 _Cameraposition;
    [SerializeField] private Camera _camera;
    [SerializeField] private Transform _hat;
    [SerializeField] private bool _isAlive;
    [SerializeField] private Quaternion _angle;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Instantiate(_hat, _position, _angle);
        _camera.transform.position = _Cameraposition;
        _camera.transform.rotation = _angle;
    }
}


