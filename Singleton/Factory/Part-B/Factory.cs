using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton.Factory.PartB
{
    /// <summary>
    /// Abstract Product
    /// </summary>
    public abstract class Page
    {
        
    }
    /// <summary>
    /// Concrete Product 1
    /// </summary>
    public class SkillsPage : Page
    {
        
    }
    /// <summary>
    /// Concrete Product 2
    /// </summary>
    public class EducationPage : Page
    {

    }
    /// <summary>
    /// Concrete Product 3
    /// </summary>
    public class IntroductionPage: Page
    {

    }
    /// <summary>
    /// Concrete Product 4
    /// </summary>
    public class ExperiencePage : Page
    {

    }
    /// <summary>
    /// Concrete Product 5
    /// </summary>
    public class ResultsPage : Page
    {

    }
    /// <summary>
    /// Concrete Product 6
    /// </summary>
    public class ConclusionPage : Page
    {

    }
    /// <summary>
    /// Concrete Product 7
    /// </summary>
    public class SummaryPage : Page
    {

    }
    /// <summary>
    /// Concrete Product 8
    /// </summary>
    public class BibliographyPage : Page
    {

    }

    /// <summary>
    /// The creator class
    /// </summary>
    public abstract class Document
    {
        //Stores references of concrete products
        private List<Page> _Pages = new List<Page>();
        //Readonly interface to concrete product reference 
        public List<Page> Pages => _Pages;
        public Document()
        {
            this.CreatePages();
        }
        public abstract void CreatePages();
    }

    /// <summary>
    /// Concrete Creator 1
    /// </summary>
    public class Resume : Document
    {
        public override void CreatePages()
        {
            Pages.Add(new SkillsPage());
            Pages.Add(new EducationPage());
            Pages.Add(new ExperiencePage());
            Console.WriteLine("Resume pages created");
        }
    }
    /// <summary>
    /// Concrete Creator 2
    /// </summary>
    public class Report : Document
    {
        public override void CreatePages()
        {
            Pages.Add(new IntroductionPage());
            Pages.Add(new ResultsPage());
            Pages.Add(new ConclusionPage());
            Pages.Add(new SummaryPage());
            Pages.Add(new BibliographyPage());
            Console.WriteLine("Report pages created");
        }
    }

}
