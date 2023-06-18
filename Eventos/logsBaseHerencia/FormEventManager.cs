using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace logsBaseHerencia
{
    public class FormEventManager
    {
        public event Action<string> FormOpened;
        public event Action<string> FormClosed;

        public void RaiseFormOpened(string formName)
        {
            FormOpened?.Invoke(formName);
        }

        public void RaiseFormClosed(string formName)
        {
            FormClosed?.Invoke(formName);
        }
    }
}
