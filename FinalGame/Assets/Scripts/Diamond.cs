using CarGame.Player;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CarGame.Pickables
{
    public class Diamond : MonoBehaviour, IPickable
    {
        [SerializeField]
        private int _scoreIncrement;

        public int ScoreIncrement => _scoreIncrement;


        public void Pick(GameObject picker)
        {
            gameObject.SetActive(false);
        }

        private void OnTriggerEnter(Collider other)
        {
            var playerController = other.gameObject.GetComponentInParent<PlayerController>();
            if (playerController != null)
            {
                playerController.Pick(this);
            }
        }
    }
}