using System;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class ControllerManager : MonoBehaviour
{
    public XRController rightHand;
    public XRController leftHand;
    public bool trigger;
    public bool grip;
    public bool menu;
    public bool pb;
    public bool par;
    public bool pal;
    public bool pau;
    public bool pad;
    public bool pac;
    public bool pat;
    void Update()
    {
        rightHand.inputDevice.IsPressed(InputHelpers.Button.Trigger, out trigger);
        rightHand.inputDevice.IsPressed(InputHelpers.Button.Grip, out grip);
        rightHand.inputDevice.IsPressed(InputHelpers.Button.MenuButton, out menu);
        rightHand.inputDevice.IsPressed(InputHelpers.Button.PrimaryButton, out pb); // on htc vive controller this is the hamburger menu button
        
        //D pad
        rightHand.inputDevice.IsPressed(InputHelpers.Button.PrimaryAxis2DRight, out par);
        rightHand.inputDevice.IsPressed(InputHelpers.Button.PrimaryAxis2DLeft, out pal);
        rightHand.inputDevice.IsPressed(InputHelpers.Button.PrimaryAxis2DUp, out pau);
        rightHand.inputDevice.IsPressed(InputHelpers.Button.PrimaryAxis2DDown, out pad);
        rightHand.inputDevice.IsPressed(InputHelpers.Button.Primary2DAxisClick, out pac);
        rightHand.inputDevice.IsPressed(InputHelpers.Button.Primary2DAxisClick, out pat);
    }
}