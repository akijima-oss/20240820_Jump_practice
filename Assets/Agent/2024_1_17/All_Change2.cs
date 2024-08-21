using System;
using Random = System.Random;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class All_Change2 : StateMachineBehaviour {

  //===== 定義領域 =====
  int para;
  int flag = 0;
  int count78 = 0;
  int count910 = 0;
  int count56 = 0;
  Random rand = new System.Random();

  public override void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
      {
          // ステートに入ったときの処理
          if(count78 + count910 + count56 < 20){
            para = rand.Next(5, 11);
            if((para == 5 || para == 6) && (flag == 56)){
              para = rand.Next(7, 11);
            }else if((para == 7 || para == 8) && (flag == 78)){
              int[] num = new int[4]{ 5, 6, 9, 10 };
              para = num[rand.Next(num.Length)];
            }else if((para == 9 || para == 10) && (flag == 910)){
              para = rand.Next(5, 9);
            }
          }else if(count56 + count78 + count910 >= 20){
            para = 0;
          }

          if(para == 5 || para == 6){
              count56++;
              flag = 56;
          }else if(para == 7 || para == 8){
              count78++;
              flag = 78;
          }else if(para == 9 || para == 10){
              count910++;
              flag = 910;
          }

          animator.SetInteger("Inv_Para", para);
          Debug.Log(para + " (MID2:" + count78 + ",MID3:" + count910 + ",Nom:" + count56 + ")");

      }
}
