using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(AudioSource))]
public class AudioPeerLimitedFreq : MonoBehaviour {
    
    AudioSource _audioSource;
    public static float[] _samples = new float[512];
    //public float[] test = new float[512];
    public static float[] _freqBand = new float[8];
    // Use this for initialization
    void Start()
    {
        _audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        GetSpectrumAudioSource();
    }

    void GetSpectrumAudioSource()
    {
        _audioSource.GetSpectrumData(_samples, 0, FFTWindow.Blackman);
    }

    void MakeFreqBands(){

        // hz / bands = hz per sample.
        // 22050 / 512 = 43 hertz per sample

        /*
         * 0 - 2 = 86 hertz
         * 1 - 4 = 172 hertz 
         * 2 - 8 = 344 hertz
         * 3 - 16 = 688 hertz
         * 4 - 32  = 1376 hertz
         * 5 - 64  = 2752 hertz
         * 6 - 128 = 5504 hertz
         * 7 - 256 = 11,008 hertz
         */
        int count = 0;
        for (int i = 0; i < 8; i++)
        {
            float average = 0;
            int sampleCount = (int)Mathf.Pow(2, i) * 2;
            if (i == 7){
                sampleCount += 2;
            }
            for (int j = 0; j < sampleCount; j++)
            {
                average += _samples[count] * (count + 1);
                count++;

            }
            average /= count;

            _freqBand[i] = average * 10;
        }
    }
}
