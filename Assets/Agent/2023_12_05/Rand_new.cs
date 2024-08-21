using System;
using Random = System.Random;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rand_new : StateMachineBehaviour {

  //===== 定義領域 =====
  int para;
  int count = 0;
  int countN = 0;
  int count12 = 0;
  int count34 = 0;
  int count56 = 0;
  Random rand = new System.Random();
  static Random r = new System.Random();
  int N = r.Next(1, 21);

  public override void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
      {
          // ステートに入ったときの処理
          if(count >= 20){
            para = 0;
          }else if(count == N){
            para = 11;
            countN++;
          }else{
            para = rand.Next(1, 7);
            if(para == 1 || para == 2){
                count12++;
            }else if(para == 3 || para == 4){
                count34++;
            }else if(para == 5 || para == 6){
                count56++;
            }
          }

          count++;

          animator.SetInteger("Inv_Para", para);
          Debug.Log(para + " (SPD:" + count12 + ",MID:" + count34 + ",Nom:" + count56 + ",New:" + countN + ")");

      }
}
