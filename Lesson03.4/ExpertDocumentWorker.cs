using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson03._4
{
    class ExpertDocumentWorker : DocumentWorker
    {

        public override void EditDocument()
        {
            base.EditDocument();
        }

        public override void OpenDocument()
        {
            base.OpenDocument();
        }

        public override void SaveDocument()
        {
            Console.WriteLine("Документ сохранен в новом формате");
        }
    }
}
