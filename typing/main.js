// 変数の初期化
let untyped = '';
let typed = '';
let score = 0;
let mistakes = 0;  // ミスのカウント
let startTime = 0; // ゲーム開始時刻

// 必要なhtml要素の取得
const untypedfield = document.getElementById('untyped');
const typedfield = document.getElementById('typed');
const wrap = document.getElementById('wrap');
const start = document.getElementById('start');
const count = document.getElementById('count');

// 複数のテキストを格納する配列
const textLists = [
    'Hello World','This is my App','How are you?',
   'Today is sunny','I love JavaScript!','Good morning',
   'I am Japanese','Let it be','computer',
   'Typing Game','Information Technology',
   'quantum computing','What day is today?',
   'I want to build a web app','Nice to meet you',
   'Feeling good today','machine learning',
   'Brendan Eich','John Resig','Mandarin orange',
   'artificial intelligence','undefined null NaN',
   'Thank you very much','microprocessor',
   'pencil','Cherry blossom','Congratulations',
   'Hamburger','learning to code',
   'programming'
];

const adjustTextLength = text => {
    const maxLength = 30; // 最大文字数
    return text.length > maxLength ? text.substring(0, maxLength) + '...' : text;
}

// ランダムなテキストを表示
const createText = () => {
    // 正タイプした文字列をクリア
    typed = '';
    typedfield.textContent = typed;

    // 配列のインデックス数からランダムな数値を生成する
    let random = Math.floor(Math.random() * textLists.length);

    // 配列からランダムにテキストを取得し画面に表示する
    untyped = adjustTextLength(textLists[random]);
    untypedfield.textContent = untyped;
};

// キー入力の判定
const keyPress = e => {
    // 誤タイプの場合
    if(e.key !== untyped.substring(0, 1)){
        wrap.classList.add('mistyped');
        mistakes++;  // ミスが増える
        // 100ms後に背景色を元に戻す
        setTimeout(() => {
            wrap.classList.remove('mistyped');
        }, 100);
        return;
    }

    // 正タイプの場合
    score++;
    typed += untyped.substring(0, 1);
    untyped = untyped.substring(1);
    typedfield.textContent = typed;
    untypedfield.textContent = untyped;

    // テキストがなくなったら新しいテキストを表示
    if(untyped === ''){
        createText();
    }
};

// タイピングスピードと正確さを測定
const getTypingSpeed = () => {
    const timeElapsed = Math.floor((Date.now() - startTime) / 1000); // 経過時間（秒）
    const speed = timeElapsed > 0 ? Math.floor(score / timeElapsed) : 0;  // 秒間打った文字数
    const accuracy = score > 0 ? Math.floor(((score - mistakes) / score) * 100) : 0; // 正確さ（パーセント）
    return { speed, accuracy};
};

// タイピングスキルのランクを判定
const rankCheck = () => {
    const { speed, accuracy } = getTypingSpeed();
    // テキストをを格納する変数を作る
    let text = '';

    // スコアに応じて異なるメッセージを変数textに格納する
    if(score < 100){
        text = `あなたのランクはCです。まだ練習が必要です。`;
    }else if(score < 200){
        text = `あなたのランクはBです。さらに練習してAランクを目指しましょう！`;
    }else if(score < 300){
        text = `あなたのランクはAです。素晴らしい！Sランクまであと少しです。`;
    }else{
        text = `あなたのランクはSです。おめでとうございます！完璧です！`;
    }

    // 正確さによるフィードバックを追加
    if (accuracy < 80) {
        text += `\n正確さが少し低めです。さらに注意して打ちましょう！`;
    } else if (accuracy < 90) {
        text += `\n正確さは良好です！少しの改善で完璧になります。`;
    } else {
        text += `\n素晴らしい正確さです！ミスなく入力できて素晴らしいです！`;
    }

    return `${score}文字打てました！\nタイピングスピード: ${speed} 文字/秒\n正確さ: ${accuracy}%\n${text}\n【OK】リトライ / 【キャンセル】終了`;
};

// ゲーム終了
const gameOver = id => {
    clearInterval(id);// タイマーを停止

    // 「終了」のテキストを画面に表示
    untypedfield.textContent = "終了";

    // 結果をアラートで表示
    const resultMessage = rankCheck();
    const result = confirm(resultMessage);

    // OKボタンを押した場合にリロードする
    if (result === true) {
        window.location.reload();
    }
};

// カウントダウンタイマー
const timer = () => {
    // タイマー部分のHTML要素(p要素)を取得する
    let time = count.textContent;

    const id = setInterval(() => {
        // カウントダウンする
        time--;
        count.textContent = time;

        // 警告色の変化
        if (time <= 10) {
            count.classList.add('danger');
            count.classList.remove('warning');
        } else if (time <= 30) {
            count.classList.add('warning');
            count.classList.remove('danger');
        } else {
            count.classList.remove('danger', 'warning');
        }

        // カウントが0になったらタイマーを停止する
        if(time <= 0){
            gameOver(id);
        }
    }, 1000);
};

// ゲームスタート時の処理
start.addEventListener('click', () => {
    startTime = Date.now(); // ゲーム開始時刻を記録
    timer();// カウントダウンタイマーを開始する

    // ランダムなテキストを表示する
    createText();

    //「スタートボタン」を非表示にする
    start.style.display = 'none';

    // キーボードのイベント処理
    document.addEventListener('keypress', keyPress);
});

untypedfield.textContent = 'スタートボタンで開始';