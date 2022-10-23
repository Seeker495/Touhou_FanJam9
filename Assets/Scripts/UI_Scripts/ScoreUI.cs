using TMPro;
using UnityEngine;

public class ScoreUI: MonoBehaviour
{
    [SerializeField]
    private GameObject m_multiplyScore;
    [SerializeField]
    private GameObject m_totalScore;
    [SerializeField]
    private GameObject m_score;
    [SerializeField]
    private Enemy m_enemy;
    [SerializeField]
    private Player m_player;
    private void Awake()
    {
        //m_multiplyScore = GameObject.Find("MultiplyScore");
        //m_totalScore = GameObject.Find("TotalScore");
        //m_score = GameObject.Find("ScoreText");
        //Debug.Log(m_multiplyScore);
        //Debug.Log(m_totalScore);
        //Debug.Log(m_score);
    }

    private void Update()
    {
        Parameter.MULTIPLY_SCORE = (int) (m_enemy.m_stateMachine.GetState()) + 1;
        m_totalScore.GetComponent<TextMeshProUGUI>().text = m_player.GetScore().ToString("#,0");
        m_multiplyScore.GetComponent<TextMeshProUGUI>().text = $"Multiply: <color=#58FF7C> x{Parameter.MULTIPLY_SCORE} </color>";
    }
}
