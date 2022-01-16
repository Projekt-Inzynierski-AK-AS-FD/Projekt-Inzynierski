using Abituria.controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abituria.datamodels
{
    public class CompletedExercise : DomainObject
    {
        //public int Id { get; set; }
        public Account Account { get; set; }
        public bool IsComplete { get; set; }
        public int Number { get; set; }
        public DateTime DateCompleted { get; set; }
    }
}
