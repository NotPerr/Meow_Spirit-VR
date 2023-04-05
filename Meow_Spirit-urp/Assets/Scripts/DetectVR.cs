
using UnityEngine;
using UnityEngine.XR.Management;

public class DetectVR : MonoBehaviour
{
    public bool startInVR = true;
    public GameObject xrOrigin;
    public GameObject desktopCharacter;

    // Start is called before the first frame update
    void Start()
    {
        if(startInVR)
        {
            var xrSetting = XRGeneralSettings.Instance;
            if (xrSetting == null)
            {
                Debug.Log("XRGeneralSettings is null");
                return;
            }

            var xrManager = xrSetting.Manager;
            if (xrManager == null)
            {
                Debug.Log("XRManagerSettings is null");
                return;
            }

            var xrLoader = xrManager.activeLoader;
            if (xrLoader == null)
            {
                Debug.Log("XRLoader is null");
                xrOrigin.SetActive(false);
                desktopCharacter.SetActive(true);
                return;
            }

            Debug.Log("XRLoader is not null");
            xrOrigin.SetActive(true);
            desktopCharacter.SetActive(false);
            return;
        }else
        {
            xrOrigin.SetActive(false);
            desktopCharacter.SetActive(true);
        }

        
    }

   
}
