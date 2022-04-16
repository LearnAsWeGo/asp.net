using Jenkins_ASP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace ASP_Test.Controller.ValuesControllerTests
{
    public class Get
    {

        ValuesController m_controller = new ValuesController();

        public Get()
        {

        }

        [Fact]
        public void WhenValid_ReturnsOK()
        {
            var response = m_controller.Get();

            Assert.NotNull(response);
        }
    }
}
