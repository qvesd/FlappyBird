using UnityEngine;

public class playerMove : MonoBehaviour
{
    private Rigidbody _player;
    private bool _move = false;
    private Transform _playerT;
    
    private void Start()
    {
        _player = GetComponent<Rigidbody>();
        _playerT = GetComponent<Transform>();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            _move = true;
        } 
    }

    private void FixedUpdate()
    {
        _playerT.Translate(new Vector3(0f, 0f, 10f) * Time.deltaTime);
        
        if (_move)
        {
            _player.AddForce(new Vector3(0f, 1000f, 0f));
       
            _move = false;

            _player.AddForce(new Vector3(0f, -650f, 0f));
        }
    }
}
