using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace logsBaseHerencia
{
    public class BaseForm : Form
    {
        protected static FormEventManager formEventManager;

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            SubscribeToFormEvents();
        }

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            base.OnFormClosed(e);
            UnsubscribeFromFormEvents();
        }

        protected virtual void SubscribeToFormEvents()
        {
            if (formEventManager != null)
            {
                formEventManager.FormOpened += FormEventManager_FormOpened;
                formEventManager.FormClosed += FormEventManager_FormClosed;
            }
        }

        protected virtual void UnsubscribeFromFormEvents()
        {
            if (formEventManager != null)
            {
                formEventManager.FormOpened -= FormEventManager_FormOpened;
                formEventManager.FormClosed -= FormEventManager_FormClosed;
            }
        }

        protected virtual void FormEventManager_FormOpened(string formName)
        {
            // Handle the opening of forms
            if (this.Name == formName)
            {
                //Console.WriteLine("Form opened: " + formName);
                StringBuilder sb = new StringBuilder();
                sb.Append("Se abrio ");
                sb.Append(formName);
                File.WriteAllText("movements,txt",sb.ToString());
            }
        }

        protected virtual void FormEventManager_FormClosed(string formName)
        {
            // Handle the closing of forms
            if (this.Name == formName)
            {
                //Console.WriteLine("Form closed: " + formName);
                StringBuilder sb = new StringBuilder();
                sb.Append("Se Cerro ");
                sb.Append(formName);
                File.WriteAllText("movements,txt", sb.ToString());
            }
        }
    }
}
