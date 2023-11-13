using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[CreateAssetMenu(fileName = "EventChannelSO", menuName = "Events/IntEventChannel", order = 0)]
public class IntEventChanel : ScriptableObject
{
    public event UnityAction<int> OnEventPublished;

    public void Publish(int value)
    {
        OnEventPublished?.Invoke(value);
    }
}
