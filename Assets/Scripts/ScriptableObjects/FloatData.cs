﻿using System.Collections;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

[CreateAssetMenu]
public class FloatData : ScriptableObject
{
    public float value = 1f;
    public UnityEvent lessThanZeroEvent;

    public void SetValue(float number)
    {
        value = number;
    }

    public void UpdateValue(float number)
    {
        value += number;
    }

    public void CheckForOver()
    {
        if (value >= 1)
        {
            value = 1;
        }
    }

    public void CheckForUnder()
    {
        if (value <= 0)
        {
            value = 0;
        }
    }

    public void SetImageFillAmount(Image img)
    {
        if (value >= 0 || value <= 1)
        {
            img.fillAmount = value;
        }

        if (value <= 0)
        {
            lessThanZeroEvent.Invoke();
            value = 0;
        }

        if (value >= 1)
        {
            value = 1;
        }
    }
}