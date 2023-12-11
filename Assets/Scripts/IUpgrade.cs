using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IUpgrade
{
    string GetName();
    string GetDescription();
    float GetPrice();
    Sprite GetImage();
    void ApplyEffect();
}