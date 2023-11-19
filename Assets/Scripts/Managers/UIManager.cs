using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    #region singleton
    public static UIManager instance;
    private void Awake()
    {
        instance = this;
    }
    #endregion


    [Header("Level Up UI")]
    public GameObject levelUpMenu;
    public TextMeshProUGUI levelReachText;

    public void OnOpenLevelUpMenu()
    {
        levelUpMenu.SetActive(true);
        GameManager.instance.canMovePlayer = false;
    }

    public void OnCloseLevelUpMenu()
    {
        levelUpMenu.SetActive(false);
        GameManager.instance.canMovePlayer = true;
    }
}
