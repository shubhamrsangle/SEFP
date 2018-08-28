using UnityEngine;

public class Read : MonoBehaviour {

    public GameObject mz = GameObject.Find("maze (96)");
    public GameObject pnl = GameObject.Find("Panel");
    public GameObject txt = GameObject.Find("TextMeshPro Text");
    public GameObject inp = GameObject.Find("InputField");
    public GameObject hnt = GameObject.Find("Hint");

    public void ReadInput(string ans)
    {
        Debug.Log(ans);
        if (ans == "0")
        {
            pnl.gameObject.SetActive(false);
            txt.gameObject.SetActive(false);
            mz.gameObject.SetActive(false);
            hnt.gameObject.SetActive(false);
            inp.gameObject.SetActive(false);
        }

    }
}