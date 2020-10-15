using UnityEngine;

public class ControllerTest : MonoBehaviour
{
    public Material IdleMat;
    public Material ActivatedMat;
    public ControllerManager CM;

    public GameObject triggerObj;
    public GameObject gripObj;
    public GameObject menuObj;

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
    }

    private void changetexture(GameObject gm, Material m)
    {
        gm.GetComponent<Renderer>().material = m;
    }
}