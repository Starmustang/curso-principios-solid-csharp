using SingleResponsability;


StudentRepository studentRepository = new();
ExportHelper<Student> studentExport = new();
studentExport.ExportStudents(studentRepository.GetAll());
Console.WriteLine("Proceso Completado");