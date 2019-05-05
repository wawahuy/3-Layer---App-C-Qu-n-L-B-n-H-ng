using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bunifu.Framework.UI;

namespace App_QLBan_Hang.YuhUserControl
{
    public partial class UC_MenuOne : UserControl
    {
        public UC_MenuOne()
        {
            ui_items = new List<BunifuFlatButton>();

            yuhBackColorActive = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            YuhBackColorIdel = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            yuhBackColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            yuhTextColorHover = System.Drawing.Color.White;
            yuhTextColorIdel = System.Drawing.Color.White;
            yuhAlignText = System.Drawing.ContentAlignment.MiddleLeft;
            yuhFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            InitializeComponent();
        }


        /// <summary>
        /// Call clicked with pos old
        /// </summary>
        public void ReferActionClicked()
        {
            YuhSelectedItem = posSelectedItem;
        }


        /// <summary>
        /// Pos selected
        /// </summary>
        int posSelectedItem = -1;
        public int YuhSelectedItem {
            get{ return posSelectedItem; }
            set {
                if (value > -1 && value < ui_items.Count)
                    clickItem(ui_items[value], null);
                else
                    posSelectedItem = value;
            }
        }


        /// <summary>
        /// Event Selected
        /// </summary>
        public event EventHandler YuhSelect;
        private BunifuFlatButton uiitemSelectd;

        private void clickItem(object obj, EventArgs args)
        {
            int pos = ui_items.IndexOf(obj as BunifuFlatButton);
            posSelectedItem = pos;

            ///Change color old
            if (uiitemSelectd != null)
            {
                uiitemSelectd.BackColor = uiitemSelectd.Normalcolor = yuhBackColorIdel;
                uiitemSelectd.Textcolor = uiitemSelectd.ForeColor = yuhTextColorIdel;
                uiitemSelectd.OnHovercolor = yuhBackColorHover;
                uiitemSelectd.OnHoverTextColor = yuhTextColorHover;
                uiitemSelectd.Activecolor = yuhBackColorActive;
            }
            
            ///Change color new
            BunifuFlatButton uiitem = ui_items[pos];
            uiitem.BackColor = uiitem.Normalcolor = uiitem.OnHovercolor = yuhBackColorActive;
            uiitem.Textcolor = uiitem.ForeColor = yuhTextColorHover;
            uiitemSelectd = uiitem;

            ///Call event
            Object objselect = items[pos] as Object;
            if(YuhSelect!=null) YuhSelect.Invoke(objselect, args);
            items[pos].OnSelect(objselect, args);
        }


        /// <summary>
        /// COLOR STATE
        /// </summary> 

        private Color yuhBackColorIdel;
        private Color yuhBackColorHover;
        private Color yuhBackColorActive;
        private Color yuhTextColorIdel;
        private Color yuhTextColorHover;


        public Color YuhBackColorIdel
        {
            get
            {
                return yuhBackColorIdel;
            }

            set
            {
                yuhBackColorIdel = value;
                RunActionAll((BunifuFlatButton item) => {
                    item.BackColor = value;
                    item.Normalcolor = value;
                    });
            }
        }

        public Color YuhBackColorHover
        {
            get
            {
                return yuhBackColorHover;
            }

            set
            {
                yuhBackColorHover = value;
                RunActionAll((BunifuFlatButton item) => item.OnHovercolor = value);
            }
        }

        public Color YuhBackColorActive
        {
            get
            {
                return yuhBackColorActive;
            }

            set
            {
                yuhBackColorActive = value;
                RunActionAll((BunifuFlatButton item) => item.Activecolor = value);
            }
        }

        public Color YuhTextColorIdel
        {
            get
            {
                return yuhTextColorIdel;
            }

            set
            {
                yuhTextColorIdel = value;
                RunActionAll((BunifuFlatButton item) => item.Textcolor = value);
            }
        }

        public Color YuhTextColorHover
        {
            get
            {
                return yuhTextColorHover;
            }

            set
            {
                yuhTextColorHover = value;
                RunActionAll((BunifuFlatButton item) => item.OnHoverTextColor = value);
            }
        }


        /// <summary>
        /// Align & Font
        /// </summary>
        private Font yuhFont;
        private ContentAlignment yuhAlignText;

        public Font YuhFont
        {
            get
            {
                return yuhFont;
            }

            set
            {
                yuhFont = value;
                RunActionAll((BunifuFlatButton item) => item.TextFont = value);
            }
        }

