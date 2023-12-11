using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ProfileButton : MonoBehaviour
{
    public Button profileButton;
    public GameObject profileScreen;
    public GameObject elderlyScrene;
    public TextMeshProUGUI label;
    public TextMeshProUGUI name;
    private void Start()
    {
        profileButton = GetComponent<Button>();
        profileButton.onClick.AddListener(ShowProfile);
    }

    void ShowProfile()
    {
        profileScreen.SetActive(true);
        elderlyScrene.SetActive(false);
        label.text = name.text;
    }
}
