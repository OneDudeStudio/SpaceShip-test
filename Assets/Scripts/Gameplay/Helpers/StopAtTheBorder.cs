using System.Collections;
using System.Collections.Generic;
using Gameplay.Helpers;
using UnityEngine;

public class StopAtTheBorder : MonoBehaviour
{
    [SerializeField]
    private SpriteRenderer _representation;
    private float _maxLeftPos;
    private float _maxRightPos;
    private void Start()
    {
        SetBorders();
    }

    void LateUpdate()
    {
        CheckBorders();
    }

    private void CheckBorders()
    {
        if (transform.position.x + _representation.size.x > _maxRightPos)
        {
            transform.position = new Vector3(_maxRightPos - _representation.size.x, transform.position.y, transform.position.z);
        }
        else if (transform.position.x - _representation.size.x < _maxLeftPos) 
        {
            transform.position = new Vector3(_maxLeftPos + _representation.size.x, transform.position.y, transform.position.z);
        }
    }

    private void SetBorders() 
    {
        if (GameAreaHelper.IsInGameplayArea(transform, _representation.bounds))
        {
            _maxLeftPos = GameAreaHelper._leftBound;
            _maxRightPos = GameAreaHelper._rightBound;
        }
    }
}
