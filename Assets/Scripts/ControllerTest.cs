using UnityEngine;

public class ControllerTest : MonoBehaviour
{
    public Material IdleMat;
    public Material ActivatedMat;
    public ControllerManager CM;

    public GameObject triggerObj;
    public GameObject gripObj;
    public GameObject menuObj;

    //Directions
    public GameObject rightObj;
    public GameObject leftObj;
    public GameObject upObj;
    public GameObject downObj;

    private void Update()
    {
        //grip
        if (CM.grip)
        {
            changetexture(gripObj, ActivatedMat);
            Debug.Log("pressend");
        }
        else
        {
            changetexture(gripObj, IdleMat);
        }

        //menu
        if (CM.pb)
        {
            changetexture(menuObj, ActivatedMat);
            Debug.Log("pressend");
        }
        else
        {
            changetexture(menuObj, IdleMat);
        }

        //trigger
        if (CM.trigger)
        {
            changetexture(triggerObj, ActivatedMat);
            Debug.Log("pressend");
        }
        else
        {
            changetexture(triggerObj, IdleMat);
        }

        #region D pad

        //right
        if (CM.par)
        {
            changetexture(rightObj, ActivatedMat);
            Debug.Log("pressend");
        }
        else
        {
            changetexture(rightObj, IdleMat);
        }

        //left
        if (CM.pal)
        {
            changetexture(leftObj, ActivatedMat);
            Debug.Log("pressend");
        }
        else
        {
            changetexture(leftObj, IdleMat);
        }

        //up
        if (CM.pau)
        {
            changetexture(upObj, ActivatedMat);
            Debug.Log("pressend");
        }
        else
        {
            changetexture(upObj, IdleMat);
        }

        //down
        if (CM.pad)
        {
            changetexture(downObj, ActivatedMat);
            Debug.Log("pressend");
        }
        else
        {
            changetexture(downObj, IdleMat);
        }

        #endregion
    }

    private void changetexture(GameObject gm, Material m)
    {
        gm.GetComponent<Renderer>().material = m;
    }
}