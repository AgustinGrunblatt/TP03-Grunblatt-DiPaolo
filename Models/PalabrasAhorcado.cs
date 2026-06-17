namespace TP03_Grunblatt_Dipaolo.Models;

public class PalabrasAhorcado
{
    private List<string> palabras;
        
    public string ObtenerPalabra()
        {
            BD MiBase = new BD();
            palabras = MiBase.TraerPalabras();
            Random random = new Random();
            int numeroAleatorio = random.Next(0, palabras.Count);
            string palabraElegida = palabras[numeroAleatorio];
            return palabraElegida;
        }
    public void ArchivarPalabra(string PalabraNueva)
    {
        BD MiBase = new BD();
        MiBase.ArchivarPalabra(PalabraNueva);
    }
}