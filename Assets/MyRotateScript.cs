using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class MyRotateScript : MonoBehaviour
{
    private Transform _parentTransform;
    private Transform _childTransform;
    private GameObject _parentObject;
    private GameObject _childObject;
    public float speed = 1.0f;
    private int _childCount;
    

    // Start is called before the first frame update
    void Start()
    {
        _parentTransform = gameObject.transform.parent;
        _childTransform = gameObject.transform.GetChild(0);
        _childCount = gameObject.transform.childCount;

        if (_parentTransform != null)
        {
            _parentObject = _parentTransform.gameObject;
            Debug.Log(_parentObject);
        }

        if (_childTransform != null)
        {
            _childObject = _childTransform.gameObject;
            Debug.Log(_childObject);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (_parentTransform != null)
        {
            _parentTransform.Rotate(1.0f * speed, 0.0f, 0.0f, Space.World);
        }

        if (_childTransform != null && _childCount == 1)
        {
            _childTransform.Rotate(1.0f * speed, 0.0f, 0.0f, Space.World);
        }
        
        if (_childTransform != null && _childCount > 1)
        {
            for (var i = 0; i < _childCount; i++)
            {
                gameObject.transform.GetChild(i).Rotate(1.0f * speed, 0.0f, 0.0f, Space.World);
            }
        }
    }
}
