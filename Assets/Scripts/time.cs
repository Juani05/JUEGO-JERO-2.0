using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class time : MonoBehaviour
{
    internal static int Timescale;
    public Text txt_timeFloored;
    public GameObject txt_ganaste;
    public GameObject txt_perdiste;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        float currentTime = Time.time;
        txt_timeFloored.text = Mathf.Floor(currentTime).ToString();

            if (currentTime > 15)
            {
                txt_ganaste.SetActive(true);
            Time.timeScale = 0;

        }
        }
    }
