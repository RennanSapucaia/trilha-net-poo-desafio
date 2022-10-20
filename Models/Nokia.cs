namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    // (!!!FEITO!!!)
    public class Nokia : Smartphone
    {
        // TODO: Sobrescrever o método "InstalarAplicativo"
        // (!!!FEITO!!!)
        public Nokia(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria)
        {

        }
        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalando Aplicativo [{nomeApp}] Em aparelho Nokia...");
            Console.WriteLine($"Aplicativo [{nomeApp}] - INSTALADO COM SUCESSO!");
        }
    }
}