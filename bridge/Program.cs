using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace bridge
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        
        
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }

    }
    public interface system
    {
        void payprocess(string Product, string Price);

    }
    //banks
    class MasrBank : system
    {
        public void payprocess(string Product, string Price)
        {
            File.AppendAllText("Masr.txt", "Name:" + Product + "   " + "Price:" + Price);
        }
    }
    class AlexBank : system
    {
        public void payprocess(string Product, string Price)
        {
            File.AppendAllText("Alex.txt", "Name:" + Product + "   " + "Price:" + Price);
        }
    }
    class Ahly : system
    {
        public void payprocess(string Product, string Price)
        {
            File.AppendAllText("AL Ahly.txt", "Name:" + Product + "   " + "Price:" + Price);
        }
    }

    //cardtype
    public abstract class payment
    {
        public system _system;
        public abstract void pay(string choice_Bank);
    }
    class Paybal : payment
    {

        public override void pay(string choice_Bank)
        {
            if (choice_Bank == "Masr")
            {
                File.AppendAllText("Masr.txt", "   " + "Visa:" + "paybal" + "\n");
            }
            else if (choice_Bank == "Alex")
            {
                File.AppendAllText("Alex.txt", "   " + "Visa:" + "paybal" + "\n");
            }
            else if (choice_Bank == "AL Ahly")
            {
                File.AppendAllText("AL Ahly.txt", "   " + "Visa:" + "paybal" + "\n");
            }
        }
    }
    class Misa : payment
    {
        public override void pay(string  choice_Bank)
        {
            if (choice_Bank == "Masr")
            {
                File.AppendAllText("Masr.txt", "   " + "Visa:" + "Misa" + "\n");
            }
            else if (choice_Bank == "Alex")
            {
                File.AppendAllText("Alex.txt", "   " + "Visa:" + "Misa" + "\n");
            }
            else if (choice_Bank == "AL Ahly")
            {
                File.AppendAllText("AL Ahly.txt", "   " + "Visa:" + "Misa" + "\n");
            }
        }
    }
}