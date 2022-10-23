using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour
{
    private int m_score = 0;
    private int m_highScore = 0;

    private void Update()
    {
        UpdateHighScore();
    }

    public void AddScore(in int score)
    {
        m_score += score;
    }

    public int GetScore()
    {
        return m_score;
    }

    public void UpdateHighScore()
    {
        m_highScore = m_highScore < m_score ? m_score : m_highScore;
    }

    public int GetHighScore()
    {
        return m_highScore;
    }
}
