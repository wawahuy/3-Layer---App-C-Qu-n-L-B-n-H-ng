using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shared
{
    public class SSequence
    {
        private Thread       m_thread;
        private List<Action> m_stmt;
        private Control      m_control;

        public SSequence(Control control) : this()
        {
            m_control = control;
        }

        public SSequence()
        {
            m_thread = new Thread(Run);
            m_stmt = new List<Action>();
        }

        public void Start()
        {
            m_thread.Start();
        }

        private void Run()
        {
            foreach (Action action in m_stmt)
            {
                if (m_control != null && m_control.InvokeRequired)
                {
                    m_control.Invoke((Action)(() =>
                    {
                        action();
                    }));
                }
                else
                    action();
                Thread.Sleep(10);
            }
        }

        public SSequence Then(Action action)
        {
            m_stmt.Add(action);
            return this;
        }

        public SSequence callTimeout(int mili, Action call)
        {
            return Then(
                () => 
                SFunction.SetTimeOut(
                    ()=> {
                        if (m_control != null && m_control.InvokeRequired)
                        {
                            m_control.Invoke((Action)(() =>
                            {
                                call();
                            }));
                        }
                        else
                            call();
                    }, 
                    mili)
                    );
        }
        
    }
}
