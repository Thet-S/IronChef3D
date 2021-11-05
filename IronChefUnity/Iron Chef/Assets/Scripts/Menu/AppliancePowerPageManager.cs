using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AppliancePowerPageManager : MonoBehaviour
{
    public List<AppliancePowerPage> pages;
    int currentIndex;
    public Button rightButton;
    public Button leftButton;

    private void Start()
    {
        currentIndex = -1;
        LoadNextPage();
    }
    public void LoadNextPage()
    {
        ForwardIndex();
        TurnOffAllPages();
        TurnOnCurrentPage();
        SetNav();
    }
    public void LoadPrevPage()
    {
        BackwardIndex();
        TurnOffAllPages();
        TurnOnCurrentPage();
        SetNav();
    }

    void TurnOffAllPages()
    {
        foreach (var p in pages)
            p.gameObject.SetActive(false);
    }
    void TurnOnCurrentPage()
    {
        pages[currentIndex].gameObject.SetActive(true);
    }

    void ForwardIndex()
    {
        currentIndex++;
        if (currentIndex >= pages.Count)
            currentIndex = 0;
    }
    void BackwardIndex()
    {
        currentIndex--;
        if (currentIndex < 0)
            currentIndex = pages.Count - 1;
    }

    void SetNav()
    {
        var nav = rightButton.navigation;
        nav.selectOnUp = pages[currentIndex].lastButton;
        rightButton.navigation = nav;
        nav = leftButton.navigation;
        nav.selectOnUp = pages[currentIndex].lastButton;
        leftButton.navigation = nav;

    }
}