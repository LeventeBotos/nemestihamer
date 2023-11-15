using System;

class SikloErnyozes
{
    static void Main()
    {
        // Hegycsúcsok magasságai
        int[] magassagok = { 7, 8, 7, 9, 3, 2, 4, 3, 3, 6 };

        int n = 0;
        // A, B, és C részekre vonatkozó számítások
        int aValasz = SzamolSikloErnyozesek(magassagok, 1, n);
        int bValasz = SzamolSikloErnyozesek(magassagok, 2, n);
        int dValasz = SzamolSikloErnyozesek(magassagok, 3, n);
        int eValasz = SzamolSikloErnyozesek(magassagok, 4, n);
        int fValasz = SzamolSikloErnyozesek(magassagok, 5, n);
        int gValasz = SzamolSikloErnyozesek(magassagok, 6, n);
        int cValasz = aValasz + bValasz + eValasz + dValasz + fValasz + gValasz;

        // Eredmények kiírása
        Console.WriteLine($"A. {aValasz} különböző siklóernyzés");
        Console.WriteLine($"B. {bValasz} különböző siklóernyzés");
        Console.WriteLine($"C. {cValasz} különböző siklóernyzés összesen");
    }

    static int SzamolSikloErnyozesek(int[] magassagok, int atrepulesSzam, int hanyadik)
    {
        int eredmeny = 0;
        int hossz = magassagok.Length;

        for (int i = 0; i < hossz; i++)
        {
            if (magassagok[hanyadik] > magassagok[i])
                eredmeny += SzamolErnyozesekRekurzivan(magassagok, i, atrepulesSzam - 1, hanyadik);
        }

        return eredmeny;
    }

    static int SzamolErnyozesekRekurzivan(int[] magassagok, int jelenlegiIndex, int atrepulesSzam, int hanyadik)
    {
        if (atrepulesSzam == 0)
        {
            return 1; // Ha nincs több átrepülés, akkor egy újabb siklóernyőzés kész
        }

        int eredmeny = 0;

        for (int kovetkezoIndex = 0; kovetkezoIndex < magassagok.Length; kovetkezoIndex++)
        {
            if (magassagok[kovetkezoIndex] < magassagok[jelenlegiIndex])
            {
                eredmeny += SzamolErnyozesekRekurzivan(magassagok, kovetkezoIndex, atrepulesSzam - 1, hanyadik);
            }
        }

        return eredmeny;
    }

    static int SzamolOsszesSikloErnyozes(int[] magassagok, int hanyadik)
    {
        int osszeg = 0;
        int hossz = magassagok.Length;

        for (int i = 1; i <= hossz; i++)
        {
            if (magassagok[i - 1] > magassagok[hanyadik])
            {
                osszeg += SzamolSikloErnyozesek(magassagok, i, hanyadik);
            }
        }

        return osszeg;
    }
}
