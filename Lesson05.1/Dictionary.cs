using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson05._1
{
    class Dictionary
    {
        private string[] russianLanguage = new string[5];
        private string[] englishLanguage = new string[5];
        private string[] ukrainLanguage = new string[5];

        public Dictionary()
        {
            russianLanguage[0] = "яблоко"; englishLanguage[0] = "apple"; ukrainLanguage[0] = "яблодько";
            russianLanguage[1] = "папа"; englishLanguage[1] = "dad"; ukrainLanguage[1] = "батько";
            russianLanguage[2] = "мама"; englishLanguage[2] = "mom"; ukrainLanguage[2] = "матько";
            russianLanguage[3] = "машина"; englishLanguage[3] = "car"; ukrainLanguage[3] = "машинко";
            russianLanguage[4] = "дерево"; englishLanguage[4] = "tree"; ukrainLanguage[4] = "деревко";
        }

        public string this[string index]
        {
            get
            {
                for(int i = 0; i < russianLanguage.Length; i++)
                {
                    if(russianLanguage[i] == index || englishLanguage[i] == index || ukrainLanguage[i] == index)
                    {
                        return String.Format($"{russianLanguage[i]} - {englishLanguage[i]} - {ukrainLanguage[i]}");
                    }
                }
                return "Слово не найдено в словаре";
            }
        }

        public string this[int index]
        {
            get
            {
                if (index >= 0 && index < russianLanguage.Length)
                {                                           
                    return String.Format($"{russianLanguage[index]} - {englishLanguage[index]} - {ukrainLanguage[index]}");                       
                }
                else
                {
                    return "Вы вышли за границы массива";
                }
            }
        }
    }
}
