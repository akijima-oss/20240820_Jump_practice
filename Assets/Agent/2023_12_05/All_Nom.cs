using System;
using Random = System.Random;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class All_Nom : StateMachineBehaviour {

  //===== 定義領域 =====
  int para;
  int count12 = 0;
  int count34 = 0;
  int count56 = 0;
  Random rand = new System.Random();

  public override void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
      {
          // ステートに入ったときの処理
          if(count56 < 20){
            para = rand.Next(5, 7);
            count56++;
          }else if(count56 >= 20){
            para = 0;
          }

          animator.SetInteger("Inv_Para", para);
          Debug.Log(para + " (SPD:" + count12 + ",MID:" + count34 + ",Nom:" + count56 + ")");

      }
}
