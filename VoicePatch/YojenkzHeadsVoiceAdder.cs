using System;
using BepInEx;
using UnityEngine;

namespace YojenkzHeadsVoiceAdder
{

    [BepInPlugin("com.grooveypenguinx.basedonCWXVoiceAdder.WTT-TheLongLostHeadsOfYojenkz", "WTT-TheLongLostHeadsOfYojenkz", "0.6.9")]
    public class YojenkzHeadsVoiceAdder : BaseUnityPlugin
    {

        private void Start()
        {
            new YojenkHeadsVoicePatch().Enable();
        }
    }
}