using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class zoomScript : MonoBehaviour
{
    public Transform mercuryParentObject, venusParentObject, earthParentObject, marsParentObject, jupiterParentObject, saturnParentObject, uranusParentObject, neptuneParentObject;

    public void MercuryButton()
    {
        //transform.position = mercuryParentObject.position;
        SceneManager.LoadScene("Mercury Scene");
    }

    public void VenusButton()
    {
        //transform.position = venusParentObject.position;
        SceneManager.LoadScene("Venus Scene");
    }

    public void EarthButton()
    {
        //transform.position = earthParentObject.position;
        SceneManager.LoadScene("Earth Scene");
    }

    public void MarsButton()
    {
        //transform.position = marsParentObject.position;
        SceneManager.LoadScene("Mars Scene");
    }

    public void JupiterButton()
    {
        //transform.position = jupiterParentObject.position;
        SceneManager.LoadScene("Jupiter Scene");
    }

    public void SaturnButton()
    {
        //transform.position = saturnParentObject.position;
        SceneManager.LoadScene("Saturn Scene");
    }

    public void UranusButton()
    {
        //transform.position = uranusParentObject.position;
        SceneManager.LoadScene("Uranus Scene");
    }

    public void NeptuneButton()
    {
        //transform.position = neptuneParentObject.position;
        SceneManager.LoadScene("Neptune Scene");
    }

}
