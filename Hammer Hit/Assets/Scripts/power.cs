using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class power : MonoBehaviour
{
    // Start is called before the first frame update
    public float Power=5;
    public Slider slider;
    bool Loop = true;
    bool play = true;
    public float speed = 3f;
    void Start()
    {
        
    }
    void Update()
    {
        slider.value = Power;
        powerLoop();
        
    }
    public void Play()
    {
        if (play)
        {
            play = false;
        }
        else
        {
            play = true;
        }
    }
    private void powerLoop()
    {       
        if (play)
        {
            if (Loop)
            {
                Power += Time.deltaTime*speed;
                if (Power > 10)
                {
                    Loop = false;
                }
            }
            else
            {
                Power -= Time.deltaTime*speed;
                if (Power < 0)
                {
                    Loop = true;
                }
            }
        }
    }
}
