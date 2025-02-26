using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ConsoleCode
{
    class TestCoding
    {
        //TABEL KAMUS   
        //A = 0        || //a = 9
        //B-D = 1      || //b-d = 8
        //E = 2        || //b-d = 8
        //F-H = 3      || //e = 7
        //I = 4        || //f-h = 6
        //J-N = 5      || //i = 5
        //O = 6        || //j-n = 4
        //P-T = 7      || //o = 3
        //U = 8        || //p-t = 2
        //V-Z = 9      || //u = 1
        //             || //v-z = 0
        //             || //space = 0

        public static string ubahData(string param, string param1, string param2)
        {
            string output = string.Empty;

            //Buat kamus dengan tipe key int dan value string
            Dictionary<int, string> kamus = new Dictionary<int, string>();
            Dictionary<int, string> kamusBesar = new Dictionary<int, string>();
            Dictionary<int, string> kamusKecil = new Dictionary<int, string>();

            //Menambahkan pasangan key-value ke dalam kamus
            kamus[0] = "Avwxyz ";
            kamus[1] = "BCDu";
            kamus[2] = "Epqrst";
            kamus[3] = "FGHo";
            kamus[4] = "Ijklmn";
            kamus[5] = "JKLMNi";
            kamus[6] = "Ofgh";
            kamus[7] = "PQRSTe";
            kamus[8] = "Ubcd";
            kamus[9] = "VWXYZa";

            kamusBesar[0] = "A";
            kamusBesar[1] = "BCD";
            kamusBesar[2] = "E";
            kamusBesar[3] = "FGH";
            kamusBesar[4] = "I";
            kamusBesar[5] = "JKLMN";
            kamusBesar[6] = "O";
            kamusBesar[7] = "PQRST";
            kamusBesar[8] = "U";
            kamusBesar[9] = "VWXYZ";

            kamusKecil[0] = "vwxyz ";
            kamusKecil[1] = "u";
            kamusKecil[2] = "pqrst";
            kamusKecil[3] = "o";
            kamusKecil[4] = "jklmn";
            kamusKecil[5] = "i";
            kamusKecil[6] = "fgh";
            kamusKecil[7] = "e";
            kamusKecil[8] = "bcd";
            kamusKecil[9] = "a";

            // Menampilkan isi kamus
            //foreach (var item in kamus)
            //{
            //    Console.WriteLine($"{item.Key} = {item.Value}");
            //}

            if (param1 == "HURUF_ANGKA" && param2 == "DEFAULT")
            {
                #region 1. Ubahlah daftar kalimat di atas menjadi sebuah bilangan berdasarkan kamus yang telah diberikan.
                //Titanic           7 5 2 9 4 5 8
                //Avenger Endgame   0 0 7 4 6 7 2 0 2 4 8 6 9 4 7
                foreach (var i_par in param)
                {
                    foreach (var i_kamus in kamus)
                    {
                        if (i_kamus.Value.Contains(i_par))
                        {
                            //Console.WriteLine(item.Key);
                            //output += string.Join(" ", Convert.ToString(i_kamus.Key));
                            output += i_kamus.Key + " ";

                        }
                    }

                }
                #endregion
            }
            if (param1 == "ANGKA_HURUF" && param2 == "UPPER")
            {
                foreach (var i_param in param)
                {
                    foreach (var i_kamusBesar in kamusBesar)
                    {
                        if (i_kamusBesar.Key.ToString().Contains(i_param))
                        {
                            //Console.WriteLine(_item + " " + item.Value[1]);
                            output += i_kamusBesar.Value[0] + " ";
                        }
                    }

                }
            }
            if (param1 == "ANGKA_HURUF" && param2 == "LOWER")
            {
                foreach (var i_param in param)
                {
                    foreach (var i_kamusKecil in kamusKecil)
                    {
                        if (i_kamusKecil.Key.ToString().Contains(i_param))
                        {
                            //Console.WriteLine(_item + " " + item.Value[1]);
                            output += i_kamusKecil.Value[0] + " ";
                        }
                    }

                }
            }

            output = output.Substring(0, output.Length - 1);

            return output;
        }

        public static string konversiData(string param)
        {
            string output = string.Empty;

            //a. Apabila hasil negative, maka diubah ke bilangan positif.
            int maxLength = Math.Abs(int.Parse(param));
            Console.WriteLine("SOAL 3=> TEST CASE A SOAL 3: \n" +
                "{0}", maxLength);
            Console.WriteLine("");


            //b.Huruf yang dipakai adalah huruf besar.
            //c.Apabila terdapat abjad range maka diambil huruf pertama (Contoh: B – D, maka diambil huruf B).
            //d.Pengambilan huruf diambil secara berurutan(Contoh: A B E F = 6, bukan A A A AA A = 6).
            int _Count = 0;
            int _Temp = 0;
            string _Hasil = string.Empty;
            for (int i = 0; i < maxLength; i++)
            {
                //12 = 0 + 1 + 2 + 3 + 4 + 0 + 1 + 0 + 1
                //-16 = 16 = 0 + 1 + 2 + 3 + 4 + 5 + 0 + 1
                //10+5
                //_Temp += _Count;
                if (_Temp == maxLength)
                {

                }
                else
                {
                    _Temp += _Count;
                    if (_Temp > maxLength)
                    {
                        _Temp = _Temp - _Count;
                        _Count = 0;
                    }
                    else if (_Temp <= maxLength)
                    {
                        _Hasil += _Count.ToString() + " ";
                        _Count++;
                    }
                   
                }
                
            }

            output = _Hasil.Substring(0, _Hasil.Length-1);
            Console.WriteLine("SOAL 3=> TEST CASE B,C & D: ");

            output = output.Replace(" ", "");
            output = ubahData(output, "ANGKA_HURUF", "UPPER");

            return output;
        }

        public static string konversiData_FindYourSelf(string param)
        {
            string output = string.Empty;
                               
            int maxLength = Math.Abs(int.Parse(param));
            //Console.WriteLine("SOAL 4=> Apabila hasil negative, maka diubah ke bilangan positif : \n" +
            //    "{0}", maxLength);
            //Console.WriteLine("");

            //ditambahkan +2 dan apabila lebih besar dari 11 maka cek count terakhir genap atau ganjil 
            //apabila genap maka count menjadi 1
            //apabila ganjil count++
            maxLength = maxLength + 2;

            int _Count = 0;
            int _Temp = 0;
            string _Hasil = string.Empty;
            for (int i = 0; i < maxLength; i++)
            {
               
                if (_Temp == maxLength)
                {

                }
                else
                {
                    if (_Temp > 10 && _Temp <= maxLength)
                    {
                        if (_Count %2 == 0)
                        {
                            _Count = 1;
                        }
                        else
                        {
                            _Count++;
                        }
                        _Temp = _Temp + _Count;
                        _Hasil += _Count.ToString() + " ";
                        
                    }
                    else
                    {
                        _Temp += _Count;
                        if (_Temp > maxLength)
                        {
                            _Temp = _Temp - _Count;
                            _Count = 0;
                        }
                        else if (_Temp <= maxLength)
                        {
                            _Hasil += _Count.ToString() + " ";
                            _Count++;
                        }
                    }
                   

                }

            }

            output = _Hasil.Substring(0, _Hasil.Length - 1);
            output = output.Replace(" ", "");
            output = ubahData(output, "ANGKA_HURUF", "UPPER");

            return output;
        }

        public static string konversiData_FindYourSelf_2(string param)
        {
            string output = string.Empty;

            int maxLength = Math.Abs(int.Parse(param));
            //Console.WriteLine("SOAL 4=> Apabila hasil negative, maka diubah ke bilangan positif : \n" +
            //    "{0}", maxLength);
            //Console.WriteLine("");

            int _Count = 0;
            int _Temp = 0;
            string _Hasil = string.Empty;
            for (int i = 0; i < maxLength; i++)
            {

                if (_Temp == maxLength)
                {

                }
                else
                {
                    int _ganjil = 0;

                    if (_Temp > 10 && _Temp <= maxLength)
                    {
                        if (_Count % 2 == 0)
                        {
                            _Count = 1;

                        }
                        else
                        {
                            _ganjil = 1;
                            _Count++;
                        }
                        _Temp = _Temp + _Count;
                        _Hasil += (_Count + _ganjil).ToString() + " ";

                    }
                    else
                    {
                        
                        _Temp += _Count;
                        if (_Temp > maxLength)
                        {
                            _Temp = _Temp - _Count;
                            _Count = 0;
                        }
                        else if (_Temp <= maxLength)
                        {
                            
                            if (_Count %2 == 0)
                            {
                                _ganjil = 1;
                            }
                            else
                            {
                                _ganjil = 0;
                            }
                            _Hasil += (_Count + _ganjil).ToString() + " ";
                            _Count++;
                        }
                    }


                }

            }


            output = _Hasil.Substring(0, _Hasil.Length - 1);
            //output = output.Replace(" ", "");
            //output = ubahData(output, "ANGKA_HURUF", "UPPER");

            return output;
        }

        public static string jumlahDeretAngka(string param)
        {
            string output = string.Empty;
            //string dummy = string.Empty;
            //7+5-2+9-4+5-8

            param = param.Replace(" ", "");
            int _Temp = 0;

            for (int i = 0; i < param.Length; i++)
            {
                if (i == 0 || i == 1)
                {
                    _Temp += int.Parse(param[i].ToString());
                }
                else
                {
                    if (i % 2 == 0)
                    {
                        _Temp -= int.Parse(param[i].ToString());
                        //dummy += param[i] + "-";
                    }
                    else
                    {
                        _Temp += int.Parse(param[i].ToString());
                        //dummy += param[i] + "+";
                    }
                }
                
            }                     

            output = _Temp.ToString();

            return output;

        }

        public static int IsNewLine(int param)
        {
            Console.WriteLine("");
            for (int i = 0; i < param; i++)
            {
                Console.Write("=");
            }
            Console.WriteLine("\n");

            return param;
        }

        static void Main(string[] args)
        {
            #region isNewLine
            IsNewLine(100);
            #endregion

            string input_1 = "Titanic";
            string input_2 = "Avenger Endgame";

            Console.WriteLine("1. Ubahlah daftar kalimat di atas menjadi sebuah bilangan berdasarkan kamus yang telah diberikan : ");
            string output_soal_1A = ubahData(input_1, "HURUF_ANGKA", "DEFAULT");
            Console.WriteLine("SOAL 1=> TEST CASE 1: {0}", input_1);
            Console.WriteLine(output_soal_1A);
            Console.WriteLine("");

            string output_soal_1B = ubahData(input_2, "HURUF_ANGKA", "DEFAULT");
            Console.WriteLine("SOAL 1=> TEST CASE 2: {0}", input_2);
            Console.WriteLine(output_soal_1B);

            #region isNewLine
                IsNewLine(100); 
            #endregion

            Console.WriteLine("2. Ubah, jumlah, dan kurangkan secara bergantian dari hasil konversi nomor 1 : ");
            string output_soal_2A = jumlahDeretAngka(output_soal_1A);
            Console.WriteLine("SOAL 2=> TEST CASE 1: {0}", output_soal_1A);
            Console.WriteLine(output_soal_2A);
            Console.WriteLine("");

            string output_soal_2B = jumlahDeretAngka(output_soal_1B);
            Console.WriteLine("SOAL 2=> TEST CASE 2: {0}", output_soal_1B);
            Console.WriteLine(output_soal_2B);

            #region isNewLine
            IsNewLine(100);
            #endregion

            Console.WriteLine("3. Konversikan hasil dari nomor 2 dan dikembalikan ke dalam bentuk abjad (huruf besar) sesuai kamus\n" +
                " yang diberikan di atas. Ketentuan: ");
            Console.WriteLine("" +
                "a. Apabila hasil negative, maka diubah ke bilangan positif. \n" +
                "b. Huruf yang dipakai adalah huruf besar. \n" +
                "c. Apabila terdapat abjad range maka diambil huruf pertama (Contoh: B – D, maka diambil huruf B). \n" +
                "d. Pengambilan huruf diambil secara berurutan (Contoh: A B E F = 6, bukan A A A AA A = 6).");
            Console.WriteLine("");

            string output_soal_3A = konversiData(output_soal_2A);
            Console.WriteLine("{0}", output_soal_3A);
            //Console.WriteLine("0 1 2 3 4 0 1 0 1");
            //Console.WriteLine("A B E F I A B A B");
            Console.WriteLine("");

            string output_soal_3B = konversiData(output_soal_2B);
            Console.WriteLine("{0}", output_soal_3B);
            //Console.WriteLine("0 1 2 3 4 5 0 1");
            //Console.WriteLine("A B E F I J A B");

            #region isNewLine
            IsNewLine(100);
            #endregion

            Console.WriteLine("4.Konversikan hasil nomor 3 menjadi sample output seperti table di bawah.\n" +
                            "Petunjuk:\n" +
                            "a.Ubah input yang didapat menjadi sebuah bilangan kembali(bisa menggunakan kamus di atas).\n" +
                            "b.Lakukan operasi matematika terhadap bilangan tersebut hingga menjadi bilangan baru.\n" +
                            "c.Lakukan perubahan kembali ke bentuk abjad(menggunakan kamus) dan pastikan telah sesuai\n" +
                            "  dengan bentukan contoh di bawah.\n");

            string output_soal_4A_1 = ubahData(output_soal_3A, "HURUF_ANGKA", "DEFAULT");
            Console.WriteLine("SOAL 4(a)=> TEST CASE 1: {0}", output_soal_3A);
            Console.WriteLine(output_soal_4A_1);                  
            Console.WriteLine("");

            string output_soal_4A_2 = ubahData(output_soal_3B, "HURUF_ANGKA", "DEFAULT");
            Console.WriteLine("SOAL 4(a)=>TEST CASE 2: {0}", output_soal_3B);
            Console.WriteLine(output_soal_4A_2);
            Console.WriteLine("");

            string output_soal_4B_1 = jumlahDeretAngka(output_soal_4A_1);
            Console.WriteLine("SOAL 4(b)=>TEST CASE 1: {0}", output_soal_4A_1);
            Console.WriteLine(output_soal_4B_1);
            Console.WriteLine("");

            string output_soal_4B_2 = jumlahDeretAngka(output_soal_4A_2);
            Console.WriteLine("SOAL 4(b)=>TEST CASE 2: {0}", output_soal_4A_2);
            Console.WriteLine(output_soal_4B_2);
            Console.WriteLine("");

            string output_soal_4C_1 = konversiData_FindYourSelf(output_soal_4B_1);
            Console.WriteLine("SOAL 4(c)=>TEST CASE 1: {0}", output_soal_4B_1);
            Console.WriteLine(output_soal_4C_1);
            Console.WriteLine("");
            
            string output_soal_4C_2 = konversiData_FindYourSelf(output_soal_4B_2);
            Console.WriteLine("SOAL 4(c)=>TEST CASE 2: {0}", output_soal_4B_2);
            Console.WriteLine(output_soal_4C_2);
            Console.WriteLine("");

            #region isNewLine
            IsNewLine(100);
            #endregion

            Console.WriteLine("5. Dari hasil nomor 4, silakan lakukan perubahan kembali menjadi sample output seperti table di bawah. \n" +
                                  "Petunjuk:\n" +
                                  "a.Lakukan operasi matematika terhadap huruf tersebut hingga menjadi huruf baru.\n" +
                                  "b.Lakukan perubahan kembali ke bentuk bilangan(menggunakan kamus) dan pastikan \n" +
                                  "  telah sesuai dengan bentukan contoh di bawah.\n");

            string output_soal_5_1 = ubahData(output_soal_4C_1, "HURUF_ANGKA", "DEFAULT");
            //Console.WriteLine("SOAL 5(a)=> TEST CASE 1: {0}", output_soal_4C_1);
            //Console.WriteLine(output_soal_5A_1);
            //Console.WriteLine("");

            string output_soal_5_2 = ubahData(output_soal_4C_2, "HURUF_ANGKA", "DEFAULT");
            //Console.WriteLine("SOAL 5(a)=>TEST CASE 2: {0}", output_soal_4C_2);
            //Console.WriteLine(output_soal_5A_2);
            //Console.WriteLine("");

            string output_soal_5A_1 = jumlahDeretAngka(output_soal_5_1);
            Console.WriteLine("SOAL 5(a)=>TEST CASE 1: {0}", output_soal_5_1);
            Console.WriteLine(output_soal_5A_1);
            Console.WriteLine("");

            string output_soal_5A_2 = jumlahDeretAngka(output_soal_5_2);
            Console.WriteLine("SOAL 5(a)=>TEST CASE 2: {0}", output_soal_5_2);
            Console.WriteLine(output_soal_5A_2);
            Console.WriteLine("");

            //string output_soal_5B_1 = konversiData_FindYourSelf_2(output_soal_4B_1);
            string output_soal_5B_1 = konversiData_FindYourSelf_2(output_soal_5A_1);
            Console.WriteLine("SOAL 5(a)=>TEST CASE 1: {0}", output_soal_5A_1);
            Console.WriteLine(output_soal_5B_1);
            Console.WriteLine("");

            //string output_soal_5B_2 = konversiData_FindYourSelf_2(output_soal_4B_2);
            string output_soal_5B_2 = konversiData_FindYourSelf_2(output_soal_5A_2);
            Console.WriteLine("SOAL 5(c)=>TEST CASE 2: {0}", output_soal_5A_2);
            Console.WriteLine(output_soal_5B_2);
            Console.WriteLine("");

            #region isNewLine
            IsNewLine(100);
            #endregion

            //Thread.Sleep(10000); //Close Program after 10 Detik
            Console.ReadKey();
        }
    }
}
