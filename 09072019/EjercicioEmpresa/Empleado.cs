using System;
using System.Collections.Generic;
using System.Text;
//La clase empleado tendrá como mínimo cuatro atributos: 
//nombre de tipo String, apellidos de tipo String, fechanacimiento de tipo String y fechaContrato de tipo String 
namespace EjercicioEmpresa
{
    [Serializable]
    class Empleado
    {
        private string nombre;
        private string apellidos;
        private string fechaNacimiento;
        private string fechaContrato;       

        public string Nombre
        {
            get => nombre;
            set => nombre = value;
        }
        public string Apellidos
        {
            get => apellidos;
            set => apellidos = value;
        }
        public string FechaNacimiento
        {
            get => fechaNacimiento;
            set => fechaNacimiento = value;
        }
        public string FechaContrato
        {
            get => fechaContrato;
            set => fechaContrato = value;
        }
    }
}
