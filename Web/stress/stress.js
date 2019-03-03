var question_text = {
    "infomation": {
        "TestName": "青少年壓力量表",
        "Author": "基金會",
        "count": 30,
        "button": 5,
        "note": "在下列所列的人、地或事中，選擇你所感受到的壓力程度。"

    },
    "question": [
        "某個特定的老師", "學校中的幫派人物", "某個特定的科目", "覺得自己沒有其他同學聰明", "害怕失敗", "沒能入選某個校隊或團體", "擔心被同學愚弄或欺負", "無法達成父母或師長的期望", "擔心將來無法進入好的學校", "擔心自己以後不知從事哪個工作", "擔心父母會離婚或再婚", "被姐妹或兄弟傷害", "其他家庭成員傷害", "沒有足夠的零用錢或生活費", "沒有得到應有的注意", "因缺乏管教而易惹麻煩", "沒有得到充分的關懷與愛", "父母親吵架或打架", "家庭成員的健康狀況欠佳", "自己的健康狀況欠佳", "失去某個要好的朋友", "沒有足夠的朋友", "遭到某個朋友的拒絕", "受到某個朋友的欺騙或背叛", "某個朋友在背後說我壞話", "感覺不被接受或不受歡迎", "父母不喜歡我的某個朋友", "我擔心自己沒有男(女)朋友", "不知如何結交朋友", "不知該如何維護自己的權利"
    ],
    "answer": {
        "text": [
            "沒有壓力",
            "輕微壓力",
            "中等壓力",
            "沉重壓力",
            "極沉重壓力"
        ],
        "value": [1, 2, 3, 4, 5]
    },

    "result": {
        "30-45": "你正承受到適度的壓力，所需要的是情緒上無條件的支持。只要沒有出現異於往常的行為或情緒反應，父母應該可以放心。",
        "46-60": "你正承受到略大的壓力，應該找個疏發情緒的環境。找個人傾訴心裡的話，或是安排一趟開心的旅遊，都是可以考慮的方式",
        "61-75": "你正承受到強大的壓力，並可能已經出現異於往常的行為或情緒反應。你應該考慮帶立即尋求專業的心理諮商服務，以維護身心健全發展。",
        "76-": "你正承受到強大的壓力，內心壓抑強烈的情緒與不安。你應該立即尋求專業的心理諮商服務，以維護你身心健全發展。"
    }
};

var score = 0;
var question_no = 0;
var ansarr = [];

function init() {
    question_no = 0;
    document.getElementById("main_question").innerHTML = String(question_no + 1) + ". " + question_text["question"][question_no];
    ansarr = [];
};

function AnswerButtonClick(ans) {
    if (question_no >= question_text["infomation"]["count"] -1) {
        CountAnswer();
        question_no = 0; //Reset
    }
    else {
        ansarr.push(ans);
        question_no += 1;
        document.getElementById("main_question").innerHTML = String(question_no + 1) + ". " + question_text["question"][question_no];
    }
};

function CountAnswer() {
    var total = 0;
    ansarr.forEach(function (element) {
        total += element;
    });

    document.getElementById("main_question").innerHTML = "Score = " + String(total) + "<br/>";
    if (total <= 45) {
        document.getElementById("main_question").innerHTML += question_text["result"]["30-45"];
    }
    else if (total > 45 && total <=60 ){
        document.getElementById("main_question").innerHTML += question_text["result"]["46-60"];
    }
    else if (total > 60 && total <=75){
        document.getElementById("main_question").innerHTML += question_text["result"]["61-75"];
    }
    else{
        document.getElementById("main_question").innerHTML += question_text["result"]["76-"];
    }
};
