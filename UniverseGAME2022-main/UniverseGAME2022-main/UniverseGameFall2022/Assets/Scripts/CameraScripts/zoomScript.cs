using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zoomScript : MonoBehaviour
{
    public Transform mercuryParentObject, venusParentObject, earthParentObject, marsParentObject, jupiterParentObject, saturnParentObject, uranusParentObject, neptuneParentObject;
    
    public void MercuryButton()
    {
        transform.position = mercuryParentObject.position;
    }

    public void VenusButton()
    {
        transform.position = venusParentObject.position;
    }

    public void EarthButton()
    {
        transform.position = earthParentObject.position;
    }

    public void MarsButton()
    {
        transform.position = marsParentObject.position;
    }

    public void JupiterButton()
    {
        transform.position = jupiterParentObject.position;
    }

    public void SaturnButton()
    {
        transform.position = saturnParentObject.position;
    }

    public void UranusButton()
    {
        transform.position = uranusParentObject.position;
    }

    public void NeptuneButton()
    {
        transform.position = neptuneParentObject.position;
    }

}
