using UnityEngine;
using TMPro;

public class p2_state : MonoBehaviour
{
    public int p2_mallstate = 300;

    public int p2_mjump = 0;
    public int p2_mspeed = 0;
    public int p2_mtest = 0;

    public TextMeshProUGUI p2_allstate;
    public TextMeshProUGUI p2_jump;
    public TextMeshProUGUI p2_speed;
    public TextMeshProUGUI p2_test;

    public TMP_InputField p2_jumpInput;
    public TMP_InputField p2_speedInput;
    public TMP_InputField p2_testInput;

    public void OnJumpInputChanged(string value)
    {
        value = p2_jumpInput.text;

        if (!string.IsNullOrEmpty(value))
        {
            int.TryParse(value.Trim(), out p2_mjump);
        }
        else
        {
            p2_mjump = 0;
        }

        CalculateTotalPoints();
        UpdateUI();
    }

    public void OnSpeedInputChanged(string value)
    {
        value = p2_speedInput.text;

        if (!string.IsNullOrEmpty(value))
        {
            int.TryParse(value.Trim(), out p2_mspeed);
        }
        else
        {
            p2_mspeed = 0;
        }

        CalculateTotalPoints();
        UpdateUI();
    }

    public void OnTestInputChanged(string value)
    {
        value = p2_testInput.text;

        if (!string.IsNullOrEmpty(value))
        {
            int.TryParse(value.Trim(), out p2_mtest);
        }
        else
        {
            p2_mtest = 0;
        }

        CalculateTotalPoints();
        UpdateUI();
    }

    void CalculateTotalPoints()
    {
        int usedPoints = p2_mjump + p2_mspeed + p2_mtest;
        p2_mallstate = 300 - usedPoints;
    }

    void UpdateUI()
    {
        if (p2_allstate != null)
            p2_allstate.text = "남은 포인트 : " + p2_mallstate;

        if (p2_jump != null)
            p2_jump.text = "점프 : " + p2_mjump;

        if (p2_speed != null)
            p2_speed.text = "민첩 : " + p2_mspeed;

        if (p2_test != null)
            p2_test.text = "테스트 : " + p2_mtest;
    }
}