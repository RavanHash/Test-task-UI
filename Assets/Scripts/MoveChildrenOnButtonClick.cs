using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MoveChildrenOnButtonClick : MonoBehaviour
{
    [SerializeField] private int offsetX, offsetY = 8;
    [SerializeField] private RectTransform[] btnChildrenRect;
    
    private Vector3[] _initialPositions;

    private Vector3[] GetInitialPositions()
    {
        if (_initialPositions != null) return _initialPositions;
        
        _initialPositions = new Vector3[btnChildrenRect.Length];

        for (var i = 0; i < btnChildrenRect.Length; i++)
        {
            if (btnChildrenRect[i] != null)
            {
                _initialPositions[i] = btnChildrenRect[i].localPosition;
            }
        }

        return _initialPositions;
    }

    public void Down()
    {
        for (var i = 0; i < btnChildrenRect.Length; i++)
        {
            if (btnChildrenRect[i] != null)
            {
                btnChildrenRect[i].localPosition = new Vector3(GetInitialPositions()[i].x + offsetX, 
                    GetInitialPositions()[i].y - offsetY, GetInitialPositions()[i].z);
            }
        }
    }

    public void Up()
    {
        for (var i = 0; i < btnChildrenRect.Length; i++)
        {
            if (btnChildrenRect[i] != null)
            {
                btnChildrenRect[i].localPosition = GetInitialPositions()[i];
            }
        }
    }
}
