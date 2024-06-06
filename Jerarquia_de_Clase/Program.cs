using System;

        public class MiembroDeLaComunidad
        {
            public string Nombre { get; set; }
            public int Edad { get; set; }

            public virtual void MostrarInformacion()
            {
                Console.WriteLine($"Nombre: {Nombre}, Edad: {Edad}");
            }
        }

        public class Empleado : MiembroDeLaComunidad
        {
            public string Puesto { get; set; }

            public override void MostrarInformacion()
            {
                base.MostrarInformacion();
                Console.WriteLine($"Puesto: {Puesto}");
            }
        }

        public class Estudiante : MiembroDeLaComunidad
        {
            public string Carrera { get; set; }

            public override void MostrarInformacion()
            {
                base.MostrarInformacion();
                Console.WriteLine($"Carrera: {Carrera}");
            }
        }

        public class ExAlumno : MiembroDeLaComunidad
        {
            public int AñoGraduacion { get; set; }

            public override void MostrarInformacion()
            {
                base.MostrarInformacion();
                Console.WriteLine($"Año de Graduación: {AñoGraduacion}");
            }
        }

        public class Docente : Empleado
        {
        }

        public class Administrativo : Empleado
        {
        }

        public class Administrador : Docente
        {
        }

        public class Maestro : Docente
        {
        }
   



