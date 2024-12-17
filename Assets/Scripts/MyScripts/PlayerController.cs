using Scripts.Helpers;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    [SerializeField]
    private Rigidbody2D righthand, lefthand;
    private Vector3 mousePos;
    private Vector3 mouseDirection;
    private float mouseDist;

    // Start is called before the first frame update
    void Start()
    {
        mousePos = righthand.position;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        mouseDist = Vector3.Distance(mousePos, righthand.position);
        mouseDirection = Vector3.Normalize(mousePos - (Vector3)righthand.position);
        righthand.velocity = mouseDirection * (10 + mouseDist*4);
    }

    private void OnMove(InputValue input)
    {
        mousePos = GeneralHelpers.GetMouseWorldPosition();
    }

    public void CollisionDetected(Collision2D collision)
    {
        StateManager.Score();
    }
}
