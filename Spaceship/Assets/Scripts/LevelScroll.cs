using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelScroll : MonoBehaviour
{
    [SerializeField] float CurrentSpeed;
    public AnimationCurve speedOverTimeModifer;
    public float speedCurveMultiplier;

    public void FixedUpdate()
    {
        CurrentSpeed = speedOverTimeModifer.Evaluate(Time.time) * speedCurveMultiplier;

        transform.Translate(-CurrentSpeed, 0, 0);
    }
}
