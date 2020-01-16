using System;

namespace Adapter.bank
{
    public abstract class Bank
    {
        public abstract void KrediSorgula();
    }


    #region katılım bankacılığı

    public abstract class KatılımBankası : Bank
    {

        public int taksit { get; set; }
        public int miktar { get; set; }

        public abstract void KatılımPayıHesapla();
    }

    public class Abank : KatılımBankası
    {
        public override void KatılımPayıHesapla()
        {
            Console.WriteLine("katılım payı hesaplanıyor..");
        }

        public override void KrediSorgula()
        {
            Console.WriteLine("Katılım bankası finansman hesaplanıyor..");
        }
    }



    #endregion

    #region ticaret bankacılığı
    public abstract class TicaretBankacılığı : Bank
    {
        public int taksit { get; set; }
        public int miktar { get; set; }

        public abstract void KobiDestekSorgula();
    }


    public class TBank : TicaretBankacılığı
    {
        public override void KobiDestekSorgula()
        {
            Console.WriteLine("Kobi destek kredisi hesaplanıyor.");
        }

        public override void KrediSorgula()
        {
            Console.WriteLine("Ticaret bankası kredi hesaplanıyor..");

        }
    }


    #endregion

    #region adapters

    public class KatılımAdapter : TicaretBankacılığı
    {
        KatılımBankası Katılım;

        public KatılımAdapter(KatılımBankası k)
        {
            this.Katılım = k;
        }

        public override void KobiDestekSorgula()
        {
            this.Katılım.KatılımPayıHesapla();
        }

        public override void KrediSorgula()
        {
            this.Katılım.KrediSorgula();
        }
    }

    public class TicaretAdapter : KatılımBankası
    {
        TicaretBankacılığı Ticaret;

        public TicaretAdapter(TicaretBankacılığı k)
        {
            this.Ticaret = k;
        }

        public override void KatılımPayıHesapla()
        {
            this.Ticaret.KobiDestekSorgula();
        }

        public override void KrediSorgula()
        {
            this.Ticaret.KrediSorgula();
        }
    }

    #endregion
}
