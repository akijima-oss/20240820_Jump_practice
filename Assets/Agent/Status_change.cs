using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Status_change : MonoBehaviour
{

  //===== 定義領域 =====
  private Animator anim;  //Animatorをanimという変数で定義する

  //===== 初期処理 =====
  void Start()
  {
      //変数animに、Animatorコンポーネントを設定する
      anim = gameObject.GetComponent<Animator>();
  }

  //ボタンが押された時に行う処理
  public void Jump_start(){
    anim.SetBool("Status", true);
  }

  public void Jump_stop(){
    anim.SetBool("Status", false);
  }

}
