using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.RuleTile.TilingRuleOutput;

public class RouletteObject : MonoBehaviour
{
    [Header("# 룰렛 오브젝트")]
    public GameObject m_RouletteObject;

    [Header("# 룰렛 제동력")]
    public float m_BrakingForce = 1500.0f;

    /// <summary>
    /// 현재 적용된 z축 회전 속도입니다.
    /// 0 일 경우 회전하지 않습니다.
    /// </summary>
    private float _ZRotationVelocity;

    /// <summary>
    /// 룰렛 오브젝트 회전 허용 여부입니다.
    /// </summary>
    private bool _IsRotatingfAllowed;

    private void Update()
    {
        // Input.GetKeyDown : 눌릴 경우 한번 True
        // Input.GetKey : 눌려있을 경우 True
        // Input.GetKeyUp : 떼어졌을 경우 한번 True

        if (Input.GetKeyDown(KeyCode.Space))
        {
            InitializeRoulette();
        }
        // 룰렛 회전
        RotationRoulette();

    }
    /// <summary>
    /// 룰렛 오브젝트를 초기화합니다.
    /// </summary>
    public void InitializeRoulette()
    {
        InitializeRotationVelocity();

        _IsRotatingfAllowed = true;
    }


    /// <summary>
    /// 회전 속도를 초기화합니다.
    /// </summary>
    private void InitializeRotationVelocity()
    {
        _ZRotationVelocity = 3000.0f;
    }

    /// <summary>
    /// 룰렛을 회전시킵니다.
    /// </summary>
    private void RotationRoulette()
    {
        if (_IsRotatingfAllowed)
        {
            // 룰렛의 현재 회전을 얻습니다.
            Vector3 rouletteRotation = m_RouletteObject.transform.localEulerAngles;

            // 제동력을 적용합니다.
            _ZRotationVelocity -= m_BrakingForce * Time.deltaTime;

            // 회전 속도가 0 미만인 경우 회전을 진행하지 않습니다.
            if (_ZRotationVelocity < 0.0f)
            {
                // 회전을 멈추도록 합니다.
                _IsRotatingfAllowed = false;
            }

            // 다음 회전값을 설정합니다.
            rouletteRotation.z -= _ZRotationVelocity * Time.deltaTime;

            // 룰렛의 회전을 설정합니다.
            m_RouletteObject.transform.localEulerAngles = rouletteRotation;
        }
    }


}
