using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Player : MonoBehaviour
{
    [SerializeField]
    private Rigidbody2D m_rigidBody2D;

    private bool m_isHiding = true;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Move(InputAction.CallbackContext context)
    {
        if (!m_isHiding) return;
        Debug.Log("Moving");
    }

    public void StopHiding(InputAction.CallbackContext context)
    {
        m_isHiding = true;
        Debug.Log("Hiding stopped");
    }

    public void StartHiding(InputAction.CallbackContext context)
    {
        m_isHiding = false;
        Debug.Log("Hiding started");
    }

    public void Spook(InputAction.CallbackContext context)
    {

    }

}
