window.addEventListener('load',function(){          
       
        
        let btnStopBetting = document.querySelector("#stopBetting");
        let bet = "";      
        let gegokteWaarden = "";
        let gegokteKleur = "";
        
       for(let i = 1 ; i<=36;i++)
       {
          this.document.querySelector(`#waarde${i}`).addEventListener("click",function(){
            waarde(i);
          })
       }
       //Knop voor op rood te gokken
       this.document.querySelector("#waardeRood").addEventListener("click",function(){
         if(gegokteKleur.includes("Rood")){
           alert("U kan niet 2 keer op rood gokken");
           return;
         }
         else{
          gegokteKleur = "Rood"
          window.betOpKleur = document.getElementById("betvalue").value;
         } 
         
        //knop voor op zwart te gokken
       })
       this.document.querySelector("#waardeZwart").addEventListener("click",function(){
        if(gegokteKleur.includes("Zwart")){
          alert("U kan niet 2 keer op zwart gokken");
          return;
        }
        else{
         gegokteKleur = "Zwart"
         window.betOpKleur = document.getElementById("betvalue").value;
        }         
      })

      btnStopBetting.addEventListener("click",function(){
     
        var ArrayGegoksteWaarden = gegokteWaarden.split(",");
        var ArrayBet = bet.split(",");
        console.log(ArrayGegoksteWaarden);

        window.gegokteWaarde = ArrayGegoksteWaarden;
        window.gegokteKleur = gegokteKleur;
        window.betOpKleur = betOpKleur;
        window.Bets = ArrayBet;

       })
      
       //Voeg gegogkte waarden toe in een array
       function waarde(cijfer){      
         bet += `${document.getElementById("betvalue").value},`;
         gegokteWaarden+= `${cijfer},`       
              
       }

})
 