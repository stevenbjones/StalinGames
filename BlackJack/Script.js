window.addEventListener('load', function() {
  //Arrays voor kaarten
  var suits = ["Spades", "Diamonds", "Clubs", "Hearts"];
  var values = ["1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K"];
  //Var die gebruikt wordt om totale waarde van kaarten te bereken
  let totaleWaardeSpeler = 0;
  let totaleWaardeDealer = 0;

  //2 divs waar foto's ingestoken worden
  let kaartDealer = document.querySelector("#FotoDealer");
  let kaartSpeler = document.querySelector("#FotoKaartSpeler");

  //buttons
  let btnSpelerGetCard = document.querySelector("#btnSpelerGetCard");
  let btnSpelerStop = document.querySelector("#btnSpelerStop");

  //Eerste kaart van dealer
  getCard(kaartDealer,"dealer")

  //Button om kaart aan speler te geven
  btnSpelerGetCard.addEventListener("click", function(){
    getCard(kaartSpeler,"speler")
  });

  //Button Stop van speler
  btnSpelerStop.addEventListener("click", function(){
    dealerSpeelt();
  });
  
  
  function dealerSpeelt()
  {
    while(totaleWaardeDealer<=totaleWaardeSpeler)
    {
      getCard(kaartDealer,"dealer")
    }
    if(totaleWaardeDealer<=21)
    {
      alert("Dealer wint");
    }
    else
    {
      alert("speler wint");
    }
  }
  function getCard(divFoto,soortSpeler) {     

      let card;
      //Haal random waarde uit array waardes
      let waarde = values[Math.floor(Math.random() * values.length)].charAt(0)
      //Haal random symbool uit array symbols
      let symbool = suits[Math.floor(Math.random() * suits.length)].charAt(0)

      //Maak kaart 
      card = waarde + symbool;

      switch(waarde) {
        case "J":
          waarde = 11
          break;
        case "Q":
          waarde = 12
          break;
        case "K":
          waarde = 13      
      }
      if(soortSpeler == "speler")
      {
        totaleWaardeSpeler += parseInt(waarde);
        document.querySelector("#WaardeSpeler").innerHTML = `Score speler: ${totaleWaardeSpeler}`;  
        if(totaleWaardeSpeler>21)
        {
          //hier komt code als speler meer als 21 heeft
          alert("you lose");
        }    
      }
      if(soortSpeler == "dealer")
      {
        totaleWaardeDealer += parseInt(waarde);
        document.querySelector("#WaardeDealer").innerHTML = `Score dealer: ${totaleWaardeDealer}`
      }
      


      console.log(totaleWaardeSpeler);

      let img = document.createElement("img");
      img.setAttribute("src", `img/${card}.jpg`);
      divFoto.appendChild(img);
  }


})

//waarde+simbool (1e letter)