﻿using NUnit.Framework;

namespace Umbraco.Tests.Integration.Umbraco.Configuration.UmbracoSettings
{
    [TestFixture]
    public class WebRoutingElementDefaultTests : WebRoutingElementTests
    {
        protected override bool TestingDefaults => true;

        [Test]
        public override void UrlProviderMode()
        {
            Assert.IsTrue(WebRoutingSettings.UrlProviderMode == "Auto");
        }

        [Test]
        public void DisableAlternativeTemplates()
        {
            Assert.IsTrue(WebRoutingSettings.DisableAlternativeTemplates == false);
        }

        [Test]
        public void ValidateAlternativeTemplates()
        {
            Assert.IsTrue(WebRoutingSettings.ValidateAlternativeTemplates == false);
        }

        [Test]
        public void DisableFindContentByIdPath()
        {
            Assert.IsTrue(WebRoutingSettings.DisableFindContentByIdPath == false);
        }

        [Test]
        public void DisableRedirectUrlTracking()
        {
            Assert.IsTrue(WebRoutingSettings.DisableRedirectUrlTracking == false);
        }
    }
}
