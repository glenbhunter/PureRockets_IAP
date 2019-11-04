using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Advertisements;
using UnityEngine.Analytics;

public class AdManager : MonoBehaviour
{
    public void OnClick_ShowAd()
    {
        if(Advertisement.IsReady())
        {
            Debug.Log("Advertisement is ready");
            Debug.Log("Attemping to show default ad");
            Advertisement.Show();
        }
        else
        {
            Debug.Log("Advert is not ready");
        }
    }


    public void OnClick_ShowPrivacyPolicy()
    {
        Application.OpenURL("https://unity3d.com/legal/privacy-policy");


        int level = 1;
        AnalyticsEvent.LevelComplete(level);
    }
}
