using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson03._4
{
    class ProDocumentWorker : DocumentWorker
    {
        public override void EditDocument()
        {
            Console.WriteLine("Документ отредактирован");
        }

        public override void OpenDocument()
        {
            base.OpenDocument();
        }

        public override void SaveDocument()
        {
            Console.WriteLine("Документ сохранен в старом формате, сохранение в остальных форматах доступно в версии Эксперт");
        }
    }
}
