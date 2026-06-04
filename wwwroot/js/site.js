function ArriesgarLetra()
{
    let LaLetra = document.getElementById("Letra").value.toUpperCase();
    let LaPalabraOculta = document.getElementById("Palabra").value;
    let oculta = document.getElementById("Oculta");
    let palabraVacia ="";
    let intentos = document.getElementById("Intento").value;
    let intentosRestantes = 10;

    if (LaPalabraOculta.includes(LaLetra))
    {
        console.log("Entre al if")
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
    }
    else{
        intentosRestantes -1;
        intentos = intentosRestantes;
    }

}
