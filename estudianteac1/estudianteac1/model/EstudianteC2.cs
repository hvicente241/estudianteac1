using estudianteac1.services;
using System;
using System.Collections.Generic;
using System.Text;

namespace estudianteac1.model
{
   public class EstudianteC2 : EstudianteP
    {
        private int _ID;

        public int ID
        {
            get { return _ID; }
            set { _ID = value; OnPropertyChanged(); }
        }

        private string _NombreEstudiante;

        public string NombreEstudiante
        {
            get { return _NombreEstudiante; }
            set { _NombreEstudiante = value; OnPropertyChanged(); }
        }

        private string _ApellidoEstudiante;

        public string ApellidoEstudiante
        {
            get { return _ApellidoEstudiante; }
            set { _ApellidoEstudiante = value; OnPropertyChanged(); }
        }

        private string _Curso;

        public string Curso
        {
            get { return _Curso; }
            set { _Curso = value; OnPropertyChanged(); }
        }

        private int _Edad;

        public int Edad
        {
            get { return _Edad; }
            set { _Edad = value; OnPropertyChanged(); }
        }
        private string _Direccion;

        public string Direccion
        {
            get { return _Direccion; }
            set { _Direccion = value; OnPropertyChanged(); }
        }
        private string _ResponsableEmergencia;

        public string ResponsableEmergencia
        {
            get { return _ResponsableEmergencia; }
            set { _ResponsableEmergencia = value; OnPropertyChanged(); }
        }







    }
}
