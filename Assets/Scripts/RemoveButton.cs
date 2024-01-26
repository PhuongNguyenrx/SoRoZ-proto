using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RemoveButton : MonoBehaviour
{
    Button removeButton;
    public GameObject removeMenu;
    public Transform screen;
    GameObject menu;
    public GameObject elderlyToRemove;

    private void Start()
    {
        removeButton=GetComponent<Button>();
        removeButton.onClick.AddListener(ShowRemoveMenu);
        screen = GameObject.Find("ElderlyScreen").transform;
    }
    void ShowRemoveMenu()
    {
        menu = Instantiate(removeMenu, screen.transform.position, Quaternion.identity);
        menu.transform.SetParent(screen);
        var confirmBtn = menu.transform.GetChild(1).GetChild(1).GetComponent<Button>();
        confirmBtn.onClick.AddListener(RemoveElderly);
        var noBtn = menu.transform.GetChild(1).GetChild(2).GetComponent<Button>();
        noBtn.onClick.AddListener(Cancel);
    }

    void Cancel()
    {
        Destroy(menu);
    }
    void RemoveElderly()
    {
        Destroy(elderlyToRemove);
        Destroy(menu);
    }
}
