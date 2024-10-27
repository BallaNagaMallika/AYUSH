using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;
    

public class PlantClick : MonoBehaviour
{
    public GameObject popupPanel;  // Reference to the popup UI panel
    public Text popupText;         // Reference to the text component in the popup
    public string plantUsage;      // Usage information for the plant

    // This function will be triggered when the plant is clicked
    void OnMouseDown()
    {
        Debug.Log("Plant clicked: " + plantUsage);
        popupPanel.SetActive(true);  // Ensure this is properly referenced
        popupText.text = plantUsage; // Set the plant usage text
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(1)) // Right-click to close
        {
            if (popupPanel.activeSelf)
            {
                popupPanel.SetActive(false);
            }
        }
    }

    // Optional: Close the popup when clicking anywhere on the screen
    void OnGUI()
    {
        if (Event.current.type == EventType.MouseDown && !popupPanel.GetComponent<RectTransform>().rect.Contains(Event.current.mousePosition))
        {
            popupPanel.SetActive(false);
        }
    }
}
