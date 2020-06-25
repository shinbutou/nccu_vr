using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class touch_ghost : MonoBehaviour
{
    public GameObject ghost;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {

        ghost.SetActive(true);
        //sadako1.transform.DOLocalMoveY(1.833f, 0.5f);
    }
    private void OnTriggerExit(Collider other)
    {
        ghost.SetActive(false);
        //sadako1.transform.DOLocalMoveY(-0.295f, 0f);
    }
}
