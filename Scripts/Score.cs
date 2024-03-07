using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public int score;
    private int previousScore;

    [SerializeField] private TextMeshProUGUI uiText;

    // Start is called before the first frame update
    void Start()
    {
        score = 0;
        previousScore = 0;
    }

    private void Update()
    {
        if (score != previousScore)
        {
            if (score < 10)
                uiText.text = ("<sprite name=" + '"' + score + '"' + ">");

            else if (10 <= score && score < 100)
            {
                int dezena = score / 10;
                int unidade = score - dezena * 10;

                uiText.text = ("<sprite name=" + '"' + dezena + '"' + ">" + "<sprite name=" + '"' + unidade + '"' + ">");
            }

            //
            previousScore = score;
        }
    }
}
