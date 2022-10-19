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

    private Player m_player;
    // Start is called before the first frame update
    private void Awake()
    {
        m_player = GameObject.FindWithTag("Player").GetComponent<Player>();
        Enable();
    }

    private void OnDisable()
    {
        Disable();
    }

    public void Enable()
    {
        m_controller.Enable();
        m_controller.Move.action.started += m_player.Move;
        m_controller.Spook.action.started += m_player.StopHiding;
        m_controller.Spook.action.performed += m_player.Spook;
        m_controller.Spook.action.canceled += m_player.StartHiding;
    }

    public void Disable()
    {
        m_controller.Disable();
    }

}
