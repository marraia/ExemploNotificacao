using ExemploNotificacao.Application.Interface;
using ExemploNotificacao.Common.Implementation;
using ExemploNotificacao.Domain;
using ExemploNotificacao.Common.Interface;

namespace ExemploNotificacao.Application
{
    public class StudentAppService : IStudentAppService
    {
        private readonly Notify _notify;

        public StudentAppService(INotify notify)
        {
            _notify = notify.Invoke();
        }

        public Student Add(Student obj)
        {
            if (obj.Age < 18)
            {
                _notify.NewNotification("Student", "Aluno com menos de 18 anos");
                return null;
            }

            return obj;
        }
    }
}
