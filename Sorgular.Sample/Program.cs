using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace Sorgular.Sample
{

    class Program
    {

        static void Main(string[] args)
        {
            NORTHWNDEntities db = new NORTHWNDEntities();



            /****************   SORGULAR  ****************/

            #region Product tablosunun hepsini ToList Method Syntax ile çekme.
            //var urunler= db.Products.ToList();
            // foreach (var product in urunler) 
            // {
            //     Console.WriteLine(product);
            // } 
            #endregion

            #region Product tablosunun hepsini ToList Query Syntax ile çekme.
            //var urunler2= (from urun in db.Products
            //              select urun).ToList();
            //foreach (var urun in urunler2) ;  
            #endregion


            /****************   ÇOĞUL OLARAK SORGU  ****************/

            #region Çoğul olarak Listeleme işemleri (TOLİST,WHERE,ORDERBY THENBY)

            #region ToList
            //uretilen sorguyu execute etmemizi sağlar.

            //var dt = db.Products.ToList();
            //foreach (Products p in dt)
            //{
            //    Console.WriteLine(p.ProductName);
            //}

            #endregion

            #region ToList v2 SELECT
            // sadece ürünün isimlerine ihityacım var ise bunu kullanabilirim
            // diğer tablolarına ihtiyacım yok 
            //var dt = db.Products.Select(a => a.ProductName);
            //foreach ( var d in dt)
            //{
            //    Console.WriteLine(d);
            //}

            #endregion


            /****************   WHERE(STARTWITH,ENDWITH,ID ÜZERİNDEN SORGU)  ****************/

            #region Where // Method Syntax Product ID 500 den büyük olanlar.
            // oluşturulan sorguya where şartı eklememizi sağlıyor.

            //var dt = db.Products
            //    .Where(a => a.ProductID > 500)
            //    .Select(a=>a.ProductName)
            //    .ToList();

            //foreach (var d in dt) 
            //{
            //    Console.WriteLine(d);
            //}


            #endregion

            #region Where// Method Syntax İçerisinde a kelimesi ile başlayan ürünler.
            //var dt = db.Products
            //    .Where(a => a.ProductName
            //    .StartsWith("a"))
            //    .ToList();
            //foreach ( var d in dt )
            //{
            //    Console.WriteLine(d);
            //}

            #endregion

            #region Where// Method Syntax İçerisinde a kelimesi ile başlayan ve idsi 10dan büyük olanlarürünler.

            //var dt = db.Products.Where(a => a.ProductID > 10 && a.ProductName.StartsWith("a")).ToList();
            //foreach ( var d in dt )
            //{
            //    Console.WriteLine(d);
            //}
            #endregion


            /****************   ORDERBY  ****************/

            #region ORDERBY Prodcut IDsi 0dan büyük VE sonu a ile bitip product ismine göre sıralayan sorgu.

            //var dt = db.Products
            //    .Where(a => a.ProductID > 10 && a.ProductName
            //    .EndsWith("a"))
            //    .OrderBy(a => a.ProductName).ToList();

            //foreach ( var d in dt ) 
            //{   
            //    Console.WriteLine(d);
            //} 
            #endregion

            /****************   THENBY  ****************/

            #region ORDERBY üzerinden THENBY ile 2 ve 3 cül olarak yapılan sıralama
            //ORDERBY üzerinden THENBY ile 2 ve 3 cül olarak yapılan sıralama işlemini farklı kolonlarda uygulamamıza sağlayan bir fonksiyon.
            //var dt = db.Products
            //    .Where(a => a.ProductID > 10 && a.ProductName
            //    .EndsWith("a"))
            //    .OrderBy(a => a.ProductName).ThenBy(a=>a.UnitPrice).ThenBy(a=>a.ProductID).ToList();

            // foreach (var d in dt)
            // {
            //     Console.WriteLine(d);
            // }
            #endregion
            #endregion

            #region Tekil olarak listeleme işlemleri (single,singleordefult,first,firstordefault)

            /****************   Tekil OLARAK SORGU  ****************/

            /****************   /Single/SingleOrDefault/  ****************/
            //yapılan sorguda tek bir veri gelmesi amaçlanıyor ise kullanılır. 

            //single
            //sorguda 1 den fazla veri geliyorsa ve hiç vir veri geliyorsa execption bırakır.

            //singleordefault
            //sorguda birden fazla veri geliyorsa exeption fırlatır eger hic veri gelmiyorsa null döner.


            #region Single
            #region Single tek kayıt geldiğinde.

            //var urun = db.Products.Single(a => a.ProductID == 55);
            //Console.WriteLine(urun); 
            #endregion

            #region Single kayıt gelmiyorsa.
            //var urun = db.Products.Single(a => a.ProductID == 98887);
            //Console.WriteLine(urun); 
            #endregion

            #region Single birden fazla kayıt geliyorsa
            //var urun = db.Products.Single(a => a.ProductID > 10);
            //Console.WriteLine(urun); 
            #endregion

            #endregion


            #region First, FirstOrDefault
            // sorgu neticesinde elde edilen verilerden ilkini getirir. eğer hiç veri gelmiyorsa hata fırlatır.

            //var urun = db.Products.First(a => a.ProductID == 55);
            //Console.WriteLine(urun);









            #endregion


            #endregion

            /****************   Diğer SORGU Tipleri ****************/

            #region Diğer Sorgulama Teknikleri(count,long,any,max,min,distinct....)

            #region Count
            // oluşturulan sorgunun execute etmesini neticesinde kaç adet
            // satırın çıktı alabiliriz.


            //var urun = db.Products.Count();




            #endregion

            #region LONGCount

            //oluşan data count olarak intten büyük olabilir bigdata üzerinden gelebilir.
            // fiyatı 50 den büyük olan dataların adedi. long cinsinden şartta eklenebilir.
            //var urun = db.Products.LongCount(u=>u.UnitPrice>50);

            #endregion

            #region Any
            // sorguneticesinde verirnin gelip gelmedini bool türüne dönen fonksiyondur.

            //var urun = db.Products.Any();

            #endregion

            #region MAX
            // VERİLEN MAX DEĞERİ GETİRİR
            //var fiyat = db.Products.Max(a=>a.UnitPrice);
            //Console.WriteLine(fiyat);
            #endregion

            #region MİN
            // VERİLEN DEĞERŞN MİN DEĞERLERİNİ GETİRİR.
            //var fiyat = db.Products.Min(a => a.UnitPrice);
            //Console.WriteLine(fiyat);
            #endregion

            #region DİSTİNCT
            //MÜKERRER KAYITLARI TEKİLLEŞTİREN BİR İŞLEVE SAHİP BİR FONSİYONDUR.
            //var fiyat = db.Products.Distinct().ToList();
            //foreach (var item in fiyat)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region All
            // bir sorguda gelen verilerin verilen şarta
            // uygun olup olmadıgını belirten true false döndürür.

            //var urun = db.Products.All(a=>a.UnitPrice>200);
            //Console.WriteLine(urun);    

            #endregion

            #region SUM
            // toplam fonsiyonudur.

            //var urun = db.Products.Sum(a => a.UnitPrice);
            //Console.WriteLine(urun);

            #endregion

            #region Average
            // average fonsiyonudur.

            //var urun = db.Products.Average(a => a.UnitPrice);
            //Console.WriteLine(urun);

            #endregion

            #region Contains
            // like sorugusu oluşturmamızı sağlar %....%


            //var urun = db.Products.Where(a => a.ProductName.Contains("h")).ToList();
            //foreach ( var u in urun )
            //{
            //    Console.WriteLine(u);
            //}
            #endregion

            #region StartWith
            // başlama ile olanlar kodu incele

            //var urun = db.Products.Where(p => p.ProductName.StartsWith("a")).ToList();
            //foreach ( var p in urun )
            //{
            //    Console.WriteLine(p.ProductName);
            //}
            #endregion




            #endregion

            /****************   Sorgu Sonucu dönüşüm Fonksiyonları ****************/

            #region Sorgu sonucu dönüşüm sorguları (TODictionary,toarray,select,selectmany)

            // bu fonsiyonlar ile sorgu neticesinde elde edilen verileri siteğimiz doğrultusunda
            //farklı türlerde projeksiyon edebiliyoruz.

            #region ToDictionary
            // gelecek olan sorgu sonuçlarını dicitonar döner

            // tolist ile aynı amaca hizmet eer.
            //var urun = db.Products.ToDictionary(a => a.ProductName, a=>a.UnitPrice);


            #endregion

            #region ToArray
            // oluşturan sorguyu dizi oalrak elde eder.
            //to list ile aynı amaca hizmet eder. gelen sonucu oalrak entitiy  dizisi olarak elde eder.

            //var urun = db.Products.ToArray();
            //Console.WriteLine(urun);
            #endregion

            #region Select
            // işlevsel olarak birden fazla davranışı vardır.
            //fonsiyon generete edilcek sorugnun çek,lcek kolonlarını ayarlamızızı sağlar

            //var urun2=db.Products.Select( p => new { 
            //ıd=p.ProductID,
            //fiyat=p.UnitPrice

            //} ).ToList();
            //foreach ( var p in urun2 )
            //{
            //    Console.WriteLine(p);
            //}

            // fonksiyon gelen verileri farklı türlerde karşılamaızı sağlar , T,ANONİM.

            #endregion

            #region SelectMany
            //??
            #endregion



            #endregion


            /****************   Group by Fonksiyonları ****************/

            #region Group by Fonksiyonları 
            // gruplama yapmamızı sağlayan fonksiyon.

            //var datas = db.Products.GroupBy(a => a.UnitPrice).Select(grp => new
            //{
            //    count = grp.Count(),
            //    fiyat= grp.Key

            //}).ToList();
            //foreach ( var data in datas )
            //{
            //    Console.WriteLine( data );  
            //}





            #endregion



            Console.ReadLine();
        }
    }
}
