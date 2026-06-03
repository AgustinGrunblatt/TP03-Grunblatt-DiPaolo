function ArriesgarLetra()
{
    let LaLetra = document.getElementById("Letra").toUpperCase();
    let LaPalabraOculta = document.getElementById("Palabra")
    let palabraVacia ="";

    if (LaPalabraOculta.includes(LaLetra))
    {
        for (let i = 0; i < LaPalabraOculta; i++)
        {
            if (LaPalabraOculta[i] == LaLetra)
            {
                palabraVacia[1] == LaPalabraOculta[i];
            }
        }
    }

}
