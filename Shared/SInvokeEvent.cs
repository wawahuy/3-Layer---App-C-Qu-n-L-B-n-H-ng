using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shared
{
    public class SInvokeEvent
    {
        public Control control;
        private SDelegate.CALLBACK1 wait;
        private SDelegate.CALLBACK1 error;
        private SDelegate.CALLBACK1 success;

        private SDelegate.CALLBACK1 invokeWait;
        private SDelegate.CALLBACK1 invokeError;
        private SDelegate.CALLBACK1 invokeSuccess;

        public SInvokeEvent(Control control)
        {
            this.control = control;
            invokeError = new SDelegate.CALLBACK1(cbError);
            invokeWait = new SDelegate.CALLBACK1(cbWait);
            invokeSuccess = new SDelegate.CALLBACK1(cbSuccess);
        }

        private void cbWait(object obj1)
        {
            control.Invoke(
                (Action)(() => {
                    wait(obj1);
                }));
        }

        private void cbError(object obj1)
        {
            control.Invoke(
                (Action)(() => {
                    error(obj1);
                }));
        }

        private void cbSuccess(object obj1)
        {
            control.Invoke(
                (Action)(() => {
                    success(obj1);
                }));
        }

        public Control Control
        {
            get
            {
                return control;
            }

            set
            {
                control = value;
            }
        }

        public SDelegate.CALLBACK1 Wait
        {
            get
            {
                return invokeWait;
            }

            set
            {
                wait = value;
            }
        }

        public SDelegate.CALLBACK1 Error
        {
            get
            {
                return invokeError;
            }

            set
            {
                error = value;
            }
        }

        public SDelegate.CALLBACK1 Success
        {
            get
            {
                return invokeSuccess;
            }

            set
            {
                success = value;
            }
        }
    }
}
