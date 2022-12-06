using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ДЗ4
{
    public interface IStoreItem
    {
        double Price { get; set; }
        void DiscountPrice(int percent);
    }
    public class Disk : IStoreItem
    {
        private string _name;
        private string _genre;
        private int _burnCount;
        public Disk(string name, string genre)
        {
            Name = name;
            Genre = genre;
        }
        public virtual int DiskSize { get; set; }
        public double Price { get; set; }
        public int BurnCount { get => _burnCount; set => _burnCount = value; }
        public string Name { get => _name; set => _name = value; }
        public string Genre { get => _genre; set => _genre = value; }

        public virtual void Burn(params string[] values)
        {
            BurnCount++;
        }
        public void DiscountPrice(int percent)
        {
            Price *= percent / 100.0;
        }
    }

    public class Audio : Disk
    {
        private string _artist;
        private string _recordingStudio;
        private int _songsNumber;
        public Audio(string artist, string recordingStudio, int songsNumber, string name, string genre) : base(name, genre)
        {
            this.Artist = artist; 
            this.RecordingStudio = recordingStudio; 
            this.SongsNumber = songsNumber;
            
        }

       
        public override int DiskSize { get => _songsNumber * 8; set => base.DiskSize = value; }
        public string Artist { get => _artist; set => _artist = value; }
        public string RecordingStudio { get => _recordingStudio; set => _recordingStudio = value; }
        public int SongsNumber { get => _songsNumber; set => _songsNumber = value; }

        public override void Burn(params string[] values)
        {
            BurnCount++;
            Artist = values[0];
            RecordingStudio = values[1];
            SongsNumber = Convert.ToInt32(values[2]);
            Name = values[3];
            Genre = values[4];

        }

        public override string ToString()
        {
            string s = $"Название:\t{Name}\nЖанр:\t{Genre}\nИсполнитель:\t{Artist}\nСтудия звукозаписи:\t{RecordingStudio}\nКоличество песен:\t{SongsNumber}\nКоличество прожигов:\t{BurnCount}";
            return s;
        }
    }

    public class DVD : Disk
    {
        private string _producer;
        private string _filmCompany;
        private int _minutesCount;
        public DVD(string producer, string filmCompany, int minutesCount,string name, string genre) : base(name, genre)
        {
            this.Producer = producer;
            this.FilmCompany = filmCompany;
            this.MinutesCount = minutesCount;
        }

        public int MinutesCount { get => _minutesCount; set => _minutesCount = value; }
        public string FilmCompany { get => _filmCompany; set => _filmCompany = value; }
        public string Producer { get => _producer; set => _producer = value; }

        public override int DiskSize { get => (_minutesCount / 64) * 2; set => base.DiskSize = value; }

        public override void Burn(params string[] values)
        {
            BurnCount++;
            Producer= values[0];
            FilmCompany= values[1];
            MinutesCount = Convert.ToInt32(values[2]);
            Name = values[3];
            Genre= values[4];

        }
       
        public override string ToString()
        {
            string s = $"Название:\t{Name}\nЖанр:\t{Genre}\nРежиссер:\t{Producer}\nКинокомпания:\t{FilmCompany}\nКоличество минут:\t{MinutesCount}\nКоличество прожигов:\t{BurnCount}";
            return s;
        }
    }
    public class Store 
    {
        private string _storeName;
        private string _adress;
        private List<Audio> _audios= new List<Audio>();
        private List<DVD> _dvds = new List<DVD>();
        public Store(string name, string adress) 
        { 
            _storeName = name;
            _adress = adress;
        }

        public string StoreName { get => _storeName; set => _storeName = value; }
        public string Adress { get => _adress; set => _adress = value; }
        public List<Audio> Audios { get => _audios; set => _audios = value; }
        public List<DVD> Dvds { get => _dvds; set => _dvds = value; }

        public static Store operator +(Store a, DVD b) 
        {
            a.Dvds.Add(b);
            return a;
        }
        public static Store operator -(Store a, DVD b)
        {
            a.Dvds.Remove(b);
            return a;
        }
        public static Store operator *(Store a, Audio b) // Переопределил знак "*" так как не понял, как два раза переопределять "+"
        {
            a.Audios.Add(b);
            return a;
        }
        public static Store operator /(Store a, Audio b) // Переопределил знак "/" так как не понял, как два раза переопределять "-"
        {
            a.Audios.Remove(b);
            return a;
        }
        public override string ToString()
        {
            string s = "";
            for (int i = 0; i < Audios.Count(); i++)
            {
                s += Audios[i].ToString() + "\n\n\n";
            }
            for (int i = 0; i < Dvds.Count(); i++)
            {
                s += Dvds[i].ToString() + "\n\n\n";
            }
            return s;
        }
    }

}
