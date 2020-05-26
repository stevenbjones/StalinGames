window.addEventListener('load',function(){  
        
    
        let bord = document.querySelector("#bord");
        let div = document.createElement("div");
        let btnTest = document.querySelector("#stopBetting");
        let bet = 0;      
        let gegokteWaarden = "";
        
       for(let i = 1 ; i<=36;i++)
       {
          this.document.querySelector(`#waarde${i}`).addEventListener("click",function(){
            waarde(i);
          })
       }

       btnTest.addEventListener("click",function(){
        window.gegokteWaarde = gegokteWaarden;
       })

      
       function waarde(cijfer){
      
         bet = document.getElementById("betvalue").value;
         gegokteWaarden+= `${cijfer},`
         console.log(gegokteWaarden);
         alert(`U gokt ${bet} op ${cijfer}`);
       }
})
 