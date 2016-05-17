using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task04
{
  class DocumentWorker
  {
    public void OpenDocument()
    {
      Console.WriteLine("Документ открыт");
    }
    public virtual void EditDocument()
    {
      Console.WriteLine("Редактирование документа доступно в версии Про");
    }
    public virtual void SaveDocument()
    {
      Console.WriteLine("Сохранение документа доступно в версии Про");
    }
  }

  class DocumentWorkerPro : DocumentWorker
  {
    public override void EditDocument()
    {
      Console.WriteLine("Документ отредактирован");
    }
    public override void SaveDocument()
    {
      Console.WriteLine("Документ сохранен в старом формате, сохранение в остальных форматах доступно в версии Эксперт");
    }
  }

  class ExpertDocumentWorker : DocumentWorkerPro
  {
    public override void SaveDocument()
    {
      Console.WriteLine("Документ сохранен в новом формате");
    }
  }

}
