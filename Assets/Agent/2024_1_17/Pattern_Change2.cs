using System;
using Random = System.Random;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pattern_Change2 : StateMachineBehaviour {

  //===== 定義領域 =====
  int para;
  int count = 0;
  int count56 = 0;
  int count78 = 0;
  int count910 = 0;
  int value = 0;
  int n = 0;
  int j;

  Random rand = new System.Random();

  int[] jump1 = new int[] { 56, 78, 910 };
  int[] jump2 = new int[] { 56, 910, 78 };
  int[] jump3 = new int[] { 78, 56, 910 };
  int[] jump4 = new int[] { 78, 910, 56 };
  int[] jump5 = new int[] { 910, 56, 78 };
  int[] jump6 = new int[] { 910, 78, 56 };
  List<int> jump = new List<int>() { 1, 2, 3, 4, 5, 6 };

  public override void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
      {
          // ステートに入ったときの処理
          if(count == 0 || count%3 == 0){
            // jumpからランダムに1つ選んで値を取り出す
            int pos = rand.Next(0, jump.Count);
            value = jump[pos];
            // 取り出した値はリストから取り去る
            jump.RemoveAt(pos);
            n = 0;
          }

          if(count >= 20){
            para = 0;
          }else if(count == 18 || count == 19){
            para = rand.Next(5, 7);
          }else{
            if(value == 1){
              j = jump1[n];
            }else if(value == 2){
              j = jump2[n];
            }else if(value == 3){
              j = jump3[n];
            }else if(value == 4){
              j = jump4[n];
            }else if(value == 5){
              j = jump5[n];
            }else if(value == 6){
              j = jump6[n];
            }

            if(j == 56){
              para = rand.Next(5, 7);
            }else if(j == 78){
              para = rand.Next(7, 9);
            }else if(j == 910){
              para = rand.Next(9, 11);
            }

          }

          if(para == 5 || para == 6){
              count56++;
          }else if(para == 7 || para == 8){
              count78++;
          }else if(para == 9 || para == 10){
              count910++;
          }

          count++;
          n++;

          animator.SetInteger("Inv_Para", para);
          Debug.Log(para + "[value:" + value + "]" + " (MID2:" + count78 + ",MID3:" + count910 + ",Nom:" + count56 + ")");

      }
}
