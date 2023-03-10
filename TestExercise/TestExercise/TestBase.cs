using OpenQA.Selenium;

namespace TestExercise
{
    /// <summary>
    /// Класс базовых значений теста
    /// </summary>
    public class TestBase : LogTestExceptionError
    {
        protected IWebDriver Driver;
        public IDictionary<string, object>? Vars { get; set; }

        protected IJavaScriptExecutor? Js;
    }
}
