using Abituria.datamodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Abituria.controls
{
    public class CompleteExerciseService : ICompleteExerciseService///Niezależne od Entity Framework, zależne od interfejsów
    {
        private readonly IDataService<Account> maccountService;
        public CompleteExerciseService(IDataService<Account> accountService)
        {
            maccountService = accountService;
        }
        public async Task<Account> CompleteExercise(Account user, int exercise, bool isComplete)
        {
            CompletedExercise successfullyCompletedExercise = new CompletedExercise()
            {
                Account = user,
                Number = exercise,
                DateCompleted = DateTime.Now,
                IsComplete = true
            };
            user.CompletedExercises.Add(successfullyCompletedExercise);
            await maccountService.Update(user.Id, user);
            return user;
        }
    }
}
