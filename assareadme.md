あっさりばっさりしたreadme(必要最低限版readmeを用意しました!)

「[代読くん](https://github.com/yokonoha/daidoku_kun)」は、
簡単に言うと **ブラウザーや音声認識結果から A.I.VOICE を操作して喋らせるソフト**です。実況配信向け機能も入っています。 

## まず何が必要？

このソフト単体ではなく、以下が必要です。

* Windows PC
* 対応する A.I.VOICE 製品
* マイク（実況用途なら）
* Chrome系ブラウザー推奨  

---

# 一番簡単な使い方（実況・配信向け）

## 1. ダウンロード

GitHubのReleasesから最新版を落とします。

[代読君](https://github.com/yokonoha/daidoku_kun/releases)  

zipを「そのまま全部」解凍してください。  
dllを欠かすと起動エラーになります。  

---

## 2. 起動

`daidoku_kun.exe` を起動します。

正常なら：

* 代読くん本体
* A.I.VOICE
* 字幕ウィンドウ

などが開きます。  

---

## 3. キャラ表示

メイン画面の「キャラ配置」を押します。

すると立ち絵ウィンドウが出ます。
デフォルトでは結月ゆかりです。  

---

## 4. VoiceConToolを起動  

右下の「VCT」ボタンを押します。  

するとブラウザーで  
VoiceConTool という音声認識Webアプリが開きます。   

---

## 5. マイクON

VoiceConToolで

「マイクをオン」

を押して喋ると、

* 音声認識  
  ↓  
* テキスト化  
  ↓  
* A.I.VOICE が読み上げ  

という流れになります。 

つまり、  

> 自分の声をキャラ音声に変換して実況できる  

感じです。  

---

# Webサイトから喋らせる方法（開発者向け） 

代読くんを起動すると、  

```txt
http://localhost:8080/
```

にローカルAPIが立ちます。  

リポジトリにある `dec.js` は実質これだけです：  

```javascript
async function send2d(text) {
  const url = `http://localhost:8080/?text=${encodeURIComponent(text)}`;
  await fetch(url);
}
```

つまり、   

```javascript
send2d("こんにちは！");
```

を実行すると、A.I.VOICE が喋ります。  

---

# 超簡単サンプル  

HTMLでこう書くだけです。  

```html
<button onclick='send2d("こんにちは！")'>
喋る
</button>

<script src="dec.js"></script>
```

---

# カスタム立ち絵  

`daidoku_kun.exe` と同じ場所に  

```txt
tachie
```

フォルダを作り、  

* a.png
* b.png
* c.png
* d.png

を入れます。  

意味は：  

| ファイル  | 状態      |
| ----- | ------- |
| a.png | 目開き・口開き |
| b.png | 目閉じ・口開き |
| c.png | 目開き・口閉じ |
| d.png | 目閉じ・口閉じ |

その後、  

設定 → 「カスタム立ち絵をセット」  

で読み込みます。  

---

# トラブルシューティング  

## 起動時にエラー  

多い原因：  

* ZIPを部分解凍した  
* DLLが足りない  
* A.I.VOICE未インストール  


---

## 音声認識しない  

既定のブラウザーを変えましょう。Chrome 推奨です。 

---

## 勝手に口パクする  

仕様です。  
音量レベルだけ見てるので、PC音声にも反応します。  

---

# まとめ  

このソフトは：  

* A.I.VOICE を  
* localhost API 化して  
* ブラウザーから操作できる  

ツールです。  

なので、  

* 実況配信  
* ブラウザーゲーム読み上げ  
* コメント読み上げ  
* Webアプリ連携  
* OBS字幕  

みたいな用途に使えます。
