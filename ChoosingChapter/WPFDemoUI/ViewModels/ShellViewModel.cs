using Caliburn.Micro;
using DemoLibrary;
using DemoLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFDemoUI.ViewModels
{
    public class ShellViewModel : Screen
    {
        public BindableCollection<ExerciseModel> Exercises { get; set; }

        private ExerciseModel _selectedExercise;

        public ExerciseModel SelectedExercise
        {
            get { return _selectedExercise; }
            set
            {
                _selectedExercise = value;
                SelectedChapter = value.PrimaryExercise;
                NotifyOfPropertyChange(() => SelectedExercise);
            }
        }

        private ChapterModel _selectedChapter;

        public ChapterModel SelectedChapter
        {
            get { return _selectedChapter; }
            set
            {
                _selectedChapter = value;
                SelectedExercise.PrimaryExercise = value;
                NotifyOfPropertyChange(() => SelectedChapter);
            }
        }


        public ShellViewModel()
        {
            DataAccess da = new DataAccess();
            Exercises = new BindableCollection<ExerciseModel>(da.GetExercises());
        }
    }
}
