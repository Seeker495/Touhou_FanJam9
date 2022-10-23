using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.InputSystem;

public class Player : MonoBehaviour
{
    [SerializeField]
    private Rigidbody2D m_rigidBody2D;

    private bool m_isHiding = true;
    private List<GameObject> m_playerPlace = new List<GameObject>(2);
    private int m_placeIndex = 0;

    [SerializeField]
    private Score m_score;
    private void Awake()
    {
        m_playerPlace = GameObject.FindGameObjectsWithTag("Player's_Place").ToList();
        m_rigidBody2D.position = m_playerPlace[m_placeIndex].GetComponent<Rigidbody2D>().position;
    }

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
        var move = context.ReadValue<Vector2>();
        m_placeIndex = (int)Mathf.Clamp01(m_placeIndex + move.x);
        m_rigidBody2D.position = m_playerPlace[m_placeIndex].GetComponent<Rigidbody2D>().position;
    }

    public void StopHiding(InputAction.CallbackContext context)
    {
        m_isHiding = false;
        GetComponent<SpriteRenderer>().sortingOrder++;
        Debug.Log("Hiding stopped");
    }

    public void StartHiding(InputAction.CallbackContext context)
    {
        m_isHiding = true;
        GetComponent<SpriteRenderer>().sortingOrder--;
        Debug.Log("Hiding started");
    }

    public void Spook(InputAction.CallbackContext context)
    {
        AddScore(Parameter.SPOOK_BASE_POINT * Parameter.MULTIPLY_SCORE);
    }

    public void AddScore(in int score)
    {
        m_score.AddScore(score);
    }

    public int GetScore()
    {
        return m_score.GetScore();
    }
}
