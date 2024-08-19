using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;
public class NextLevelButtonView : MonoBehaviour
{
    [SerializeField] List<Button> _buttonLevels;
    [SerializeField] private ChangeBlockView _changeBlockView;
    [SerializeField] private LevelCounterView _levelCounter;
 
    private void Awake()
    {
        _changeBlockView.TargetBlocksLoaded += OnTargetBlocksLoaded;
    }

    private void OnTargetBlocksLoaded()
    {
        _buttonLevels[_levelCounter.NextLevel].onClick.Invoke();
    }
}