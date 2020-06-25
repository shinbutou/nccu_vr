using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class sadako1 : MonoBehaviour
{
    public GameObject Ghost;


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

        Ghost.SetActive(true);
        //sadako1.transform.DOLocalMoveY(1.833f, 0.5f);
    }
    private void OnTriggerExit(Collider other)
    {
        Ghost.SetActive(false);
        //sadako1.transform.DOLocalMoveY(-0.295f, 0f);
    }





}