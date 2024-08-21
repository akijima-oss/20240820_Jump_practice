using System;
using Random = System.Random;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump_set : StateMachineBehaviour {

  //===== 定義領域 =====
  int para;
  int count12 = 0;
  int count34 = 0;
  int count56 = 0;
  Random rand = new System.Random();

  public override void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
      {
          // ステートに入ったときの処理
          //３パターンともとれる
          if(count12 < 5 && count34 < 5 && count56 < 10){
            para = rand.Next(1, 7);
          //速度反転が５回になったとき
          }else if(count12 >= 5 && count34 < 5 && count56 < 10){
            para = rand.Next(3, 7);
          //中央反転が５回以上になったとき
          }else if(count12 < 5 && count34 >= 5 && count56 < 10){
            int[] num = new int[4]{ 1, 2, 5, 6 };
            para = num[rand.Next(num.Length)];
          //通常が１０回以上になったとき
          }else if(count12 < 5 && count34 < 5 && count56 >= 10){
            para = rand.Next(1, 5);
          //通常しかとれないとき
          }else if(count12 >= 5 && count34 >= 5 && count56 < 10){
            int[] num = new int[2]{ 5, 6 };
            para = num[rand.Next(num.Length)];
          //中央反転しかとれないとき
          }else if(count12 >= 5 && count34 < 5 && count56 >= 10){
            int[] num = new int[2]{ 3, 4 };
            para = num[rand.Next(num.Length)];
          //速度反転しかとれないとき
          }else if(count12 < 5 && count34 >= 5 && count56 >= 10){
            int[] num = new int[2]{ 1, 2 };
            para = num[rand.Next(num.Length)];
          //終了条件
          }else if(count12 >= 5 && count34 >= 5 && count56 >= 10){
            para = 0;
          }

          if(para == 1 || para == 2){
              count12++;
          }else if(para == 3 || para == 4){
              count34++;
          }else if(para == 5 || para == 6){
              count56++;
          }

          animator.SetInteger("Inv_Para", para);
          Debug.Log(para + " (SPD:" + count12 + ",MID:" + count34 + ",Nom:" + count56 + ")");

      }
}
