using System;
using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;

public class JumpScript : MonoBehaviour
{
    public Transform jumpPointA;
    public Transform jumpPointB;
    private void OnTriggerEnter2D(Collider2D c)
    {
        if (c.CompareTag("Luna"))
        {
            LunaController luna = c.transform.GetComponent<LunaController>();
            luna.Jump(true);
            float distanceA = Vector3.Distance(luna.transform.position, jumpPointA.position);
            float distanceB = Vector3.Distance(luna.transform.position, jumpPointB.position);

            if (distanceA > distanceB)
            {
                luna.transform.DOMove(jumpPointA.position, 0.5F).OnComplete(() =>
                {
                    EndJump(luna);
                });
            }  if (distanceA < distanceB)
            {
                luna.transform.DOMove(jumpPointB.position, 0.5F).OnComplete(() =>
                {
                    EndJump(luna);
                });
            }

            Transform lunaSprite = luna.transform.GetChild(0);
            Sequence seq = DOTween.Sequence();
            seq.Append(lunaSprite.DOLocalMoveY(1.5F, 0.25F).SetEase(Ease.InOutSine));
            seq.Append(lunaSprite.DOLocalMoveY(0.61F, 0.25F).SetEase(Ease.InOutSine));
            seq.Play();
        }
    }

    private void EndJump(LunaController luna)
    {
        luna.Jump(false);
    }
}
