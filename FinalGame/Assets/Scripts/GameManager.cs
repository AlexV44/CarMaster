using CarGame.Pickables;
using CarGame.Player;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField]
    private PlayerController _player;

    [SerializeField]
    private IntEventChanel _scoreChannel;

    [SerializeField]
    public int numberOfDiamonds;

    [SerializeField]
    private GameObject portal;

    public int _score;
   
    void Start()
    {
        _player.OnPickableCollected += OnPickableCollected;
        portal.SetActive(false);
        Init();
    }

    private void Init()
    {
        _scoreChannel.Publish(_score);
    }

    private void OnPickableCollected(IPickable pickable)
    {
        if (pickable != null)
        {
            _score += pickable.ScoreIncrement;
        }

        _scoreChannel.Publish(_score);
    }

    private void Update()
    {
        if (numberOfDiamonds == _score) {
            portal.SetActive(true);
        }
    }
}
