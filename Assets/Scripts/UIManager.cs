using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UIManager : MonoBehaviour
{
    public Player player;
    public GameObject GameplayPanel;
    public GameObject DefeatPanel;
    public TextMeshProUGUI score;
    public TextMeshProUGUI finalscore;
    public float timer;
    public float finaltime;
    void Start()
    {
        GameplayPanel.SetActive(true);
        DefeatPanel.SetActive(false);
        timer = 0;
        finaltime = 0;
    }
    private void Update()
    {
        timer = Time.deltaTime + timer;
        score.text = "Puntaje: " + timer.ToString();
    }
    public void ShowGameplayPanel()
    {
        GameplayPanel.SetActive(true);
        DefeatPanel.SetActive(false);
        timer = 0;
        player.Health = 3;
        player.hasBeenDefeated = false;
    }
    public void ShowDefeatedPanel()
    {
        GameplayPanel.SetActive(false);
        DefeatPanel.SetActive(true);
        finaltime = timer;
        finalscore.text = "Puntaje: " + finaltime.ToString();
    }
}
