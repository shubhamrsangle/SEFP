using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Read1 : MonoBehaviour {

    public GameObject mz1;
    public GameObject pnl1;
    public GameObject txt1;
    public GameObject inp1;
    public GameObject hnt1;
    
    private void Awake() { 
        mz1 = GameObject.Find("maze (23)");
        pnl1 = GameObject.Find("Panel");
        txt1 = GameObject.Find("TextMeshPro Text (1)");
        inp1 = GameObject.Find("InputField (1)");
        hnt1 = GameObject.Find("Hint (1)");
    }

    public void ReadInput(string ans)
    {
        Debug.Log(ans);
        if (ans == "2268")
        {
            pnl1.gameObject.SetActive(false);
            txt1.gameObject.SetActive(false);
            mz1.gameObject.SetActive(false);
            hnt1.gameObject.SetActive(false);
            inp1.gameObject.SetActive(false);
        }

    }
}
