using DRrest.Model;

namespace DRrest.Repository
{
    public class MusicRepository
    {
        List<Music> musicList;

        public MusicRepository()
        {
            musicList = new List<Music>()
            {
                new Music() {Title="House of Rock", Artist="Elvis", Duration = 3, PublicationYear=1989},
                new Music() {Title="House of Pop", Artist="Michael", Duration = 4, PublicationYear=1990},
                new Music() {Title="House of Jazz", Artist="Awais", Duration = 5, PublicationYear=1991},
                new Music() {Title="House of Metal", Artist="Ibo", Duration = 6, PublicationYear=1992}
            };
        }
        public List<Music> GetMusicList()
        {
            return musicList;
        }
    }
}
