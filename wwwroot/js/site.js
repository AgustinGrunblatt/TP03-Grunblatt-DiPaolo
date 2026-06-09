function ArriesgarLetra()
{
    let LaLetra = document.getElementById("Letra").value.toUpperCase();
    let LaPalabraOculta = document.getElementById("Palabra").value;
    let oculta = document.getElementById("Oculta");
    let palabraVacia ="";
    let intentos = document.getElementById("Intento").innerText;
    let intentosRestantes = parseInt(intentos);
    let rta = document.getElementById("resultado");
    console.log(intentosRestantes);
    if (LaPalabraOculta.includes(LaLetra))
    {
        console.log("Entre al if");
        for (let i = 0; i < LaPalabraOculta.length; i++)
        {
            if (LaPalabraOculta[i] == LaLetra)
            {
                palabraVacia += LaPalabraOculta[i];
                console.log(palabraVacia);
            }
            else{
                console.log("Agregue un guion");
                palabraVacia += oculta.innerText[i];
            }
        }
        oculta.innerText = palabraVacia;
        if (oculta.innerText.includes("_"))
        {   
            console.log("Entre en el otro if");
            rta.innerText = "Ganaste";
        }
    }
    else{
        console.log("Entre al else");
        intentosRestantes = intentosRestantes - 1;
        console.log(intentosRestantes);
        Intento.innerText = intentosRestantes;
        
        if (intentosRestantes < 1)
        {   
            console.log("Entre en el otro if");
            rta.innerText = "Perdiste";
        }
    }

}
