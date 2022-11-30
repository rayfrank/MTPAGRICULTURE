using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.Events;
public class settingmenu : MonoBehaviour
{
    const string prefname = "optionvalue";
    const string resName = "resolutionoption";
    const string resAnd = "resolutionAndroid";
    public AudioMixer audioMixer;
    public Slider slider;
    Resolution[] resolutions; // automatically detect resolutions
    public Dropdown resolutionDropdown;
    public Dropdown resolutionAndroid;
    public Dropdown qualityDropDown;
    private void Awake()
    {
        qualityDropDown.GetComponent<Dropdown>();
        resolutionAndroid.onValueChanged.AddListener(new UnityAction<int>(index =>
        {
            PlayerPrefs.SetInt(resAnd, resolutionAndroid.value);
            PlayerPrefs.Save();




        }));
       resolutionDropdown.onValueChanged.AddListener(new UnityAction<int>(index =>
        {

            PlayerPrefs.SetInt(resName, resolutionDropdown.value);
            PlayerPrefs.Save();
            


       }
       ));
        qualityDropDown.onValueChanged.AddListener(new UnityAction<int>(index =>
        {

            PlayerPrefs.SetInt(prefname, qualityDropDown.value);
            PlayerPrefs.Save();

        }
       ));


    }
    public void setVolume(float volume)
    {
        audioMixer.SetFloat("volume", volume);
        volume = slider.value;
    }
    public void setQuality(int qualityIndex)
    {
        QualitySettings.SetQualityLevel(qualityIndex);   // sets the quality for resolution.
       
       

    }
    public void setResolution(int resolutionIndex)
    {
        Resolution resolution = resolutions[resolutionIndex];
       Screen.SetResolution(resolution.width, resolution.height, Screen.fullScreen);
    }
    private void Start()
    {
        resolutionAndroid.value = PlayerPrefs.GetInt(resAnd, 0);
        qualityDropDown.value = PlayerPrefs.GetInt(prefname,0);
      resolutions =   Screen.resolutions;
        resolutionDropdown.ClearOptions();

        List<string> options = new List<string>();
        int currentResolutionIndex = 0;
        for (int i = 0; i < resolutions.Length; i++)
        {
            string option = resolutions[i].width + "x" + resolutions[i].height;
            options.Add(option);
            if (resolutions[i].width == Screen.currentResolution.width && resolutions[i].height==Screen.currentResolution.height)
            {
                currentResolutionIndex = i;
            }
        } 





        resolutionDropdown.AddOptions(options);
        resolutionDropdown.value = currentResolutionIndex;
        resolutionDropdown.RefreshShownValue();
    }
}
