using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RobotController : MonoBehaviour
{
    public float speed = 6f;
    Rigidbody2D _rb;
    public Camera _cam;

  

    Vector2 movement;
    Vector2 mousePos;

    private void Start() 
    {
    _rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");

        mousePos = _cam.ScreenToWorldPoint(Input.mousePosition);
        SuperSpeed();
    }

    private void FixedUpdate() 
    {
        _rb.MovePosition(_rb.position + movement * speed * Time.fixedDeltaTime);

        Vector2 lookdir = mousePos - _rb.position;
        float angel = Mathf.Atan2(lookdir.y, lookdir.x) * Mathf.Rad2Deg - 90f;
        _rb.rotation = angel;
    }

    void SuperSpeed()
    {
        if(Input.GetMouseButton(1))
        {
            speed = 30f;
            _rb.MovePosition(_rb.position + movement * speed * Time.fixedDeltaTime);
        }
        else
        {
            _rb.MovePosition(_rb.position + movement * speed * Time.fixedDeltaTime);
            speed = 15f;
        }
    }
}
