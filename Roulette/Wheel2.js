window.addEventListener('load',function(){  
    var options = ["1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17","18", "19","20","21","22","23","24","25","26","27","28","29","30","31","32","33","34","35","36"];
    
    var startAngle = 0;
    var arc = Math.PI / (options.length / 2);
    var spinTimeout = null;
    
    var spinArcStart = 10;
    var spinTime = 0;
    var spinTimeTotal = 0;
    
    var ctx;
    this.document.getElementById("Spinwheel").addEventListener("click",spin);
    
   

    
    function drawRouletteWheel() {
      var canvas = document.getElementById("canvas");
      if (canvas.getContext) {
        var outsideRadius = 200;
        var textRadius = 160;
        var insideRadius = 125;
    
        ctx = canvas.getContext("2d");
        ctx.clearRect(0,0,500,500);
    
        ctx.strokeStyle = "black";
        ctx.lineWidth = 2;
    
        ctx.font = 'bold 12px Helvetica, Arial';
    
        for(var i = 0; i < options.length; i++) {
          var angle = startAngle + i * arc;
          //ctx.fillStyle = colors[i];
          if(i%2 == 0)
          {
              //zwart
            ctx.fillStyle = "#000000"
          }
          else
          {
            //rood
            ctx.fillStyle = "#F50A0A"
          }
          
    
          ctx.beginPath();
          ctx.arc(250, 250, outsideRadius, angle, angle + arc, false);
          ctx.arc(250, 250, insideRadius, angle + arc, angle, true);
          ctx.stroke();
          ctx.fill();
    
          ctx.save();
          ctx.shadowOffsetX = -1;
          ctx.shadowOffsetY = -1;
          ctx.shadowBlur    = 0;
          ctx.shadowColor   = "rgb(220,220,220)";
          ctx.fillStyle = "black";
          ctx.translate(250 + Math.cos(angle + arc / 2) * textRadius, 
                        250 + Math.sin(angle + arc / 2) * textRadius);
          ctx.rotate(angle + arc / 2 + Math.PI / 2);
          var text = options[i];
          ctx.fillText(text, -ctx.measureText(text).width / 2, 0);
          ctx.restore();
        } 
    
        //Arrow
        ctx.fillStyle = "black";
        ctx.beginPath();
        ctx.moveTo(250 - 4, 250 - (outsideRadius + 5));
        ctx.lineTo(250 + 4, 250 - (outsideRadius + 5));
        ctx.lineTo(250 + 4, 250 - (outsideRadius - 5));
        ctx.lineTo(250 + 9, 250 - (outsideRadius - 5));
        ctx.lineTo(250 + 0, 250 - (outsideRadius - 13));
        ctx.lineTo(250 - 9, 250 - (outsideRadius - 5));
        ctx.lineTo(250 - 4, 250 - (outsideRadius - 5));
        ctx.lineTo(250 - 4, 250 - (outsideRadius + 5));
        ctx.fill();
      }
    }
    
    function spin() {
      spinAngleStart = Math.random() * 10 + 10;
      spinTime = 5;
      spinTimeTotal = Math.random() * 3 + 4 * 1000;
      callRotateWheel();
    }
    
    function rotateWheel() {
      spinTime += 30;
      if(spinTime >= spinTimeTotal) {
        //stopRotateWheel();
        return;
      }
      var spinAngle = spinAngleStart - easeOut(spinTime, 0, spinAngleStart, spinTimeTotal);
      startAngle += (spinAngle * Math.PI / 180);
      drawRouletteWheel();  
    }

    //Gebruik deze functie om RotateWheel verschillende keren te herhalen
    function callRotateWheel(){
      for(let i = 0 ; i<(Math.floor(Math.random() * 50))  ; i++)
      {
        rotateWheel();
      }
       stopRotateWheel();
    }
    
    function stopRotateWheel() {
      clearTimeout(spinTimeout);
      var degrees = startAngle * 180 / Math.PI + 90;
      var arcd = arc * 180 / Math.PI;
      var index = Math.floor((360 - degrees % 360) / arcd);
      ctx.save();
      ctx.font = 'bold 30px Helvetica, Arial';
      var text = options[index]
     
      checkProfit(text);
      console.log(window.gegokteWaarde);
      console.log(window.Bets);
      

      ctx.fillText(text, 250 - ctx.measureText(text).width / 2, 250 + 10);
      ctx.restore();
    }

    function checkProfit(resultaat){

      for(let i = 1 ; i<window.gegokteWaarde.length ; i++){
        if(resultaat == (gegokteWaarde[i]) ){
          //hier komt de winst
          console.log(`U heeft ${window.Bets[i]} ingezet op ${window.gegokteWaarde[i]} hierdoor wint u ${window.Bets[i] * 10} `)
        }
      }

    }
    
    function easeOut(t, b, c, d) {
      var ts = (t/=d)*t;
      var tc = ts*t;
      return b+c*(tc + -3*ts + 3*t);
    }
    
    drawRouletteWheel();
    })