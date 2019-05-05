using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Shared;
using System.Threading;

namespace App_QLBan_Hang.UCGuest
{
    public partial class GTConfig : UserControl
    {
        /// <summary>
        /// Các lựa chọn trong phần "Loại cấu hình"
        /// </summary>
        private const string TYPE_CONFIG_AUTO   = "Auto";
        private const string TYPE_CONFIG_CUSTOM = "Custom";

        /// <summary>
        /// Các lựa chọn trong phần "bảo mật"
        /// </summary>
        private const string TYPE_AUTH_WINDOW   = "Windows Authentication";
        private const string TYPE_AUTH_SQL      = "SQL Server Authentication";


        private BUS.BUSSql busSql;

        public GTConfig()
        {
            InitializeComponent();
            
            // Init object
            busSql = new BUS.BUSSql();

        }

        /// <summary>
        /// Khởi tạo các giá trị lựa chọn, và các thông tin mà người dùng đã lưu trước đó
        /// </summary>
        private void Init()
        {
            dd_typeconfig.Items = new string[] { TYPE_CONFIG_AUTO, TYPE_CONFIG_CUSTOM };
            dd_auth.Items = new string[] { TYPE_AUTH_WINDOW, TYPE_AUTH_SQL };
            dd_typeconfig.selectedIndex = 0;
            dd_auth.selectedIndex = 0;
            UpdateControlsWithDeltailGlobal();
            //LoadDatbaseWithHostName();
        }

        private void UpdateControlsWithDeltailGlobal()
        {
            DTO.DTOSql deltail = busSql.GetSqlDeltail();
            dd_typeconfig.selectedIndex = deltail.Server == "localhost" ? 0 : 1;
            cb_db.Text = deltail.DB;
            cb_server.Text = deltail.Server;
            dd_auth.selectedIndex = deltail.AuthWin ? 0 : 1;
            txb_user.Text = deltail.User;
            txb_password.Text = deltail.Pass;
            UpdateControlsWithAuthention();
        }

        private void UpdateControlsWithAuthention()
        {
            bool enable = dd_auth.selectedValue == TYPE_AUTH_SQL;
            txb_user.Enabled = txb_password.Enabled = enable;
            if (enable)
            {
                txb_user.BackColor = txb_password.BackColor = System.Drawing.Color.FromArgb(250, 250, 250);
            }
            else
            {
                txb_user.BackColor = txb_password.BackColor = System.Drawing.Color.FromArgb(158, 158, 158);
            }
        }

        private void LoadDatbaseWithHostName()
        {
            if (cb_server.Text != "localhost") return;

            new SSequence(this)
                .Then(() =>
                {
                    FGuest.showWaiting(true);
                    List<string> dbs = busSql.GetListDatabaseNameLocal();
                    cb_db.Items.Clear();
                    dbs.ForEach((string name) => cb_db.Items.Add(name));
                }
                )
                .callTimeout(500, () => FGuest.showWaiting(false))
                .Start();
        }

        /// <summary>
        /// Khi người dùng thay đổi cách cấu hình
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dd_typeconfig_onItemSelected(object sender, EventArgs e)
        {
            if (dd_typeconfig.selectedValue == TYPE_CONFIG_AUTO)
            {
                cb_server.Text = "localhost";
                cb_server.Enabled = false;
                LoadDatbaseWithHostName();
            }
            else
            {
                cb_server.Enabled = true;
                cb_server.Text = "";
            }
        }

        /// <summary>
        /// Khi người dùng thay đổi phương thức xác thực (Đăng nhập vào sql)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dd_auth_onItemSelected(object sender, EventArgs e)
        {
            UpdateControlsWithAuthention();
        }


        /// <summary>
        /// Khi người dùng click cấu hình
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_config_Click(object sender, EventArgs e)
        {
            DTO.DTOSql sqlDeltail = new DTO.DTOSql();
            sqlDeltail.AuthWin = dd_auth.selectedValue != TYPE_AUTH_SQL;
            sqlDeltail.Server = cb_server.Text;
            sqlDeltail.DB = cb_db.Text;
            sqlDeltail.User = txb_user.Text;
            sqlDeltail.Pass = txb_password.Text;

            SInvokeEvent cb = new SInvokeEvent(this);
            cb.Wait = (obj) =>
            {
                FGuest.showWaiting(true);
            };

            cb.Error = (obj) =>
            {
                SFunction.SetTimeOut(
                        () => {
                            Invoke((Action)(() => FGuest.showWaiting(false)));
                            MessageBox.Show("Cấu hình bị lỗi!");
                        }
                        , 500);
            };

            cb.Success = (obj) =>
            {
                SFunction.SetTimeOut(
                        () => {
                            Invoke((Action)(() => FGuest.showWaiting(false)));
                            MessageBox.Show("Cấu hình thành công!");
                        }
                        , 500);
            };

            busSql.Config(sqlDeltail, cb);
        }



        /// <summary>
        /// Import các table vào csdl
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lbl_create_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
        }


        /// <summary>
        /// Khi user control này được load
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GTConfig_Load(object sender, EventArgs e)
        {
            // Init Control
            Init();
        }
    }
}
