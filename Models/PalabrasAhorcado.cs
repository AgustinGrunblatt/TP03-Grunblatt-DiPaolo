namespace TP03_Grunblatt_Dipaolo.Models;

public class PalabrasAhorcado
{
    private List<string> palabras;

    public PalabrasAhorcado()
    {
       palabras = new List<string>(){"TENTACION","ONOMATOPEYA", "LEVITICO", "AUSTERO", "CRUCIGRAMA", "CORRELACION", "ELECTROENCEFALOGRAFISTA", "TROMPETA", "PULMONADO", "CALEIDOSCOPIO"};
    }
        
        
    public string ObtenerPalabra()
        {
            Random random = new Random();
            int numeroAleatorio = random.Next(0, 10);
            string palabraElegida = palabras[numeroAleatorio];
            return palabraElegida;
        }
}