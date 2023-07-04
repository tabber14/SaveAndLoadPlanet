using UnityEngine;
using System.IO;

public class LoadPlanetData : MonoBehaviour
{
    public string loadPath = "planet_data.json";
    public PlanetGenerator planetGenerator;

    void Start()
    {
        LoadPlanet();
    }

    public void LoadPlanet()
    {
        if (File.Exists(loadPath))
        {
            string jsonData = File.ReadAllText(loadPath);
            PlanetData planetData = JsonUtility.FromJson<PlanetData>(jsonData);

            ApplyPlanetData(planetData);

            planetGenerator.Seed = planetData.Seed;

            Debug.Log("Planet data loaded from " + loadPath);
        }
        else
        {
            Debug.LogError("Could not find planet data file at " + loadPath);
        }
    }

    private void ApplyPlanetData(PlanetData planetData)
    {
        planetGenerator.Radius = planetData.Radius;
        planetGenerator.IcosphereSubdivisions = planetData.IcosphereSubdivisions;
        planetGenerator.SmoothNormals = planetData.SmoothNormals;
        planetGenerator.Rotate = planetData.Rotate;
        planetGenerator.TurnSpeed = planetData.TurnSpeed;
        planetGenerator.Colors = planetData.Colors;
        planetGenerator.DrawShore = planetData.DrawShore;
        planetGenerator.MinShoreWidth = planetData.MinShoreWidth;
        planetGenerator.MaxShoreWidth = planetData.MaxShoreWidth;
        planetGenerator.MaxAmountOfContinents = planetData.MaxAmountOfContinents;
        planetGenerator.ContinentsMinSize = planetData.ContinentsMinSize;
        planetGenerator.ContinentsMaxSize = planetData.ContinentsMaxSize;
        planetGenerator.MinLandExtrusionHeight = planetData.MinLandExtrusionHeight;
        planetGenerator.MaxLandExtrusionHeight = planetData.MaxLandExtrusionHeight;
        planetGenerator.MaxAmountOfMountains = planetData.MaxAmountOfMountains;
        planetGenerator.MountainBaseSize = planetData.MountainBaseSize;
        planetGenerator.MinMountainHeight = planetData.MinMountainHeight;
        planetGenerator.MaxMountainHeight = planetData.MaxMountainHeight;
        planetGenerator.MinBumpFactor = planetData.MinBumpFactor;
        planetGenerator.MaxBumpFactor = planetData.MaxBumpFactor;
    }
}
