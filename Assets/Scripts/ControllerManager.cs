using System;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class ControllerManager : MonoBehaviour
{
    public XRController rightHand;
    public XRController leftHand;
    public bool trigger;
    public bool triggerpressed;
    public bool grippressed;

    void Update()
    {
        rightHand.inputDevice.IsPressed(InputHelpers.Button.Trigger, out trigger);
        rightHand.inputDevice.IsPressed(InputHelpers.Button.Grip, out grippressed);
        rightHand.inputDevice.IsPressed(InputHelpers.Button.Trigger, out trigger);
        rightHand.inputDevice.IsPressed(InputHelpers.Button.Grip, out grippressed);
    }
}