using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//発展課題
public class Boss{
    private int mp = 53;    //MP
    private int mpcost = 5;  //消費MP

    public void Magic(){
        if (mp > mpcost){
            this.mp -= mpcost;
            Debug.Log("魔法攻撃をした。残りMPは" + mp);
        }else{
            Debug.Log("MPが足りないため魔法が使えない。");    
        }
    }
}

public class Test : MonoBehaviour {
    // Use this for initialization
    void Start()
    {
        //配列課題
        int[] array = { 5, 10, 15, 20, 25 };

        for (int i = 0; i < 5; i++){
            Debug.Log(array[i]);
        }
        //逆順表示
        for (int j = 5 - 1; j >= 0; j--){
            Debug.Log(array[j]);
        }
        //発展課題出力
        Boss lastboss = new Boss();
        for (int x = 0; x < 11; x++){
            lastboss.Magic();
        }
    }

    // Update is called once per frame
    void Update () {
		
	}

}