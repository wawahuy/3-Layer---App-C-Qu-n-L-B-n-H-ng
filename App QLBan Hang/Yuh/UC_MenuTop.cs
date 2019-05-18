using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App_QLBan_Hang.Yuh
{
    public partial class UC_MenuTop : UserControl
    {
        private UC_MenuTopChild[] yuhitems;
        private Font yuhfont;

        public event EventHandler YuhClick;

        public UC_MenuTopChild[] Yuhitems
        {
            get
            {
                return yuhitems;
            }

            set
            {
                int i = 2;
                int y = 20;
                yuhitems = value;
                if(yuhitems != null)
                    yuhitems.All(item =>
                    {
                        this.panel1.Controls.Add(item.linklabel);

                        item.linklabel.TabIndex = i++;
                        item.linklabel.Location = new System.Drawing.Point(y, 26);
                        item.linklabel.Font = yuhfont;
                        item.linklabel.BringToFront();
                        item.linklabel.Click += (object sender, EventArgs args) =>
                        {
                            if (!item.Enable) return;

                            yuhitems.All(item2 =>
                            {
                                item2.linklabel.LinkColor = item2.Coloridel;
                                return true;
                            });

                            ((LinkLabel)sender).LinkColor = item.Colorselected;

                            if(YuhClick != null)
                                YuhClick(item, null);
                        };

                        y += item.linklabel.Size.Width + 50;
                        return true;
                    });
                
            }
        }


        public void click(int index)
        {
            yuhitems.All(item2 =>
            {
                item2.linklabel.LinkColor = item2.Coloridel;
                return true;
            });

            Yuhitems[index].linklabel.LinkColor = Yuhitems[index].Colorselected;

            if (YuhClick != null)
                YuhClick(Yuhitems[index], null);
        }


        public Font Yuhfont
        {
            get
            {
                return yuhfont;
            }

            set
            {
                yuhfont = value;
                if(yuhitems != null)
                yuhitems.All(item =>
                {
                    item.linklabel.Font = yuhfont;
                    return true;
                });
            }
        }

        public UC_MenuTop()
        {
            InitializeComponent();

           
        }


        public class UC_MenuTopChild
        {
            private String text;
            public event EventHandler click;
            private bool enable;
            public System.Windows.Forms.LinkLabel linklabel;
            private Color coloridel;
            private Color colorselected;


            public UC_MenuTopChild()
            {
                this.linklabel = new LinkLabel();
                this.linklabel.AutoSize = true;
                this.linklabel.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
                this.linklabel.Name = "linklabel";
                //this.linklabel.Size = new System.Drawing.Size(108, 16);
                this.linklabel.TabStop = true;

                Coloridel = Color.DimGray;
                Colorselected = Color.ForestGreen;
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
                    this.linklabel.Text = text;
                }
            }

            public bool Enable
            {
                get
                {
                    return enable;
                }

                set
                {
                    enable = value;
                    //this.linklabel.Enabled = enable;
                }
            }

            //public LinkLabel Linklabel
            //{
            //    get
            //    {
            //        return linklabel;
            //    }

            //    set
            //    {
            //        linklabel = value;
            //    }
            //}

            public Color Coloridel
            {
                get
                {
                    return coloridel;
                }

                set
                {
                    coloridel = value;
                    this.linklabel.LinkColor = value;
                }
            }

            public Color Colorselected
            {
                get
                {
                    return colorselected;
                }

                set
                {
                    colorselected = value;
                    this.linklabel.ActiveLinkColor = value;
                }
            }
        }

    }
}
