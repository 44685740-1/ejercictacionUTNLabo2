using System.Text;

namespace FromulaUno
{
    public class AutoF1
    {
        private short _cantidadCombustible;
        private bool _enCompetencia;
        private string _escuderia;
        private short _numero;
        private short _vueltasRestantes;


        public AutoF1(short numero, string escuderia)
        {
            this._numero = numero;
            this._escuderia = escuderia;
        }

        //Properties
        public short CantidadCombustible { 
            get { return _cantidadCombustible;} 
            set { _cantidadCombustible = value;} 
        }

        public bool enCompetencia 
        {
            get { return _enCompetencia; }
            set { _enCompetencia = value;   }
        }

        public short vueltasRestantes 
        {
            get { return _vueltasRestantes;}
            set { _vueltasRestantes = value;}
        }

        public string Mostrar()
        {
            StringBuilder autoF1SB = new StringBuilder();
            autoF1SB.AppendLine($"cantidad de combustible {this._cantidadCombustible}");
            autoF1SB.AppendLine($"escuderia {this._escuderia}");
            autoF1SB.AppendLine($"numero {this._numero}");
            autoF1SB.AppendLine($"vueltas restantes {this._vueltasRestantes}");
            if (this._enCompetencia)
            {
                autoF1SB.AppendLine("esta en competencia");
            }
            else
            {
                autoF1SB.AppendLine("No esta en competencia");
            }

            return autoF1SB.ToString();
        }

        public static bool  operator ==(AutoF1 autoUno, AutoF1 autoDos) 
        {
            if (autoUno._escuderia == autoDos._escuderia && autoUno._numero == autoDos._numero)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool operator !=(AutoF1 autoUno, AutoF1 autoDos)
        {
            if (autoUno._escuderia == autoDos._escuderia && autoUno._numero == autoDos._numero)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

    }
}