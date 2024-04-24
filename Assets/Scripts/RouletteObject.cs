using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.RuleTile.TilingRuleOutput;

public class RouletteObject : MonoBehaviour
{
    [Header("# �귿 ������Ʈ")]
    public GameObject m_RouletteObject;

    [Header("# �귿 ������")]
    public float m_BrakingForce = 1500.0f;

    /// <summary>
    /// ���� ����� z�� ȸ�� �ӵ��Դϴ�.
    /// 0 �� ��� ȸ������ �ʽ��ϴ�.
    /// </summary>
    private float _ZRotationVelocity;

    /// <summary>
    /// �귿 ������Ʈ ȸ�� ��� �����Դϴ�.
    /// </summary>
    private bool _IsRotatingfAllowed;

    private void Update()
    {
        // Input.GetKeyDown : ���� ��� �ѹ� True
        // Input.GetKey : �������� ��� True
        // Input.GetKeyUp : �������� ��� �ѹ� True

        if (Input.GetKeyDown(KeyCode.Space))
        {
            InitializeRoulette();
        }
        // �귿 ȸ��
        RotationRoulette();

    }
    /// <summary>
    /// �귿 ������Ʈ�� �ʱ�ȭ�մϴ�.
    /// </summary>
    public void InitializeRoulette()
    {
        InitializeRotationVelocity();

        _IsRotatingfAllowed = true;
    }


    /// <summary>
    /// ȸ�� �ӵ��� �ʱ�ȭ�մϴ�.
    /// </summary>
    private void InitializeRotationVelocity()
    {
        _ZRotationVelocity = 3000.0f;
    }

    /// <summary>
    /// �귿�� ȸ����ŵ�ϴ�.
    /// </summary>
    private void RotationRoulette()
    {
        if (_IsRotatingfAllowed)
        {
            // �귿�� ���� ȸ���� ����ϴ�.
            Vector3 rouletteRotation = m_RouletteObject.transform.localEulerAngles;

            // �������� �����մϴ�.
            _ZRotationVelocity -= m_BrakingForce * Time.deltaTime;

            // ȸ�� �ӵ��� 0 �̸��� ��� ȸ���� �������� �ʽ��ϴ�.
            if (_ZRotationVelocity < 0.0f)
            {
                // ȸ���� ���ߵ��� �մϴ�.
                _IsRotatingfAllowed = false;
            }

            // ���� ȸ������ �����մϴ�.
            rouletteRotation.z -= _ZRotationVelocity * Time.deltaTime;

            // �귿�� ȸ���� �����մϴ�.
            m_RouletteObject.transform.localEulerAngles = rouletteRotation;
        }
    }


}
