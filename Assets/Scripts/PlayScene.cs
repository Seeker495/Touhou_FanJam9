using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayScene : MonoBehaviour
{
    [SerializeField]
    private Player m_player;
    [SerializeField]
    private Enemy m_enemy;

    void Awake()
    {
        if (!m_player)
            m_player = GameObject.FindWithTag("Player").GetComponent<Player>();
        if (!m_enemy)
            m_enemy = GameObject.FindWithTag("Enemy").GetComponent<Enemy>();
    }

    // Update is called once per frame
    void Update()
    {

    }
}
