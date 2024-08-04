using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public static UIManager Instance;
    public Image hpMaskImg;
    public Image mpMaskImg;

    private float _originalHpSize;
    private float _originalMpSize;

    void Awake()
    {
        Instance = this;
        _originalHpSize = hpMaskImg.rectTransform.rect.width;
        _originalMpSize = mpMaskImg.rectTransform.rect.width;
    }

    public void SetHp(float percent)
    {
        hpMaskImg.rectTransform.SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, percent * _originalHpSize);
    }

    public void SetMp(float percent)
    {
        mpMaskImg.rectTransform.SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, percent * _originalMpSize);
    }
}