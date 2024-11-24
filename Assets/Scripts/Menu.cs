using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
using System;

public class Menu : MonoBehaviour
{
    public void Start()
    {
        SceneManager.LoadScene("SampleScene");
    }
}
