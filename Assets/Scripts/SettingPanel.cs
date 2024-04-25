using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;



/// <summary>
/// ���� �г��� ��Ÿ���� ���� ������Ʈ
/// </summary>
public class SettingPanel : MonoBehaviour
{
    [Header("# �Է� �ʵ�")]
    public TMP_InputField[] m_InputFields;

    [Header("# ���� ��ư")]
    public Button m_ClearButton;

    [Header("# �����ϱ� ��ư")]
    public Button m_StartButton;

    private void Awake()
    {
        // ��ư �̺�Ʈ ���ε�
        m_ClearButton.onClick.AddListener(OnClearButtonClicked);
    }


  
    /// <summary>
    /// ���� ��ư Ŭ�� �� ȣ��Ǵ� �޼����Դϴ�.
    /// </summary>
    private void OnClearButtonClicked()
    {
        Debug.Log("���� ��ư Ŭ��");
    }

}
