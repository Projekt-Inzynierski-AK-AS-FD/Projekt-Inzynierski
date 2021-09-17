using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLibrary.Models
{
    public class ExerciseModel
    {
        public int ExerciseId { get; set; }
        public string Title { get; set; }
        public string Subtitle { get; set; }
        public int NumberOfTasks { get; set; }
        public DateTime DateOfCreation { get; set; }
        public bool IsDone { get; set; }
        public decimal Points { get; set; }
        public List<ChapterModel> Exercises { get; set; } = new List<ChapterModel>();
        public ChapterModel PrimaryExercise { get; set; }

        public string FullTitle
        {
            get
            {
                return $"{ Title } { Subtitle }";
            }
        }
    }
}
