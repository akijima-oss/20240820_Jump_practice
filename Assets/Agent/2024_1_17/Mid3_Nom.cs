using System;
using Random = System.Random;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mid3_Nom : StateMachineBehaviour {

  //===== 定義領域 =====
  int para;
  int count = 0;
  int count56 = 0;
  int count78 = 0;
  int count910 = 0;
  Random rand = new System.Random();

  public override void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
      {
          // ステートに入ったときの処理
          if(count >= 20){
            para = 0;
          }else if(count >= 5 && count <= 14){
            para = rand.Next(5, 7);
            count56++;
          }else{
            para = rand.Next(9, 11);
            count910++;
          }

          count++;

          animator.SetInteger("Inv_Para", para);
          Debug.Log(para + " (MID2:" + count78 + ",MID3:" + count910 + ",Nom:" + count56 + ")");

      }
}
