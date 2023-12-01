using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoopingBackground : MonoBehaviour
{
    [SerializeField] private float backgroundSpeed = 1.0f;
    [SerializeField] private Renderer backgroundRenderer;
    [SerializeField] private float origin;
    private void Start()
    {
        origin = transform.position.x;
    }
  
    void Update()
    {
        backgroundRenderer.material.mainTextureOffset += new Vector2(backgroundSpeed * Time.deltaTime, 0f);
        GetScore();
    }

    int GetScore()
    {
        ScoreManager.Instance.score= (int)(transform.position.x - origin);
        return ScoreManager.Instance.score;
    }
}
