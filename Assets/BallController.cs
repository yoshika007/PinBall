using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BallController : MonoBehaviour
{

    //ボールが見える可能性のあるz軸の最大値
    private float visiblePosZ = -6.5f;

    //ゲームオーバーを表示するテキスト
    private GameObject gameoverText;

    private GameObject pointText;

    void Start()
    {
        //シーンの中のGameOverTextを取得
        this.gameoverText = GameObject.Find("GameOverText");
        this.pointText = GameObject.Find("PointText");
    }

    // Update is called once per frame
    void Update()
    {
        //ボールが画面外に出た場合
        if(this.transform.position.z < this.visiblePosZ)
        {
            //GameOverTextにゲームオーバーを表示
            this.gameoverText.GetComponent<Text> ().text = "Game Over";
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "SmallStarTag")
        {
            this.pointText.GetComponent<Text>().text = "10 Point";
        }
        else if(collision.gameObject.tag == "LargeStarTag")
        {
            this.pointText.GetComponent<Text>().text = "15 Point";
        }
        else if (collision.gameObject.tag == "SmallCloudTag")
        {
            this.pointText.GetComponent<Text>().text = "20 Point";
        }
        else if (collision.gameObject.tag == "LargeCloudTag")
        {
            this.pointText.GetComponent<Text>().text = "25 Point";
        }
    }
}
