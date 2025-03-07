using NUnit.Framework;
using Moq;
using Microsoft.AspNetCore.Mvc;
using BooksAPI.Controllers;
using BooksAPI.Data.Repository;
using System.Collections.Generic;

namespace BooksAPI.Tests.Controllers
{
    [TestFixture]
    public class BooksControllerTest
    {
        private Mock<IBookRepository> _mockBookRepository;
        private BooksController _booksController;

        [SetUp]
        public void SetUp()
        {
            _mockBookRepository = new Mock<IBookRepository>();
            _booksController = new BooksController(_mockBookRepository.Object);
        }

        [TearDown]
        public void TearDown()
        {
            _mockBookRepository = null;
            _booksController = null;
        }

        [Test]
        public void GetBooks_ReturnsOkResult_WithListOfBooks()
        {
            // Arrange
            var books = new List<Book> { new Book { Id = 1, Title = "Test Book" } };
            _mockBookRepository.Setup(repo => repo.GetAllBooks()).Returns(books);

            // Act
            var result = _booksController.GetBooks();

            // Assert
            Assert.IsInstanceOf<OkObjectResult>(result.Result);
            var okResult = result.Result as OkObjectResult;
            Assert.IsNotNull(okResult);
            Assert.AreEqual(books, okResult.Value);
        }

        [Test]
        public void GetBookById_BookExists_ReturnsOkResult_WithBook()
        {
            // Arrange
            var book = new Book { Id = 1, Title = "Test Book" };
            _mockBookRepository.Setup(repo => repo.GetBookById(1)).Returns(book);

            // Act
            var result = _booksController.GetBookById(1);

            // Assert
            Assert.IsInstanceOf<OkObjectResult>(result.Result);
            var okResult = result.Result as OkObjectResult;
            Assert.IsNotNull(okResult);
            Assert.AreEqual(book, okResult.Value);
        }

        [Test]
        public void GetBookById_BookDoesNotExist_ReturnsNotFoundResult()
        {
            // Arrange
            _mockBookRepository.Setup(repo => repo.GetBookById(1)).Returns((Book)null);

            // Act
            var result = _booksController.GetBookById(1);

            // Assert
            Assert.IsInstanceOf<NotFoundResult>(result.Result);
        }

        [Test]
        public void CreateBook_ValidBook_ReturnsCreatedAtActionResult()
        {
            // Arrange
            var book = new Book { Id = 1, Title = "Test Book" };

            // Act
            var result = _booksController.CreateBook(book);

            // Assert
            Assert.IsInstanceOf<CreatedAtActionResult>(result.Result);
            var createdAtActionResult = result.Result as CreatedAtActionResult;
            Assert.IsNotNull(createdAtActionResult);
            Assert.AreEqual(book, createdAtActionResult.Value);
        }

        [Test]
        public void UpdateBook_BookExists_ReturnsNoContentResult()
        {
            // Arrange
            var book = new Book { Id = 1, Title = "Test Book" };

            // Act
            var result = _booksController.UpdateBook(1, book);

            // Assert
            Assert.IsInstanceOf<NoContentResult>(result);
        }

        [Test]
        public void UpdateBook_BookIdMismatch_ReturnsBadRequestResult()
        {
            // Arrange
            var book = new Book { Id = 1, Title = "Test Book" };

            // Act
            var result = _booksController.UpdateBook(2, book);

            // Assert
            Assert.IsInstanceOf<BadRequestResult>(result);
        }

        [Test]
        public void DeleteBook_BookExists_ReturnsNoContentResult()
        {
            // Arrange
            var book = new Book { Id = 1, Title = "Test Book" };
            _mockBookRepository.Setup(repo => repo.GetBookById(1)).Returns(book);

            // Act
            var result = _booksController.DeleteBook(1);

            // Assert
            Assert.IsInstanceOf<NoContentResult>(result);
        }

        [Test]
        public void DeleteBook_BookDoesNotExist_ReturnsNotFoundResult()
        {
            // Arrange
            _mockBookRepository.Setup(repo => repo.GetBookById(1)).Returns((Book)null);

            // Act
            var result = _booksController.DeleteBook(1);

            // Assert
            Assert.IsInstanceOf<NotFoundResult>(result);
        }

        [Test]
        public void GetAllBooks_ReturnsOkResult_WithListOfBooks()
        {
            // Arrange
            var books = new List<Book> { new Book { Id = 1, Title = "Test Book" } };
            _mockBookRepository.Setup(repo => repo.GetAllBooks()).Returns(books);

            // Act
            var result = _booksController.GetAllBooks();

            // Assert
            Assert.IsInstanceOf<OkObjectResult>(result.Result);
            var okResult = result.Result as OkObjectResult;
            Assert.IsNotNull(okResult);
            Assert.AreEqual(books, okResult.Value);
        }
    }
}