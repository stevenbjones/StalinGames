window.addEventListener('load',function(){  
        
    
        let bord = document.querySelector("#bord");
        let div = document.createElement("div");
        let btnTest = document.querySelector("#stopBetting");
        let bet = "";      
        let gegokteWaarden = "";
        
       for(let i = 1 ; i<=36;i++)
       {
          this.document.querySelector(`#waarde${i}`).addEventListener("click",function(){
            waarde(i);
          })
       }
       this.document.querySelector("#waardeRood").addEventListener("click",function(){

       })
       this.document.querySelector("#waardeZwart").addEventListener("click",function(){
         
      })

       btnTest.addEventListener("click",function(){
     
        var ArrayGegoksteWaarden = gegokteWaarden.split(",");
        var ArrayBet = bet.split(",");
        console.log(ArrayGegoksteWaarden);

        window.gegokteWaarde = ArrayGegoksteWaarden;
        window.Bets = ArrayBet;

       })

      
       function waarde(cijfer){      
         bet += `${document.getElementById("betvalue").value},`;
         gegokteWaarden+= `${cijfer},`       
              
       }
})
 