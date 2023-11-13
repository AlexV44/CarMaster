using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class IntToText : MonoBehaviour
{
    [SerializeField]
    private IntEventChanel _intEventChannel;


    private TextMeshProUGUI _text;


    private void Awake()
    {
        _text = GetComponent<TextMeshProUGUI>();
    }

    private void OnEnable()
    {
        _intEventChannel.OnEventPublished += OnValueChanged;
    }

    private void OnDisable()
    {
        _intEventChannel.OnEventPublished -= OnValueChanged;
    }


    private void OnValueChanged(int value)
    {
        _text.text = value.ToString();
    }
}
