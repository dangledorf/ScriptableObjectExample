using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeController : MonoBehaviour
{
    [SerializeField] private Rigidbody rigid;
    [SerializeField] private float jumpForce = 5f;

    public void OnJump()
    {
    	rigid.AddForce(Vector3.up * jumpForce, ForceMode.VelocityChange);
    }
}
