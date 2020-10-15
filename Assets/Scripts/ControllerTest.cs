using UnityEngine;

public class ControllerTest : MonoBehaviour
{
    public Material IdleMat;
    public Material ActivatedMat;
    public ControllerManager CM;

    public GameObject triggerObj;

    private void Update()
    {
        triggerObj.GetComponent<Renderer>().material = IdleMat;
        if (CM.trigger)
        {
            triggerObj.GetComponent<Renderer>().material = ActivatedMat;
            Debug.Log("pressend");
        }
    }
}