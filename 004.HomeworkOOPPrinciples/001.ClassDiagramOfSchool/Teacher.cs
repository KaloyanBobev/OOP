using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Teacher : Person, ICommentable
    {
    //fields
        private List<Disciplines> disciplines;
        private List<string> freeText;
    //properties
        public List<Disciplines> Disciplines
        {
            get
            {
                return this.disciplines;
            }
            set
            {
                if (value.Count >=1)
                {
                    this.disciplines = value;
                }
                else
                {
                    throw new ArgumentException("no recorded discipline");
                }
 
            }
        }

        public string[] FreeTexts
        {
            get { return this.freeText.ToArray(); }
            set { }
        }
    //constuctor
        public Teacher(string name, Disciplines[] disciplines)
            : base(name) //Teachers have name.
        {
            this.disciplines = new List<Disciplines>(disciplines);
        }

        public void AddDiscipline(Disciplines discipline)
        {
            this.disciplines.Add(discipline);
        }

        public void DeleteDiscipline(Disciplines discipline)
        {
            this.disciplines.Remove(discipline);
        }

        public void AddText(string freeText)
        {
            this.freeText.Add(freeText);
        }
    }

