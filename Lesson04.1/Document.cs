using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson04._1
{
    abstract class Document
    {
        private string fieldName;
        private string content;

        public Document(string fieldName)
        {
            this.fieldName = fieldName;
        }

        public  string Content
        {
            protected get
            {
                if (content != null)
                    return content;
                else
                    return fieldName + " отсутствует.";
            }
            set
            {
                content = value;
            }
        }

        public abstract void Show();
    }
}
