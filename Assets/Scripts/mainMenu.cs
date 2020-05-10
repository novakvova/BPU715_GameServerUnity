using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class mainMenu : MonoBehaviour
{
    public void StartGames()
    {
        SlingShot.isFire = GameObject.Find("check_isFirst").GetComponent<Toggle>().isOn;
        if (SlingShot.isFire)
        {
            SlingShot.firstName = GameObject.Find("txt_First").GetComponent<InputField>().text;
            SlingShot.secondName = GameObject.Find("txt_Second").GetComponent<InputField>().text;
        }
        else
        {
            SlingShot.firstName = GameObject.Find("txt_Second").GetComponent<InputField>().text;
            SlingShot.secondName = GameObject.Find("txt_First").GetComponent<InputField>().text;
        }

        SceneManager.LoadScene("_Scene_0");
    } 
}
