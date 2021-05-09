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
    int point = 0;


    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "SmallStarTag")
        {
            this.point += 10;
        }
        else if (collision.gameObject.tag == "LargeStarTag")
        {
            this.point += 15;
        }
        else if (collision.gameObject.tag == "SmallCloudTag")
        {
            this.point += 20;
        }
        else if (collision.gameObject.tag == "LargeCloudTag")
        {
            this.point += 25;
        }
    }



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

        this.pointText.GetComponent<Text>().text = this.point+ " point";
    }


}
