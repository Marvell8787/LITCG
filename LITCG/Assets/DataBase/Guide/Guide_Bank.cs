using System.Collections;
using System.Collections.Generic;
using UnityEngine;

static class Guide_Bank
{
    //Init
    public static string C_Init_Content =
        "●點選兩側的按鈕可得知資訊\n";
    public static string E_Init_Content =
    "●Click on the buttons on both sides to get information.";

    //Task
    public static string C_Task_Content =
        "●任務分學習類及對戰類：\n" +
        "\t□學習類以完成學習關卡為主\n" +
        "\t□對戰類以完成對戰關卡為主\n" +
        "●任務明細：\n" +
        "\t□點擊後會顯示任務內容\n" +
        "\t□分為門檻、要求、獎勵、懲罰\n" +
        "\t\t◇門檻為需要完成某個條件才能接下\n" +
        "\t\t◇要求為任務成功條件\n" +
        "●每個任務僅能接一次，會成功或失敗\n" +
        "●不論成功或失敗，皆需回來回報任務\n";

    public static string E_Task_Content =
    "●Tasks are divided into Learn and Battle：\n" +
    "\t□Learn:complete the Learn level\n" +
    "\t□Battle:complete the Battle level\n" +
    "●Task details：\n" +
    "\t□The task content will be displayed after clicking the task\n" +
    "\t□Divided into thresholds, requirements, rewards, punishment\n" +
    "\t\t◇Threshold:needed to complete a certain condition\n" +
    "\t\t◇Required:Task success conditions\n" +
    "●Each task can only be taken once, will succeed or fail\n" +
    "●Regardless of success or failure, you need to return to the task\n";

    //Learn

    public static string C_Learn_Content =
        "●學習共分為兩種：\n" +
        "\t□教材\n" +
        "\t□關卡\n" +
        "●關卡的分類如下：\n" +
        "\t□Level-1~Level-3為單選題-聽音選字彙\n" +
        "\t□Level-4~Level-6為單選題-字彙英選中\n" +
        "\t□Overall為拼字題-字彙中翻英\n" +
        "●點選關卡後有詳細資訊\n" +
        "●學習者可選擇先練習或挑戰：\n" +
        "\t□練習：無論是否有接任務，結果皆不影響\n" +
        "\t\t◇但仍保有獎懲機制\n" +
        "\t□挑戰：需接下任務才能挑戰，結果會影響任務";
    public static string E_Learn_Content =
    "●There are two types of Learn：\n" +
    "\t□Material\n" +
    "\t□Level\n" +
    "●The classification of Level is as follows：\n" +
    "\t□Level-1~Level-3：Multiple choice - Listening\n" +
    "\t□Level-4~Level-6：Multiple choice - Translation\n" +
    "\t□Overall：Spelling - Translation\n" +
    "●Detailed information after clicking Level\n" +
    "●Learners can choose to practice or challenge：\n" +
    "\t□Practice：Regardless of whether or not there is a task, the results do not affect\n" +
    "\t\t◇But still retain the reward and punishment mechanism\n" +
    "\t□Challenge：Need to take the task to challenge, the result will affect the task";

    //Battle

    public static string[] C_Battle_Content = new string[2] {
    "●採卡牌對戰，以在系統中持有的卡牌與電腦對戰：\n" +
    "\t□能對戰的電腦共三個\n" +
    "\t□每個電腦的難易度皆不同\n" +
    "\t\t◇簡單、普通、困難\n" +
    "●對戰共有3個階段：\n" +
    "\t□答題階段\n" +
    "\t\t◇每個回合開始前都會有題目，需先回答問題\n" +
    "\t\t\t△題目為單選題-字彙中翻英\n" +
    "\t\t◇回答錯誤會損失5點LP\n" +
    "\t□主要階段\n" +
    "\t\t◇學習者可選擇要出的牌\n" +
    "\t□結算階段\n" +
    "\t\t◇比較雙方的攻擊力並對雙方的LP進行增減\n"
        ,
    "●學習者的狀態有LP、牌組、手牌：\n" +
    "\t□LP：20\n" +
    "\t□牌組：由持有的卡牌組成\n" +
    "\t□手牌：由牌組亂數後抽到手中的牌\n" +
    "\n" +
    "●電腦的狀態有LP、牌組、手牌：\n" +
    "\t□LP：10~30\n" +
    "\t□牌組：15~20\n" +
    "\t□手牌：由牌組亂數後抽到手中的牌\n"
        };

    public static string[] E_Battle_Content = new string[2] {
    "●Learner must play against the computer with cards had in the system：\n" +
    "\t□There are three computers\n" +
    "\t□The difficulty of each computer is different\n" +
    "\t\t◇Easy, Normal, Hard\n" +
    "●There are three phase in the battle：\n" +
    "\t□Question Phase\n" +
    "\t\t◇You need to answer the questions first.\n" +
    "\t\t\t△Multiple choice questions - Translation\n" +
    "\t\t◇Answering the error will lose 5 points (LP)\n" +
    "\t□Main Phase\n" +
    "\t\t◇The learner can choose the card to be played.\n" +
    "\t□End Phase\n" +
    "\t\t◇Compare the attack of both and increase or decrease the LP of both\n"
        ,
    "●Learner：LP、Deck、Hand(Card)：\n" +
    "\t□LP：20\n" +
    "\t□Deck：Composed of cards had\n" +
    "\t□Hand(Card):A card drawn from the hands of the deck\n" +
    "\n" +
    "●Computer：LP、Deck、Hand(Card)：\n" +
    "\t□LP：10~30\n" +
    "\t□Deck：15~20\n" +
    "\t□Hand(Card)：A card drawn from the hands of the deck\n"
        };

    //Item

    public static string C_Item_Content =
    "●分數:根據對戰狀況變動\n" +
    "●金幣:商店購買商品\n" +
    "●水晶:任務指標\n" +
    "●獎章:成就達成時給予\n" +
    "●卡牌:對戰用\n" +
    "●點數:針對項目懲罰時的懲罰項目\n" +
    "●失誤:失敗次數的指標\n";

    public static string E_Item_Content =
    "●Score: Change according to the Battle\n" +
    "●Coins: Store Purchases\n" +
    "●Crystal: Mission Indicators\n" +
    "●Badges: Give when the achievement is achieved\n" +
    "●Cards: For Battle \n" +
    "●Points: Penalty items for the penalty of the project\n" +
    "●Mistakes:Indicator of the number of failures \n";
}
