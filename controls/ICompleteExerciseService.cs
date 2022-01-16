using Abituria.datamodels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Abituria.controls
{
    public interface ICompleteExerciseService
    {
        Task<Account> CompleteExercise(Account user, int exercise, bool isComplete);///Nowy stan konta po wykonaniu zadania
    }
}
