using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Task_2_School
{
    class Teacher
    {
        public string Name;

        private Subject[] subjects = new Subject[5];

        public void AddSubject(Subject subject)
        {
            if (subject == null) return;

            if (subjects == null)
            {
                subjects[0] = subject;
            }

            if (subjects[subjects.Length - 1] != null)
            {
                Subject[] subjects_new = new Subject[subjects.Length];
                for (int i = 0; i < subjects_new.Length; i++)
                    subjects_new[i] = subjects[i];
                subjects_new[subjects_new.Length - 1] = subject;
                subjects = subjects_new;
            }
        }
    }
}
