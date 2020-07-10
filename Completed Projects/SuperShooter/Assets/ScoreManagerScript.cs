using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManagerScript : MonoBehaviour
{
    public static ScoreManagerScript instance;

    public int score;

    void Awake()
    {
        instance = this;
    }
}
