namespace Models;

public class SampleArticleTitle
{
    private static IList<string> EnglishArticleTitles { get; set; }
    private static IList<string> PersianArticleTitles { get; set; }

    private SampleArticleTitle()
    {
    }

    public static IList<string> GetEnglishArticleTitles()
    {
        if (EnglishArticleTitles == null)
        {
            EnglishArticleTitles = new List<string>();
            AddToEnglishTitleList();
        }

        return EnglishArticleTitles;
    }

    public static IList<string> GetPersianArticleTitles()
    {
        if (PersianArticleTitles == null)
        {
            PersianArticleTitles = new List<string>();
            AddToPersianTitleList();
        }

        return PersianArticleTitles;
    }

    private static void AddToEnglishTitleList()
    {
        EnglishArticleTitles.Add("Send Human To Moon");
        EnglishArticleTitles.Add("Web New Wave");
        EnglishArticleTitles.Add("Superhuman Exit ?");
        EnglishArticleTitles.Add("Where Are You!");
        EnglishArticleTitles.Add("Access To Forbidden History");
        EnglishArticleTitles.Add("Clean Code");
        EnglishArticleTitles.Add("Domain Driven Design");
        EnglishArticleTitles.Add("C# 11 Features");
        EnglishArticleTitles.Add("Node Js Faster Or Asp Core 6");
        EnglishArticleTitles.Add("Collection In C#");
        EnglishArticleTitles.Add("Wrong Way");
        EnglishArticleTitles.Add("Just Go");
        EnglishArticleTitles.Add("W3 ?!");
        EnglishArticleTitles.Add("Http https ?!");
    }

    private static void AddToPersianTitleList()
    {
        PersianArticleTitles.Add("امروز دیروز فردا !");
        PersianArticleTitles.Add("توهم موفقیت");
        PersianArticleTitles.Add("روزهای پایانی زبانی جهانی");
        PersianArticleTitles.Add("گشتی در کشور سرخ");
        PersianArticleTitles.Add("گشتن به دنبال امید");
        PersianArticleTitles.Add("رویایی پر از شرور پایانی پر از تلخ");
        PersianArticleTitles.Add("نود جی اس یا ای اس پی ؟ مساله این است");
        PersianArticleTitles.Add("روباه آبی");
        PersianArticleTitles.Add("سیشارپ زبانی استاندارد");
        PersianArticleTitles.Add("قصر طلایی آرزو ها");
        PersianArticleTitles.Add("سفید برفی و هفت کوتوله احمق");
        PersianArticleTitles.Add("راز آفریش گوزن ها");
        PersianArticleTitles.Add("رویا پوچ");
        PersianArticleTitles.Add("گذر از سمت بیخیالی");
        PersianArticleTitles.Add("هنر دار یا دار هنر ؟");
    }

    public static string GetPersianDiscription()
    {
        string discription =
            "لورم ایپسوم متن ساختگی با تولید سادگی نامفهوم از صنعت چاپ، و با استفاده از طراحان گرافیک است، چاپگرها و متون بلکه روزنامه و مجله در ستون و سطرآنچنان که لازم است، و برای شرایط فعلی تکنولوژی مورد نیاز، و کاربردهای متنوع با هدف بهبود ابزارهای کاربردی می باشدفرهنگ پیشرو در زبان فارسی ایجاد کرد، در این صورت می توان امید داشت.";
        return discription;
    }

    public static string GetEnglishDiscription()
    {
        string discription =
            "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur";

        return discription;
    }
}