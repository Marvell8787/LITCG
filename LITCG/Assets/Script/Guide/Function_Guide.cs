using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Function_Guide : MonoBehaviour {

	public void Task () {
        Text T_Temp;
        T_Temp = GameObject.Find("Text_Content").GetComponent<Text>();
        T_Temp.text = "●任務分學習類及對戰類:\n  □學習類以完成學習關卡為主\n  □對戰類以完成對戰勝利為主\n";
        T_Temp.text += "●藍色區塊:\n  □任務明細\n  □點擊後會在右邊黃色區塊顯示任務內容\n";
        T_Temp.text += "●黃色區塊:\n  □任務內容\n  □分為門檻、要求、獎勵、懲罰\n";
        T_Temp.text += "●每個任務僅能接一次，會成功或失敗\n";
        T_Temp.text += "●不論成功或失敗，皆須回報任務(按下Finish)\n";

    }
    public void Learn(){
        Text T_Temp;
        T_Temp = GameObject.Find("Text_Content").GetComponent<Text>();
        T_Temp.text = "●學習共分為兩種:\n  Material-教材\n  Level-關卡\n";
        T_Temp.text += "\n";
        T_Temp.text += "●Level關卡的分類如下:\n";
        T_Temp.text += "  □Level-1、Level-4為單選題-聽音選字彙\n";
        T_Temp.text += "  □Level-2、Level-5為單選題-字彙英選中\n";
        T_Temp.text += "  □Level-3、Level-6為單選題-填空選字彙\n";
        T_Temp.text += "  □Overall為拼字題-字彙中翻英\n";

    }
    public void Battle()
    {
        Text T_Temp;
        T_Temp = GameObject.Find("Text_Content").GetComponent<Text>();
        T_Temp.text = "●一開始雙方各抽五張至手上作為手牌\n";
        T_Temp.text += "●第一回合雙方不能抽牌，之後每當某方玩家的回合開始，該玩家要從牌庫抽一張卡至手上，作為手牌。\n";
        T_Temp.text += "●回合分四個階段:\n   問答、行動、戰鬥、結束\n";
        T_Temp.text += "●遊戲雙方各打3回合，共6回合\n";
        T_Temp.text += "●玩家必須在問答階段回答問題，回答正確才可進入戰鬥階段，回答錯誤會扣1點HP。\n";
        T_Temp.text += "●6回合結束後，生命值較高的一方獲勝\n";

    }
    public void Status()
    {
        Text T_Temp;
        T_Temp = GameObject.Find("Text_Content").GetComponent<Text>();
        T_Temp.text = "●分數:根據對戰狀況變動\n";
        T_Temp.text += "●金幣:商店購買商品\n";
        T_Temp.text += "●水晶:任務指標\n";
        T_Temp.text += "●獎章:成就達成時給予的獎勵 \n";
        T_Temp.text += "●卡片:對戰用\n";
        T_Temp.text += "●點數:無法針對項目懲罰時的懲罰項目\n";
        T_Temp.text += "●失誤:失敗次數的指標\n";
    }

}
