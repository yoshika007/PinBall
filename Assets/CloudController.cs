using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloudController : MonoBehaviour
{
    
    private float minimum = 0.5f;           //最小サイズ
    private float magSpeed = 10.0f;         //拡大スピード　
    private float magnification = 0.07f;    //拡大率

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //雲を拡大縮小

        float xz = this.minimum + Mathf.Sin(Time.time * this.magSpeed) * this.magnification;
        float y = this.transform.localScale.y;

            this.transform.localScale = new Vector3(xz, y, xz);
    }
}
