using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class AddProfile : MonoBehaviour
{
    public TextMeshProUGUI nameField, roomField;
    public Button addButton;
    public Transform profilePrefab;
    public Transform elderlyHolder;
    private void Start()
    {
        addButton=GetComponent<Button>();
        addButton.onClick.AddListener(CreateProfile);
    }

    void CreateProfile()
    {
        var profile = Instantiate(profilePrefab, elderlyHolder);
        profile.gameObject.transform.GetChild(0).GetChild(0).GetComponent<TextMeshProUGUI>().text = nameField.text + " - room " + roomField.text;

    }
}
