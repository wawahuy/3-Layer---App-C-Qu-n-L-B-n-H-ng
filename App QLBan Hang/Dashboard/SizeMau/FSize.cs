using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App_QLBan_Hang.Dashboard.SizeMau
{
    public partial class FSize : FTemplate
    {
        public FSize()
        {
            InitializeComponent();

        }


        public FSize(DTO.DTOKichCo kichcochon)
        {
            InitializeComponent();
            uC_KichCo1.setWindowSelectItem((object obj) =>
            {
                DTO.DTOKichCo mau = (DTO.DTOKichCo)obj;
                kichcochon.Ma = mau.Ma;
                kichcochon.Ten = mau.Ten;
                this.Close();
            });
        }
    }
}
