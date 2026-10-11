// var kursAdi=".NET ile C# Proglamlama Dili".Split(' ');
// Console.WriteLine(kursAdi[2]);

// Console.WriteLine(kursAdi.Length);
// Console.WriteLine(kursAdi.ToLower());
// Console.WriteLine(kursAdi.StartsWith("."));
// Console.WriteLine(kursAdi.IndexOf("C#"));
// Console.WriteLine(kursAdi.Contains("C#"));
// Console.WriteLine(kursAdi.Replace("Dili","Dersleri"));
// Console.WriteLine(kursAdi);
// string[] isimler =new string[4];
// isimler[0]="bengi";
// isimler[1]="zeyp";
// isimler[2]="idris";
// isimler[3]="görkem";
// string[] isimler={"bengi","zeyp","idris","görkem"};

// int[] numaralar= new int[4];
// numaralar[0]=100;
// numaralar[1]=200;
// numaralar[2]=300;
// numaralar[3]=400;

// Console.WriteLine($"{numaralar[2]} numarali kişinin adi {isimler[2]}dir.");
// Console.WriteLine($"{numaralar[0]} numarali kisinin adi {isimler[0]}dir");
// int[] plakalar={41,66,34,10,9,6};
// var sonuc=plakalar[0..4];
// Console.WriteLine(sonuc[2]);
// foreach (var i in sonuc)
// {
//     Console.WriteLine(i);
// }
// string[] students= new string[3];
// int[] notes=new int[3];
// for (int i=0; i<students.Length;i++)
// {
//     Console.WriteLine($"{i+1}. öğrenci adini giriniz:");
//     students[i]=Console.ReadLine()?? "";
// }
// for(int i = 0; i < notes.Length; i++)
// {
//     Console.WriteLine($"{students[i]} adli öğrencinin notunu giriniz:");
//     notes[i]=Convert.ToInt32(Console.ReadLine());
// }
// Console.WriteLine($"Ogrenciler dizisi {students.Length} elemanlidir.");
// Console.WriteLine($"{students[0]} adli öğrencinin notu {notes[0]}dir.");
// Console.WriteLine($"{students[1]} adli öğrencinin notu {notes[1]}dir.");

// int sum=0;
// for (int i=0;i<students.Length;i++)
// {
//     sum+=notes[i];
// }
// double avarage=(double)sum/students.Length;
// Console.WriteLine("Avarege is "+avarage);

// string[] myFam={"zeynep","idris","ozlem","kadir","yasar"};
// Array.Sort(myFam);
// foreach (var i in myFam)
// {
//     Console.WriteLine(i);
// }

// int[] myNumbers={10,20,4,32,16};
// Console.WriteLine(myNumbers.Max());
// Console.WriteLine(myNumbers.Min());
// Console.WriteLine(myNumbers.Sum());
// Array.Sort(myNumbers);
// Console.WriteLine("--------");
// foreach (var i in myNumbers)
// {
// Console.WriteLine(i);

// }
// Console.Write("Ulkenizin oy kullanabilme yasini girin:");
// int resit=Convert.ToInt32(Console.ReadLine());

// Console.Write("Yasiniz:");
// int yas=Convert.ToInt32(Console.ReadLine());

// var sonuc=yas>=resit ? "oy kullanilabilir" : "oy kullanilmak için yas uygun degil";
// Console.WriteLine(sonuc);
// Console.WriteLine($"Oy kullanilmasi için kalan sure:{resit-yas} yil."); 


// Console.Write("Yasinizi girin:");
// int age=Convert.ToInt32(Console.ReadLine());
// Console.Write("Veli izni varsa true girin:");
// bool isValid=Convert.ToBoolean(Console.ReadLine());
// string result = age>18 || isValid==true ? "calisilabilir":"sartlar uygun degil";
// Console.WriteLine(result);

// Console.Write("Ders notunuzu giriniz:");
// int note=Convert.ToInt32(Console.ReadLine());
// string result=note>50 && note<100 ? "tebrikler dersi geçtiniz!":"basarisiz dersten kaldiniz";
// Console.WriteLine(result);

// double vize1,vize2,final,ort;
// Console.Write("Vize1 notunu giriniz:");
//  vize1=Convert.ToDouble(Console.ReadLine());

//  Console.Write("Vize2 notunu giriniz:");
//  vize2=Convert.ToDouble(Console.ReadLine());

//  Console.Write("Final notunu giriniz:");
//  final=Convert.ToDouble(Console.ReadLine());

//  ort=(vize1*0.25)+(vize2*0.25)+(final*0.50);
//  Console.Write("Zayif not varsa true giriniz:");
//  bool isValid=Convert.ToBoolean(Console.ReadLine());

//  string result=ort>=70 && isValid!=true ? "tesekkür belgesi alabilir" : "belge alamaz";
//  Console.WriteLine(result);


// string[] cars={"bmw","mercedes","audi","mazda"};
// var rnd= new Random();
// int sayi=rnd.Next(0,4);
// Console.WriteLine(sayi);
// Console.WriteLine(cars[sayi]);

// string[] isim={"bengi","zeynep","nisa","idris","özlem"};
// Random rnd1= new Random();
// int index=rnd1.Next(0,2);
// Console.WriteLine(index);
// Console.WriteLine(isim[index]);


// StreamReader sr=File.OpenText("deneme.txt");
// var s="";
// while ((s=sr.ReadLine()) !=null)
// {
//     Console.WriteLine(s);
// }

// string sonuc=File.ReadAllText("deneme.txt");
// Console.WriteLine(sonuc);

// string[] result=File.ReadAllLines("deneme.txt");
// Console.WriteLine(result[0]);

// using(StreamWriter sw=File.CreateText("deneme.txt")){
// sw.WriteLine("Bu");
// sw.WriteLine("konuyu");
// sw.WriteLine("da");
// sw.WriteLine("hallettik");
// }

// using(StreamWriter sw=File.AppendText("deneme.txt"))
// {
//     sw.WriteLine("cok sukur");
//     sw.WriteLine("siradaki gelsin");
// }

namespace Projem.App
{
    class program
    {
        static void Main(string[] args)
        {
          ID personel1=new ID();
          personel1.TC="12365478936";
          if(personel1.TC != null)
          {
          Console.WriteLine("Girdiginiz tc kimlik numrasi:" +personel1.TC );
          }

        }
    }

    class ID
    {
        private string? tc_no ;
        // properties
        public string? TC {
            get
            {
              if(tc_no == null) return null;
              return tc_no.Length>5 ? tc_no.Substring(0,5)+"******" : tc_no;
            }
            set
            {
                bool kontrol=false;
                if (value.Length == 11)
                {
                    for(int i=0; i<11; i++)
                    {
                        bool sayiMi = char.IsNumber(value[i]);
                        if (sayiMi)
                        {
                            // true
                        }
                        else
                        {
                            kontrol=true;
                            break;
                        }
                    }
                    if(kontrol)
                    {
                        Console.WriteLine("Tc kimlik numaranizda gecersiz karakter bulundu.");
                    }
                    else
                    {
                        tc_no=value;
                    }

                }
                else
                {
                    Console.WriteLine("Girdiginiz TC Kimlik No 11 karakter olmali.");
                }
                

            } 
            
        }
        //methods
    }
}
