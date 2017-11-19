using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(AudioSource))]
public class FrequencyBandsCreator : MonoBehaviour {
    AudioSource _audioSource;
    public static float[] _samples = new float[512];
    public static float[] _freqBand = new float[8];
    public float bassOffset;
    public GameObject Wall;
	// Use this for initialization
	void Start () {
        _audioSource = GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {
        GetSpectrumAudioSource();
        MakeFreqBands();
        SpawnTunnels();
	}

    void GetSpectrumAudioSource()
    {
        _audioSource.GetSpectrumData(_samples, 0, FFTWindow.Blackman);
    }

    void MakeFreqBands()
    {

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
            if (i == 7)
            {
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

    void SpawnTunnels()
    {
        if (_freqBand[0] > bassOffset)
        {
            Debug.Log("Freq 0: " + _freqBand[0].ToString());
        }
        if (_freqBand[1] > bassOffset)
        {
            Debug.Log("Freq 1: " + _freqBand[1].ToString());
        }
        if (_freqBand[2] > bassOffset)
        {
            Debug.Log("Freq 2: " + _freqBand[2].ToString());
        }
        if (_freqBand[3] > bassOffset)
        {
            Debug.Log("Freq 3: " + _freqBand[3].ToString());
        }
        if (_freqBand[4] > bassOffset)
        {
            Debug.Log("Freq 4: " + _freqBand[4].ToString());
        }
        if (_freqBand[5] > bassOffset)
        {
            Debug.Log("Freq 5: " + _freqBand[5].ToString());
        }
        if (_freqBand[6] > bassOffset)
        {
            Debug.Log("Freq 6: " + _freqBand[6].ToString());
        }
        if (_freqBand[7] > bassOffset)
        {
            Debug.Log("Freq 7: " + _freqBand[7].ToString());
        }

    }

    public void MakeWall()
    {
        GameObject temp = Instantiate(Wall, new Vector3(transform.position.x, transform.position.y, transform.position.z + 100f), Quaternion.identity);
        temp.transform.Rotate(new Vector3(this.transform.rotation.x, this.transform.rotation.y, transform.rotation.z));
        //temp.gameObject.GetComponent<ModulateSize>().wake(1f, 1f, 0.5f);
    }
}
