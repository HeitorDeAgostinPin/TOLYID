using TOLYID.BANCO;
using Microsoft.Maui.Controls;
using System;
using System.Linq;

namespace TOLYID.BANCO
{
    public partial class MainPage : ContentPage
    {

        private  readonly AppDbContext contexto = new AppDbContext();
        public MainPage()
        {
           
            LoadItems();
        }

        private void OnAddButtonClicked(object sender, EventArgs e)
        {
            //var name = Tatu.Text; // Certifique-se de que "Tatu" é o nome correto do Entry no XAML
            
            //if (!string.IsNullOrEmpty(name))
            //{
            //    var tatuEntity = new Tatu();
            //    contexto.Tatus.Add(tatuEntity);
            //    contexto.SaveChanges();
            //    LoadItems();
            //    //Tatu.Text = string.Empty;  // Limpar o campo de entrada
            //}
        }

        private void LoadItems()
        {
            var items = contexto.Tatus.ToList();
           
        }
    }
}
