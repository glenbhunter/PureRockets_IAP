using UnityEngine;
using UnityEngine.Analytics;


public class AnalyticManager : MonoBehaviour
{
   public void OnClick_CompleteLevel(int level)
   {
       Debug.Log("Completed level: " + level);

       AnalyticsResult result;
       result = AnalyticsEvent.LevelComplete(level);
       
       Debug.Log("Analytics response/result: " + result.ToString());
   }
}
