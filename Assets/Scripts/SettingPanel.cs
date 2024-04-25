using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;



/// <summary>
/// 세팅 패널을 나타내기 위한 컴포넌트
/// </summary>
public class SettingPanel : MonoBehaviour
{
    [Header("# 입력 필드")]
    public TMP_InputField[] m_InputFields;

    [Header("# 비우기 버튼")]
    public Button m_ClearButton;

    [Header("# 시작하기 버튼")]
    public Button m_StartButton;

    private void Awake()
    {
        // 버튼 이벤트 바인딩
        m_ClearButton.onClick.AddListener(OnClearButtonClicked);
    }


  
    /// <summary>
    /// 비우기 버튼 클릭 시 호출되는 메서드입니다.
    /// </summary>
    private void OnClearButtonClicked()
    {
        Debug.Log("비우기 버튼 클릭");
    }

}
