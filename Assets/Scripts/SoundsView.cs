using System;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;


public class SoundsView : MonoBehaviour
{
    [SerializeField] Image image; 
    [SerializeField] Button button;
    [SerializeField] private Sprite _redImage;
    [SerializeField] private Sprite _greenImage;
    [SerializeField] private bool _isSound;
    [SerializeField] private AudioMixer _mixer;
    [SerializeField] private AudioSource _audioSource;

    private bool isMoved = true;
    private Vector3 _startPos;

    void Start()
    {
        button.onClick.AddListener(OnButtonClick);
        _startPos = image.rectTransform.position;
        image.rectTransform.position += new Vector3(0.5f, 0f, 0f); // —двиг на 100 по X
        image.sprite = _greenImage;
        _mixer.SetFloat("SoundsVolume", 0);
    }

    void OnButtonClick()
    {
        _audioSource.Play();
        if (_isSound)
        {

            if (isMoved)
            {
                image.rectTransform.position = _startPos;
                image.sprite = _redImage;
                _mixer.SetFloat("SoundsVolume", -80);
            }
            else
            {
                image.rectTransform.position += new Vector3(0.5f, 0f, 0f);
                image.sprite = _greenImage;
                _mixer.SetFloat("SoundsVolume", 0);

            }
            isMoved = !isMoved;
        }
        else
        {
            if (isMoved)
            {
                image.rectTransform.position = _startPos;
                image.sprite = _redImage;
                _mixer.SetFloat("MusicsVolume", -80);
            }
            else
            {
                image.rectTransform.position += new Vector3(0.5f, 0f, 0f);
                image.sprite = _greenImage;
                _mixer.SetFloat("MusicsVolume", 0);
               
            }
            isMoved = !isMoved;
        }

    }
}