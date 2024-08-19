using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WinArea : MonoBehaviour
{
    //[SerializeField] private Text _stopTime;
    [SerializeField] private LevelTimerView _levelTimerView;
    [SerializeField] private List<GameObject> _currentBlocks;
    [SerializeField] private List<GameObject> _targetBlocks;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        _levelTimerView.StopLevelTimeCounter();

        foreach (GameObject block in _currentBlocks)
        {
            block.SetActive(false);
        }
        foreach (GameObject block in _targetBlocks)
        {
            block.SetActive(true);
        }

    }


}
