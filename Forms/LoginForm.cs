﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
namespace BlowerConfigUpdate
{
    public partial class LoginForm : Form
    {
        XmlNode users;
        string username;
        public LoginForm(XmlNode users)
        {
            InitializeComponent();
            this.users = users;
        }

        private void ButtonLogin_Click(object sender, EventArgs e)
        {
            string user = this.Field_User.Text;
            string pass = this.Field_Pass.Text;

            foreach(XmlNode x in this.users)
            {   
                if(x.Attributes[0].InnerText == user)
                {
                    if(x.Attributes[1].InnerText == pass)
                    {   

                        this.username = user;
                        this.Close();
                        break;
                       
                    }
                }

            }
        }

        private void ButtonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public string ShowForm()
        {
            
            var output = this.ShowDialog();
            
            return this.username;
        }


    }


}
