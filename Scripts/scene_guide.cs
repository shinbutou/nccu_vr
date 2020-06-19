using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class scene_guide : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "b_portal")
        {
            SceneManager.LoadScene("bathroom");
        }
        else if (collision.gameObject.tag == "b_back")
        {
            SceneManager.LoadScene("classroom");
        }
        else if (collision.gameObject.tag == "e_portal")
        {
            SceneManager.LoadScene("elavator");
        }
        else if (collision.gameObject.tag == "e_back")
        {
            SceneManager.LoadScene("classroom");
        }
    }

}
