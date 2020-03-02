using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizAppFixed_WF
{
    class GlobalVars
    {
        //All public variables can be accessed anywhere in the application//
        public static string strForname;
        public static string strSurname; //these variables store users first and second name respectively in strings

        public static int intTotal; //keeps track of the total questions answered \
        public static int intCorrectAnswers; //tracks total correct answers        using int datatype
        public static int intIncorrectAnswers; //tracks total incorrect answers   /
    }
}
