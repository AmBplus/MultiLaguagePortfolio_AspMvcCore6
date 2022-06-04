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

        return EnglishArticleTitles;
    }

    private static void AddToEnglishTitleList()
    {
        EnglishArticleTitles.Add("Send Human To Moon");
        EnglishArticleTitles.Add(".net New Wave");
        EnglishArticleTitles.Add("Superhuman Exit ?");
        EnglishArticleTitles.Add("Where Are YOu!");
        EnglishArticleTitles.Add("Access To Forbiden History");
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
            "لورم ایپسوم متن ساختگی با تولید سادگی نامفهوم از صنعت چاپ، و با استفاده از طراحان گرافیک است، چاپگرها و متون بلکه روزنامه و مجله در ستون و سطرآنچنان که لازم است، و برای شرایط فعلی تکنولوژی مورد نیاز، و کاربردهای متنوع با هدف بهبود ابزارهای کاربردی می باشد، کتابهای زیادی در شصت و سه درصد گذشته حال و آینده، شناخت فراوان جامعه و متخصصان را می طلبد، تا با نرم افزارها شناخت بیشتری را برای طراحان رایانه ای علی الخصوص طراحان خلاقی، و فرهنگ پیشرو در زبان فارسی ایجاد کرد، در این صورت می توان امید داشت که تمام و دشواری موجود در ارائه راهکارها، و شرایط سخت تایپ به پایان رسد و زمان مورد نیاز شامل حروفچینی دستاوردهای اصلی، و جوابگوی سوالات پیوسته اهل دنیای موجود طراحی اساسا مورد استفاده قرار گیرد.";
        return discription;
    }

    public static string GetEnglishDiscription()
    {
        string discription =
            "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Egestas purus viverra accumsan in nisl nisi. Arcu cursus vitae congue mauris rhoncus aenean vel elit scelerisque. In egestas erat imperdiet sed euismod nisi porta lorem mollis. Morbi tristique senectus et netus. Mattis pellentesque id nibh tortor id aliquet lectus proin. Sapien faucibus et molestie ac feugiat sed lectus vestibulum. Ullamcorper velit sed ullamcorper morbi tincidunt ornare massa eget. Dictum varius duis at consectetur lorem. Nisi vitae suscipit tellus mauris a diam maecenas sed enim. Velit ut tortor pretium viverra suspendisse potenti nullam. Et molestie ac feugiat sed lectus. Non nisi est sit amet facilisis magna. Dignissim diam quis enim lobortis scelerisque fermentum. Odio ut enim blandit volutpat maecenas volutpat. Ornare lectus sit amet est placerat in egestas erat. Nisi vitae suscipit tellus mauris a diam maecenas sed. Placerat duis ultricies lacus sed turpis tincidunt id aliquet. ";
        return discription;
    }
}