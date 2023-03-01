using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Abas
{
    public partial class MainPage : TabbedPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void btnProximo1_Clicked(object sender, EventArgs e)
        {
            CurrentPage = Children[1];
        }

        private void btnProximo2_Clicked(object sender, EventArgs e)
        {
            CurrentPage= Children[2];
        }

        private void btnAnterior2_Clicked(object sender, EventArgs e)
        {
            CurrentPage= Children[0];
        }

        private void btnAnterior3_Clicked(object sender, EventArgs e)
        {
            CurrentPage= Children[1];
        }
    }
}
