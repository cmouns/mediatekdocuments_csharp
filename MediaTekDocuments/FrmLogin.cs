using MediaTekDocuments.view;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MediaTekDocuments.model;
using MediaTekDocuments.controller;

namespace MediaTekDocuments
{
    public partial class FrmLogin : Form
    {
        private readonly FrmMediatekController controller;
        public FrmLogin()
        {
            InitializeComponent();
            this.controller = new FrmMediatekController();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txbLogin.Text != "" && txbPwd.Text != "")
            {
                Utilisateur user = controller.GetUtilisateur(txbLogin.Text, txbPwd.Text);

                if (user != null)
                {
                    if (user.Service == "Culture")
                    {
                        MessageBox.Show("Les droits ne sont pas suffisants pour accéder à cette application.");
                        Application.Exit();
                    }
                    else
                    {
                        FrmMediatek frmMediatek = new FrmMediatek(user);
                        frmMediatek.Show();
                        this.Hide(); 
                    }
                }
                else
                {
                    MessageBox.Show("Identifiants incorrects.");
                }
            }
        }
    }
}
