using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    private int score;
    public TextMeshProUGUI scoreText;

    void Start()
    {
        score = 0;
        scoreText.text = score.ToString();
    }

    private void OnTriggerEnter(Collider other) {
        if (other.tag == "Treasure")
        {
            score++;
            Destroy(other.gameObject);
            scoreText.text = score.ToString();
        }
    }
}
