using TMPro;
using UnityEngine;
using UnityEngine.UI;


public class ScoreText : MonoBehaviour
{
    public ScoreButton scoreButton;
    TextMeshProUGUI scoreTxt;

    private void Awake()
    {

        scoreTxt = GetComponent<TextMeshProUGUI>();
        scoreButton.scoreButton.onClick.AddListener(RefreshUi);
    }

    public void RefreshUi()
    {
        scoreTxt.text = $"Push Score : {scoreButton._score.ToString()}";
    }
}
