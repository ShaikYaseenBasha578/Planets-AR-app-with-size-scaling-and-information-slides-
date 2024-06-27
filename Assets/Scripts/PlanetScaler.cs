using UnityEngine;
using System.Collections.Generic;

public class PlanetScaler : MonoBehaviour
{
    // Define the scale factors relative to Earth, with " Planet" appended to each name
    private Dictionary<string, float> planetScales = new Dictionary<string, float> {
         { "Mercury Planet", 0.38f },
        { "Venus Planet", 0.94f },
        { "Earth Planet", 1f },
        { "Mars Planet", 0.53f },
        { "Jupiter Planet", 11.2f },
        { "Saturn Planet", 9.45f },
        { "Uranus Planet", 4f },
        { "Neptune Planet", 3.88f },
        { "Moon Planet", 0.27f },
        { "Sun Planet", 90f }

    };

    // Temporary scale factor to manage visibility in AR space
    private float visibilityScaleFactor = 0.5f; // Adjust this value as needed

    // Start is called before the first frame update
    void Start()
    {
        // Assuming you have game objects for each planet named accordingly
        ScalePlanet("Mercury Planet");
        ScalePlanet("Venus Planet");
        ScalePlanet("Earth Planet");
        ScalePlanet("Mars Planet");
        ScalePlanet("Jupiter Planet");
        ScalePlanet("Saturn Planet");
        ScalePlanet("Uranus Planet");
        ScalePlanet("Neptune Planet");
        ScalePlanet("Sun Planet");
        ScalePlanet("Moon Planet");

    }

    // Method to scale a planet based on its name
    void ScalePlanet(string planetName)
    {
        GameObject planet = GameObject.Find(planetName);
        if (planet != null && planetScales.ContainsKey(planetName))
        {
            float scale = planetScales[planetName] * visibilityScaleFactor;
            planet.transform.localScale = new Vector3(scale, scale, scale);
            Debug.Log($"Scaled {planetName} to {scale}");
        }
        else
        {
            Debug.LogWarning($"Planet {planetName} not found or scale factor not defined.");
        }
    }
}
