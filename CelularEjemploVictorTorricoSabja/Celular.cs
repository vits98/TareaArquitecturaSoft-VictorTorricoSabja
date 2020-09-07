using System;

namespace CelularEjemploVictorTorricoSabja
{
    public class Celular:Electronico, IPortatiles
    {
        private string _estadoDeLaBateria;
        public string Marca { get; set; }
        public int LineaNumerica { get; set; }
        public int AniosDeUso { get; set; }
        public int Bateria { get; set; }
        public Celular()
        {
            _estadoDeLaBateria = "100%";
            AniosDeUso = 1;
        }

        public void Llamar()
        {
            _estadoDeLaBateria = "95%";
        }
        public void Mensajear()
        {
            Vibrar();
        }
        public string MostrarEstadoBateria()
        {
            return "el estado de la bateria es" + _estadoDeLaBateria;
        }
        public void Descargar()
        {
            AniosDeUso = AniosDeUso + 1;
        }

        public void Notificar()
        {
            throw new NotImplementedException();
        }

        public int NumeroDeCamaras()
        {
            return 3;
        }
    }
}
