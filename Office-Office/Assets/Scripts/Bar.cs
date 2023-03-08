using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Bar : MonoBehaviour
{
    public Image WorkBar;
    public float Workbar_Amount = 100f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
            if (Input.GetKeyDown(KeyCode.Space))
            {
                Bar_decrease(2);
            }
            //  Application.LoadLevel(Application.loadedLevel);
        
        
    }

    public void Bar_decrease(float Decrease)
    {
        Workbar_Amount -= Decrease;
        WorkBar.fillAmount = Workbar_Amount/100f;
    }
    public void Bar_increase(float Increase)
    {
        Workbar_Amount += Increase;
        Workbar_Amount = Mathf.Clamp(Workbar_Amount, 0, 100);

        WorkBar.fillAmount = Workbar_Amount / 100f;
    }
}
