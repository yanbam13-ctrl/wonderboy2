using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System.Linq;

public class PlayManager : MonoBehaviour
{
    public bool playEnd;
    public float limitTime;
    public int enemyCount;

    public Text timeLabel;
    public Text enemyLabel;
    public GameObject finalGUI;
    public Text finalMessage;
    public Text finalScoreLabel;

    public Text playerName;

    private void Start()
    {
        enemyLabel.text = string.Format("Enemy : {0}", enemyCount);
        timeLabel.text = string.Format("Time : {0:N2}", limitTime);

        playerName.text = PlayerPrefs.GetString("UserName");
    }

    private void Update()
    {
        if (!playEnd)
        {
            if (limitTime > 0)
            {
                limitTime -= Time.deltaTime;
                timeLabel.text = string.Format("Time : {0:N2}", limitTime);
            }
            else
            {
                GameOver();
            }
        }
    }

    public void EnemyDie()
    {
        enemyCount--;
        AddTime(5f); //2-2. 적을 죽였을 때 제한시간을 5초 증가 시킨다.
        enemyLabel.text = string.Format("Enemy : {0}", enemyCount);

        if (enemyCount <= 0)
            Clear();
    }

    //2-2. 적을 죽였을 때 제한시간을 5초 증가 시킨다.
    void AddTime(float time)
    {
        limitTime += time;
        //시관값 변경후 UI에 그려주는 것을 신경써줘야 한다. 이 스크립트에서는 update에서 매 프레임 출력해주고 있어서 pass
    }

    public void Clear()
    {
        if (!playEnd)
        {
            Time.timeScale = 0;
            playEnd = true;
            finalMessage.text = "Clear!!";

            PlayerController pc =
                GameObject.Find("Player").GetComponent<PlayerController>();
            float score = 12345f + limitTime * 123f + pc.hp * 123f;
            finalScoreLabel.text = string.Format("{0:N0}", score);

            finalGUI.SetActive(true);

            pc.playerState = PlayerState.Dead;

            BestCheck(score);
        }
    }

    public void GameOver()
    {
        if (!playEnd)
        {
            Time.timeScale = 0;
            playEnd = true;
            finalMessage.text = "Fail...";
            float score = 1234f - enemyCount * 123f;
            finalScoreLabel.text = string.Format("{0:N0}", score);
            finalGUI.SetActive(true);

            PlayerController pc =
                GameObject.Find("Player").GetComponent<PlayerController>();
            pc.playerState = PlayerState.Dead;

            BestCheck(score);
        }
    }

    public void Replay()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("MainPlay");
    }

    public void Quit()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Title");
    }

    private void BestCheck(float score)
    {
        //5. 최고 점수를 Top3까지 표시한다.

        UserNameScore[] scores = new UserNameScore[4];

        for (int i = 0; i < scores.Length - 1; i++)
        {
            scores[i] = new UserNameScore(PlayerPrefs.GetString("BestPlayer" + i), PlayerPrefs.GetFloat("BestScore" + i));
            //scores[i] = new UserNameScore();
            //scores[i].Name = PlayerPrefs.GetString("BestUserName" + i);
            //scores[i].Score = PlayerPrefs.GetFloat("BestUserName" + i);
        }

        scores[3] = new UserNameScore(PlayerPrefs.GetString("UserName"), score);

        for (int i = 0; i < 4; i++)
        {
            Debug.Log("이름 : " + scores[i].Name +  "점수 : " + scores[i].Score);
        }

        scores = scores.OrderByDescending(x => x.Score).ToArray();

        //float bestScore = PlayerPrefs.GetFloat("BestScore");

        for (int i = 0; i < scores.Length - 1; i++)
        {
            PlayerPrefs.SetString("BestPlayer" + i, scores[i].Name);
            PlayerPrefs.SetFloat("BestScore" + i, scores[i].Score);
        }

        PlayerPrefs.Save();

        for (int i = 0; i < scores.Length - 1; i++)
        {
            Debug.Log(scores[i].Name);
            Debug.Log(scores[i].Score);
        }

        //if (scores[3].Score > bestScore)
        //{
        //    PlayerPrefs.SetFloat("BestScore", score);
        //    string userName = PlayerPrefs.GetString("UserName");
        //    PlayerPrefs.SetString("BestPlayer", userName);
        //    PlayerPrefs.Save();
        //}
    }
}
