using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class MicrophoneManager : MonoBehaviour
{
    [SerializeField] private TMP_Dropdown micDropdown;
    private string selectedMic;
    void Start()
    {
        PopulateMicDropdown();
        micDropdown.onValueChanged.AddListener(delegate { SelectMicrophone(micDropdown.value); });
    }

    private void PopulateMicDropdown()
    {
        micDropdown.ClearOptions();
        var micOptions = new List<string>(Microphone.devices);
        micDropdown.AddOptions(micOptions);

        if (micOptions.Count > 0)
        {
            SelectMicrophone(0);
        }
    }

    private void SelectMicrophone(int index)
    {
        if (index >= 0 && index < Microphone.devices.Length)
        {
            selectedMic = Microphone.devices[index];

            FindObjectOfType<GlobalControl>().SaveSelectedMic(selectedMic);
            Debug.Log("Selected Microphone: " + selectedMic);
        }
        else
        {
            Debug.LogError("Invalid microphone index");
        }
    }
}
