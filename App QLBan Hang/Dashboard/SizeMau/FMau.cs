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
    public partial class FMau : FTemplate
    {
        public FMau()
        {
            InitializeComponent();
            uC_Mau1.setWindowSelectItem((object obj) =>
            {
                DTO.DTOMau mau = (DTO.DTOMau)obj;

            });
        }


        public FMau(DTO.DTOMau mauchon)
        {
            InitializeComponent();
            uC_Mau1.setWindowSelectItem((object obj) =>
            {
                DTO.DTOMau mau = (DTO.DTOMau)obj;
                mauchon.Ma = mau.Ma;
                mauchon.Ten = mau.Ten;
                this.Close();
            });
        }
    }
}
