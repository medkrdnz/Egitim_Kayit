using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EgitimKayitLib
{
    public class IsBirimi
    {
        public List<Ders> Dersler { get; set; }
        public List<Sube> Subeler { get; set; }
        public List<Ogretmen> Ogretmenler { get; set; }
        public List<Ogrenci> Ogrenciler { get; set; }
        public List<Egitim> Egitimler { get; set; }

        public IsBirimi()
        {
            Dersler = new List<Ders>();
            Subeler = new List<Sube>();
            Ogretmenler = new List<Ogretmen>();
            Ogrenciler = new List<Ogrenci>();
            Egitimler = new List<Egitim>();

        }
        public void OgrenciEkle(string ogrenciAdi, string ogrenciSoyadi, string telefon, string email)
        {
            Ogrenci yeniOgrenci = new Ogrenci(ogrenciAdi, ogrenciSoyadi, telefon, email);
            Ogrenciler.Add(yeniOgrenci);
            var connectionString= @"Server = SERDARPC\SQLEXPRESS; Database = Dershane; Integrated Security = true; ";
            var commandText = "INSERT INTO Ogrenci(Id,Adi,Soyadi,Telefon,Email) " +
                "VALUES('" + yeniOgrenci.Id + "','" + yeniOgrenci.OgrenciAdi + "','" + yeniOgrenci.OgrenciSoyadi + "'," +
                "'" + yeniOgrenci.Telefon + "','" + yeniOgrenci.Email + "')";
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            SqlCommand command = new SqlCommand(commandText, con);
            command.ExecuteNonQuery();
            con.Close();
        }

        public void OgrenciDuzenle(string id, string ogrenciAdi, string ogrenciSoyadi, string telefon, string email)
        {
            var duzenlenecekOgrenci = Ogrenciler.SingleOrDefault(x => x.Id == id);
            duzenlenecekOgrenci.OgrenciAdi = ogrenciAdi;
            duzenlenecekOgrenci.OgrenciSoyadi = ogrenciSoyadi;
            duzenlenecekOgrenci.Telefon = telefon;
            duzenlenecekOgrenci.Email = email;
            var connectionString = @"Server=SERDARPC\SQLEXPRESS;Database=Dershane;Integrated Security=true;";
            var commandText = string.Format("UPDATE Ogrenci SET Adi=@Adi,Soyadi=@Soyadi,Telefon=@Telefon,Email=@Email WHERE Id=@Id");        
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            SqlCommand command = new SqlCommand(commandText, con);
            command.Parameters.AddWithValue("@Adi", duzenlenecekOgrenci.OgrenciAdi);
            command.Parameters.AddWithValue("@Soyadi", duzenlenecekOgrenci.OgrenciSoyadi);
            command.Parameters.AddWithValue("@Telefon", duzenlenecekOgrenci.Telefon);
            command.Parameters.AddWithValue("@Email", duzenlenecekOgrenci.Email);
            command.Parameters.AddWithValue("@Id", duzenlenecekOgrenci.Id);
            command.ExecuteNonQuery();
            con.Close();
        }

        public List<Ogrenci> OgrenciGetir()
        {
            Ogrenciler.Clear();
            var connectionString = @"Server=SERDARPC\SQLEXPRESS;Database=Dershane;Integrated Security=true;";
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            SqlCommand command = new SqlCommand("SELECT * FROM Ogrenci", con);
            SqlDataReader reader = command.ExecuteReader();
            while(reader.Read())
            {
                Ogrenci ogrenci = new Ogrenci(reader.GetGuid(0).ToString(),reader.GetString(1),
                    reader.GetString(2),reader.GetString(3),reader.GetString(4));
                Ogrenciler.Add(ogrenci);
            }
            con.Close();
            return Ogrenciler;
        }

        public void SubeEkle(string subeAdi)
        {
            Sube sube = new Sube(subeAdi);
            Subeler.Add(sube);
            var connectionString = @"Server=SERDARPC\SQLEXPRESS;Database=Dershane;Integrated Security=true;";
            var commandtext = "INSERT INTO Sube(Id,Adi) VALUES('" + sube.Id + "','" + sube.SubeAdi + "')";
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            SqlCommand command = new SqlCommand(commandtext, con);
            command.ExecuteNonQuery();
            con.Close();
        }

        public void SubeDuzenle(string id, string subeAdi)
        {
            var duzenlenecekSube = Subeler.SingleOrDefault(x => x.Id == id);
            duzenlenecekSube.SubeAdi = subeAdi;
            var connectionString = @"Server=SERDARPC\SQLEXPRESS;Database=Dershane;Integrated Security=true;";
            var commandText = string.Format("UPDATE Sube SET Adi=@Adi WHERE Id=@Id");
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            SqlCommand command = new SqlCommand(commandText, con);
            command.Parameters.AddWithValue("@Adi", duzenlenecekSube.SubeAdi);
            command.Parameters.AddWithValue("@Id", duzenlenecekSube.Id);
            command.ExecuteNonQuery();
            con.Close();
        }

        public List<Sube> SubeGetir()
        {
            Subeler.Clear();
            var connectionString = @"Server=SERDARPC\SQLEXPRESS;Database=Dershane;Integrated Security=true;";
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            SqlCommand command = new SqlCommand("SELECT * FROM Sube", con);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                Sube sube = new Sube(reader.GetGuid(0).ToString(), reader.GetString(1));
                Subeler.Add(sube);
            }
            con.Close();
            return Subeler;
        }

        public void DersEkle(string dersAdi)
        {
            Ders ders = new Ders(dersAdi);
            Dersler.Add(ders);
            var connectionString = @"Server=SERDARPC\SQLEXPRESS;Database=Dershane;Integrated Security=true;";
            var commandtext = "INSERT INTO Ders(Id,Adi) VALUES('" + ders.Id + "','" + ders.DersAdi + "')";
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            SqlCommand command = new SqlCommand(commandtext, con);
            command.ExecuteNonQuery();
            con.Close();
        }

        public void DersDuzenle(string id, string dersAdi)
        {
            var duzenlenecekDers = Dersler.SingleOrDefault(x => x.Id == id);
            duzenlenecekDers.DersAdi = dersAdi;
            var connectionString = @"Server=SERDARPC\SQLEXPRESS;Database=Dershane;Integrated Security=true;";
            var commandText = string.Format("UPDATE Ders SET Adi='{0}' WHERE Id='{1}'", duzenlenecekDers.DersAdi, duzenlenecekDers.Id);
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            SqlCommand command = new SqlCommand(commandText,con);
            command.ExecuteNonQuery();
            con.Close();
        }

        public List<Ders> DersGetir()
        {
            Dersler.Clear();
            var connectionString = @"Server=SERDARPC\SQLEXPRESS;Database=Dershane;Integrated Security=true;";
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            SqlCommand command = new SqlCommand("SELECT * FROM Ders", con);
            SqlDataReader reader = command.ExecuteReader();
            while(reader.Read())
            {
                Ders ders = new Ders(reader.GetGuid(0).ToString(), reader.GetString(1));
                Dersler.Add(ders);
            }
            con.Close();
            return Dersler;
        }

        public void OgretmenEkle(string ogretmenAdi)
        {
            Ogretmen ogretmen = new Ogretmen(ogretmenAdi);
            Ogretmenler.Add(ogretmen);
            var connectionString = @"Server=SERDARPC\SQLEXPRESS;Database=Dershane;Integrated Security=true;";
            var commandtext = "INSERT INTO Ogretmen(Id,Adi) VALUES('" + ogretmen.Id + "','" + ogretmen.OgretmenAdi + "')";
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            SqlCommand command = new SqlCommand(commandtext, con);
            command.ExecuteNonQuery();
            con.Close();
        }

        public void OgretmenDuzenle(string id, string ogretmenAdi)
        {
            var duzenlenecekOgretmen = Ogretmenler.SingleOrDefault(x => x.Id == id);
            duzenlenecekOgretmen.OgretmenAdi = ogretmenAdi;
            var connectionString = @"Server=SERDARPC\SQLEXPRESS;Database=Dershane;Integrated Security=true;";
            var commandText = string.Format("UPDATE Ogretmen SET Adi='{0}' WHERE Id='{1}'", duzenlenecekOgretmen.OgretmenAdi, duzenlenecekOgretmen.Id);
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            SqlCommand command = new SqlCommand(commandText, con);
            command.ExecuteNonQuery();
            con.Close();
        }

        public List<Ogretmen> OgretmenGetir()
        {
            Ogretmenler.Clear();
            var connectionString = @"Server=SERDARPC\SQLEXPRESS;Database=Dershane;Integrated Security=true;";
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            SqlCommand command = new SqlCommand("SELECT * FROM Ogretmen", con);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                Ogretmen ogretmen = new Ogretmen(reader.GetGuid(0).ToString(), reader.GetString(1));
                Ogretmenler.Add(ogretmen);
            }
            con.Close();
            return Ogretmenler;
        }

        public void EgitimEkle(string dersId, string ogretmenId, string subeId)
        {
            var eklenecekDers = Dersler.SingleOrDefault(arananDers => arananDers.Id == dersId);
            var eklenecekOgretmen = Ogretmenler.SingleOrDefault(arananOgretmen => arananOgretmen.Id == ogretmenId);
            var eklenecekSube = Subeler.SingleOrDefault(arananSube => arananSube.Id == subeId);
            Egitim yeniEgitim = new Egitim(eklenecekDers, eklenecekOgretmen, eklenecekSube);

        }


        //SingleOrDefault Metodunun çalışma mantığı
        //public Ogrenci MySıngleOrDefault(int id)
        //{
        //    foreach (var item in Ogrenciler)
        //    {
        //        if (item.Id == id)
        //        {
        //            return item;
        //        }

        //    }
        //    return default(Ogrenci);
        //}
    }

}
