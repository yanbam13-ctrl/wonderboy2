using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UserNameScore
{
    public string Name { get; set; }
    public float Score { get; set; }

    public UserNameScore(string name, float score)
    {
        Name = name;
        Score = score;
    }

}
