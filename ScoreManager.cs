using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour {

    public static ScoreManager Instance { get; set; }
    public int score;
    private void Awake()
    {
        Instance = this;
    }
}

