#region Using directives
using System;
using UAManagedCore;
using OpcUa = UAManagedCore.OpcUa;
using FTOptix.UI;
using FTOptix.HMIProject;
using FTOptix.RAEtherNetIP;
using FTOptix.NativeUI;
using FTOptix.WebUI;
using FTOptix.Alarm;
using FTOptix.Retentivity;
using FTOptix.CoreBase;
using FTOptix.NetLogic;
using FTOptix.CommunicationDriver;
using FTOptix.SerialPort;
using FTOptix.Core;
using FTOptix.AuditSigning;
#endregion

[CustomBehavior]
public class _4State_TextBoxBehavior : BaseNetBehavior
{
    public override void Start()
    {
        // Insert code to be executed when the user-defined behavior is started
    }

    public override void Stop()
    {
        // Insert code to be executed when the user-defined behavior is stopped
    }

#region Auto-generated code, do not edit!
    protected new _4State_TextBox Node => (_4State_TextBox)base.Node;
#endregion
}
