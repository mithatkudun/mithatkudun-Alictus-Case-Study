using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class CanvasManager : MonoBehaviour
{
    public HoleLevel1 holeLevel1;
    public Image FilltheBar;
    public TMP_Text percent;
    public GameObject finishlevelpanel;
    public float OnePercent;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        OnePercent = holeLevel1.destroyedobject * 1.555f;
        percent.text = OnePercent.ToString("0") + "%";       
        FilltheBar.fillAmount = OnePercent / 100f;
        GameObject[] Olives = GameObject.FindGameObjectsWithTag("Olive");
        if (Olives.Length <=0)
        {
            finishlevelpanel.SetActive(true);
        }

    }
    public void RestartButton()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    public void NextLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
    }
}
