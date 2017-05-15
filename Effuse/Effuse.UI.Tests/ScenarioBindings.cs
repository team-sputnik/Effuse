using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace Effuse.UI.Tests
{
    [Binding]
    public sealed class ScenarioBindings
    {
        [BeforeScenario]
        public void BeforeScenario()
        {
            //Effuse.Services.Start();
        }

        [AfterScenario]
        public void AfterScenario()
        {
            //ThrowPositiveTestExceptions();
            //Effuse.Services.Dispose();
        }
    }
}
