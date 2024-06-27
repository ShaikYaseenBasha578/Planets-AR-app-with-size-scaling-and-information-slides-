using UnityEngine;

public class PlanetTouchHandler : MonoBehaviour
{
    public PlanetInfo planetInfo;

    void Update()
    {
        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began)
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.GetTouch(0).position);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit))
            {
                // Ensure the hit object has a name in the format "PlanetName Planet"
                string planetName = hit.collider.gameObject.name;
                planetInfo.ShowPlanetInfo(planetName);
            }
            else
            {
                planetInfo.HideInfo();
            }
        }
    }
}
