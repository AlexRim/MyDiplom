using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace MyDiplom
{
   public  delegate void Change (UserControl userControl1, UserControl userControl2);
   
    public partial class Form1 : Form
    {
        public UserControl1 userControl1;
        public UserControl2 userControl2;


        //метод переключающий контроллы, удаляющий текущи и добавляющий следующий
        public void ChangeUserControl(UserControl userControl1, UserControl userControl2)
        {
            if (userControl1 != null)
            {
                Controls.Remove(userControl1);
                userControl1.Dispose();
            }
            if (userControl2 != null)
            {
                Controls.Remove(userControl2);
                userControl2.Dispose();
            }





        }
     

        public Form1()
        {
            InitializeComponent();
        }

        private void клиентыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            //ChangeUserControl(userControl1,userControl2);
            Change change = ChangeUserControl;
            change(userControl1,userControl2);
            userControl1 =new UserControl1();
            this.Controls.Add(userControl1);
            userControl1.Top = 25;
            userControl1.Left = 0;

        }

        private void контрактыToolStripMenuItem_Click(object sender, EventArgs e)
        {
        
            //ChangeUserControl(userControl1, userControl2);
            Change change = ChangeUserControl;
            change(userControl1, userControl2);
            userControl2 =new UserControl2();
            this.Controls.Add(userControl2);
            userControl2.Top = 25;
            userControl2.Left = 0;

        }
    }
}
