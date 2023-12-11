using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RemoveButton : MonoBehaviour
{
    Button removeButton;
    public Button confirmButton;
    public GameObject removeMenu;
    public Transform screen;
    GameObject menu;
    public GameObject elderlyToRemove;

    private void Start()
    {
        removeButton=GetComponent<Button>();
        removeButton.onClick.AddListener(ShowRemoveMenu);
    }
    void ShowRemoveMenu()
    {
        menu = Instantiate(removeMenu, screen.transform.position, Quaternion.identity);
        menu.transform.SetParent(screen);
        var confirmBtn = menu.transform.GetChild(1).transform.GetChild(1).GetComponent<Button>();
        confirmBtn.onClick.AddListener(RemoveElderly);
    }

    void RemoveElderly()
    {
        Destroy(elderlyToRemove);
        Destroy(menu);
    }
}
