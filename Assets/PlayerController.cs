using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float CarSpeed=5f;
    Vector3 MoveInput = Vector3.zero;
    CharacterController characterController;

    private void Awake()
    {
        characterController = GetComponent<CharacterController>();
    }
    private void Update()
    {
        Move();
    }

    private void Move()
    {
        MoveInput = new Vector3(Input.GetAxis("Horizontal"), 0f, Input.GetAxis("Vertical"));
        MoveInput = transform.TransformDirection(MoveInput) * CarSpeed;

        characterController.Move(MoveInput * Time.deltaTime);
    }

}
