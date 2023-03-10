using OpenQA.Selenium;
using NUnit.Framework;

namespace TestExercise
{
    /// <summary>
    /// Класс для структуры теста
    /// </summary>
    public class TestStructure : NavigationTest
    {
        public void TestExecution()
        {
            SiteNavigation();
            var elements = Driver.FindElements(By.XPath("//span[contains(.,\'Philosophy\')]"));
            
            try
            {
                Assert.True(elements.Count > 0, "Страница Philosophy не найдена");
            }
            catch (Exception ex)
            {
                Write(ex);
                throw;
            }
        }
    }
}
