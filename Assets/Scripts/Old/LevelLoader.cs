using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LevelLoader : MonoBehaviour
{
    #region Public Members

    public Slider m_slider;
    public Text m_text;

    #endregion

    #region Public void

    public void LevelLoading(int _LevelToLoad)
    {
        StartCoroutine(LoadLevelAsync(_LevelToLoad));
    }

    IEnumerator LoadLevelAsync(int _LevelToLoad)
    {
        AsyncOperation operation = SceneManager.LoadSceneAsync(_LevelToLoad);

        while (!operation.isDone)
        {
            float progress = Mathf.Clamp01(operation.progress / 0.9f);
            m_slider.value = progress;
            m_text.text = (progress * 100) + " %";
            
            //Debug.Log("Chargement : " + operation.progress);

            yield return new WaitForSeconds(0f);
            // OR yield return null
        }
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