using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelCounterView : MonoBehaviour
{
    public int NextLevel { get; private set; }

    [SerializeField] List<Button> _buttonLevels;

    private void Awake()
    {
        foreach (Button button in _buttonLevels)
        {
            button.onClick.AddListener(() =>
            {
                OnLevelButtonClicked(button);
            });
        }
    }

    private void OnLevelButtonClicked(Button button)
    {
        NextLevel = button.GetComponent<SetLevelValuesView>().LevlNum + 1;
        if (NextLevel >= 3)
        {
            NextLevel = 0;
        }
    }
}
