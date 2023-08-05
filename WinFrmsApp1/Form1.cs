using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFrmsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        /// <summary>
        /// Event `Form1_Load`
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {
            List<string> form1_Load = new List<string>();
            form1_Load.Add("Row1");
            form1_Load.Add("Row2");
            form1_Load.Add("Row3");
        }

        /// <summary>
        /// Button `button1_Click`
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            List<string> ls_button1 = new List<string>();
            ls_button1.Add("Row1");
            ls_button1.Add("Row2");
            ls_button1.Add("Row3");
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }


        /// <summary>
        /// Тег summary: Method1
        /// </summary> 
        /// <code source="..\Form1.cs" 
        /// region="MyRegion" 
        /// language="cs"
        /// title="MyRegion" />
        private void Method1()
        {
            #region MyRegion            
            List<string> ls_button1 = new List<string>();
            ls_button1.Add("Item1");
            ls_button1.Add("Item2");
            ls_button1.Add("Item3");
            #endregion
        }

        /// <summary>
        /// Тег summary: Method1
        /// </summary> 
        /// <code source="..\Form1.cs"         
        /// language="cs"
        /// title="MyRegion" />
        private void Method2()
        {
            #region MyRegion            
            List<string> ls_button1 = new List<string>();
            ls_button1.Add("Item1");
            ls_button1.Add("Item2");
            ls_button1.Add("Item3");
            #endregion
        }

    }
}
