﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameOver : MonoBehaviour
{
    [SerializeField]
    private TextMeshProUGUI winText;

  public void EndGame(string playerName)
    {
        this.gameObject.SetActive(true);
        winText.text = playerName + " has been defeated!";
    }
}
