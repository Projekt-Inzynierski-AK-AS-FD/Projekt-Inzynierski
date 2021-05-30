using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLibrary.Models
{
    public class ChapterModel
    {
        public int ChapterId { get; set; }
        public string Chapter { get; set; }
        public string TheContentOfTheTask { get; set; }
        public string Subsection { get; set; }
        public string TheContentOfTheSubsection { get; set; }

        public string FullContent
        {
            get
            {
                return $"{ Chapter }, { TheContentOfTheTask }, { Subsection }  { TheContentOfTheSubsection }";
            }
        }
    }
}
