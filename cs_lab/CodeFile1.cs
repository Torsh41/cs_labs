// a module?


using System;
using System.Drawing;
using System.Windows.Forms;

namespace GUI_lab_1
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 10; i++)
            {
                are_you_ok(100);
            }

            // now time for the Form
            MyForm app = new MyForm();

        }


        private static void are_you_ok(int number) // the method
        {
            Random rnd = new Random();
            int rnd_number = rnd.Next(number * 2);
            if (rnd_number < number)
                Console.WriteLine("yes");
            else
                Console.WriteLine("no");
        }
    }

    public class MyForm
    {
        static MyForm() // the form
        {
            Form my_form = new Form();
            Button my_button = new Button();

            my_button.Text = "ok";
            my_button.Location = new Point(100, 100);
            my_form.AcceptButton = my_button;
            my_form.Controls.Add(my_button);

            my_form.Text = "GUI_lab_1";
            my_form.HelpButton = false;
            my_form.FormBorderStyle = FormBorderStyle.FixedDialog;
            my_form.StartPosition = FormStartPosition.CenterScreen;


            my_form.ShowDialog();
        }
    }
}




