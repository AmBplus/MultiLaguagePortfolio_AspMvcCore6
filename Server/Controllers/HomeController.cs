﻿using System.Diagnostics;
using Microsoft.AspNetCore.Http.Headers;
using Microsoft.AspNetCore.Mvc;
using Models;
using Models.ArticleModel;
using Models.ProjectModel;
using Server.Models;

namespace Server.Controllers
{
    public class HomeController : Controller
    {
        public HomeController(PortfolioContext context)
        {
            Context = context;
        }

        private PortfolioContext Context { get; }

        public IActionResult Index()
        {
            ContextViewModel contextViewModel;
            if (!Context.Clients.Any())
            {
                CreateSample();
            }

            string currentCulture = Thread.CurrentThread.CurrentUICulture.TwoLetterISOLanguageName;
            if (currentCulture == "fa")
            {
                PersianProject[] spicialProject = Context.PersianProjects.Where(x => x.IsSpecial).ToArray();
                PersianAticle[] latestArticle = Context.PersianAticles.OrderBy(x => x.DateTime).Take(8).ToArray();
                Console.WriteLine("fa mode");
                contextViewModel = new ContextViewModel(latestArticle, spicialProject);
            }
            else
            {
                List<EnglishArticle> list1 = Context.EnglishArticles.ToList();
                List<EnglishProject> list2 = Context.EnglishProjects.ToList();
                EnglishProject[] spicialProject = Context.EnglishProjects.Where(x => x.IsSpecial).ToArray();
                EnglishArticle[] latestArticle = Context.EnglishArticles.OrderBy(x => x.DateTime).Take(8).ToArray();
                contextViewModel = new ContextViewModel(latestArticle, spicialProject);
                Console.WriteLine("en` mode");
            }

            return View(contextViewModel);
        }

        public IActionResult Privacy()
        {
            return View();
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public IActionResult CreateSample()
        {
            RequestHeaders? typedHeaders =
                HttpContext.Request.GetTypedHeaders();

            string? httpReferer =
                typedHeaders?.Referer?.AbsoluteUri;
            char p = Path.AltDirectorySeparatorChar;
            string path = @$"wwwroot{p}assets{p}images";

            Context.Clients.Add(new Client
            {
                Id = 1,
                Name = "امیر معصوم بیگی"
            });
            Context.Clients.Add(new Client
            {
                Id = 2,
                Name = "Amir MassoumBeygi"
            });
            Context.Clients.Add(new Client
            {
                Id = 3,
                Name = "Google"
            });
            CreateArticleSample(path, p);
            CreateProjectSample(path, p);
            Context.SaveChanges();
            if (httpReferer == null) return RedirectToAction("Index");
            return Redirect(httpReferer);
        }

        private void CreateArticleSample(string path, char p)
        {
            string articlePath = path + p + "blog";
            string projectPath = path + p + "project";
            Console.WriteLine("null in context");
            string[] articleFile = Directory.GetFiles(articlePath);

            int i = 1;
            IList<string> englishArticleTitles = SampleArticleTitle.GetEnglishArticleTitles();
            string discription = SampleArticleTitle.GetEnglishDiscription();
            foreach (string article in articleFile)
            {
                FileInfo ArticlefileInfo = new FileInfo(article);
                Context.EnglishArticles.Add(new EnglishArticle
                {
                    ClientId = 2,
                    Title = englishArticleTitles[i],
                    Image = $"{ArticlefileInfo.FullName}",
                    Description = discription
                });
                Context.SaveChanges();
                if (i + 1 == englishArticleTitles.Count) break;
                i++;
            }

            discription = SampleArticleTitle.GetPersianDiscription();

            i = 1;
            IList<string> PersianTitle = SampleArticleTitle.GetPersianArticleTitles();
            foreach (string article in articleFile)
            {
                FileInfo ArticlefileInfo = new(article);
                Context.PersianAticles.Add(new PersianAticle
                {
                    ClientId = 1,
                    Title = PersianTitle[i],
                    Image = $"{ArticlefileInfo.FullName}",
                    Description = discription
                });
                Context.SaveChanges();
                if (i + 2 == PersianTitle.Count) break;
                i++;
            }
        }

        private void CreateProjectSample(string path, char p)
        {
            string articlePath = path + p + "blog";
            string projectPath = path + p + "project";
            Console.WriteLine("null in context");
            string[] articleFile = Directory.GetFiles(projectPath);
            bool flag = false;
            int i = 1;
            IList<string> englishArticleTitles = SampleArticleTitle.GetEnglishArticleTitles();
            string discription = SampleArticleTitle.GetEnglishDiscription();
            foreach (string article in articleFile)
            {
                flag = Convert.ToBoolean(i % 2);
                FileInfo ArticlefileInfo = new FileInfo(article);
                Context.EnglishProjects.Add(new EnglishProject
                {
                    ClientId = 2,
                    Title = englishArticleTitles[i],
                    Image = $"{ArticlefileInfo.FullName}",
                    Description = discription,
                    IsSpecial = flag
                });
                Context.SaveChanges();
                i++;
                if (i + 2 == englishArticleTitles.Count) break;
            }

            discription = SampleArticleTitle.GetPersianDiscription();
            i = 1;
            IList<string> PersianTitle = SampleArticleTitle.GetPersianArticleTitles();
            foreach (string article in articleFile)
            {
                flag = Convert.ToBoolean(i % 2);
                flag = Convert.ToBoolean(i % 2);
                FileInfo ArticlefileInfo = new(article);
                Context.PersianProjects.Add(new PersianProject
                {
                    ClientId = 1,
                    Title = PersianTitle[i],
                    Image = $"{ArticlefileInfo.FullName}",
                    Description = discription,
                    IsSpecial = flag
                });
                Context.SaveChanges();
                i++;
                if (i + 2 == PersianTitle.Count) break;
            }
        }
    }
}