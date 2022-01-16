using Abituria.controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abituria.datamodels
{
    public class Account : DomainObject
    {
        //public int Id { get; set; } 
        public User AccountHolder { get; set; }
        public string Password { get; set; }
        public ICollection<CompletedExercise> CompletedExercises { get; set; }///Nie robi dżojnta na pustą kolekcje z automatu
    }
}
