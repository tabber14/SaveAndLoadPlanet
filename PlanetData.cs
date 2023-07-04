using UnityEngine;
using System.Collections.Generic;
using Unity.VisualScripting;

public class PlanetData
{
    public float Radius;
    public int IcosphereSubdivisions;
    public bool SmoothNormals;
    public bool Rotate;
    public float TurnSpeed;
    public List<ColorSetting> Colors;
    public bool DrawShore;
    public float MinShoreWidth;
    public float MaxShoreWidth;
    public int MaxAmountOfContinents;
    public float ContinentsMinSize;
    public float ContinentsMaxSize;
    public float MinLandExtrusionHeight;
    public float MaxLandExtrusionHeight;
    public int MaxAmountOfMountains;
    public float MountainBaseSize;
    public float MinMountainHeight;
    public float MaxMountainHeight;
    public float MinBumpFactor;
    public float MaxBumpFactor;
    public int Seed;
}
