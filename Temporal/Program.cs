using reackBackend.Repository;

//abstraction de un objeto Dao

AlumnoDAO alumnoDao = new AlumnoDAO();

//llamamos el metodo que creamos en el DAO

var alumno = alumnoDao.SelectAll();

// Recorremos la lista

foreach (var item in alumno)
{
    Console.WriteLine(item.Nombre);
}