namespace constructor
{
    class program
    {
        static void Main(string[] args)
        {
            coche coche1 = new coche();//crea un objeto o instancia a la clase coche
            coche coche2 = new coche();
            Console.WriteLine(coche1.getinfocoche());

            coche coche3 = new coche(23,234);
            Console.WriteLine(coche3.getinfocoche());
        }
    }

    class coche
    {
        public coche()
        {
            ruedas = 4;
            largo = 5;
            ancho = 6;
        }
        public coche(double largocoche, double anchocoche)
        {
            ruedas = 4;
            largo = largocoche;
            ancho = anchocoche;
        }

        private int ruedas;
        private double largo;
        private double ancho;
        private bool climatizador;
        private string? tapiceria;

        public string getinfocoche()
        {
            return "info del coche" + ruedas + "largo" + largo + "ancho"+ancho;
        }
    }
}