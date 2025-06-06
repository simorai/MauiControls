

using System.Collections.ObjectModel;

namespace MauiControls.Models
{
    public class FotoViewModel
    {
        public ObservableCollection<Foto> fotos { get; set; }

        public ObservableCollection<Foto> Fotos
        {
            get { return fotos; }
            set { fotos = value; }
        }

        public FotoViewModel()
        {
            Fotos = new ObservableCollection<Foto>()
            {
                new Foto { Nome = "Galaxia 1", ImagemUrl = "galaxy1.jpg" },
                new Foto { Nome = "Galaxia 2", ImagemUrl = "galaxy2.jpg" },
                new Foto { Nome = "Galaxia 3", ImagemUrl = "galaxy3.jpg" },
                new Foto { Nome = "Galaxia 4", ImagemUrl = "galaxy4.jpg" },
                new Foto { Nome = "Galaxia 5", ImagemUrl = "galaxy5.jpg" }
            };
        }
    }
}
