using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CBMM.APP._360.Model;
using CBMM.APP._360.Pages;

namespace CBMM.APP._360.Services
{
    public class ItemService
    {
        private static ObservableCollection<MasterPageItem> menuLista { get; set; }

        public static ObservableCollection<MasterPageItem> GetMenuItens()
        {
            menuLista = new ObservableCollection<MasterPageItem>();
            // Criando as paginas para navegação
            // Definimos o titulo para o item
            // o icone do lado esquerdo e a pagina que vamos abrir
            var pagina1 = new MasterPageItem() { Title = "Pagina inicial", Icon = "icon_homepage.png", TargetType = typeof(HomePage) };
            var pagina2 = new MasterPageItem() { Title = "Videos 360º", Icon = "icon_video.png", TargetType = typeof(Videos) };
            var pagina3 = new MasterPageItem() { Title = "Fotos 360º", Icon = "icon_foto.png", TargetType = typeof(Fotos) };
          
            // Adicionando items no menuLista
            menuLista.Add(pagina1);
            menuLista.Add(pagina2);
            menuLista.Add(pagina3);
            
            //retorna a lista de itens */
            return menuLista;
        }
    }
}
