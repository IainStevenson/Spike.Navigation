using System;
using NUnit.Framework;

namespace Spike.Navigation
{
    public class NavigationDesignTests : TestBase<Resource>
    {

        [Test]
        public void ItShouldProvideANavigationLinkId()
        {
            Assert.IsInstanceOf<string>(Unit.Id);
        }

        [Test]
        public void ItShouldProvideANavigationLinkCaption()
        {
            Assert.IsInstanceOf<string>(Unit.Caption);
        }

        [Test]
        public void ItShouldProvideANavigationLinkLocation()
        {
            Assert.IsInstanceOf<Uri>(Unit.Location);
        }

    }
}