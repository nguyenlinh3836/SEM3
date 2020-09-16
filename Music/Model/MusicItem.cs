using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Music.Model
{
    public class MusicItem
    {
        public int Id { get; set; }
        
        public string Image { get; set; }

        public string Category { get; set;}

        public string Title { get; set; }

        public string Artist { get; set; }
    }
    public class MusicManager
    {
        public static void GetMusics(string category, ObservableCollection<MusicItem> musicItems)
        {
            var allItems = getMusicItems();

            var filteredMusicItems = allItems.Where(p => p.Category == category).ToList();

            musicItems.Clear();

            filteredMusicItems.ForEach(p => musicItems.Add(p));
        }

        private static List<MusicItem> getMusicItems()
        {
            var items = new List<MusicItem>();

            items.Add(new MusicItem() { Id = 1, Category = "POP", Title = "HAVANA", Artist = "Camila Cabello", Image = "Assets/havana.jpg" });
            items.Add(new MusicItem() { Id = 2, Category = "POP", Title = "VORACITY", Artist = "Myth & Roid", Image = "Assets/voracity.jpg" });
            items.Add(new MusicItem() { Id = 3, Category = "POP", Title = "PARALAXIUM", Artist = "Myth & Roid", Image = "Assets/PARALOXIUM.jpg" });

            items.Add(new MusicItem() { Id = 4, Category = "RAP", Title = "OK", Artist = "Binz", Image = "Assets/ok.jpg" });
            items.Add(new MusicItem() { Id = 5, Category = "RAP", Title = "BigCityBoy", Artist = "Binz", Image = "Assets/bigcity.jpg" });
            return items;
        }
    }

 }
