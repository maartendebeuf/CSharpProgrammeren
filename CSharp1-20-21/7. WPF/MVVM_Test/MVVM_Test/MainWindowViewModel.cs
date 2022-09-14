using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MVVM_Test.Database;
using MVVM_Test.Core;

namespace MVVM_Test
{
    public class MainWindowViewModel
    {
        public MainWindowViewModel()
        {
            OphalenAlbums();
        }

        public List<Album> Albums { get; set; }
        public Album SelectedAlbum { get; set; }
        private void OphalenAlbums()
        {
            using (var database = new ChinookEntities())
            {
                Albums = database.Album.ToList();
            }
        }

        public DelegateCommand CmdNieuw
        {
            get
            {
                return new DelegateCommand(NieuwAlbumAanmaken);
            }
        }
        public void NieuwAlbumAanmaken()
        {

        }
        public DelegateCommand CmdAanpassen
        {
            get
            {
                return new DelegateCommand(AlbumAanpassen); ;
            }
        }
        public void AlbumAanpassen()
        {
            if (SelectedAlbum != null)
            {
                if (SelectedAlbum.AlbumId == 0)
                {

                }
                using (var database = new ChinookEntities())
                {
                    // opvragen: x = item uit lijst. eerste (x)albumId gelijk aan de selected albumId
                    var dbAlbum = database.Album.FirstOrDefault(x => x.AlbumId == SelectedAlbum.AlbumId);
                    dbAlbum.Title = SelectedAlbum.Title;
                    database.SaveChanges();
                }
            }
        }
    }
}
