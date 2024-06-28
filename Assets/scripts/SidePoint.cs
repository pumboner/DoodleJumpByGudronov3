using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SidePoint : MonoBehaviour
{
    [SerializeField] private Transform _oppositePoint;
    [SerializeField] private Transform _target;

   [SerializeField] private bool _leftSide;
    private void Update()
    {
        if(_leftSide)
        {
            if(transform.position.x > _target.position.x)
            {
                MoveToOppositePiont();
            }
        }
        else
        {
            if(transform.position.x < _target.position.x)
            {
                MoveToOppositePiont();
            }
        }
    }

    private void MoveToOppositePiont() => _target.position = new Vector2(_oppositePoint.position.x, _target.position.y);
}
