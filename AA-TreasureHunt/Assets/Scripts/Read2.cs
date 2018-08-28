using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Read2 : MonoBehaviour {

    public GameObject mz2;
    public GameObject pnl2;
    public GameObject txt2;
    public GameObject inp2;
    public GameObject hnt2;

    private void Awake()
    {
        mz2 = GameObject.Find("maze (6)");
        pnl2 = GameObject.Find("Panel");
        txt2 = GameObject.Find("TextMeshPro Text (2)");
        inp2 = GameObject.Find("InputField (2)");
        hnt2 = GameObject.Find("Hint (2)");
    }

    public void ReadInput(string ans)
    {
        Debug.Log(ans);
        if (ans == "16477")
        {
            pnl2.gameObject.SetActive(false);
            txt2.gameObject.SetActive(false);
            mz2.gameObject.SetActive(false);
            hnt2.gameObject.SetActive(false);
            inp2.gameObject.SetActive(false);
        }

    }
}
