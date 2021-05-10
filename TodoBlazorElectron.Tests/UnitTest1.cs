using Bunit;
using LiteDB;
using Microsoft.Extensions.DependencyInjection;
using Moq;
using MudBlazor;
using MudBlazor.Services;
using System;
using TodoBlazorElectron.Context;
using TodoBlazorElectron.Pages;
using TodoBlazorElectron.Services;
using Xunit;

namespace TodoBlazorElectron.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            using var ctx = new TestContext();

            var db = new LiteDBContext(@"ToDoDataTest.db");
            ctx.Services.AddSingleton<IToDoSvc>(new ToDoSvc(db));
            ctx.Services.AddMudServices();

            var mainPage = ctx.RenderComponent<Pages.Index>();
            var renderedMarkup = mainPage.Markup;

            Assert.Contains("Open Simple Dialog", renderedMarkup);
        }
    }
}
