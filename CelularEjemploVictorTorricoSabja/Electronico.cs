using System;
using System.Collections.Generic;
using System.Text;

namespace CelularEjemploVictorTorricoSabja
{
    public abstract class Electronico
    {
        protected string pantalla;
        protected void Vibrar()
        {

        }
        public string Sonar()
        {
            return "brrrr";
        }
    }
}
