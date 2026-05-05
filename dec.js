       //////////////////////////////////////////
       ////Daidoku Endpoint Connection Script////
      ////  by Y.Yokoha Rev.1.0 2026/05/05   ////
      //// 代読くんにテキストを送信するだけ。   ////
      ///////////////////////////////////////////
       
       async function send2d(recievedtext) {
            const endpointurl=`http://localhost:8080/?text=${encodeURIComponent(recievedtext)}`;
            try{
                const res=await fetch(endpointurl);
                if(res.ok){console.log("送信済み:",recievedtext);}
            }
            catch(err){console.log("サーバーと通信出来ませんでした。",err);}
        }