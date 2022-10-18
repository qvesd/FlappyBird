using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformPos : MonoBehaviour
{
    private Transform _platformPos;
    public Transform playerPos;
    
    private void Start()
    {
        _platformPos = GetComponent<Transform>();
    }
    
    private void Update()
    {
        _platformPos.position = new Vector3(_platformPos.position.x, _platformPos.position.y, playerPos.position.z);
    }
}
