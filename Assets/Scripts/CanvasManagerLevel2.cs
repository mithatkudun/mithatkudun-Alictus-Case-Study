using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class CanvasManagerLevel2 : MonoBehaviour
{
    public InstantiatePrefabs instantiatePrefabs;
    public CollisionDetect collisionDetect;
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
        OnePercent = collisionDetect.destroyedobject * 1.585f;
        percent.text = OnePercent.ToString("0") + "%";
        FilltheBar.fillAmount = OnePercent / 100f;
        if (instantiatePrefabs.watermeloninstantiated == true)
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
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
