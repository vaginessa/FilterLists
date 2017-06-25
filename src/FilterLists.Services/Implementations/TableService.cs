﻿using System.IO;
using System.Net.Http;
using System.Threading.Tasks;
using FilterLists.Data.Repositories.Contracts;
using FilterLists.Services.Contracts;

namespace FilterLists.Services.Implementations
{
    public class TableService : ITableService
    {
        private readonly IListRepository _listRepository;

        public TableService(IListRepository listRepository)
        {
            _listRepository = listRepository;
        }

        /// <summary>
        ///     update all tables via .CSVs from GitHub
        /// </summary>
        public void UpdateTables()
        {
            //TODO: loop through all CSVs
            UpdateTable("List");
        }

        /// <summary>
        ///     update table via .CSV from GitHub
        /// </summary>
        /// <param name="tableName">name of database table</param>
        public void UpdateTable(string tableName)
        {
            switch (tableName)
            {
                case "List":
                    //TODO: fetch CSV URL from db table
                    const string csvUrl =
                        "https://raw.githubusercontent.com/collinbarrett/FilterLists/master/data/List.csv";
                    var file = FetchFile(csvUrl).Result;
                    break;
                default:
                    //TODO: throw invalid table exception
                    break;
            }
        }

        /// <summary>
        ///     fetch file as string from internet
        /// </summary>
        /// <param name="url">URL of file to fetch</param>
        /// <returns>string of file</returns>
        private static async Task<string> FetchFile(string url)
        {
            var client = new HttpClient();
            var response = await client.GetAsync(url);
            response.EnsureSuccessStatusCode();
            var path = Path.Combine(Directory.GetCurrentDirectory(), "csv");
            Directory.CreateDirectory(path);
            var file = Path.Combine(path,"List.csv");
            using (var fileStream = new FileStream(file, FileMode.Create, FileAccess.Write,
                FileShare.None))
            {
                await response.Content.CopyToAsync(fileStream);
            }
            return file;
        }
    }
}