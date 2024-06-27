using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlanetInfo : MonoBehaviour
{
    public GameObject infoPanel;  // Reference to the info panel
    public TextMeshProUGUI infoText;  // Reference to the info text

    private Dictionary<string, string> planetInfos = new Dictionary<string, string>()
    {
        { "Mercury Planet", "Mercury is the smallest planet in our solar system and closest to the Sun." },
        { "Venus Planet", "Venus is the second planet from the Sun and has a thick, toxic atmosphere." },
        { "Earth Planet", "Earth is the third planet from the Sun and the only one known to support life." },
        { "Mars Planet", "Mars is the fourth planet from the Sun and is known as the Red Planet." },
        { "Jupiter Planet", "Jupiter is the largest planet in our solar system and has a Great Red Spot." },
        { "Saturn Planet", "Saturn is the sixth planet from the Sun and is famous for its rings." },
        { "Uranus Planet", "Uranus is the seventh planet from the Sun and has a unique tilt." },
        { "Neptune Planet", "Neptune is the eighth planet from the Sun and is known for its intense blue color." },
        { "Sun Planet", "The Sun is the star at the center of our solar system, providing light and heat." },
        { "Moon Planet", "The Moon is Earth's only natural satellite and affects the tides." }
    };

    void Start()
    {
        // Ensure the info panel is hidden at the start
        HideInfo();
    }

    public void ShowPlanetInfo(string planetName)
    {
        if (planetInfos.ContainsKey(planetName))
        {
            infoText.text = planetInfos[planetName];
            infoPanel.SetActive(true);
        }
        else
        {
            infoText.text = "Information not available.";
            infoPanel.SetActive(true);
        }
    }

    public void HideInfo()
    {
        infoPanel.SetActive(false);
    }
}
