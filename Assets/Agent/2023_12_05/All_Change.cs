using System;
using Random = System.Random;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class All_Change : StateMachineBehaviour {

  //===== 定義領域 =====
  int para;
  int flag = 0;
  int count12 = 0;
  int count34 = 0;
  int count56 = 0;
  Random rand = new System.Random();

  public override void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
      {
          // ステートに入ったときの処理
          if(count12 + count34 + count56 < 20){
            para = rand.Next(1, 7);
            if((para == 1 || para == 2) && (flag == 12)){
              para = rand.Next(3, 7);
            }else if((para == 3 || para == 4) && (flag == 34)){
              int[] num = new int[4]{ 1, 2, 5, 6 };
              para = num[rand.Next(num.Length)];
            }else if((para == 5 || para == 6) && (flag == 56)){
              para = rand.Next(1, 5);
            }
          }else if(count12 + count34 + count56 >= 20){
            para = 0;
          }

          if(para == 1 || para == 2){
              count12++;
              flag = 12;
          }else if(para == 3 || para == 4){
              count34++;
              flag = 34;
          }else if(para == 5 || para == 6){
              count56++;
              flag = 56;
          }

          animator.SetInteger("Inv_Para", para);
          Debug.Log(para + " (SPD:" + count12 + ",MID:" + count34 + ",Nom:" + count56 + ")");

      }
}
