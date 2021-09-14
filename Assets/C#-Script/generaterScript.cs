using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class ListExt
{
    public static T PopRandomElement<T>( this List<T> self )
    {
        var item = self[ Random.Range( 0, self.Count ) ];
        self.Remove( item );
        return item;
    }
}

public class generaterScript : MonoBehaviour
{
  public GameObject blockPrefab;
  public GameObject block2Prefab;
    float span = 1.6f;
    float delta = 0;
    int ratio = 5;
                                 //ゲームオブジェクトを取得せずとも、アウトレット接続で実行できる！！
  void Update()
  {
  this.delta += Time.deltaTime; //経過時間をどんどん加算
  if(this.delta>this.span)
    {
      this.delta=0;
      var list = new List<float> { -2.2f, -1.1f, 0.0f, 1.1f, 2.2f };
      var CreatePosX  = list.PopRandomElement();

        GameObject go;
        int dice = Random.Range(1,11);
        if(dice <= this.ratio)  　　//ratioを定義して、確率を調整。
  {
   go = Instantiate(blockPrefab) as GameObject;
  }
  else
  {
  go = Instantiate(block2Prefab) as GameObject;
  }
      go.transform.position = new Vector3(CreatePosX,4,0); //プレハブを基にゲームオブジェクトを作成するメソッド！
    }
  }

}
