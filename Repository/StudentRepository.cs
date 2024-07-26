using DotNetCorePracticeApp.Model;

namespace DotNetCorePracticeApp.Repository
{
    public class StudentRepository : IStudent
    {
        public List<StudentModel> getAllStudents()
        {
            return DataSource();
         
        }

        public StudentModel getStudentById(int id)
        {
            return DataSource().Where(x => x.rollNo == id).FirstOrDefault();
        }

        private List<StudentModel> DataSource()
        {
            return new List<StudentModel>
    {
        new StudentModel {rollNo = 1 , Name = "Daniyal", Stand=12},
        new StudentModel { rollNo = 2, Name = "Ahmed", Stand = 11 },
        new StudentModel { rollNo = 3, Name = "Ali", Stand = 10 },

         new StudentModel { rollNo = 3, Name = "saqib",Stand = 11 },


        new StudentModel { rollNo = 3, Name = "Talha " , Stand = 10 },

    };
        }
    }
}