        public ContentAlignment YuhAlignText
        {
            get
            {
                return yuhAlignText;
            }

            set
            {
                yuhAlignText = value;
                RunActionAll((BunifuFlatButton item) => item.TextAlign = value);
            }
        }


        /// <summary>
        /// ITEM ARRAY SELECT
        /// </summary>
        private MenuItem[] items;
        public MenuItem[] YuhItems
        {
            get { return items; }
            set {
                SetItems(value);
            }
        }

        private void SetItems(MenuItem[] its)
        {
            items = its;
            int numstr = items.Length;

            foreach (var item in ui_items) Controls.Remove(item);
            ui_items.Clear();

            for (int i = 0; i < numstr; i++)
            {
                BunifuFlatButton bt = new BunifuFlatButton();
                CreateItem(bt, items[i], "child" + i);
                ui_items.Add(bt);
            }

            for (int i = numstr - 1; i >= 0; i--)
                Controls.Add(ui_items[i]);
        }


        private Bunifu.Framework.UI.BunifuFlatButton CreateItem(BunifuFlatButton item, MenuItem mits, string nameid)
        {
            item.Activecolor = yuhBackColorActive;
            item.BackColor = yuhBackColorIdel;
            item.Normalcolor = yuhBackColorIdel;
            item.OnHovercolor = yuhBackColorHover;
            item.OnHoverTextColor = yuhTextColorHover;
            item.TextAlign = yuhAlignText;
            item.Textcolor = yuhTextColorIdel;
            item.TextFont = yuhFont;

            item.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            item.BorderRadius = 0;
            item.ButtonText = mits.Text;
            item.Cursor = System.Windows.Forms.Cursors.Hand;
            item.DisabledColor = System.Drawing.Color.Gray;
            item.Dock = System.Windows.Forms.DockStyle.Top;
            item.Iconcolor = System.Drawing.Color.Transparent;
            item.Iconimage = mits.Icon;
            item.Iconimage_right = null;
            item.Iconimage_right_Selected = null;
            item.Iconimage_Selected = null;
            item.IconMarginLeft = mits.IconMarginLeft;
            item.IconMarginRight = mits.IconMarginRight;
            item.IconRightVisible = true;
            item.IconRightZoom = 0D;
            item.IconVisible = mits.IconVisible;
            item.IconZoom = mits.IconZoom;
            item.IsTab = false;
            item.Location = new System.Drawing.Point(0, 0);
            item.Name = nameid;
            item.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            item.RightToLeft = System.Windows.Forms.RightToLeft.No;
            item.selected = false;
            item.Size = new System.Drawing.Size(187, 44);
            item.TabIndex = 0;
            item.Text = mits.Text;
            item.Click += new EventHandler(clickItem);
            return item;
        }


        private void RunActionAll(Action<BunifuFlatButton> action)
        {
            foreach (var item in ui_items) action(item);
        }

        /// <summary>
        /// Menu Item
        /// </summary>
        public class MenuItem
        {
            String name;
            String text;
            Image icon;
            bool iconVisible;
            int iconMarginRight;
            int iconMarginLeft;
            double iconZoom = 90D;

            public event EventHandler YuhSelect;

            public void OnSelect(Object obj, EventArgs args)
            {
                if(YuhSelect != null) YuhSelect.Invoke(obj, args);
            }

            public string Text
            {
                get
                {
                    return text;
                }

                set
                {
                    text = value;
                }
            }

            public Image Icon
            {
                get
                {
                    return icon;
                }

                set
                {
                    icon = value;
                }
            }

            public bool IconVisible
            {
                get
                {
                    return iconVisible;
                }

                set
                {
                    iconVisible = value;
                }
            }

            public int IconMarginRight
            {
                get
                {
                    return iconMarginRight;
                }

                set
                {
                    iconMarginRight = value;
                }
            }

            public int IconMarginLeft
            {
                get
                {
                    return iconMarginLeft;
                }

                set
                {
                    iconMarginLeft = value;
                }
            }

            public double IconZoom
            {
                get
                {
                    return iconZoom;
                }

                set
                {
                    iconZoom = value;
                }
            }

            public string Name
            {
                get
                {
                    return name;
                }

                set
                {
                    name = value;
                }
            }

            public MenuItem()
            {
            }
        }
    }
}
