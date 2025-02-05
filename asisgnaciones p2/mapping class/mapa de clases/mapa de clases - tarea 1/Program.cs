namespace Classes;

public class Miembro_de_la_comunidad
{
    public string Nombre { get; }
    public string Sexo { get; set; }


    public void Saludar()
    {
        Console.WriteLine($"Hola, soy {Nombre}");
    }


    public void DecirSexo()
    {
        Console.WriteLine($"Soy {Sexo}");
    }
}


public class Estudiante : Miembro_de_la_comunidad
{
    public string Carrera { get; set; }
    public int Semestre { get; set; }


    public void DecirCarrera()
    {
        Console.WriteLine($"Estudio {Carrera}");
    }

    public void DecirSemestre()
    {
        Console.WriteLine($"Estoy en el semestre {Semestre}");
    }
}

public class ExAlumno : Miembro_de_la_comunidad {

    public string nombre { get; set; }

    public int anos_cursados { get; set; }

    public void DecirNombreExAlumno()
    {
        Console.WriteLine($"Me llamo {nombre} y estudio {anos_cursados} en el centro");
    }

}

public class Empleado : Miembro_de_la_comunidad
{
    public string nombre { get; }
    public string Rol { get; set; }
    public string departamento { get; set; }
    public decimal Salario { get; }

    public void DecirNombreEmpleado()
    {
        Console.WriteLine($"Me llamo {nombre}");
    }

    public void DecirRolEmpleado()
    {
        Console.WriteLine($"Mi rol es {Rol} y pertenezco al departamento de {departamento}");
    }
}

public class Docente : Empleado
{
    public string nombre { get; set; }
    public string rol { get; set; }

    public void DecirNombreDocente()
    {
        Console.WriteLine($"Me llamo {nombre}");
    }

    public void DecirRolDocente()
    {
        Console.WriteLine($"Mi rol es {Rol}");
    }

}

public class Maestro : Docente
{
    public string nombre { get; set; }
    public string asignatura { get; set; }

    public void DecirNombreMaestro()
    {
        Console.WriteLine($"Me llamo {nombre}");
    }

    public void DecirAsignatura()
    {
        Console.WriteLine($"La asignatura que imparto es {Rol}");
    }
}
  
