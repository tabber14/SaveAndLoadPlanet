using UnityEngine;
using System.IO;

public class SavePlanetData : MonoBehaviour
{
    public string savePath = "planet_data.json";
    public PlanetGenerator planetGenerator;

    private void OnApplicationQuit()
    {
        SavePlanet();
    }

    public void SavePlanet()
    {
        PlanetData planetData = new PlanetData();

        // Set the planet data from the planet generator
        planetData.Radius = planetGenerator.Radius;
        planetData.IcosphereSubdivisions = planetGenerator.IcosphereSubdivisions;
        planetData.SmoothNormals = planetGenerator.SmoothNormals;
        planetData.Rotate = planetGenerator.Rotate;
        planetData.TurnSpeed = planetGenerator.TurnSpeed;
        planetData.Colors = planetGenerator.Colors;
        planetData.DrawShore = planetGenerator.DrawShore;
        planetData.MinShoreWidth = planetGenerator.MinShoreWidth;
        planetData.MaxShoreWidth = planetGenerator.MaxShoreWidth;
        planetData.MaxAmountOfContinents = planetGenerator.MaxAmountOfContinents;
        planetData.ContinentsMinSize = planetGenerator.ContinentsMinSize;
        planetData.ContinentsMaxSize = planetGenerator.ContinentsMaxSize;
        planetData.MinLandExtrusionHeight = planetGenerator.MinLandExtrusionHeight;
        planetData.MaxLandExtrusionHeight = planetGenerator.MaxLandExtrusionHeight;
        planetData.MaxAmountOfMountains = (int)planetGenerator.MaxAmountOfMountains;
        planetData.MountainBaseSize = planetGenerator.MountainBaseSize;
        planetData.MinMountainHeight = planetGenerator.MinMountainHeight;
        planetData.MaxMountainHeight = planetGenerator.MaxMountainHeight;
        planetData.MinBumpFactor = planetGenerator.MinBumpFactor;
        planetData.MaxBumpFactor = planetGenerator.MaxBumpFactor;

        // Generate a random seed
        int seed = Random.Range(0, int.MaxValue);
        planetData.Seed = seed;

        string jsonData = JsonUtility.ToJson(planetData);
        File.WriteAllText(savePath, jsonData);

        Debug.Log("Planet data saved to " + savePath);
    }
}
