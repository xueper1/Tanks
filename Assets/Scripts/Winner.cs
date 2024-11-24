using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Winner : MonoBehaviour
{
    public TextMeshProUGUI winnerText;
    public void Start()
    {
        
    }
    public void SetWinner(string playerName)
    {
        winnerText.text = playerName;
    }
}
