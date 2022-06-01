//Code for managing a main menu
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuCanvasController : MonoBehaviour
{
    public GameObject m_mainMenu;
    public GameObject m_options;

    public Slider m_musicSlider;
    public Slider m_sfxSlider;

    public void OnPlay()
    {
        SceneManager.LoadScene(AppScenes.GAME_SCENE);
    }

    public void OnOptions(bool isOptions)
    {
        m_mainMenu.SetActive(!isOptions);
        m_options.SetActive(isOptions);

        if (!isOptions)
        {
            MusicManager.Instance.MusicVolumeSave   = m_musicSlider.value;
            MusicManager.Instance.SFXVolume         = m_sfxSlider.value;
        }
    }

    public void OnExit()
    {
        Application.Quit();
    }

    public void OnMusicValueChanged()
    {
        MusicManager.Instance.MusicVolume   = m_musicSlider.value;
    }
    public void OnSFXValueChanged()
    {
        MusicManager.Instance.SFXVolume     = m_sfxSlider.value;
    }
}
