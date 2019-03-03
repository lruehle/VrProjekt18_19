using UnityEngine;
using System.Collections;

public class RotateGear : MonoBehaviour
{
    public GameObject gearOne;
    public GameObject gearTwo;

    // Update is called once per frame
    void Update()
    {
        gearOne.transform.Rotate(0, 1, 0);
        gearTwo.transform.Rotate(0, -1, 0);
    }
}