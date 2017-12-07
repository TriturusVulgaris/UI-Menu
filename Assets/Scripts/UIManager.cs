using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    #region Public Members

    public GameObject m_buttonContinue;
    public GameObject m_buttonLoadGame;
    public GameObject m_buttonNewGame;

    public GameObject m_panelAreYouSure;

    public AudioSource m_hoverSound;

    #endregion

    #region Public void

    public void ToggleCampaign(bool _status)
    {
        m_buttonContinue.SetActive(_status);
        m_buttonLoadGame.SetActive(_status);
        m_buttonNewGame.SetActive(_status);
    }

    public void ToggleAreYouSure(bool _status)
    {
        m_panelAreYouSure.SetActive(_status);
    }

    public void PlayHover()
    {
        m_hoverSound.Play();
    }

    #endregion

    #region System

    void Start()
    {
		
	}
	
	void Update()
    {
		
	}

    #endregion

    #region Tools Debug And Utility

    #endregion

    #region Private an Protected Members

    #endregion
}