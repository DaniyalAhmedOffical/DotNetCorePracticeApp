using DotNetCorePracticeApp.Model;

namespace DotNetCorePracticeApp.Repository
{
    public interface IStudent
    {
        List<StudentModel> getAllStudents();
        StudentModel getStudentById(int id); 
    }
}
