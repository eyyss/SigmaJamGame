using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Menu : MonoBehaviour
{
    public TMP_Dropdown QualityDropDown;
    void Awake()
    {
        if (PlayerPrefs.HasKey("QualityLevel"))
        {
            QualityDropDown.value = PlayerPrefs.GetInt("QualityLevel",2);
        }
    }

    public void StartGame()
    {
        SceneManager.LoadScene("Office");
    }
    public void ExitGame()
    {
        Application.Quit();
    }

    public void SaveQuaility(int index)
    {
        PlayerPrefs.SetInt("QualityLevel", index);
    }

    public void SetQuaility(int index)
    {
        QualitySettings.SetQualityLevel(index);
        SaveQuaility(index);
    }
}
