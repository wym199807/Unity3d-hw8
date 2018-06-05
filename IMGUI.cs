using UnityEngine;

public class IMGUI : MonoBehaviour
{

    public float BloodStart;
    private float BloodResult;
    private float runTime;

    void Start()
    {
        BloodResult = BloodStart = 0.5f;
    }

    void OnGUI()
    {
        if (GUI.Button(new Rect(20, 50, 70, 30), "HP+") && BloodResult <= 1)
        {
            if (BloodResult + 0.1 > 1) BloodResult = 1;
            else BloodResult += 0.1f;
            runTime = Time.time;
        }
        if (GUI.Button(new Rect(150, 50, 70, 30), "HP-") && BloodResult >= 0)
        {
            if (BloodResult - 0.1 < 0) BloodResult = 0;
            else BloodResult -= 0.1f;
            runTime = Time.time;
        }

        if (BloodStart != BloodResult)
        {
            BloodStart = Mathf.Lerp(BloodStart, BloodResult, 1.0f * (Time.time - runTime));
        }

        GUI.HorizontalScrollbar(new Rect(20, 20, 200, 20), 0.0f, BloodStart, 0.0f, 1.0f);
    }
}