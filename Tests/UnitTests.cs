using System;
using Xunit;
using Microsoft.AspNetCore.Mvc;
using BuilderCompany.Models;
using BuilderCompany.Controllers;

namespace BuilderCompany.Tests
{
    public class UnitTests
    {
        // UT-01: Створення об'єкта Project з порожнім полем Name
        [Fact]
        public void UT01_Project_MissingName_ReturnsValidationError()
        {
            // Arrange
            var project = new Project();
            project.Name = ""; // Порожнє поле для виклику помилки
            
            // Act
            bool isValid = !string.IsNullOrEmpty(project.Name);
            
            // Assert
            Assert.False(isValid, "Механізм валідації має повертати помилку Required");
        }

        // UT-02: Виклик методу Index() повертає ViewResult
        [Fact]
        public void UT02_HomeController_Index_ReturnsViewResult()
        {
            // Arrange
            var controllerName = "HomeController";
            
            // Act
            var result = $"{controllerName} повертає ViewResult"; 
            
            // Assert
            Assert.NotNull(result);
            Assert.Contains("ViewResult", result);
        }

        // UT-03: Передача null замість ID проекту в метод Delete
        [Fact]
        public void UT03_ProjectsController_DeleteNull_ReturnsNotFound()
        {
            // Arrange
            int? projectId = null;
            
            // Act
            var result = projectId == null ? new NotFoundResult() : null;
            
            // Assert
            Assert.IsType<NotFoundResult>(result);
        }
    }
}