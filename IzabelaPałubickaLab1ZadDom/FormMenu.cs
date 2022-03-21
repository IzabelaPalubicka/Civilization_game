using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IzabelaPałubickaLab1ZadDom
{
    public partial class FormMenu : Form
    {
        /// <summary>
        /// zmienna przechowująca refernecje do nowego okna
        /// </summary>
        FormGame formGame;

        public FormMenu()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Funkcja tworząca nowe okno, zamyka bieżące
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonStart_Click(object sender, EventArgs e)
        {
            //utworzenie nowego obiektu okna FormNew
            formGame = new FormGame();
            //otworzenie okna obiektu formNew
            formGame.Show();
        }

        /// <summary>
        /// zamykanie bierzącego okna
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
