using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateBoard : MonoBehaviour
{
    private int rand;
    public Sprite WhiteSprite;
    public SpriteRenderer test;
    // Start is called before the first frame update
    void Start()
    {
        //rand = Random.Range(0, sprite);
        GetComponent<SpriteRenderer>().sprite = WhiteSprite;
        //for (int i = 0; i < 8; i++)
        //{
           
        GetComponent<SpriteRenderer>().transform.localPosition = new Vector3(2f, 3f, 0f);
        //}


    }


    // Update is called once per frame
    void Update()
    {

    }
}
