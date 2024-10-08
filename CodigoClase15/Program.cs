

using CodigoClase15.Clases;
using CodigoClase15.Interfaces;

List<EmpleadoBase> empleados = new List<EmpleadoBase>();

Gerente gerente = new Gerente
{
    IdEmpleado = 1,
    Nombre = "Hugo Torrico",
    Puesto = "Gerente Desarrollo"
};

Desarollador desarollador = new Desarollador
{
    IdEmpleado = 2,
    Nombre = "José Cárdenas",
    Puesto = "Desarrollador Senior",   
};





empleados.Add(gerente);
empleados.Add(desarollador);

foreach (var empleado in empleados)
{
    //empleado.CalcularSueldo();
    empleado.MostrarDetalle();
    //if (empleado is ISueldoBonificable bonificable)
    //{
    //    Console.WriteLine($"Bonificación: {bonificable.CalcularBonificacion()}");
    //}
    //Calcular Bonificacion
}

Console.Read();