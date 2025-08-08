using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{

    //�̱��� ��ü
    public static ScoreManager Instance = null;

    //�̱��� ��ü�� ���� ������ ������ �ڱ� �ڽ��� �Ҵ�
    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
    }

    // ���� ���� UI
    public Text currentScoreUI;
    // ���� ����
    private int currentScore;

    // �ְ� ���� UI
    public Text bestScoreUI;
    // �ְ� ����
    private int bestScore;

    void Start()
    {
        // ��ǥ : �ְ����� �ҷ��ͼ� bestScore ������ �Ҵ��ϰ� ȭ�鿡 ǥ���Ѵ�.
        // ���� : 1. �ְ����� �ҷ��ͼ� bestScore �� �־��ֱ�
        bestScore = PlayerPrefs.GetInt("Best Score", 0);
        //        2. �ְ����� ȭ�鿡 ǥ���ϱ�
        bestScoreUI.text = "�ְ����� : " + bestScore;
    }

    // currentScore �� ���� �ְ� ȭ�鿡 ǥ���ϱ�
    public void SetScore(int value)
    {
        // 3.ScoreManager Ŭ������ �Ӽ��� ���� �Ҵ� �Ѵ�.
        currentScore += value;
        // 4.ȭ�鿡 ���� ���� ǥ���ϱ�
        currentScoreUI.text = "�������� : " + currentScore;

        //��ǥ: �ְ� ������ ǥ���ϰ� �ʹ�.
        //1.���� ������ �ְ� ���� ���� ũ�ϱ�
        //  -> ���� ���� ������ �ְ� ������ �ʰ� �Ͽ��ٸ顱
        if (currentScore > bestScore)
        {
            //2.�ְ� ������ ���� ��Ų��.
            bestScore = currentScore;
            //3.�ְ� ���� UI �� ǥ��
            bestScoreUI.text = "�ְ����� : " + bestScore;
            // ��ǥ : �ְ������� ���� �ϰ�ʹ�.
            PlayerPrefs.SetInt("Best Score", bestScore);
        }
    }

    // currentScore �� ��������
    public int GetScore()
    {
        return currentScore;
    }
}
