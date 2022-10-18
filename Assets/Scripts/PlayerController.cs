using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    [Serializable]
    public struct Controller
    {
        public InputActionReference Move;
        public InputActionReference Spook;

        public void Enable()
        {
            List<InputActionReference> inputActionReferences = new List<InputActionReference>(2)
            { Move, Spook, };
            foreach (var inputActionReference in inputActionReferences)
            {
                inputActionReference.action.Enable();
            }
        }

        public void Disable()
        {
            List<InputActionReference> inputActionReferences = new List<InputActionReference>(2)
            { Move, Spook, };
            foreach (var inputActionReference in inputActionReferences)
            {
                inputActionReference.action.Disable();
            }

        }
    }

    [SerializeField]
    private Controller m_controller;


    // Start is called before the first frame update
    private void Awake()
    {
        Enable();
    }

    private void OnDisable()
    {
        Disable();
    }

    public void Enable()
    {
        m_controller.Enable();
        //m_controller.Move.action.performed += ;
        //m_controller.Spook.action.performed += ;
        //m_controller.Spook.action.canceled += ;
    }

    public void Disable()
    {
        m_controller.Disable();
    }

}
