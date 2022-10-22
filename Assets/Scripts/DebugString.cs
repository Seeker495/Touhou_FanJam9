using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class DebugString : MonoBehaviour
{
    private Enemy m_enemy;
    // Start is called before the first frame update
    void Awake()
    {
        m_enemy = GameObject.Find("Enemy").GetComponent<Enemy>();
    }

    // Update is called once per frame
    void Update()
    {
        GetComponent<TextMeshProUGUI>().text = $"Current State: {m_enemy.m_stateMachine.GetState()}";
    }
}
