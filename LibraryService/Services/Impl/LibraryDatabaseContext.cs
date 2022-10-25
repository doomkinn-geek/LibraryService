using LibraryService.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace LibraryService.Services.Impl
{
    public class LibraryDatabaseContext : ILibraryDatabaseContextService
    {
        private IList<Book> _libraryDatabase;
        public IList<Book> Books => _libraryDatabase;
        public LibraryDatabaseContext()
        {
            Initialize();
        }
        private void Initialize()
        {
            string allJson = File.ReadAllText("d:\\books.json");
            /*IList<Book> o = (List<Book>)JsonConvert.DeserializeObject(
                    System.Text.Encoding.UTF8.GetString(Properties.Resources.books), typeof(List<Book>));
            _libraryDatabase = o;*/
            _libraryDatabase =
                (List<Book>)JsonConvert.DeserializeObject(allJson, typeof(List<Book>));

        }
    }
}