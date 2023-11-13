using CarGame.Pickables;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CarGame.Player
{
    public class PlayerController : MonoBehaviour
    {
        public event Action<IPickable> OnPickableCollected;

        public void Pick(IPickable pickable)
        {
            pickable.Pick(gameObject);

            OnPickableCollected?.Invoke(pickable);
        }
    }
}