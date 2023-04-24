using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuUI : MonoBehaviour
{
    [SerializeField] private Button startButton;
    [SerializeField] private Button exitButton;
    [SerializeField] private TMP_Dropdown objectDropdown;
    [SerializeField] private TMP_Dropdown colorDropdown;
    [SerializeField] private TMP_Dropdown sizeDropdown;
    [SerializeField] private TMP_InputField physicsYN;
    private int objectType;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        GetObjectFromDropdown();
    }

    private void GetObjectFromDropdown()
    {
        objectType = objectDropdown.value;
    }

    private void GetColorFromDropdown()
    {

    }

    private void GetSizeFromDropdown()
    {

    }

    public void StartButton()
    {
        Debug.Log("Value of the object dropdown is: " + objectType +", and it's a " + objectDropdown.options[objectType].text);
    }
}
