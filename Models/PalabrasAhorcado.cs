namespace TP03_Grunblatt_Dipaolo.Models;

public class PalabrasAhorcado
{
    public int Id { get; set; } 
    public string NombrePalabra { get; set; }
    public List<string> palabras;
   
    public string ObtenerPalabra()
        {
            BD MiBase = new BD();
            palabras = MiBase.TraerPalabras();
            Random random = new Random();
            int numeroAleatorio = random.Next(0, palabras.Count);
            string palabraElegida = palabras[numeroAleatorio];
            return palabraElegida;
        }
        public void Guardar()
        {
            BD bd = new BD();
            bd.ArchivarPalabra(this.NombrePalabra.ToUpper());
        }
}