using CodigoClase15.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace CodigoClase15.Clases
{
    public class Gerente : EmpleadoBase,ISueldoBonificable,IDescuentoImpuesto
    {        
        //=> Lambda: Funciones pequeñas
        public override int SueldoBase => 8000;

        public decimal CalcularBonificacion()
        {
            throw new NotImplementedException();
        }
        public decimal DescontarSueldo()
        {
            throw new NotImplementedException();
        }

        public override decimal CalcularSueldo()
        {
            return SueldoBase + CalcularBonificacion() - DescontarSueldo();
        }

        
    }
}
