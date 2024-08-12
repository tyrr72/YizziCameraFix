using BepInEx;
using System;
using UnityEngine;
using Utilla;
using YizziCamModV2;



namespace YizFix
{
    [BepInDependency("org.legoandmars.gorillatag.utilla", "1.5.0")]
    [BepInPlugin(PluginInfo.GUID, PluginInfo.Name, PluginInfo.Version)]
    public class Plugin : BaseUnityPlugin
    {

        void Start()
        {
            Utilla.Events.GameInitialized += OnGameInitialized;
        }

        void OnGameInitialized(object sender, EventArgs e)
        {
            CameraController.Instance.fpv = true;
            CameraController.Instance.smoothing = 0.8f;
            CameraController.Instance.FirstPersonCamera.fieldOfView = 110;
            CameraController.Instance.ThirdPersonCamera.fieldOfView = 110;
            CameraController.Instance.FirstPersonCamera.nearClipPlane = 0.01f;
            CameraController.Instance.ThirdPersonCamera.nearClipPlane = 0.01f;
        }
    }
}
