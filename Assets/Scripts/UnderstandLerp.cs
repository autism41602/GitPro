using System;
using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;
using Vector3 = UnityEngine.Vector3;

public class UnderstandLerp : MonoBehaviour
{
    public Transform target;

    public float totalTime = 3; //运动时长
    public float currentUseTime; //当前时长

    private Vector3 startPos; //开始位置

    [SerializeField] private AnimationCurve curve; //曲线

    void Start()
    {
        startPos = transform.position;
    }

    private void Update()
    {
        // transform.position = Vector3.Lerp(transform.position, target.position, Time.deltaTime);
        //可理解为 开始位置 目标位置 通过最后一个参数（百分比）截取两点间位置 不断的给物体赋值，使其无限接近目标点
        currentUseTime += Time.deltaTime;
        float t = currentUseTime / totalTime;
        transform.position = Vector3.Lerp(startPos, target.position, curve.Evaluate(t));
    }
}