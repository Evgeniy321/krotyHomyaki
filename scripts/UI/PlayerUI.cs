using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;
using System.Runtime.CompilerServices;


public class PlayerUI : MonoBehaviour
{
    [SerializeField] private Canvas defeatCanvas;
    [SerializeField] private Canvas winCanvas;
    [SerializeField] private Canvas pauseCanvas;
    [SerializeField] private Canvas resumeCanvas;


    [SerializeField] private Image playerHP;
    [SerializeField] private TMP_Text playerHP_Text;
    [SerializeField] private Image enemyHP;
    [SerializeField] private TMP_Text enemyHP_text;
    [SerializeField] private TMP_Text Coins;
    private float curPlayerHP;
    private float maxPlayerHP= 100;
    private float curEnemyHP;
    private float maxEnemyHP = 100;

    private void Start()
    {
        curPlayerHP = maxPlayerHP;
        curEnemyHP = maxEnemyHP;
        Coins.text = "0";

        playerHP.fillAmount = curPlayerHP/ maxPlayerHP;
        playerHP_Text.text = curPlayerHP.ToString();
        enemyHP.fillAmount=curEnemyHP/ maxEnemyHP;
        enemyHP_text.text = curEnemyHP.ToString();
        defeatCanvas.enabled = false;
        winCanvas.enabled = false;
        pauseCanvas.enabled = false;
        resumeCanvas.enabled = true;
        
    }

    private void ChangeCanvas(CanvasType type)
    {
        switch(type)
        {
            case CanvasType.win:
                winCanvas.enabled = true;
                resumeCanvas.enabled = false;
                break;
            case CanvasType.pause:
                pauseCanvas.enabled = true;
                resumeCanvas.enabled = false;
                break;
            case CanvasType.defeat:
                defeatCanvas.enabled = true;
                resumeCanvas.enabled = false;
                break;
            case CanvasType.resume:
                defeatCanvas.enabled = false;
                winCanvas.enabled = false;
                pauseCanvas.enabled = false;
                resumeCanvas.enabled = true;
                break;
        }
        Time.timeScale = (Time.timeScale != 0) ? 0 : 1;
    }
    
    public void TakeDamagePlayer(float dmg)
    {
        curPlayerHP -= dmg;
        playerHP.fillAmount = curPlayerHP / maxPlayerHP;
        playerHP_Text.text = curPlayerHP.ToString();
        if (curPlayerHP < 0)
        {
            ChangeCanvas(CanvasType.defeat);
        }
    }
    public void TakeDamageEnemy(float dmg)
    {
        curEnemyHP -= dmg;
        enemyHP.fillAmount = curEnemyHP / maxEnemyHP;
        playerHP_Text.text = curPlayerHP.ToString();
        if (curEnemyHP < 0)
        {
            ChangeCanvas(CanvasType.win);
        }
    }

    public void ToMainMenu()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(0);
    }
}

public enum CanvasType
{
    pause,
    win,
    defeat,
    resume
}
