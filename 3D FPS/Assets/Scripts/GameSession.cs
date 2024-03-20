using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameSession : MonoBehaviour
{
    // [SerializeField] private int _coinCount;
    // [SerializeField] private TextMeshProUGUI _countCountText;
    [SerializeField] private CanvasGroup _canvasGroup;
    [SerializeField] private bool _fadeIn, _fadeOut;
    // Start is called before the first frame update
    void Start()
    {
        // _coinCount = 0;
        // _countCountText.text = "Coins: " + _coinCount.ToString();
        FadeOutUI();
    }

    // Update is called once per frame
    void Update()
    {
        if(_fadeIn)
        {
            if(_canvasGroup.alpha < 1)
            {
                _canvasGroup.alpha += Time.deltaTime;
                if(_canvasGroup.alpha >= 1)
                {
                    _fadeIn = false;
                }
            }
        }

        if(_fadeOut)
        {
            if(_canvasGroup.alpha >= 0)
            {
                _canvasGroup.alpha -= Time.deltaTime;
                if(_canvasGroup.alpha == 0)
                {
                    _fadeOut = false;
                }
            }
        }
    }

    public void FadeInUI()
    {
        _fadeIn = true;
    }

    public void FadeOutUI()
    {
        _fadeOut = true;
    }
}