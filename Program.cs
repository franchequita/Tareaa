using System;

// Clase base Miembro de la Comunidad
public class MiembroDeLaComunidad
{
    public string Nombre { get; set; }
    public int Edad { get; set; }

    
    public virtual string ObtenerInformacion()
    {
        return $"Nombre: {Nombre}, Edad: {Edad}";
    }
}

// Subclase Empleado
public class Empleado : MiembroDeLaComunidad
{
    public string Cargo { get; set; }

    public override string ObtenerInformacion()
    {
        return base.ObtenerInformacion() + $", Cargo: {Cargo}";
    }
}

// Subclase Docente
public class Docente : Empleado
{
    public string Materia { get; set; }

  
    public override string ObtenerInformacion()
    {
        return base.ObtenerInformacion() + $", Materia: {Materia}";
    }
}

// Subclase Administrativo
public class Administrativo : Empleado
{
    public string Departamento { get; set; }

    
    public override string ObtenerInformacion()
    {
        return base.ObtenerInformacion() + $", Departamento: {Departamento}";
    }
}

// Subclase Estudiante
public class Estudiante : MiembroDeLaComunidad
{
    public string Carrera { get; set; }

    public override string ObtenerInformacion()
    {
        return base.ObtenerInformacion() + $", Carrera: {Carrera}";
    }
}

// Subclase ExAlumno
public class ExAlumno : MiembroDeLaComunidad
{
    public string CarreraAnterior { get; set; }

   
    public override string ObtenerInformacion()
    {
        return base.ObtenerInformacion() + $", Carrera Anterior: {CarreraAnterior}";
    }
}

// Subclase Administrador
public class Administrador : Docente
{
    public string Responsabilidades { get; set; }

    
    public override string ObtenerInformacion()
    {
        return base.ObtenerInformacion() + $", Responsabilidades: {Responsabilidades}";
    }
}

// Subclase Maestro
public class Maestro : Docente
{
    public string Grado { get; set; }

   
    public override string ObtenerInformacion()
    {
        return base.ObtenerInformacion() + $", Grado: {Grado}";
    }
}

class Program
{
    static void Main()
    {
        
        Administrador administrador = new Administrador { Nombre = "Juan", Edad = 45, Cargo = "Administrador", Materia = "Informática", Responsabilidades = "Gestión del personal" };
        Maestro maestro = new Maestro { Nombre = "Pedro", Edad = 50, Cargo = "Maestro", Materia = "Historia", Grado = "Noveno" };
        Docente docente = new Docente { Nombre = "Miguel", Edad = 38, Cargo = "Docente", Materia = "Matemáticas" };
        Administrativo administrativo = new Administrativo { Nombre = "Felipe", Edad = 32, Cargo = "Administrativo", Departamento = "Recursos Humanos" };
        Estudiante estudiante = new Estudiante { Nombre = "Carlos", Edad = 22, Carrera = "Ingeniería" };
        ExAlumno exAlumno = new ExAlumno { Nombre = "Federico", Edad = 40, CarreraAnterior = "Informática" };

        Console.WriteLine(administrador.ObtenerInformacion());
        Console.WriteLine(maestro.ObtenerInformacion());
        Console.WriteLine(docente.ObtenerInformacion());
        Console.WriteLine(administrativo.ObtenerInformacion());
        Console.WriteLine(estudiante.ObtenerInformacion());
        Console.WriteLine(exAlumno.ObtenerInformacion());
    }
}
