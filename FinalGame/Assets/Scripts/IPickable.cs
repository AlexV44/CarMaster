using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CarGame.Pickables
{
    public interface IPickable
    {
        void Pick(GameObject picker);
        int ScoreIncrement { get; }
    }
}