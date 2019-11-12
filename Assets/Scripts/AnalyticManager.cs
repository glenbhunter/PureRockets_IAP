using UnityEngine;
using UnityEngine.Analytics;


public class AnalyticManager : MonoBehaviour
{
    [SerializeField] bool m_Debug = false;

    private void Start()
    {
    }

    public void OnClick_CompleteLevel(int level)
    {
        Debug.Log("Completed level: " + level);

        AnalyticsResult result;
        result = AnalyticsEvent.LevelComplete(level);
       
        Debug.Log("Analytics response/result: " + result.ToString());
    }

    private void Update()
    {
        if(m_Debug)
        {
            m_Debug = false;
            OnClick_ItemSpent();
        }
    }

    public void OnClick_ItemSpent()
    {
        Debug.Log("OnClick_ItemSpent");

        AnalyticsResult result;

        result = AnalyticsEvent.ItemSpent(AcquisitionType.Soft, "BASEBALL2D", 1, "pitches", 1000);

        Debug.Log("Analytics response/result: " + result.ToString());
    }
}
