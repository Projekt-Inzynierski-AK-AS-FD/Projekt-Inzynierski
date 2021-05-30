using DemoLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLibrary
{
    public class DataAccess
    {
        Random rnd = new Random();
        string[] chapters = new string[] { "1. Wyrażenia algebraiczne", "2. Zbiory", "3. Funkcje", "4. Wielomiany", "5. Trygonometria" };
        string[] theContentOfTheTasks = new string[] { "Oblicz", "Obliczyć", "Rozwiąż", "Oblicz równanie", "Obliczyć równanie", "Rozwiąż równanie", "Wykonaj" };
        string[] subsections = new string[] { "a)", "b)", "c)", "d)", "e)", "f)", "g)", "h)", "i)", "j)", "k)" };
        string[] theContentOfTheSubsections = new string[] { "1.", "2.", "3.", "4.", "5.", "6.", "7.", "8.", "9.", "10.", "11.", "12." };

        string[] titles = new string[] { "Wyrażenia", "Liczby", "Liczby", "Funkcja", "Funkcja", "Funkcja", "Wyrażenia", "Funkcja", "Funkcja", "Wielomiany", "Funkcja" };
        string[] subtitles = new string[] { "algebraiczne", "Naturalne", "Rzeczywiste", "Liniowa", "Kwadratowa", "Wykładnicza", "wymierne", "Logarytmiczna", "f(x)=a/x", "", "Trygonometryczna" };
        bool[] doneStatuses = new bool[] { true, false };
        DateTime lowEndDate = new DateTime(2021, 1, 1);
        int daysFromLowDate;

        public DataAccess()
        {
            daysFromLowDate = (DateTime.Today - lowEndDate).Days;
        }

        public List<ExerciseModel> GetExercises(int total = 10)
        {
            List<ExerciseModel> output = new List<ExerciseModel>();

            for (int i = 0; i < total; i++)
            {

                output.Add(GetExercise(i + 1));
            }

            return output;
        }

        private ExerciseModel GetExercise(int id)
        {
            ExerciseModel output = new ExerciseModel();

            output.ExerciseId = id;
            output.Title = GetRandomItem(titles);
            output.Subtitle = GetRandomItem(subtitles);
            output.IsDone = GetRandomItem(doneStatuses);
            output.DateOfCreation = GetRandomDate();
            output.NumberOfTasks = GetExercises(output.DateOfCreation);
            output.Points = ((decimal)rnd.Next(1, 1000000) / 100);

            int chaptersCount = rnd.Next(1, 5);

            for (int i = 0; i < chaptersCount; i++)
            {
                output.Exercises.Add(GetChapters(((id - 1) * 5) + i + 1));
            }

            return output;
        }

        private ChapterModel GetChapters(int id)
        {
            ChapterModel output = new ChapterModel();

            output.ChapterId = id;
            output.Chapter = GetRandomItem(chapters);
            output.TheContentOfTheTask = GetRandomItem(theContentOfTheTasks);
            output.Subsection = GetRandomItem(subsections);
            output.TheContentOfTheSubsection = GetRandomItem(theContentOfTheSubsections);

            return output;
        }

        private T GetRandomItem<T>(T[] data)
        {
            return data[rnd.Next(0, data.Length)];
        }

        private DateTime GetRandomDate()
        {
            return lowEndDate.AddDays(rnd.Next(daysFromLowDate));
        }

        private int GetExercises(DateTime createDate)
        {
            DateTime now = DateTime.Today;
            int age = now.Year - createDate.Year;
            if (now < createDate.AddYears(age))
            {
                age--;
            }

            return age;
        }
    }
}
