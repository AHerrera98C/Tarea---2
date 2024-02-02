
class Program
{
    static void Main()
    {
        int tipoEmpleado;
        int cantidadOperarios = 0, cantidadTecnicos = 0, cantidadProfesionales = 0;
        double acumuladoSalarioNetoOperarios = 0, acumuladoSalarioNetoTecnicos = 0, acumuladoSalarioNetoProfesionales = 0;

        while (true)
        {
            int cedula;
            string nombre;
            double horasTrabajadas, precioHora;

            Console.WriteLine("Ingrese el numero de cedula o ingrese -1 para salir: ");
            cedula = int.Parse(Console.ReadLine());

            if (cedula == -1)
            {
                break;
            }

            Console.Write("Ingrese el nombre del Empleado:  ");
            nombre = Console.ReadLine();

            Console.Write("Ingrese el tipo de empleado (1- Operario, 2-Técnico, 3-Profesional): ");
            tipoEmpleado = int.Parse(Console.ReadLine());

            Console.Write("Ingrese la cantidad de horas trabajadas: ");
            horasTrabajadas = int.Parse(Console.ReadLine());

            Console.Write("Ingrese el valor de la hora: ");
            precioHora = int.Parse(Console.ReadLine());

            double salarioOrdinario = horasTrabajadas * precioHora;

            double aumento, salarioBruto, deduccionCCSS, salarioNeto;

            switch (tipoEmpleado)
            {
                case 1:
                    aumento = 0.15 * salarioOrdinario;
                        ; break;
                case 2:
                    aumento = 0.10 * salarioOrdinario;
                    break;
                case 3:
                    aumento = 0.05 * salarioOrdinario;
                    break;
                default:
                    Console.WriteLine("Tipo de empledo incorrecto, Error.");
                    return;

            }

            salarioBruto = salarioOrdinario + aumento;
            deduccionCCSS = 0.0917 * salarioBruto;
            salarioNeto = salarioBruto - deduccionCCSS;

            Console.WriteLine("Numero de cedula: " + cedula); 
            Console.WriteLine("Nombre del Empleado: " + nombre);
            Console.WriteLine("Tipo de empleado: " + tipoEmpleado);
            Console.WriteLine("Salario por horas: " + precioHora);
            Console.WriteLine("Cantidad de horas trabajadas: " + horasTrabajadas);
            Console.WriteLine("Salario Ordinario: " + salarioOrdinario);
            Console.WriteLine("Aumento: " + aumento);
            Console.WriteLine("Salario Bruto: " + salarioBruto);
            Console.WriteLine("Deduccion CCSS: " + deduccionCCSS);
            Console.WriteLine("Salario Neto: " + salarioNeto);

            switch (tipoEmpleado)
            {
                case 1:
                    cantidadOperarios++;
                    acumuladoSalarioNetoOperarios += salarioNeto;
                    break;
                case 2:
                    cantidadTecnicos++;
                    acumuladoSalarioNetoTecnicos += salarioNeto;
                    break;
                case 3:
                    cantidadProfesionales++;
                    acumuladoSalarioNetoProfesionales += salarioNeto;
                    break;
            }
        }

        Console.WriteLine("Estadisticas finales: ");
        Console.WriteLine("1-Cantidad de empleados tipo operario: " + cantidadOperarios);
        Console.WriteLine("Acumulado Salario neto para operarios: " + acumuladoSalarioNetoOperarios);
        Console.WriteLine("3-Promedio salario neto para operarios: " + (cantidadOperarios > 0 ? acumuladoSalarioNetoOperarios / cantidadOperarios : 0).ToString("F2"));
        Console.WriteLine("4-Cantidad de empleados tipo tecnicos: " + cantidadTecnicos);
        Console.WriteLine("5-Acumulado salario neto para tecnicos: " + acumuladoSalarioNetoTecnicos);
        Console.WriteLine("6-Promedio salario neto para tecnicos: " + (cantidadTecnicos > 0 ? acumuladoSalarioNetoTecnicos / cantidadTecnicos : 0).ToString("F2"));
        Console.WriteLine("7-Cantidad de empleados tipo profesionales: " + cantidadProfesionales);
        Console.WriteLine("8-Acumulado salario neto para profesionales: ");
        Console.WriteLine("9-Promedio salario neto para profesionales: " + (cantidadProfesionales > 0 ? acumuladoSalarioNetoProfesionales / cantidadProfesionales : 0).ToString("F2"));
    }
}
