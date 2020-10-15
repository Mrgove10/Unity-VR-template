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
    public bool pt;


    void Update()
    {
        rightHand.inputDevice.IsPressed(InputHelpers.Button.Trigger, out trigger);
        rightHand.inputDevice.IsPressed(InputHelpers.Button.Grip, out grip);
        rightHand.inputDevice.IsPressed(InputHelpers.Button.MenuButton, out menu);
        rightHand.inputDevice.IsPressed(InputHelpers.Button.PrimaryButton, out pb); // on htc vive controller this is the hamburger menu button
        rightHand.inputDevice.IsPressed(InputHelpers.Button.PrimaryTouch, out pt);

      
    }
}