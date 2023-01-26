using System.Collections.Generic;

namespace day3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ////string product = "botol";
            ////int price = 1000;
            ////Console.WriteLine("the price of {0} is {1}", product, price);
            ////Console.WriteLine("the price of {0, 8} is {1}", product, price);
            ////Console.WriteLine("{0,7} {1,-10}", "Product","Price");
            ////Console.WriteLine("{0,7} {1,-10:C}", product, price);
            //Dictionary<string, string> dic = new Dictionary<string, string>(); //string string
            ////diawal bisa diganti, bisa diganti juga pake set get
            //
            //
            //dic.Add("Peserta2", "Bajo");
            //dic.Add("Peserta3", "Bambang");
            //dic.Add("Peserta4", "Joko");
            //dic.Add("Peserta5", "Bajuri");

            ////dic["Peserta1"] = "Ahmadik"; //cara mengganti value di dictionary

            //foreach (string key in dic.Keys)
            //{
            //    Console.WriteLine($"{key} : {dic[key]}");
            //}

            //var dicFilter = dic.Where(x => x.Value == "Ahmad");
            //Console.WriteLine(dic.Count());

            Console.WriteLine("1. Home");
            Console.WriteLine("2. Profile");
            Console.WriteLine("3. Setting");
            
            //Console.ReadLine();


            List<Value> LanguangeHome = new List<Value>();
            
            List<Value> LanguangeProfile = new List<Value>();
            
            List<Value> LanguangeSetting = new List<Value>();

            //List<HalamanDepan> LanguangeSetting = new List<HalamanDepan>();



            LanguangeHome.Add(new Value() { Bahasa = "Kontak",English="Contact"});
            LanguangeHome.Add(new Value() { Bahasa = "Pengaturan", English = "Setting"});
            LanguangeHome.Add(new Value() { Bahasa = "Tentang Kami", English = "About Us" });
            

            LanguangeProfile.Add(new Value() { Bahasa = "Edit",English = "Edit"});
            LanguangeProfile.Add(new Value() { Bahasa = "Nama",English = "Name"});
            LanguangeProfile.Add(new Value() { Bahasa = "Alamat",English = "Address" });
         

            LanguangeSetting.Add(new Value() { Bahasa = "Kata Sandi",English = "Password"});
            LanguangeSetting.Add(new Value() { Bahasa = "Simpan",English = "Save" });
            LanguangeSetting.Add(new Value() { Bahasa = "Keluar",English = "Logout" });
            


            
            Dictionary<string, List<Value>> Home = new Dictionary<string, List<Value>>();
            Dictionary<string, List<Value>> Profile = new Dictionary<string, List<Value>>();
            Dictionary<string, List<Value>> Setting = new Dictionary<string, List<Value>>();
            

            Home.Add("Home", LanguangeHome);
            Profile.Add("Profile", LanguangeProfile);
            Setting.Add("Setting", LanguangeSetting);

            //Console.WriteLine(string.Join(",", Home["Home"].Select(x => x.Bahasa)));

            //foreach (var itemHome in Home["Home"])
            //foreach (var itemProfile in Profile["Profile"])
            //foreach (var itemSetting in Setting["Setting"])
            //foreach (var item in Home["Home"])
            //Console.WriteLine(item.Bahasa + " " + item.English);

            //foreach (var itemProfile in Profile["Profile"])
            //Console.WriteLine(itemProfile.Bahasa + " " + itemProfile.English);

            //foreach (var itemSetting in Setting["Setting"])
            //Console.WriteLine(itemSetting.Bahasa + " " + itemSetting.English);

            ////int input = int.Parse(Console.ReadLine());
            ////string[] keys = { "Home", "Profile", "Setting" };
            ////Dictionary<string, List<Value>>[] dictionaries = { Home, Profile, Setting };

            ////Console.WriteLine(string.Join(",", dictionaries[input - 1][keys[input - 1]].Select(x => x.Bahasa + "-" + x.English)));

            //Console.WriteLine("Masukkan input:");
            //int input = int.Parse(Console.ReadLine());
            //string[] keys = { "Home", "Profile", "Setting" };
            //Dictionary<string, List<Value>>[] dictionaries = { Home, Profile, Setting };

            //foreach (var item in dictionaries[input - 1][keys[input - 1]])
            //    Console.WriteLine(item.Bahasa + "\t\t" + item.English);

            int input;
            while (true)
            {
                try
                {
                    Console.WriteLine("Masukan 1 untuk Home, 2 untuk Profile, 3 untuk Setting: ");
                    input = int.Parse(Console.ReadLine());
                    if (input < 1 || input > 3)
                    {
                        throw new Exception("Pilihan tidak tersedia. Masukan bilangan hanya diantara 1 sampai 3.");
                    }
                    break;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            string[] keys = { "Home", "Profile", "Setting" };
            Dictionary<string, List<Value>>[] dictionaries = { Home, Profile, Setting };
            foreach (var item in dictionaries[input - 1][keys[input - 1]])
                Console.WriteLine(item.Bahasa + " - " + item.English);




            //int input = int.Parse(Console.ReadLine());
            //Console.WriteLine("value is: " + cisTuition[input]);

            //var item2 = Home["Home"];
            //Console.WriteLine(item2);




            ////Console.WriteLine(itemHome.Bahasa +""+ itemHome.English);


            //foreach (var key in Home.Keys)
            //{
            //    var value = Home[key];
            //}

            //foreach (var item in Home.Values)
            //{
            //   Console.WriteLine("Pilih Bahasa : " + Home[key]);

            //        }




            //List<Value> Valuese = new List<Value>(Home.Values);




            //int index = 0;
            //foreach (var item in Home)
            //{
            //    Console.WriteLine(string.Format("[{0}] - {1}", index, item.Value));

            //    // increment the index
            //    index++;
            //}



            //List<Value> bahasaIndonesiaHomeList = Home["BahasaIndonesiaHome"];
            //Console.WriteLine(bahasaIndonesiaHomeList);



            //Console.WriteLine(Home[BahasaIndonesiaHome]);


            //foreach (ValueHome value in Home["BahasaIndonesiaHome"])
            //{
            //    Console.WriteLine("Bahasa: {0}, English: {1}", value.Bahasa, value.English);
            //}

            //int input;
            ////Console.WriteLine("pilih (1 for Home, 2 for Profile, 3 for Setting): ");
            //input = int.Parse(Console.ReadLine());

            //string[] keys = { "LanguangeHome", "LanguangeProfile", "LanguangeSetting" };
            //string key = keys[input - 1];

            //try
            //{
            //    Console.WriteLine("pilih {0} :", key);
            //    Console.WriteLine("Bahasa: {0}, English: {1}", Home[key][0].Bahasa, Home[key][0].English);
            //    Console.WriteLine("Bahasa: {0}, English: {1}", Home[key][1].Bahasa, Home[key][1].English);
            //    Console.WriteLine("Bahasa: {0}, English: {1}", Home[key][2].Bahasa, Home[key][2].English);
            //}
            //catch (KeyNotFoundException)
            //{
            //    Console.WriteLine("Invalid Selection");
            //}


            ////foreach (var item in Home)
            ////{
            ////    Console.WriteLine("Pilih Bahasa : " + item);

            ////    }










            //Dictionary<string, Dictionary<string,string>> dic = new Dictionary<string, Dictionary<string>>();
            //dic.Add("Home","Profile","Setting");
            //Dictionary<string, (string,string)> BahasaHome = new Dictionary<string, (string,string)>();
            //Dictionary<string, string> EnglishHome = new Dictionary<string, string>();
            //Dictionary<string,(string,string)> testt = new Dictionary<string,(string,string)>();

            //Dictionary<string, (string,string,string)> Home = new Dictionary<string, (string,string,string)>();
            //Dictionary<string, (string, string, string)> Profile = new Dictionary<string, (string, string, string)>();
            //Dictionary<string, (string, string, string)>Setting = new Dictionary<string, (string, string, string)>();


            ////Home.Add("Peserta1", Home.Add("Ahmad","Bajo"));
            //Home.Add("Bahasa", ("Kontak", "Pengaturan", "Tentang Kami"));
            //Home.Add("English", ("Contact", "Setting", "About Us"));
            //Profile.Add("Bahasa", ("Edit", "Nama", "Alamat"));
            //Profile.Add("English", ("Edit", "Name", "Address"));
            //Setting.Add("Bahasa", ("Sandi", "Simpan", "Keluar"));
            //Setting.Add("English", ("Password", "Save", "Logout"));

            //var keysWithMatchingValues = Home.Where(Home => Home.Key == "Bahasa").Select(Home => Home.Value);

            //Console.ReadLine();
            //foreach (var key in keysWithMatchingValues)
            //    Console.WriteLine(key);
            //Console.ReadLine();
            //foreach (var item in Home)
            //{
            //    Console.WriteLine("Pilih Bahasa : " + item.Key);

            //}





            //BahasaHome.Add("Kontak", ("Pengaturan","Tentang Kami"));
            //EnglishHome.Add("Contact", "Settings");

            //Home.Add("Home", BahasaHome);
            //Home.Add("Home", EnglishHome);

            //foreach (string key in Home.Keys)
            //{
            //    Console.WriteLine($"{key} : {Home[key]}");


            //}








        }
    }
}