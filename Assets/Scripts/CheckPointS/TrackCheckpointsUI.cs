using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrackCheckpointsUI : MonoBehaviour
{
    [SerializeField] private TrackCheckpoints trackCheckpoints;
    //entire script exists to show that you are moving in the wrong direction when you enter through the wrong checkpoint.
    private void Start()
    {
        trackCheckpoints.OnPlayerCorrectCheckpoint += TrackCheckpoints_OnPlayerCorrectCheckpoint;
        trackCheckpoints.OnPlayerWrongCheckpoint += TrackCheckpoints_OnPlayerWrongCheckpoint;

        Hide();
    }

    private void TrackCheckpoints_OnPlayerWrongCheckpoint(object sender, System.EventArgs e)
    {
        Show();
    }
    private void TrackCheckpoints_OnPlayerCorrectCheckpoint(object sender, System.EventArgs e)
    {
        Hide();
    }

    private void Show()
    {
        gameObject.SetActive(true);
    }
    private void Hide()
    {
        gameObject.SetActive(false);
    }
}
