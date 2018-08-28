using UnityEngine;
using UnityEngine.SceneManagement;

public class Control : MonoBehaviour {

    public float speed;
    private Rigidbody rb;
    public GameObject m;
    public GameObject m1;
    public GameObject m2;
    public GameObject p;
    public GameObject t;
    public GameObject i;
    public GameObject t1;
    public GameObject i1;
    public GameObject t2;
    public GameObject i2;
    public GameObject tr;
    public GameObject t3;

    // Use this for initialization
    void Start ()
    {
        rb = GetComponent<Rigidbody>();
        p = GameObject.Find("Panel");
        p.gameObject.SetActive(false);
        t = GameObject.Find("TextMeshPro Text");
        t.gameObject.SetActive(false);
        i = GameObject.Find("InputField");
        i.gameObject.SetActive(false);
        t1 = GameObject.Find("TextMeshPro Text (1)");
        t1.gameObject.SetActive(false);
        i1 = GameObject.Find("InputField (1)");
        i1.gameObject.SetActive(false);
        t2 = GameObject.Find("TextMeshPro Text (2)");
        t2.gameObject.SetActive(false);
        i2 = GameObject.Find("InputField (2)");
        i2.gameObject.SetActive(false);
        m = GameObject.Find("maze (96)");
        m1 = GameObject.Find("maze (23)");
        m2 = GameObject.Find("maze (6)");
        tr = GameObject.Find("Treasure");
        t3 = GameObject.Find("TextMeshPro Text (3)");
        t3.gameObject.SetActive(false);
    }

    void FixedUpdate () {
        float moveh = Input.GetAxis("Horizontal");
        float movev = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveh, 0.0f, movev);

        rb.AddForce(movement*speed);
    }
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Hint"))
        {
            p.gameObject.SetActive(true);
            t.gameObject.SetActive(true);
            i.gameObject.SetActive(true);
        }
        if (other.gameObject.CompareTag("Hint1"))
        {
            p.gameObject.SetActive(true);
            t1.gameObject.SetActive(true);
            i1.gameObject.SetActive(true);
        }
        if (other.gameObject.CompareTag("Hint2"))
        {
            p.gameObject.SetActive(true);
            t2.gameObject.SetActive(true);
            i2.gameObject.SetActive(true);
        }
        if (other.gameObject.CompareTag("Treasure"))
        {
            p.gameObject.SetActive(true);
            t3.gameObject.SetActive(true);
        }

    }

}