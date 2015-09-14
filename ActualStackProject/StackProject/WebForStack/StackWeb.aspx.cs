using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using StackImplementation;

namespace WebForStack
{
    public partial class StackWeb : System.Web.UI.Page
    {
        Stack Stack1;
        public StackWeb()
        {           
        }        
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Stack1 = new Stack();
                ViewState["Stack1"] = Stack1;
            }
        }

        protected void btnPush_Click(object sender, EventArgs e)
        {
            Stack1 =(Stack)ViewState["Stack1"];
            int? PushedItem = Stack1.Push(Convert.ToInt32(txtPush.Text));
            Response.Write(Stack1.Top);
            ViewState["Stack1"] = Stack1;
            txtPush.Text = string.Empty;
            //------------------------------------------
            
            lblDisplay.Text = "Pushed item is " + PushedItem.ToString();
        }

        protected void btnPop_Click(object sender, EventArgs e)
        {
            Stack1 = (Stack)ViewState["Stack1"];
            int? PoppedItem = Stack1.Pop();
            if (PoppedItem != null)
                lblDisplay.Text ="The Popped item is " + PoppedItem.ToString() + "<br/>" + "The top index is" + Stack1.Top;
            else
                lblDisplay.Text = "Stack is empty";
            //Response.Write(Stack1.Top);
            ViewState["Stack1"] = Stack1;
        }

        protected void btnViewAll_Click(object sender, EventArgs e)
        {
            Stack1 = (Stack)ViewState["Stack1"];
            string elements = "";
            foreach (int element in Stack1.GetAllElements())
                elements = elements + "[" + element + "]"  + " ";
 
            lblDisplay.Text = "The elements in the stack are " + elements; 
        }
    }
}