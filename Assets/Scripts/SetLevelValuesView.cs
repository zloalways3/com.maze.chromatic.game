using UnityEngine;
using UnityEngine.UI;

public class SetLevelValuesView : MonoBehaviour
{
    public int LevlNum => _lvlNum;

    [SerializeField] private Transform _currentPlayerPosition;
    [SerializeField] private Transform _targetPlayerPosition;
    [SerializeField] private GameObject _level;
    [SerializeField] private ChangeBlockView _changeBlockView;
    [SerializeField] private int _lvlNum;

    private void Awake()
    {
        _changeBlockView.TargetBlocksLoaded += OnTargetBlocksLoaded;
    }

    private void OnTargetBlocksLoaded()
    {
        _currentPlayerPosition.position = _targetPlayerPosition.position;
        _level.SetActive(true);

    }
}

