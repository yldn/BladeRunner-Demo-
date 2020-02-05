using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.VFX;
using UnityEngine.UI;

public class VFX_musicConductor : MonoBehaviour
{
    public float intensitymultiplyer;
    public float amulitudemultiplyer;
    private AudioData_AmplitudeBand _audioDataAmplitudeBand;
    private VisualEffect vfx;
    public Text txt;
    void Start()
    {
        _audioDataAmplitudeBand = gameObject.GetComponent<AudioData_AmplitudeBand>();
        vfx = gameObject.GetComponent<VisualEffect>();
    }

    // Update is called once per frame
    void Update()
    {
        //set spawn radius
        float f = Mathf.Clamp(_audioDataAmplitudeBand.AmplitudeBuffer * amulitudemultiplyer, 0f, 10f); 
       setShaderFloat("Radius",f); 
        //set intensity
        setShaderFloat("Intensity",_audioDataAmplitudeBand.Amplitude*intensitymultiplyer );
        txt.text = f.ToString();
    }

    private void setShaderFloat(string par, float x)
    {
//        Debug.Log("set"+par+"to"+ x);
        vfx.SetFloat(par,x);
        
    }
    
    
}
