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
    [SerializeField] private GameObject warningText;
    [SerializeField] private TMP_Dropdown objectDropdown;
    [SerializeField] private TMP_Dropdown colorDropdown;
    [SerializeField] private TMP_Dropdown sizeDropdown;
    [SerializeField] private TMP_InputField physicsYN;
    
    public int ObjectType { get; private set; }
    public int ColorType { get; private set; }
    public int SizeType { get; private set; }
    public bool PhysicsStatus { get; private set; }

    private void GetPhysicsYN()
    {
        PhysicsStatus = false;

        if (physicsYN.text == "yes")
            {
                PhysicsStatus = true;
            }
                
    }

    private void GetDataFromDropdowns()
    {
        ObjectType = objectDropdown.value;
        ColorType = colorDropdown.value;
        SizeType = sizeDropdown.value;
    }

    public void StartButton()
    {
        if (physicsYN.text == "yes" || physicsYN.text == "no")
        {
            GetDataFromDropdowns();
            GetPhysicsYN();
            Debug.Log("Value of the object dropdown is: " + ObjectType + ", and it's a " + objectDropdown.options[ObjectType].text);
            Debug.Log("Value of the color dropdown is: " + ColorType + ", and it's a " + colorDropdown.options[ColorType].text);
            Debug.Log("Value of the size dropdown is: " + SizeType + ", and it's a " + sizeDropdown.options[SizeType].text);
            Debug.Log("PhysicsStatus bool is: " + PhysicsStatus);
            DataManager.Instance.GetDataToUse(ObjectType, ColorType, SizeType, PhysicsStatus);
            SceneManager.LoadScene("Main");
        }
        else
        {
            warningText.SetActive(true);
            StartCoroutine(CoolDown());
        }
                
    }
    IEnumerator CoolDown()
    {
        yield return new WaitForSeconds(1.5f);
        warningText.SetActive(false);
    }
}
