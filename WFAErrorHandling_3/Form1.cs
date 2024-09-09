using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFAErrorHandling_3
{
    public partial class Form1 : Form
    {

        /*
         
                          Bizim projelerimizde alabilecegimiz hatalar 3 kategoriye ayrılır:


        1 => Syntax Hataları(Yazım Hatalar, Compiler Exception, Derleme Hataları): Yazım kaynaklı bir sorun meydana geldiginde devreye girer...En kolay cözülen hata tipidir...VS'da direkt olarak Error List'te gösterilir... Zaten Error List'te gözükebilen tek hata tipidir...Bu pencere aracılıgı ile yaptıgını hatalara ilgili hatanın üzerine cift tıklayarak gidebilirsiniz...Sonra o hatayı düzeltirsiniz...

        //Syntax hatalarında projeyi calıstırmaya calısırsanız sizi uyaran bir pencere cıkacaktır...Buna her zaman no deyin...Eger do not show again ve yes derseniz bu saglıksız bir secenektir...Projenizin eski calısabilen verisyonunu calıstırır ve bir daha o pencere hic cıkmaz...Bunu düzeltmek icin Tools => Options => Project And Solutions => Build And Run => Buradaki sagdaki tarafa Always Built ve altında da Prompt To Launch seceneklerini işaretleyin


        2 => Calısma Zamanı Hataları (RunTime Exception) : Genelde kullanıcı kaynaklı öngörülemeyen hatalardır (verinin yanlıs veya bos girilmesi)...Aynı zamanda geliştiricinin gözünden kaçan ama kullanıcının sucunun olmadıgı dudumlarda da nadir olse da bu hataları gözlemleyebilirsiniz(geliştiricinin döngü sınırını gözden kacırarak menzil dısına cıkması, degişken sınırının dısına cıkması)...Cözümü try-catch blokları ile hata yönetimi sayesinde olur...Bu hatalar size (Exception) tarzında gözükür...Her RunTime hatasının da kendisine has bir exception ismi vardır...

        (FormatException,OverflowException,StackoverflowException,DivideByZeroException,SqlConnectionException etc...)
        
         
         
         
         
         
         */




        public Form1()
        {
            InitializeComponent();
        }

        private void btnCarp_Click(object sender, EventArgs e)
        {
            try
            {
                int sayi = Convert.ToInt32(txtSayi.Text);

                int sonuc = sayi / 0;
                MessageBox.Show((sonuc * 2).ToString());
            }
            catch //Eger catch'in yanında hicbir parantez yoksa alabileceginiz bütün hataları yakalar(Her türlü hatayı yakalayan bir catch kullanıyorsunuz demektir)
            {
                //Dikkat edin bu Catch bütün runtime exception'larini yakalar...Dolayısıyla tüm hatalarınız icin bu yaşam alanı calısacaktır...Siz hata spesifikleştirmek isteyip(farklı mesajlar cıkarmak veya farklı eylemlerde bulunmak isteyebilirsiniz - farklı kodlar yazmak isteyebilirsiniz) bu sekilde programa hata yönetimizini entegre etmeyi de secebilirsiniz...
                MessageBox.Show($"Lütfen {int.MinValue} ve {int.MaxValue} deger aralıklarında bir sayı giriniz");
            }

        }
        
        private void btnSpesifik_Click(object sender, EventArgs e)
        {
            //Eger siz catch bloklarınızı spesifikleştirmek istiyorsanız o zaman catch'lerin yanına parantez acarak ilgili hata tiplerinizi yazmalısınız... Fakat unutmayın ki böyle yaparsanız da o catch sadece o hata tipi icin calısacak ve baska bir hata tipi icin calısmayacaktır... Bu özel catch'lerin yanında aynı zamanda bütün hataları yakalayabilen bir catch koymak istiyorsanız bilmelisiniz ki o catch mekanizmanın en sonuna yazılmalıdır...

            //try - catch bir hata yakalama mekanizmasıdır....

            //C# kod bütünlügü cok önemlidir...Kod bütünlügü bozulmamalıdır(birlikte calısan yapılar bagımsızlastırılamaz ve araya baska kodlar giremez)

            //Scopelar icerisi görünmeyen ama dısarıyı görebilen pencereler olarak düsünülmelidir...

            //Scope dedigimiz yapılar iki süslü parantez arasıdır(Blok da , Yaşam alanı da denilebilir)

            //Bir local alanın icerisinde ekstra bir scope acılırsa o ilgili alan icerideki scope'u göremez ama icerideki scope dısarıdaki scope'u görür...Local alan icerisinde ekstra acılan yaşam alanına da sublocal alan da denir...


            //Try-Catch blokları => Runtime Exception alma riskinizin bulundugu yerleri kontrol eden, hata durumunda ise yedek calısacak kodları belirlediginiz bloklardır

           //Hata alma riskinizin bulundugu ifadeyi(veya komple bütün kodlarınızı da) kontrol edebilmek istiyorsanız onu Try'a yazmalısınız...Hata gerçekleşirse Try blogu bu hatayı tespit eder ve ilgili Catch bloguna gönderir...Catch bu hatayı yakalar ve programın cökmesini engelleyerek icerisindeki yedek kodları calıstırır...catch'te siz hata durumunda programın nasıl bir tepki vermesini istediginizi yazarak programı kontrol edersiniz...


            //Bir Try- Catch blogunda genel olan (bütün hataları yakalayan) sadece bir catch bulunabilir... (yani parantezi olmayan veya parantezinin icerisinde Exception yazan) ...BU, her türlü hatayı yakalayabilen bir Catch'tir...Ancak bir de spesifik catchler vardır...Böyle catchler de eger Try-Catch mekanizmasında kullanılacak ise ve ek olarak hem bunlar hem de genel tüm hataları yakalayan catch kullanılacak ise o genel catch'in en sona yazılması gerekir..Yoksa syntax hatası alırsınız...Cünkü genel olarak yazılan catch mekanizmayı sonlandırır...
            
            try
            {
                int a = Convert.ToInt32(txtSayi.Text);
                int sonuc = a / 0;
            }

          

            catch(FormatException ex)
            {
                MessageBox.Show($"Lütfen düzgün formatta bir sayı girişi yapın {ex.Message}");
            }



            catch (OverflowException)
            {
                MessageBox.Show($"Girebileceginiz degerler {int.MinValue} ve {int.MaxValue} aralıklarındadır(dahil alınır)");
            }
            catch(Exception ex)
            {
                MessageBox.Show($"Tespit edilemeyen bir durum olustu lütfen tekrar deneyiniz..{ex.Message}");
            }




        }
    }
}
