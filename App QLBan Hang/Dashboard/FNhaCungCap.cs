using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;

namespace App_QLBan_Hang.Dashboard
{
    public partial class FNhaCungCap : FTemplate
    {
        private static DTO.DTONhaCungCap ncc;
        private static FNhaCungCap current;

        public FNhaCungCap()
        {
            InitializeComponent();
            current = this;
            ncc = null;
        }

        public static DTONhaCungCap Ncc
        {
            get
            {
                return ncc;
            }

            set
            {
                ncc = value;
            }
        }

        public static FNhaCungCap Current
        {
            get
            {
                return current;
            }

            set
            {
                current = value;
            }
        }

        private void FNhaCungCap_FormClosing(object sender, FormClosingEventArgs e)
        {
            current = null;
        }
    }
}
