window.addEventListener('load',function(){  

let btnSlot = document.querySelector("#btnSpeelSlot");

btnSlot.addEventListener("click",slotmachine)
   
function slotmachine(){    
    slotOne = Math.floor(Math.random() * (3 - 1 + 1)) + 1;
    slotTwo = Math.floor(Math.random() * (3 - 1 + 1)) + 1;
    slotThree = Math.floor(Math.random() * (3 - 1 + 1)) + 1;
    
     
    let foto1 = document.querySelector("#foto1");
    let foto2 = document.querySelector("#foto2");
    let foto3 = document.querySelector("#foto3");
   
    foto1url = "img/foto1.jpg"
    foto2url = "img/foto2.jpg"
    foto3url = "img/foto3.jpg"

    foto1.innerHTML="";
    foto2.innerHTML="";
    foto3.innerHTML="";

    var dict = {        
        "1": foto1url,
        "2": foto2url,
        "3":foto3url       
      };
    
        
        let img = document.createElement("img");
        img.setAttribute("src", `${dict[slotOne]}`);    
        foto1.appendChild(img);

        let img2 = document.createElement("img");
        img2.setAttribute("src", `${dict[slotTwo]}`);    
        foto2.appendChild(img2);

        let img3 = document.createElement("img");
        img3.setAttribute("src", `${dict[slotThree]}`);    
        foto3.appendChild(img3);
    
        if(img.src == img2.src && img.src == img3.src){
            alert("u got some great porno")
        }
}

})
 