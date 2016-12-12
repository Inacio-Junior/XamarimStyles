using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;


namespace LandManager.Views
{
    public partial class viewLogin : ContentPage    
    {                
        public viewLogin()
        {            
            InitializeComponent();
            //Padrão MVVM
            //Atrela o code behind desta view a classe Login da pasta ViewsModel.            
            this.BindingContext = new ViewsModel.vmLogin();

            switchLogar.IsToggled = true;

        }

        private void SwitchLogar_OnToggled(object sender, ToggledEventArgs e)
        {
            if (e.Value == true)
            {
                lblCheck.Text = "Sim";
            }
            else
            {
                lblCheck.Text = "Não";
            }
        }
    }
}
