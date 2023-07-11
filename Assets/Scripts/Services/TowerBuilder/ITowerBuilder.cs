using UnityEngine;

public interface ITowerBuilder 
{
    int LevelCount { get; }

    void SetBeam(GameObject beam);
    float GetBeamScale();
    void MinusCoint();
}
